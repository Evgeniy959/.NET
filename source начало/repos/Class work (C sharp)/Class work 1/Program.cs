using System;
using System.Linq;

namespace Class_work_1
{
    class Program
    {
        static void Main()
        {
            /*int number = 67;
            double salary = 556.5;
            string name;
            int age;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Введите ваше имя: ");
            name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Введите возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{name}, {age}, {salary * 2}");
            
            string name, sername, lastname, number_phone;
            int age;
            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите отчество: ");
            lastname = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            sername = Console.ReadLine();
            Console.Write("Введите номер телефона: ");
            number_phone = Console.ReadLine();
            Console.Write("Введите возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{name}, {lastname}, {sername}, { number_phone}, {age}");*/

            /*for (var i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} ^ 2 = {i * i}");
                }
                else
                {
                    Console.WriteLine($"{i} ^ 3 = {i * i * i}");
                }
            }*/

            int size = 3;
            int[] array = new int[size];
            RandomArray(array);
            PrintArray(array);
            Avg(array);
            Console.WriteLine($"{ Avg(array)}");
            /*Max(array);
            Console.WriteLine($"{ Max(array)}");
            Min(array);
            Console.WriteLine($"{ Min(array)}");*/
            Console.WriteLine($"{ array.Sum()}");
            Console.WriteLine($"{ array.Average()}");
            //var max = array.Max();
            Console.WriteLine($"{ array.Max()}");
            Console.WriteLine($"{ array.Min()}");    
        }
        static void RandomArray(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
            }
        }
        static void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }
        static double Avg(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            return sum / (double)array.Length;
        }
        /*static int Max(int[] array)
        {
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i]) max = array[i];
            }
            return max;
        }
        static int Min(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i]) min = array[i];
            }
            return min;
        }*/
    }
}
  
