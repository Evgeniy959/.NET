using System;
using System.Collections.Generic;
using System.IO;

namespace FileWorking
{
    public class User
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
    class Program
    {
        static void Main()
        {
            /*
            User user = new User();
            user.Name = "Andrey";
            user.DateOfBirth = new DateTime(1986, 2, 18);

            string output = $"{user.Name};{user.DateOfBirth.ToString("d")}";

            using (StreamWriter file = new StreamWriter(path, false))
            {
                file.WriteLine(output);
            }
            */
            string path = @"D:\Сохранено\Downloads\Учеба\C#\Дамашние задания\ert.ini"; 

            User person = new User();
            string line;
            using (StreamReader file = new StreamReader(path))
            {
                line = file.ReadLine();
            }

            string[] temp = line.Split(';');
            person.Name = temp[0];
            person.DateOfBirth = Convert.ToDateTime(temp[1]);

            Console.WriteLine($"Name - {person.Name}\tDate og birth - {person.DateOfBirth:d}");
        }
    }
}
