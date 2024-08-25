using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Emgu;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using Emgu.Util;
using DirectShowLib;
using System.Windows.Forms;
using System.IO.Ports;


namespace _3D_Printer___Main_version
{
    public partial class Form1 : Form
    {

        SerialPort Current_Port = new SerialPort();
        string[] Ports_List = SerialPort.GetPortNames();
        bool stream_on = true; //для включения трансляции только 1 раз

        public Form1()
        {
            InitializeComponent();
        }

        private VideoCapture capture = null; //в это поле хранятся захватываемые данные с камеры
        private DsDevice[] webCams = null; //для хранения списка всех жоступных видео камер
        private int selectedCameraId = 0; //для управления этими камерами, по умолчанию id=0


        private void Form1_Load(object sender, EventArgs e)
        {
            TEXT.Text = "Состояние системы";
            foreach (string Current_Port in Ports_List)
            {
                COM.Items.Add(Current_Port);
            }
            webCams = DsDevice.GetDevicesOfCat(DirectShowLib.FilterCategory.VideoInputDevice); //получили список всех доступных видео камер с определенными параметрами (videp input devises)

            for (int i = 0; i < webCams.Length; i++) //заполняем комбобокс с камерами
            {
                comboBox_Cam.Items.Add(webCams[i].Name);
            }

        }

        //КАМЕРА
        private void comboBox_Cam_SelectedIndexChanged(object sender, EventArgs e) //обработка события в комбобоксе с именам камер - определение и сохранения выбора
        {
            selectedCameraId = comboBox_Cam.SelectedIndex;
        }

        private void Capture_ImageGrabbed(object sender, EventArgs e) //Cam - обработка избражения - end
        {
            try
            {
                Mat m = new Mat();
                capture.Retrieve(m);
                pictureBox1.Image = m.ToImage<Bgr, byte>().Bitmap;
            }
            catch
            {
                //MessageBox.Show("Ошибка вывода изображения", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void button1_Click_1(object sender, EventArgs e) //CAM Stream - end
        {
            if (stream_on)
            {
                try
                {
                    if (webCams.Length == 0) //программа не распознает камеры: они вообще не отображаются в списке
                    {
                        throw new Exception("Нет подходящих камер");
                    }
                    else if (comboBox_Cam.SelectedItem == null) //камера не выбрана: она отображается в списке, но с ней никак не взаимодействуют
                    {
                        throw new Exception("Необходимо выбрать камеру");
                    }
                    else //во всех остальных случаях корректно запускаем вывод изображения
                    {
                        capture = new VideoCapture(selectedCameraId);

                        capture.ImageGrabbed += Capture_ImageGrabbed;

                        capture.Start();

                        stream_on = false; //изменяем значение, для того, чтобы кнопка Stream больше не реагировала, т.к. изображение и так уже выводится
                    }
                }
                catch (Exception ex) //обработка исключений
                {
                    MessageBox.Show(ex.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TEXT.Text = ex.Message;
                }
            } else
            {
                MessageBox.Show("Трансляция изображения уже ведется", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TEXT.Text = "Трансляция изображения уже ведется";
            }
        }

        private void button6_Click(object sender, EventArgs e) //ScreemShot - end
        {
            if (capture != null)
            {
                TEXT.Text = "Создание скриншота";
                try 
                {
                    Mat m = new Mat();
                    capture.Retrieve(m);
                    MakeScreenShotForm screenShotForm = new MakeScreenShotForm(m.ToImage<Bgr, byte>());
                    screenShotForm.Show();
                } 
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TEXT.Text = ex.Message;
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать камеру", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TEXT.Text = "Необходимо выбрать камеру";
            }
        }

        private void button7_Click(object sender, EventArgs e) //TL: start - end
        {
            if (capture != null)
            {
                TEXT.Text = "TimeLapse: начало записи с *значения* параметрами";

            }
            else
            {
                MessageBox.Show("Необходимо выбрать камеру", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TEXT.Text = "Необходимо выбрать камеру";
            }
        }

        private void button8_Click(object sender, EventArgs e) //TL: stop - end
        {
            if (capture != null)
            {
                TEXT.Text = "TimeLapse: запись остановлена и сохранена в памяти устройства";
            }
            else
            {
                MessageBox.Show("Необходимо выбрать камеру", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TEXT.Text = "Необходимо выбрать камеру";
            }
        }
       
        
        //УПРАВЛЕНИЕ
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // Выбор порта - end
        {
            try
            {
                if (Current_Port.IsOpen)
                {
                    Current_Port.Close();
                }
                Current_Port.PortName = COM.SelectedItem as string;
                Current_Port.BaudRate = 115200;
                Current_Port.Open();
                TEXT.Text = "Порт открыт";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TEXT.Text = ex.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e) //Turn left - end
        {
            if (Current_Port.IsOpen)
            {
                Current_Port.Write("turn left");
                TEXT.Text = "Джойстик управления: поворот влево";
            } 
            else
            {
                TEXT.Text = "Выполнить действие нельзя! Выберете необходимый порт для подключения";
                MessageBox.Show("Необходимо выбрать порт", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e) //Turn right - end
        {
            if (Current_Port.IsOpen) { 
                Current_Port.Write("turn right");
                TEXT.Text = "Джойстик управления: поворот вправо";
            }
            else
            {
                TEXT.Text = "Выполнить действие нельзя! Выберете необходимый порт для подключения";
                MessageBox.Show("Необходимо выбрать порт", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e) //Push - end
        {
            if (Current_Port.IsOpen)
            {
                Current_Port.Write("push");
                TEXT.Text = "Джойстик управления: нажатие";
            }
            else
            {
                TEXT.Text = "Выполнить действие нельзя! Выберете необходимый порт для подключения";
                MessageBox.Show("Необходимо выбрать порт", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_cam_menu_Click(object sender, EventArgs e) //To menu - end
        {
            if (Current_Port.IsOpen || capture != null)
            { 
                Current_Port.Write("cam menu");
                TEXT.Text = "Камера: перемещение камеры в область просмотра меню";
            }
            else
            {
                if (capture == null && Current_Port.IsOpen)
                {
                    MessageBox.Show("Необходимо выбрать камеру", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TEXT.Text = "Необходимо выбрать камеру";
                } 
                else if (capture != null && !Current_Port.IsOpen)
                {
                    MessageBox.Show("Необходимо выбрать порт", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TEXT.Text = "Выполнить действие нельзя! Выберете необходимый порт для подключения";
                }
                else
                {
                    MessageBox.Show("Необходимо выбрать порт и камеру", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TEXT.Text = "Выполнить действие нельзя! Выберете необходимый порт для подключения и камеру для трансляции";
                }
                
            }
        }

        private void button_cam_workspace_Click(object sender, EventArgs e) //To Workspace - end
        {
            if (Current_Port.IsOpen || capture != null)
            {
                Current_Port.Write("cam workspace");
                TEXT.Text = "Камера: перемещение камеры в область печати";
            }
            else
            {
                if (capture == null && Current_Port.IsOpen)
                {
                    MessageBox.Show("Необходимо выбрать камеру", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TEXT.Text = "Необходимо выбрать камеру";
                }
                else if (capture != null && !Current_Port.IsOpen)
                {
                    MessageBox.Show("Необходимо выбрать порт", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TEXT.Text = "Выполнить действие нельзя! Выберете необходимый порт для подключения";
                }
                else
                {
                    MessageBox.Show("Необходимо выбрать порт и камеру", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TEXT.Text = "Выполнить действие нельзя! Выберете необходимый порт для подключения и камеру для трансляции";
                }
            }
        }
    }
}
