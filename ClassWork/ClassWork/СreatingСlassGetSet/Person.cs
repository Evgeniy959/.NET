using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СreatingСlassGetSet
{
    public class Person
    {
        private string _name;
        private int _age;

        public Person() { }

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public Person(Person person)
        {
            _name = person.GetName();
            _age = person.GetAge();
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetAge(int age) => _age = age;
        public int GetAge() => _age;
    }
}
