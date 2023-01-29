using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public static class Show
    {
        public static string WordName(string message)
        {
            Console.Write(message);
            var name = Console.ReadLine();
            return name;
        }
        public static string Failname()
        {
            Console.WriteLine("Введите имя файла - ");
            string path = Console.ReadLine();
            return path;
        }        
        public static void PrintLn(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void Menu() 
        {
            PrintLn("Выберите тип словаря:");
            PrintLn("1. Русско-Английский");
            PrintLn("2. Англо-Русский");
        }
        public static void submenu()
        {            
            PrintLn("1. Добавить");
            PrintLn("2. Редактировать");
            PrintLn("3. Удалить");
            PrintLn("4. Найти перевод");
            PrintLn("5. Показать весь словарь");
            PrintLn("6. Сохранить в отдельный файл результата");
            PrintLn("7. Возврат в предыдущее меню");
            PrintLn("0. Выход");


        }
    }
}
