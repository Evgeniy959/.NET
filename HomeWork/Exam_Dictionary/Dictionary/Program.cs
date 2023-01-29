using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main()
        {
            var exit = false;
            //var dictionary = new Dictionary<string, string>();
            //phoneBook = ExportFromFile();
            TranslateDictionary dictionary = new TranslateDictionary();

            do
            {
                Console.WriteLine("Выберите тип словаря :");
                /*Console.WriteLine("1. Русско-Английский");
                Console.WriteLine("2. Англо-Русский");*/
                Console.WriteLine("1. Добавить");
                Console.WriteLine("2. Редактировать");
                Console.WriteLine("3. Удалить");
                Console.WriteLine("4. Найти");
                Console.WriteLine("5. Показать всё");
                Console.WriteLine("6.Загрузить из файла ");
                Console.WriteLine("7.Сохранить в новый файл");
                Console.WriteLine("0. Выход, cохранить в файл");
                var select = Console.ReadLine();
                switch (select)
                {
                    case "1": // 1. Добавить
                        AddRecord();
                        break;
                    /*case "2": // 2. Редактировать
                        Edit(phoneBook);
                        break;
                    case "3": // 3. Удалить
                        Delete(phoneBook);
                        break;
                    case "4": // 4. Найти
                        Find(phoneBook);
                        break;*/
                    case "5": // 5. Показать всё           
                        ShowCollection(dictionary.Words);
                        break;
                    /*case "6":
                        phoneBook = ExportFromFile();
                        break;
                    case "7":
                        AddFile();
                        break;*/
                    case "0": // 0. Выход
                        //ImportToFile(phoneBook);
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
        static void AddRecord()
        { 
            TranslateDictionary dictionary = new TranslateDictionary();
            /*do
            {
                var russian = Word("Введите слово ");
                var english = Word("Введите перевод ");
                dictionary.Words.Add(new Word(russian, english) { Russian = russian, English = english });
                //var russian1 = Word("Введите слово ");
                //var english1 = Word("Введите перевод ");
                dictionary.Words.Add(new Word(russian, english) { Russian = russian, English = english });
                //dictionary.Words[0].Russian = "Здравствуй";
                //dictionary.Words[1].Remove;

            } while (dictionary.Words);*/
            var russian = Word("Добавьте русское слово "); 
            var english = Word("Введите перевод "); 
            dictionary.Words.Add(new Word(russian, english) { Russian = russian, English = english });
            //var russian1 = Word("Введите слово ");
            //var english1 = Word("Введите перевод ");
            //dictionary.Words.Add(new Word(russian, english) { Russian = russian, English = english });
            //dictionary.Words[0].Russian = "Здравствуй";
            //dictionary.Words[1].Remove;

            //Console.WriteLine($"{dictionary.Words}\t");
            //Words.ShowCollection(collection);
            //ShowCollection(dictionary.Words);

        }
        static string Word(string message)
        {
            /*Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[SUCCESS] {message}");
            Console.ResetColor();*/
            Console.Write(message);
            var name = Console.ReadLine();
            return name;
        }
        static void ShowCollection(IEnumerable<Word> collection)
        {
            Console.WriteLine();
            foreach (var word in collection)
            {
                //if (word is Word t)
                //Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write($"{word.Russian} - {word.English}\t");
                Console.WriteLine();
            }
        }
    }
}
