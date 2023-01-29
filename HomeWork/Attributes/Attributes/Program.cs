using System;

namespace Attributes
{
    class Program
    {
        static void Main()
        {            
            Console.WriteLine("Введите имя человека:");
            var name = Console.ReadLine();
            Console.WriteLine("Введите возраст человека:");
            var age = Convert.ToUInt32(Console.ReadLine());
            var person = new Person(name, age);
            uint valueAttr = 0;
            var validAgeRes = AgeValidatу.AgeValid(person, valueAttr);
            if (validAgeRes) Console.WriteLine($"{person.Name} совершеннолетний");
            else Console.WriteLine($"{person.Name} несовершеннолетний");            
        }
    }
}
