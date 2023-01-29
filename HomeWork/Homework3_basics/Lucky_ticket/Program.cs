/*Задание 2. Ввести с клавиатуры номер трамвайного билета (6-значное число) и проверить является ли данный билет счастливым (если на билете напечатано 
шестизначное число, и сумма первых трёх цифр равна сумме последних трёх, то 
этот билет считается счастливым).*/

using System;
using System.Linq;

namespace Lucky_ticket
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите номер трамвайного билета (6-значное число)");
            string str = Console.ReadLine();
            char[] ch = new char[str.Length];
            ch = str.ToCharArray();
            int[] ticketNumber = new int[ch.Length];            
            ticketNumber = ch.Select(s => int.Parse(s.ToString())).ToArray();            
            //int[] ticketNumber = ch.Select(s => int.Parse(s.ToString())).ToArray(); // сокращенный
            if (ch.Length == 6)
            {
                int leftNumber = 0;
                int rightNumber = 0;

                for (int i = 0; i < ch.Length; i++)
                {
                    if (i < 3)
                    {
                        leftNumber += ticketNumber[i];
                    }

                    else rightNumber += ticketNumber[i];
                }

                if (leftNumber == rightNumber)
                {
                    Console.WriteLine($"У вас счастливый билет: {leftNumber} = {rightNumber}");
                }

                else Console.WriteLine($"У вас не счастливый билет: {leftNumber} != {rightNumber}");
            }

            else Console.WriteLine("Число введено не правильно!");            
        }
    }
}
