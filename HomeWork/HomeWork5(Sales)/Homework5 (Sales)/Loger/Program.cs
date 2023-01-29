using System;
using System.IO;

namespace Loger
{
    class ReadIniFile
    {
        //public string Path { get; set; }
        public DateTime DateTime { get; set; }
        public string MessageType { get; set; }
        public string UserName { get; set; }
        public string Message { get; set; }
       //public ReadIniFile ()
    }

    class Program
    {
        static void Main()
        {
            string path = @"D:\Сохранено\Downloads\Учеба\C#\Дамашние задания\Loger.ini";

            ReadIniFile iniFile = new ReadIniFile();
            string line;
            using (StreamReader file = new StreamReader(path))
            {
                line = file.ReadLine();
            }

            string[] temp = line.Split(';');
            iniFile.DateTime = Convert.ToDateTime(temp[0]);
            iniFile.MessageType = temp[1];
            iniFile.UserName = temp[2];
            iniFile.Message = temp[3];

            Console.WriteLine($"{iniFile.DateTime:d}-{DateTime.Now:d}\t MessageType - {iniFile.MessageType}\t {iniFile.UserName}-{Environment.UserName}\t Message-{iniFile.Message}");

        }
    }
}
