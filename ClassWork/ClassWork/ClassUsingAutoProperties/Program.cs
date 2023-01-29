/*Создать классы: Учитель, Ученик, работник школы
В классах должна содержаться информация о человеке (ФИО, дата рождения), и 
специфическая информация о каждой группе.*/

using System;

namespace ClassUsingAutoProperties
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

            /*Student student = new Student();
            student.Person = person;
            student.Faculty = "SoftDev";*/
            Person person3 = new Person
            {
                Name = "Alex",
                Age = 39
            };
            Person person4 = new Person
            {
                Name = "Елена",
                Age = 46
            };

            var student = new Student
            {
                Person3 = person3,
                Faculty = "SoftDev"
            };
            PrintStudent(student, person3);

            var teacher = new Teacher
            {
                Person = person,
                Faculty = "Information technologies",
                Experience = 20
            };
            PrintTeacher(teacher, person);

            var schoolEmployee = new SchoolEmployee
            {
                Person4 = person4,
                Profession = "Завуч",
                Experience = 18
            };
            PrintSchoolEmployee(schoolEmployee, person4);

            static void PrintPerson(Person person)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{person.Name}, {person.Age}");
                Console.ResetColor();
            }

            static void PrintStudent(Student student, Person person3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{person3.Name}, {person3.Age}, {student.Faculty}");                
                Console.ResetColor(); 
            }

            static void PrintTeacher(Teacher teacher, Person person)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{person.Name}, {person.Age}, {teacher.Experience}, {teacher.Faculty}");
                Console.ResetColor();
            }

            static void PrintSchoolEmployee(SchoolEmployee schoolEmployee, Person person4)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"{person4.Name}, {person4.Age} лет, {schoolEmployee.Profession}, {schoolEmployee.Experience} лет");
                Console.ResetColor();
            }
        }
    }
}

