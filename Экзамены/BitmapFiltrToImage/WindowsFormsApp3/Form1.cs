using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Bitmap bitmap3;
        Bitmap bitmap4;
        Bitmap halfImg;
        Bitmap halfImg2;
        Graphics graphics;
        public Form1()
        {
            InitializeComponent();
            graphics = pictureBox2.CreateGraphics();
        }

        //Bitmap bitmap;
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "JPG|*.jpg|PNG|*.png|BMP|*.bmp";
            if (fileDialog.ShowDialog()==DialogResult.OK)
            {
                bitmap = new Bitmap(fileDialog.FileName);
                pictureBox1.Image = bitmap;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Filter();
        }

        void Filter()
        {
            DateTime first = DateTime.Now;
            int h = bitmap.Height;
            int w = bitmap.Width;
            Bitmap bitmap2 = new Bitmap(w, h);

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    Color c = bitmap.GetPixel(j, i);
                    c = Color.FromArgb(c.G, c.B, c.R);
                    bitmap2.SetPixel(j, i, c);
                }
            }
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = bitmap2;
            DateTime second = DateTime.Now;
            MessageBox.Show((second - first).ToString());
        }
        public void First()
        {
            Bitmap bitmap3 = new Bitmap(bitmap);
            halfImg2 = new Bitmap(bitmap3.Width, bitmap3.Height / 2);
            int h = bitmap3.Height;
            int w = bitmap3.Width;
            for (int i = h / 2; i < h; i++)
                for (int j = 0; j < w; j++)
                {
                    Color color = bitmap3.GetPixel(j, i);
                    color = Color.FromArgb(color.R, color.R, color.R);
                    halfImg2.SetPixel(j, i - h / 2, color);
                }
        }

        public void Second()
        {
            Bitmap bitmap4 = new Bitmap(bitmap);
            halfImg = new Bitmap(bitmap4.Width, bitmap4.Height / 2);
            int h = bitmap4.Height;
            int w = bitmap4.Width;
            for (int i = 0; i < h / 2; i++)
                for (int j = 0; j < w; j++)
                {
                    Color color = bitmap4.GetPixel(j, i);
                    color = Color.FromArgb(color.R, color.R, color.R);
                    halfImg.SetPixel(j, i, color);
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
        
            Bitmap bitmap2 = new Bitmap(bitmap);
            /*Task task = new Task(new Action(() => {

                Filter();
            }));*/
            Task task = new Task(Filter);
            task.Start();            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            Bitmap bitmap4 = new Bitmap(bitmap);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            Task task = new Task(First);
            Task task2 = new Task(Second);
            /*Task task = new Task(new Action(() => {

                First();
            }));
            Task task2 = new Task(new Action(() => {

                Second();
            }));*/
            task.Start();
            task2.Start();
            task.Wait();
            task2.Wait();
            graphics.DrawImage(halfImg2, 0, bitmap4.Height / 2);
            graphics.DrawImage(halfImg, 0, 0);
            MessageBox.Show((DateTime.Now - now).ToString());

        }
    }
}
