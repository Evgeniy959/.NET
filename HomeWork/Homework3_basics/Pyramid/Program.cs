/*Задание 4. Даны целые положительные числа A и B (A < B). Вывести все целые
числа от A до B включительно; каждое число должно выводиться на новой строке;
при этом каждое число должно выводиться количество раз, равное его значению. 
Например: если А = 3, а В = 7, то программа должна сформировать в консоли 
следующий вывод
3 3 3
4 4 4 4
5 5 5 5 5
6 6 6 6 6 6
7 7 7 7 7 7 7*/

using System;

namespace Pyramid
{
    class Program
    {
        static void Main()
        {
            int a, b;
            Console.WriteLine("Введите числа A < B: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (a > b)
            {
                Console.WriteLine("Повторите ввод чтобы было A < B");
                return;
            } 
            while (a <= b)
            {               
                for (int i = 0; i < a; i++)
                    Console.Write($"{a}");
                Console.WriteLine();
                a++;               
            }
        }
    }
}
