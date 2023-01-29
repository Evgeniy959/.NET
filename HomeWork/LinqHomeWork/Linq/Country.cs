using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Country
    {
        public string Name { get; init; }
        public string Capital { get; private set; }
        public ulong Population { get; private set; }
        public uint Territory { get; private set; }
        public string PartOfTheWorld { get; private set; }

        public Country(string name, string capital, ulong population, uint territory, string partOfTheWorld)
        {
            Name = name;
            Capital = capital;
            Population = population;
            Territory = territory;
            PartOfTheWorld = partOfTheWorld;
        }

        public Country()
        {
        }
    }
}
