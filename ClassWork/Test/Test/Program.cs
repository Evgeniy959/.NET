using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x = 1;
            int y = 6;
            int sum = x + y;
            Console.WriteLine($"{sum}");
            Console.WriteLine("Введите x");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{x+y}");
        }
    }
}
