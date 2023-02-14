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

namespace Homework_1
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
//ДЗ 2.  -------------------------------------------------------------------------------------------------------------------------------
            int down = 0;
            int up = 0;
            char symbolChar = ' ';
            Console.WriteLine("Введите маленькие и большие буквы:");
            while (symbolChar != '.')
            {
                var symbol = Console.Read();
               
                if (symbol >= 'A' && symbol <= 'Z' || symbol >= 'А' && symbol <= 'Я')
                {
                    symbol += 32;
                    ++down;
                }
                else if (symbol >= 'a' && symbol <= 'z' || symbol >= 'а' && symbol <= 'я')
                {
                    symbol -= 32;
                    ++up;
                }
                symbolChar = (char)symbol;
                Console.Write(symbolChar);            
            }
            Console.WriteLine();
            Console.Write("Количество измененных символов: ");
            Console.WriteLine($"{down + up}");*/

            //ДЗ 3.  -------------------------------------------------------------------------------------------------------------------------------
            /*int a, b;
            Console.WriteLine("Введите числа A < B: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            while (a <= b)
            {
                for (int i = 0; i < a; i++)
                    Console.Write($"{a}");
                Console.WriteLine();
                a++;
            }*/

            //ДЗ 4.  ----------------------------------------------------------------------------------------------------------------------------
            /*const int m = 8;
            const int n = 6;
            int[] arrayM = new int[m] { 2, 2, 4, 5, 6, 7, 8, 9 };
            int[] arrayN = new int[n] { 2, 2, 4, 5, 6, 7 };
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
            for (int i = 0; i < size; i++)
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
        }*/

            //ДЗ 5.  ----------------------------------------------------------------------------------------------------------------------------

            /*String str;
            Console.WriteLine("Введите строку: ");
            str = Console.ReadLine();
            Console.WriteLine($"{str}");
            //str.RemoveSymbol();
            //Tolower(str);
            //str.ToLower();
            char[] charsToTrim = { ' ' };
            Console.Write("Строка: ");
            Console.Write(IsPalindrome(str) ? "" : "НЕ ");
            Console.WriteLine("является полиндромом!");

            /*Console.WriteLine("Введите строку: ");
            int n = 256;
            String[] str = new String[n];
            String text = Console.ReadLine();
            str = text.Split();
            //str = Convert.Tostring32(Console.ReadLine());/*Console.ReadKey().KeyChar;Console.ReadLine();
            Console.WriteLine($"{str}");
            IsPalindrome(str);
        }*/
        
       /* static bool IsPalindrome(String[] str)
        {
            int n = str.Length;
            String[] buffer = new String[n + 1];
            for (int i = 0; i < n; i++)
                buffer[i] = str[i];// копирует строку str в строку буфер 
            //to_lower(buffer);
            //remove_symbol(buffer, ' ');
            n = buffer.Length;
            for (int i = 0; i < n / 2; i++)
            {
                if (str[i] != str[n - 1 - i])
                {
                    //delete[] buffer;
                    return false;
                }
            }
            //delete[] buffer;
            return true;
        }*/
        /*static int StrLen(String[] str)
        {
            int i = 0;
            for (; str[i]; i++) ;
            return i;
        }*/

        /*static bool IsPalindrome(String str)
        {
            return str == new String(str.Reverse().ToArray());
        }*/
        //ДЗ 6.  ----------------------------------------------------------------------------------------------------------------------------

        //1 способ: 
        /*Console.WriteLine("Введите текст:");
        string[] textMass;
        string text = Console.ReadLine();
        textMass = text.Split(' ');
        Console.WriteLine("Количество слов:");
        Console.WriteLine(textMass.Length);
        Console.ReadLine();*/

        //2 способ:
        Console.WriteLine("Введите текст:");
        string str = Console.ReadLine();
        str.Trim();
        int count = 1;
        foreach (char item in str)
            if (item == ' ') count++;
        Console.Write("Количество слов: ");
        Console.WriteLine(str.Trim()).Trim();
        Console.WriteLine(count);


            //ДЗ 5.  ----------------------------------------------------------------------------------------------------------------------------

            /*String str;
            //String[] text;
            Console.WriteLine("Введите строку: ");
            str = Console.ReadLine();
            char[] element = new char[]{ '*', ' ', '\'' };
            String copystr = str.ToLower();
            //text = copystr.Split(' ');
            Console.Write("Строка: ");
            Console.Write(IsPalindrome(copystr) ? "" : "НЕ ");
            Console.WriteLine("является полиндромом!");
                /*foreach (var sub in text)
                {
                    Console.WriteLine($"Substring: {text}");
                }*/
            /*foreach (int sym in element)
             {
                 copystr = copystr.Replace(sym.ToString(), "");
                 //text = copystr.Replace(sym.ToString(), "");
             }
        }
    static bool IsPalindrome(String copystr)
    //static bool IsPalindrome(String[] text)
    {
        return copystr == new String(copystr.Reverse().ToArray());
        //return text == new String[](text.Reverse().ToArray());
    }*/

            //ДЗ 6.  ----------------------------------------------------------------------------------------------------------------------------

            //1 способ: 
            /*Console.WriteLine("Введите текст:");
            string[] textMass;
            string text = Console.ReadLine();
            textMass = text.Split(' ');
            Console.WriteLine("Количество слов:");
            Console.WriteLine(textMass.Length);
            Console.ReadLine();*/

            //2 способ:
            /*Console.WriteLine("Введите текст:");
            string str = Console.ReadLine();
            //char[] charsToTrim = { '*', ' ', '\'' };
            string result = str.Trim(); //(charsToTrim);
            string result1 = Regex.Replace(result, "[ ]+", " ");
            //Console.WriteLine(Regex.Replace(result, "[ ]+", " "));
            int counter = 1;
            foreach (char item in result1)
                if (item == ' ')
                    counter++;
            Console.Write("Количество слов: ");
            Console.WriteLine(counter);*/
        }
    }
}


   

