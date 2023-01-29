using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogerLib
{
    public static class LogToFile
    {        
        public static void Info(string message)
        {
            var path = @"D:\Сохранено\Downloads\Учеба\C#\Дамашние задания\Loger.ini";
            ReadIniFile obj = new ReadIniFile(path);
            using var file = new StreamWriter(@"D:\Сохранено\Downloads\Учеба\C#\Дамашние задания\Loger.log", true);
            var text = obj.Init(path);
            file.WriteLine($"{text}:{message}");            
        }
    }
}
