using System;

namespace СreatingСlass
{
    class Program
    {
        static void Main()
        {
            Person person = new Person();
            //PrintPerson(person);

            person.name = "Андрей";
            person.age = 35;
            PrintPerson(person);

            /*Person person = new Person
            {
                name = "Андрей",
                age = 35
            };
            PrintPerson(person);*/

            var person2 = new Person(person);
            PrintPerson(person2);

            static void PrintPerson(Person person)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{person.name}, {person.age}");
                Console.ResetColor();
            }
            
        }
    }
}
