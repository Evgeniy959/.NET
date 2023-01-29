using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Bitmap bitmap2;
        Bitmap halfImg;
        Bitmap halfImg2;
        Graphics graphics;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap("C:\\Users\\Пользователь\\Documents\\1.jpg");
            bitmap2 = new Bitmap(bitmap);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = bitmap;
            graphics = pictureBox1.CreateGraphics();
        }
        public void first()
        {
            halfImg2 = new Bitmap(bitmap2.Width, bitmap2.Height / 2);
            int h = bitmap2.Height ;
            int w = bitmap2.Width;
             for (int i=h/2; i<h;i++)
                for (int j=0; j<w;j++)
                {
                    Color color = bitmap2.GetPixel(j, i);
                    color = Color.FromArgb(color.R, color.R, color.R);
                    halfImg2.SetPixel(j, i-h/2, color);
                }
        }

        public void second()
        {
            halfImg = new Bitmap(bitmap.Width, bitmap.Height / 2);
            int h = bitmap.Height ;
            int w = bitmap.Width;
            for (int i = 0; i < h / 2; i++)
                for (int j = 0; j < w; j++)
                {
                    Color color = bitmap.GetPixel(j, i);
                    color = Color.FromArgb(color.R, color.R, color.R);
                    halfImg.SetPixel(j, i, color);
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            Task task = new Task(first);
            Task task2 = new Task(second);
            task.Start();
            task2.Start();
            task.Wait();
            task2.Wait();
            graphics.DrawImage(halfImg2, 0, bitmap.Height / 2);
            graphics.DrawImage(halfImg, 0, 0);
            MessageBox.Show((DateTime.Now - now).ToString());
        }
    }
}
