using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassUsingProperties
{
    public class Person
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;

        public int Age
        {
            get => _age;
            set => _age = value;
        }

        public Person() { }

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public Person(Person person)
        {
            _name = person.Name;
            _age = person.Age;
        }
    }
}
    

