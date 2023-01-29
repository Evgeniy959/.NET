using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] graf = new int[7, 7]
            {
               {0, 1, 0, 0, 0, 1, 1},
               {1, 0, 1, 0, 0, 0, 0},
               {0, 1, 0, 0, 1, 1, 0},
               {0, 0, 0, 0, 0, 0, 0},
               {0, 0, 1, 0, 0, 1, 0},
               {1, 0, 1, 0, 1, 0, 0},
               { 1, 0, 0, 0, 0, 0, 0},
            };
            int[] color = new int[7] { 1, 1, 1, 1, 1, 3, 3 };
            int count = 0;
            for(int i = 0; i<7; i++)
                for (int j = 0; j < 7; j++)
                {
                    if (graf[i, j] == 1 && color[i] != color[j])
                        count++;
                }
            count/=2;
            MessageBox.Show(count.ToString());

        }
    }
}
