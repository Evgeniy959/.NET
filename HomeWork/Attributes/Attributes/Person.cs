using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    public class Person
    {  
        [AgeAttribute(18)]
        public uint Age { get; set; }
        public string Name { get; set; }
        public Person() { }
        public Person(string name, uint age)
        {
            Age = age;
            Name = name;
        }
    }
}
