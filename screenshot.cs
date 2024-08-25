using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using Emgu.Util;
using System.IO;

namespace _3D_Printer___Main_version
{
    public partial class MakeScreenShotForm : Form
    {
        private Image<Bgr, byte> image = null;
        private string filename = string.Empty;

        public MakeScreenShotForm(Image<Bgr, byte> image)
        {
            this.image = image;
            InitializeComponent();
        }

        private void MakeScreenShotForm_Load(object sender, EventArgs e)
        {
            filename = $"Picaso712_{DateTime.Now.Day}{DateTime.Now.Month}{DateTime.Now.Year}{DateTime.Now.Hour}{DateTime.Now.Minute}{DateTime.Now.Second}.png";
            pictureBox1.Image = image.Bitmap;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try 
            {
                pictureBox1.Image.Save(filename, ImageFormat.Png);

                if (File.Exists(filename))
                {
                    Close();
                }
                else
                {
                    throw new Exception("Не удалось сохранить скриншот");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Close ();
        }
    }
}
