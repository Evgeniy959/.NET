using System;

namespace ClassUsingProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Person person = new Person();
            //PrintPerson(person);

            person.Name = "Андрей";
            person.Age = 35;            
            PrintPerson(person);*/

            Person person = new Person
            {
                Name = "Андрей",
                Age = 35
            };
            PrintPerson(person);

            var person2 = new Person(person);
            PrintPerson(person2);

            static void PrintPerson(Person person)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{person.Name}, {person.Age}");
                Console.ResetColor();
            }
        }
    }
}

        
