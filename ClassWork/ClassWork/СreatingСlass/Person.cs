using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СreatingСlass
{
    public class Person
    {
        public string name;
        public int age;​
        public Person() { }​
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Person(Person person)
        {
            name = person.name;
            age = person.age;
        }​
    }
}
