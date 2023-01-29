using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp47
{
    interface IObserver
    {
        void Notify(string news);
    }
}
