using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryEateble
{
    class IceCream: IEateble
    {
        public string Name { get; set; }
        public IceCream(string name)
        {
            Name = name;
        }
        public string Eat() 
        {
            return "Вы съели " + Name;
        }
    }
}
