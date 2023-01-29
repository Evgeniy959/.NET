using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisSubbota
{
       class Figure
     {
        public int PosX { get; set; }
        public int PosY{ get; set; }
        public int Layer { get; set; }
        public int N { get;protected set; }
        public int Deep { get; protected set; }
        public Color color { get;  set; }
        public int[,,] figure { get; protected set; }

        public Figure( int[,,] figure, int n, int deep)
        {
            this.figure = figure;
            N = n;
            Deep = deep;
            color = Color.Black;
        }
        public void ShowArray()
        {
            string result = "";
            for (int i = 0; i < N; i++) 
            {
                for (int j = 0; j < N; j++)
                {
                    result += figure[i, j, 1].ToString();
                    //result=figure[i, j, 0].ToString(); // не верно
                    //MessageBox.Show(figure[i, j, 0].ToString()); // не верно
                }
                result += "\n";
            }
            /*for (int k = 0; k < 1; k++)
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        result += figure[i, j, k].ToString(); // Равнозначный вариант
                    }
                    result += "\n";
                }*/
            /*for (int i = 0; i < N; i++) 
                for (int j = 0; j < N; j++)
                {
                    result += figure[i, j, 0].ToString(); // Выводит в одну строчку
                    
                }
                result += "\n";*/
            MessageBox.Show(result);
        }
    }
}
