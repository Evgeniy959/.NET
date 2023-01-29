/*Задание 3.Числовые значения символов нижнего регистра в коде ASCII
отличаются от значений символов верхнего регистра на величину 32. Используя эту 
информацию, написать программу, которая считывает с клавиатуры и конвертирует 
все символы нижнего регистра в символы верхнего регистра и наоборот*/

using System;

namespace ASCII
{
    class Program
    {
        static void Main()
        {
           char symbolChar = ' ';
            Console.WriteLine("Введите маленькие и большие буквы:");
            while (symbolChar != '.')
            {
                var symbol = Console.Read();
               
                if (symbol >= 'A' && symbol <= 'Z' || symbol >= 'А' && symbol <= 'Я')
                {
                    symbol += 32;
                    
                }
                else if (symbol >= 'a' && symbol <= 'z' || symbol >= 'а' && symbol <= 'я')
                {
                    symbol -= 32;
                }
                symbolChar = (char)symbol;
                Console.Write(symbolChar);            
            }
            Console.WriteLine(); 
        }
    }
}
