namespace _3D_Printer___Main_version
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.COM = new System.Windows.Forms.ComboBox();
            this.button_left = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.button_push = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_cam_menu = new System.Windows.Forms.Button();
            this.button_cam_workspace = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button_screenshot = new System.Windows.Forms.Button();
            this.button_tl_start = new System.Windows.Forms.Button();
            this.button_tl_stop = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox_Cam = new System.Windows.Forms.ComboBox();
            this.groupBox_Control = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Stream = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolTip_Left = new System.Windows.Forms.ToolTip(this.components);
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.TEXT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_Control.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // COM
            // 
            this.COM.BackColor = System.Drawing.SystemColors.Window;
            this.COM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.COM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.COM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.COM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.COM.FormattingEnabled = true;
            this.COM.Location = new System.Drawing.Point(10, 50);
            this.COM.Margin = new System.Windows.Forms.Padding(0);
            this.COM.MinimumSize = new System.Drawing.Size(165, 0);
            this.COM.Name = "COM";
            this.COM.Size = new System.Drawing.Size(165, 23);
            this.COM.TabIndex = 0;
            this.COM.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.COM.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button_left
            // 
            this.button_left.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_left.ForeColor = System.Drawing.Color.Transparent;
            this.button_left.Image = ((System.Drawing.Image)(resources.GetObject("button_left.Image")));
            this.button_left.Location = new System.Drawing.Point(10, 113);
            this.button_left.MinimumSize = new System.Drawing.Size(80, 40);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(80, 40);
            this.button_left.TabIndex = 2;
            this.toolTip_Left.SetToolTip(this.button_left, "Джойстик управления повернется на 1 шаг влево");
            this.button_left.UseVisualStyleBackColor = false;
            this.button_left.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_right
            // 
            this.button_right.ForeColor = System.Drawing.Color.Transparent;
            this.button_right.Image = ((System.Drawing.Image)(resources.GetObject("button_right.Image")));
            this.button_right.Location = new System.Drawing.Point(95, 113);
            this.button_right.MinimumSize = new System.Drawing.Size(80, 40);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(80, 40);
            this.button_right.TabIndex = 3;
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_push
            // 
            this.button_push.Image = ((System.Drawing.Image)(resources.GetObject("button_push.Image")));
            this.button_push.Location = new System.Drawing.Point(10, 158);
            this.button_push.MinimumSize = new System.Drawing.Size(165, 40);
            this.button_push.Name = "button_push";
            this.button_push.Size = new System.Drawing.Size(165, 40);
            this.button_push.TabIndex = 4;
            this.button_push.UseVisualStyleBackColor = true;
            this.button_push.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.MinimumSize = new System.Drawing.Size(165, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выбор порта подключения";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(10, 93);
            this.label2.MinimumSize = new System.Drawing.Size(165, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Управление печатью";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(10, 218);
            this.label3.MinimumSize = new System.Drawing.Size(165, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Выбор камеры";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_cam_menu
            // 
            this.button_cam_menu.Image = ((System.Drawing.Image)(resources.GetObject("button_cam_menu.Image")));
            this.button_cam_menu.Location = new System.Drawing.Point(10, 346);
            this.button_cam_menu.MinimumSize = new System.Drawing.Size(80, 40);
            this.button_cam_menu.Name = "button_cam_menu";
            this.button_cam_menu.Size = new System.Drawing.Size(80, 40);
            this.button_cam_menu.TabIndex = 8;
            this.button_cam_menu.UseVisualStyleBackColor = true;
            this.button_cam_menu.Click += new System.EventHandler(this.button_cam_menu_Click);
            // 
            // button_cam_workspace
            // 
            this.button_cam_workspace.Image = ((System.Drawing.Image)(resources.GetObject("button_cam_workspace.Image")));
            this.button_cam_workspace.Location = new System.Drawing.Point(95, 346);
            this.button_cam_workspace.MinimumSize = new System.Drawing.Size(80, 40);
            this.button_cam_workspace.Name = "button_cam_workspace";
            this.button_cam_workspace.Size = new System.Drawing.Size(80, 40);
            this.button_cam_workspace.TabIndex = 9;
            this.button_cam_workspace.UseVisualStyleBackColor = true;
            this.button_cam_workspace.Click += new System.EventHandler(this.button_cam_workspace_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(10, 326);
            this.label4.MinimumSize = new System.Drawing.Size(165, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Положение камеры";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_screenshot
            // 
            this.button_screenshot.Image = ((System.Drawing.Image)(resources.GetObject("button_screenshot.Image")));
            this.button_screenshot.Location = new System.Drawing.Point(10, 426);
            this.button_screenshot.MinimumSize = new System.Drawing.Size(165, 40);
            this.button_screenshot.Name = "button_screenshot";
            this.button_screenshot.Size = new System.Drawing.Size(165, 40);
            this.button_screenshot.TabIndex = 11;
            this.button_screenshot.UseVisualStyleBackColor = true;
            this.button_screenshot.Click += new System.EventHandler(this.button6_Click);
            // 
            // button_tl_start
            // 
            this.button_tl_start.Image = ((System.Drawing.Image)(resources.GetObject("button_tl_start.Image")));
            this.button_tl_start.Location = new System.Drawing.Point(10, 471);
            this.button_tl_start.MinimumSize = new System.Drawing.Size(165, 40);
            this.button_tl_start.Name = "button_tl_start";
            this.button_tl_start.Size = new System.Drawing.Size(165, 40);
            this.button_tl_start.TabIndex = 12;
            this.button_tl_start.UseVisualStyleBackColor = true;
            this.button_tl_start.Click += new System.EventHandler(this.button7_Click);
            // 
            // button_tl_stop
            // 
            this.button_tl_stop.Image = ((System.Drawing.Image)(resources.GetObject("button_tl_stop.Image")));
            this.button_tl_stop.Location = new System.Drawing.Point(10, 516);
            this.button_tl_stop.MinimumSize = new System.Drawing.Size(165, 40);
            this.button_tl_stop.Name = "button_tl_stop";
            this.button_tl_stop.Size = new System.Drawing.Size(165, 40);
            this.button_tl_stop.TabIndex = 13;
            this.button_tl_stop.UseVisualStyleBackColor = true;
            this.button_tl_stop.Click += new System.EventHandler(this.button8_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 30);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(702, 526);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(702, 526);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox_Cam
            // 
            this.comboBox_Cam.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox_Cam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_Cam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Cam.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_Cam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Cam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox_Cam.FormattingEnabled = true;
            this.comboBox_Cam.Location = new System.Drawing.Point(10, 238);
            this.comboBox_Cam.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox_Cam.MinimumSize = new System.Drawing.Size(165, 0);
            this.comboBox_Cam.Name = "comboBox_Cam";
            this.comboBox_Cam.Size = new System.Drawing.Size(165, 23);
            this.comboBox_Cam.TabIndex = 15;
            this.comboBox_Cam.SelectedIndexChanged += new System.EventHandler(this.comboBox_Cam_SelectedIndexChanged);
            // 
            // groupBox_Control
            // 
            this.groupBox_Control.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Control.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox_Control.Controls.Add(this.label5);
            this.groupBox_Control.Controls.Add(this.button_Stream);
            this.groupBox_Control.Controls.Add(this.comboBox_Cam);
            this.groupBox_Control.Controls.Add(this.button_tl_stop);
            this.groupBox_Control.Controls.Add(this.COM);
            this.groupBox_Control.Controls.Add(this.button_tl_start);
            this.groupBox_Control.Controls.Add(this.button_left);
            this.groupBox_Control.Controls.Add(this.button_screenshot);
            this.groupBox_Control.Controls.Add(this.button_cam_workspace);
            this.groupBox_Control.Controls.Add(this.button_cam_menu);
            this.groupBox_Control.Controls.Add(this.button_right);
            this.groupBox_Control.Controls.Add(this.button_push);
            this.groupBox_Control.Controls.Add(this.label1);
            this.groupBox_Control.Controls.Add(this.label4);
            this.groupBox_Control.Controls.Add(this.label2);
            this.groupBox_Control.Controls.Add(this.label3);
            this.groupBox_Control.ForeColor = System.Drawing.Color.Black;
            this.groupBox_Control.Location = new System.Drawing.Point(6, 21);
            this.groupBox_Control.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox_Control.MinimumSize = new System.Drawing.Size(185, 565);
            this.groupBox_Control.Name = "groupBox_Control";
            this.groupBox_Control.Size = new System.Drawing.Size(185, 565);
            this.groupBox_Control.TabIndex = 16;
            this.groupBox_Control.TabStop = false;
            this.groupBox_Control.Text = "Управление";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(10, 406);
            this.label5.MinimumSize = new System.Drawing.Size(165, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Работа с медиафайлами";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_Stream
            // 
            this.button_Stream.ForeColor = System.Drawing.Color.Transparent;
            this.button_Stream.Image = ((System.Drawing.Image)(resources.GetObject("button_Stream.Image")));
            this.button_Stream.Location = new System.Drawing.Point(10, 266);
            this.button_Stream.MinimumSize = new System.Drawing.Size(165, 40);
            this.button_Stream.Name = "button_Stream";
            this.button_Stream.Size = new System.Drawing.Size(165, 40);
            this.button_Stream.TabIndex = 17;
            this.button_Stream.UseVisualStyleBackColor = true;
            this.button_Stream.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(197, 21);
            this.groupBox1.MinimumSize = new System.Drawing.Size(722, 565);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 565);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Контент";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.vScrollBar1);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(925, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 565);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Справка";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(258, 16);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 540);
            this.vScrollBar1.TabIndex = 0;
            this.toolTip_Left.SetToolTip(this.vScrollBar1, " ");
            // 
            // TEXT
            // 
            this.TEXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.TEXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TEXT.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TEXT.Dock = System.Windows.Forms.DockStyle.Top;
            this.TEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TEXT.ForeColor = System.Drawing.SystemColors.Window;
            this.TEXT.Location = new System.Drawing.Point(0, 0);
            this.TEXT.Margin = new System.Windows.Forms.Padding(0);
            this.TEXT.Name = "TEXT";
            this.TEXT.ReadOnly = true;
            this.TEXT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TEXT.Size = new System.Drawing.Size(1210, 19);
            this.TEXT.TabIndex = 1;
            this.TEXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1210, 685);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_Control);
            this.Controls.Add(this.TEXT);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1226, 634);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picaso Designer X: дистанционное управление";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_Control.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox COM;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.Button button_push;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_cam_menu;
        private System.Windows.Forms.Button button_cam_workspace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_screenshot;
        private System.Windows.Forms.Button button_tl_start;
        private System.Windows.Forms.Button button_tl_stop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox_Cam;
        private System.Windows.Forms.GroupBox groupBox_Control;
        private System.Windows.Forms.Button button_Stream;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolTip toolTip_Left;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.TextBox TEXT;
    }
}
