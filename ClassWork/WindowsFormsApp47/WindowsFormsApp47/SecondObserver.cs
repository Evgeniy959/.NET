using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp47
{
    class SecondObserver : IObserver
    {
        public void Notify(string news)
        {
            MessageBox.Show("Ужасно! " + news + " очень осуждаю");
        }
    }
}
