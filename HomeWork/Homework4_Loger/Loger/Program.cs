using LogerLib;
using System;
using System.IO;
using System.Linq;

namespace Loger
{
    class Program
    {
        static void Main()
        {
            int size = 3;
            int[] array = new int[size];           
            RandomArray(array);
            PrintArray(array);            
            Console.WriteLine($"{ array.Sum()}");
            LogToFile.Info(" Сумма элементов массива");
            Console.WriteLine($"{ array.Average()}");
            LogToFile.Info(" Среднее значение элементов массива");
            Console.WriteLine($"{ array.Max()}");
            LogToFile.Info(" Максимальное значение элементов массива");
            Console.WriteLine($"{ array.Min()}");
            LogToFile.Info(" Минимальное значение элементов массива");
        }       
        static void RandomArray(int[] array)
        {
            LogToFile.Info(" Заполнение массива случайными числами");
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
            }
        }
        static void PrintArray(int[] array)
        {
            LogToFile.Info(" Вывод массива на экран");
            foreach (int item in array)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }         
    }
}
