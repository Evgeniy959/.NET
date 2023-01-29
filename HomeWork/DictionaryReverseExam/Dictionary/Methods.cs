using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public static class Methods
    {
        public static void AddRus(Dictionary<string, string> dictionary)
        {
            var flagAdd = false;
            var russian = Show.WordName("Добавьте русское слово ");
            var english = Show.WordName("Введите перевод ");
            foreach (var element in dictionary)
            {
                if (element.Value == russian && element.Key == english)
                {
                    Show.PrintLn("Слово c данным переводом уже существует");
                    flagAdd = true;
                }
            }
            if (!flagAdd)
            {
                dictionary.Add(english, russian);
            }
        }
        public static void AddEng(Dictionary<string, string> dictionaryEng)
        {
            var flagAdd = false;
            var english = Show.WordName("Добавьте английское слово ");
            var russian = Show.WordName("Введите перевод ");
            foreach (var element in dictionaryEng)
            {
                if (element.Value == english && element.Key == russian)
                {
                    Show.PrintLn("Слово c данным переводом уже существует");
                    flagAdd = true;
                }
            }
            if (!flagAdd)
            {
                dictionaryEng.Add(russian, english);
            }
        }
        public static void AddFileRus(Dictionary<string, string> dictionary)
        {
            AddRus(dictionary);
            ImportToFile(dictionary);
        }
        public static void AddResFileRus()
        {
            var dictionary = new Dictionary<string, string>();
            AddRus(dictionary);
            ImportToFile(dictionary);
        }
        public static void AddResFileEng()
        {
            var dictionary = new Dictionary<string, string>();
            AddEng(dictionary);
            ImportToFile(dictionary);
        }
        public static void AddFileEng(Dictionary<string, string> dictionary)
        {
            AddEng(dictionary);
            ImportToFile(dictionary);
        }
        public static void EditRus(Dictionary<string, string> dictionary)
        {
            var flag = false;
            var russian = Show.WordName("Введите русское слово которое хотите заменить - ");
            foreach (var element in dictionary)
            {
                if (element.Value == russian)
                {
                    dictionary.Remove(element.Key);
                    flag = true;
                }
            }
            if (flag)
            {
                var russianNew = Show.WordName("Введите новое слово - ");
                var english = Show.WordName("Введите перевод ");
                dictionary.Add(english, russianNew);
            }
            if (!flag)
            {
                Console.WriteLine("Ничего не найдено");
            }
            ImportToFileEdit(dictionary);
        }
        public static void EditEng(Dictionary<string, string> dictionary)
        {
            var flag = false;
            var english = Show.WordName("Введите английское слово которое хотите заменить - ");
            foreach (var element in dictionary)
            {
                if (element.Value == english)
                {
                    dictionary.Remove(element.Key);
                    flag = true;
                }
            }
            if (flag)
            {
                var englishNew = Show.WordName("Введите новое слово - ");
                var russian = Show.WordName("Введите перевод ");
                dictionary.Add(russian, englishNew);
            }
            if (!flag)
            {
                Console.WriteLine("Ничего не найдено");
            }
            ImportToFileEdit(dictionary);
        }
        public static void FindRus(Dictionary<string, string> dictionary)
        {
            var flag = false;
            var russian = Show.WordName("Введите русское слово которое хотите найти - ");
            foreach (var element in dictionary)
            {
                if (element.Value == russian)
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
        public static void FindEng(Dictionary<string, string> dictionary)
        {
            var flag = false;
            var english = Show.WordName("Введите английское слово которое хотите найти - ");
            foreach (var element in dictionary)
            {
                if (element.Value == english)
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
        public static void DeleteRUS(Dictionary<string, string> dictionary)
        {
            var flag = false;
            var russian = Show.WordName("Введите русское слово которое хотите удалить - ");
            foreach (var element in dictionary)
            {
                if (element.Value == russian)
                {
                    dictionary.Remove(element.Key);
                    flag = true;
                }
            }
            if (!flag)
            {
                Console.WriteLine("Ничего не найдено");
            }
        }
        public static void ImportToFile(Dictionary<string, string> dictionary)
        {
            var file = new StreamWriter(Show.Failname(), true);
            foreach (var element in dictionary)
            {
                file.WriteLine($"{element.Value} - {element.Key}");
            }
            file.Close();
        }
        public static void ImportToFileEdit(Dictionary<string, string> dictionary)
        {
            var file = new StreamWriter(Show.Failname(), false);
            foreach (var element in dictionary)
            {
                file.WriteLine($"{element.Value} - {element.Key}");
            }
            file.Close();
        }
        public static void PrintDictionary(Dictionary<string, string> dictionary)
        {
            foreach (var element in dictionary)
            {
                Console.WriteLine($"{element.Value} - {element.Key}");
            }
        }
    }
}
