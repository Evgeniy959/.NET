using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryEateble
{
    class Chocolate: IEateble
    {
        public string Name { get; set; }
        public int Mass { get; set; }
        public Chocolate(string name, int mass)
        {
            Name = name;
            Mass = mass;
        }
        public string Eat()
        {
            return "Вы съели " + Name + " массой " + Mass.ToString() + " грамм";
        }
    }
}
