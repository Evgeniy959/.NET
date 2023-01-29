using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp47
{
    class ThridObserver : IObserver
    {
        Label label;

        public ThridObserver(Label label)
        {
            this.label = label;
        }
        public void Notify(string news)
        {
            label.Text = "Вот что случилось за сегодня! " + news;
        }
    }
}
