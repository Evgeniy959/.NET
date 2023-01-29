/*Задание 5.Дано целое число N (> 0), найти число, полученное при прочтении 
числа N справа налево. Например, если было введено число 345, то программа
должна вывести число 543*/

using System;
using System.Linq;

namespace Reverse
{
    class Program
    {
        static void Main()
        {
            //1 способ (Array.Reverse())
            string str;
            Console.WriteLine("Введите число:");
            str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            Array.Reverse(ch);
            string strReverse = new string(ch);
            Console.WriteLine($"{strReverse}");

            //2 способ (LINQ)
            /*string str;
            Console.WriteLine("Введите число:");
            str = Console.ReadLine();
            string strReverse = new string(str.ToCharArray().Reverse().ToArray());   
            Console.WriteLine($"{strReverse}");*/
        }
    }
}
