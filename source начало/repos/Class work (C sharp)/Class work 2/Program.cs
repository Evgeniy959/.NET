using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            /*var addressBook = new Dictionary<string, string>();
            addressBook.Add("рабочий", "ШАГ");
            addressBook.Add("домашний", "г. Воронеж");

            PrintDictionary(addressBook);
            Console.WriteLine();
            
            PrintSortDictionary(addressBook);
        }

        static void PrintDictionary(Dictionary<string, string> dictionary)
        {
            foreach (var element in dictionary)
            {
                Console.WriteLine($"{element.Key}: {element.Value}");
            }
        }

        static void PrintSortDictionary(Dictionary<string, string> dictionary)
        {
            var keys = dictionary.Keys.ToList();
            keys.Sort();

            foreach (var key in keys)
            {
                Console.WriteLine($"{key}: {dictionary[key]}");
            }
        }*/

            /*Задание.Телефонный справочник
    Написать программу по созданию и редактированию телефонного справочника.
    Должен хранится номер телефона и имя человека.
    Программа должна уметь добавлять новый номер, редактировать старый, удалять и искать по номеру телефона кому он принадлежит.*/

            var exit = false;
            var phoneBook = new Dictionary<string, string>();

            do
            {
                Console.WriteLine("Выберите пункт меню:");
                Console.WriteLine("1. Добавить");
                Console.WriteLine("2. Редактировать");
                Console.WriteLine("3. Удалить");
                Console.WriteLine("4. Найти");
                Console.WriteLine("5. Показать всё");
                Console.WriteLine("0. Выход");
                var select = Console.ReadLine();
                switch (select)
                {
                    case "1": // 1. Добавить
                        AddRecord(phoneBook);
                        break;
                    case "2": // 2. Редактировать
                        Edit(phoneBook);
                        break;
                    case "3": // 3. Удалить
                        break;
                    case "4": // 4. Найти
                        Find(phoneBook);
                        break;
                    case "5": // 5. Показать всё
                        PrintDictionary(phoneBook);
                        break;
                    case "0": // 0. Выход
                        exit = true;
                        break;
                    default: // Неправильный ввод
                        Console.WriteLine("Повторите ввод");
                        Console.WriteLine();
                        break;
                }
            } while (!exit);
            Console.WriteLine("До свидания...");
        }

        static void Edit(Dictionary<string, string> dictionary)
        {
            var flag = false;

            Console.Write("Введите имя - ");
            var name = Console.ReadLine();

            foreach (var element in dictionary)
            {
                if (element.Value == name)
                {
                    Console.Write("Введите новый номер телефона - ");
                    var phone = Console.ReadLine();

                    dictionary.Remove(element.Key);
                    dictionary.Add(phone, name);
                    //dictionary[phone] = name;

                    flag = true;
                }
            }

            if (!flag)
            {
                Console.WriteLine("Ничего не найдено");
            }
        }

        static void Find(Dictionary<string, string> dictionary)
        {
            var flag = false;

            Console.Write("Введите имя - ");
            var name = Console.ReadLine();

            foreach (var element in dictionary)
            {
                if (element.Value == name)
                {
                    Console.WriteLine($"{element.Value} - {element.Key}");
                    flag = true;
                }
            }

            if (!flag)
            {
                Console.WriteLine("Ничего не найдено");
            }
        }
        static void AddRecord(Dictionary<string, string> dictionary)
        {
            Console.Write("Введите имя - ");
            var name = Console.ReadLine();
            Console.Write("Введите номер телефона - ");
            var phone = Console.ReadLine();

            dictionary.Add(phone, name);
        }

        static void PrintDictionary(Dictionary<string, string> dictionary)
        {
            foreach (var element in dictionary)
            {
                Console.WriteLine($"{element.Key}: {element.Value}");
            }
        }
    }
}

        
 