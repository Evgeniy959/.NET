using System;

namespace СreatingСlassGetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            //PrintPerson(person);

            person.SetName("Андрей");
            person.SetAge(35);
            PrintPerson(person);

            /*Person person = new Person
            {
                _name = "Андрей",
                person.GetAge() = 35;
                //_age = 35
            };*/
            //PrintPerson(person);

            var person2 = new Person(person);
            PrintPerson(person2);

            static void PrintPerson(Person person)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{person.GetName()}, {person.GetAge()}");
                Console.ResetColor();
            }
        }
    }
}
