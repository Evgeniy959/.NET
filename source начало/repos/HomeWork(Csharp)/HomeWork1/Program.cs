/*ДЗ 1. Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка.Программа должна сосчитать количество введенных пользователем пробелов.
ДЗ 2. Числовые значения символов нижнего регистра в коде ASCII отличаются от значений символов верхнего регистра на величину 32. Используя эту информацию, написать программу, которая считывает с клавиатуры и конвертирует все символы нижнего регистра в символы верхнего регистра и наоборот.
ДЗ 3. Даны целые положительные числа A и B (A<B). Вывести все целые числа от A до B включительно; каждое число должно выводиться на новой строке; при этом каждое число должно выводиться количество раз, равное его значению.Например: если А = 3, а В = 7, то программа должна сформировать в консоли следующий вывод:
3 3 3
4 4 4 4
5 5 5 5 5
6 6 6 6 6 6
7 7 7 7 7 7 7
ДЗ 4.Даны 2 массива размерности M и N соответственно. Необходимо переписать в третий массив общие элементы первых двух массивов без повторений.
ДЗ 5. Пользователь вводит строку. Проверить, является ли эта строка палиндромом. Палиндромом называется строка, которая одинаково читается слева направо и справа налево.
ДЗ 6. Подсчитать количество слов во введенном предложении.*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Homework1
{
    class Program
    {
        static void Main()
        {
            //ДЗ 1.  -------------------------------------------------------------------------------------------------------------------------------
            /*char key;
            int count_space = 0;
            Console.Write("Введите символы: ");
            do
            { 
                key = Console.ReadKey().KeyChar;
                if (key == ' ')
                    count_space++;
            }
            while (key != '.');
            Console.WriteLine();
            Console.Write("Количество пробелов: ");
            Console.WriteLine($"{count_space}");
        }
    }
}*/
//ДЗ 2.  -------------------------------------------------------------------------------------------------------------------------------            
            /*char symbolChar = ' ';
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
}*/

//ДЗ 3.  -------------------------------------------------------------------------------------------------------------------------------
            /*int a, b;
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

//ДЗ 4.  ----------------------------------------------------------------------------------------------------------------------------
            int m = 8;
            int n = 6;
            int[] arrayM = new int[m];
            int[] arrayN = new int[n];
            int size = 0;
            RandomArray(arrayM);
            PrintArray(arrayM);
            RandomArray(arrayN);
            PrintArray(arrayN);            
            for (int i = 0; i < m; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    if (arrayM[i] == arrayN[j]) size++;
                }
            }            
            Console.Write("Размер выделяемой памяти для третьего массива: ");
            Console.WriteLine(size);
            int[] arrayC = new int[size];
            int povtor = 0;
            int it = 0;
            
            for (int i = 0; i < m; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    if (arrayM[i] == arrayN[j])
                    {
                        for (int k = 0; k < size; k++)
                        {
                            if (arrayC[k] == arrayN[j]) povtor++;
                        }                       
                        if (povtor == 0)
                        {
                            arrayC[it] = arrayN[j];
                            it++;
                        }
                        povtor = 0;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < it; i++)
            {
                Console.Write($"{arrayC[i]}");
            }
            Console.WriteLine();
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
    }
}*/

//ДЗ 5.  ----------------------------------------------------------------------------------------------------------------------------

        /*String str;
        Console.WriteLine("Введите строку: ");
        str = Console.ReadLine();        
        String copystr = str.ToLower();
        String copystr1 = str.Trim();
        String copystr2 = copystr1.Replace(" ", "");
        Console.WriteLine($"{copystr2}");
        Console.Write("Строка: ");
        Console.Write(IsPalindrome(copystr2) ? "" : "НЕ ");
        Console.WriteLine("является полиндромом!");
        }
        static bool IsPalindrome(String copystr2)
        {
            return copystr2 == new String(copystr2.Reverse().ToArray());
        }
    }
}*/

//ДЗ 6.  ----------------------------------------------------------------------------------------------------------------------------

        //1 способ (по количеству пробелов):
        Console.WriteLine("Введите текст:");
        string str = Console.ReadLine();
        string result1 = str.Trim(); 
        string result2 = Regex.Replace(result1, "[ ]+", " ");        
        int counter = 1;
        foreach (char item in result2)
            if (item == ' ') 
            counter++;
        Console.Write("Количество слов: ");
        Console.WriteLine(counter);

        //2 способ (по количеству слов): 
        Console.WriteLine("Введите текст:");
        string text = Console.ReadLine();
        char[] text1 = text.ToCharArray();
        int count = 0;
        bool spaceflag = false;
            foreach (char sym in text1)
            {
                if (sym != ' ' && (spaceflag == false))
                {
                    spaceflag = true;
                    count++;
                }
                if (sym == ' ' && (spaceflag == true))
                {
                    spaceflag = false;
                }
                Console.Write($"Количество слов: {count}");
                Console.WriteLine();
            }

        }
    }
}

