/*Задание 1. Написать программу, которая считывает символы с клавиатуры, пока не 
будет введена точка. Программа должна сосчитать количество введенных 
пользователем пробелов.*/

using System;

namespace Сount_space
{
    class Program
    {
                                  // 1 способ
        static void Main()
        {            
            Console.WriteLine("Введите символы: ");            
            string str = Console.ReadLine();
            var counter = СountSpace(str);            
            Console.WriteLine($"Количество пробелов: {counter}");
        }
        static int СountSpace(string str)
        {
            var counter = 0;                        
            foreach (var symb in str)
            {                              
                if (symb == ' ')
                {
                    ++counter;
                }
                if (symb == '.') break;                

            }
            return counter;
        }
//---------------------------------------------------------------------------------------------
                                    // 2 способ
        /*static void Main()
        {
            char key;
            int count_space = 0;
            Console.WriteLine("Введите символы: ");
            do
            {
                
                key = Console.ReadKey().KeyChar;
                if (key == ' ')
                    count_space++;
            }
            while (key != '.');
            Console.WriteLine();           
            Console.WriteLine($"Количество пробелов: {count_space}");
        }*/
    }
}
