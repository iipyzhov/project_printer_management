#include <EEPROM.h>
#include <AccelStepper.h>

#define Type_of_working 8
#define INA 11
#define INB 9
#define INC 10
#define IND 8

#define INA_cam 4
#define INB_cam 5
#define INC_cam 6
#define IND_cam 7

#define Angle 360/24 //один шаг поворота ручки управления, 24 - количество шагов на 1 полный оборот, + необходимо учесть различие радиусов двух валов - двигателя и самой ручки

#define Push_pin 12

String str;

unsigned long push_current = 0;
const long push_interval = 200;
bool push_check = false;
bool left_check = false;
bool right_check = false;
bool menu_check = false;
bool work_check = false;
bool cam_menu; //true - если камера у меню, иначе - false

int Step_joy = 4096;
int Step_cam = 4096*10;

int pos = 0;

AccelStepper stepper_joy(Type_of_working, INA, INB, INC, IND);
AccelStepper stepper_cam(Type_of_working, INA_cam, INB_cam, INC_cam, IND_cam);

void setup()
{
  Serial.begin(115200);
  Serial.setTimeout(50);
  
  pinMode(Push_pin, OUTPUT);

  stepper_joy.setMaxSpeed(1000); //максимальная скорость в шагах в секунду
  stepper_joy.setAcceleration(500); //ускорение в шагах в секунду за секунду 
  stepper_cam.setMaxSpeed(1000); //максимальная скорость в шагах в секунду
  stepper_cam.setAcceleration(500); //ускорение в шагах в секунду за секунду 
}

void loop()
{ 
  
  if(Serial.available())
  {
    str = Serial.readString();
  }
  

  if(str == "turn left") //поворот ручки управления влево
  {
    if (!left_check){
      left_check = true;
      stepper_joy.move(Step_joy);
    }
    stepper_joy.run();
    if (stepper_joy.distanceToGo() == 0) {
      stepper_joy.stop();
      stepper_joy.move(Step_joy);
      left_check = false;
      str = "";
      digitalWrite(8, 0);
      digitalWrite(9, 0);
      digitalWrite(10, 0);
      digitalWrite(11, 0);
    }
  }
  
  if(str == "turn right") //поворот ручки управления вправо
  {
    if (!right_check){
      right_check = true;
      stepper_joy.move(-Step_joy);
    }
    stepper_joy.run();
    if (stepper_joy.distanceToGo() == 0) {
      stepper_joy.stop();
      stepper_joy.move(-Step_joy);
      right_check = false;
      str = "";
      digitalWrite(8, 0);
      digitalWrite(9, 0);
      digitalWrite(10, 0);
      digitalWrite(11, 0);
    }
  }
  
  if(str == "push") //нажатие на ручку управления
  {
    if (!push_check) {
      push_check = true;
      push_current = millis();
    }
    if (millis() - push_current <= push_interval) {
      digitalWrite(Push_pin, HIGH);
    } else {
      digitalWrite(Push_pin, LOW);
      push_check = false;
      str = "";
    }
  }

  if (str=="cam menu") //перемещаем камеру к меню
  {
    if (!menu_check){
      EEPROM.get(0, cam_menu); //впервые она определится при установки системы и ее настройке
      if (cam_menu) { //если камера и так уже у меню
        str = "";
        digitalWrite(8, 0);
        digitalWrite(9, 0);
        digitalWrite(10, 0);
        digitalWrite(11, 0);
      } else {
        cam_menu = true;
        EEPROM.put(0, cam_menu);
        menu_check = true;
        stepper_cam.moveTo(Step_cam);
      }
    }
    stepper_cam.run();
    if (stepper_cam.distanceToGo() == 0) {
      stepper_cam.stop();
      stepper_cam.move(Step_cam);
      menu_check = false;
      str = "";
      digitalWrite(8, 0);
      digitalWrite(9, 0);
      digitalWrite(10, 0);
      digitalWrite(11, 0);
    }
  }

  if (str=="cam workspace")
  {
    if (!work_check){
      EEPROM.get(0, cam_menu);
      if (!cam_menu) { //если камера находится у области печати
        str = "";
        digitalWrite(8, 0);
        digitalWrite(9, 0);
        digitalWrite(10, 0);
        digitalWrite(11, 0);
      } else {
        cam_menu = false;
        EEPROM.put(0, cam_menu);
        work_check = true;
        stepper_cam.move(-Step_cam);
      }
    }
    stepper_cam.run();
    if (stepper_cam.distanceToGo() == 0) {
      stepper_cam.stop();
      stepper_cam.move(-Step_cam);
      work_check = false;
      str = "";
      digitalWrite(8, 0);
      digitalWrite(9, 0);
      digitalWrite(10, 0);
      digitalWrite(11, 0);
    }
  }
}
