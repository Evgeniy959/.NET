using System;
using EditorLib;

namespace EditorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = string.Empty;
            IFileWorker fileWorker = null;
            Document document;

            Console.WriteLine("Выберите какой файл вы хотите открыть");
            Console.WriteLine("1. TXT");
            Console.WriteLine("2. JPEG");
            var select = Console.ReadLine();
            switch (select)
            {
                case "1":
                    path = @"C:\Users\Пользователь\Documents\док.txt";
                    fileWorker = new TxtFileWorker();
                    break;
                case "2":
                    path = @"C:\Users\Пользователь\Documents\пример.docx";
                    fileWorker = new JpegFileWorker();
                    break;
            }

            document = fileWorker.Open(path);

            Show(document);
        }

        static void Show(Document document)
        {
            var type = document.GetType().FullName;
            switch (type)
            {
                case "EditorLib.JpegDocument":
                    ShowJpeg(document);
                    break;
                case "EditorLib.TxtDocument":
                    ShowTxt(document);
                    break;
            }
        }

        static void ShowTxt(Document document)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(document.Content);
            Console.ResetColor();
        }

        static void ShowJpeg(Document document)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(document.Content);
            Console.ResetColor();
        }
    }   
}
