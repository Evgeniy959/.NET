using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryEateble
{
    class Factory
    {
        List<IEateble> Menu;
        public Factory(List<IEateble> menu) 
        {
            Menu = menu;
        }

        public IEateble GetEateble(int num) 
        {
            if (num < Menu.Count) 
                return Menu[num];
            return null;
        }
    }
}
