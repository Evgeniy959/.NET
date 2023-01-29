using System;
using System.IO;

namespace LogerLib
{
    public class ReadIniFile
    {
        private string path;

        public ReadIniFile(string path)
        {
            this.path = path;
        }
        public string Date { get; set; }
        public string MessageType { get; set; }
        public string UserName { get; set; }
        public string Message { get; set; }

        public string Init(string paht)
        {         
            using var file = new StreamReader(path);
            var line = file.ReadLine();

            string[] temp = line.Split(';');
            Date = temp[0];
            MessageType = temp[1];
            UserName = temp[2];
            Message = temp[3];            
            return $"{Date}:{DateTime.Now:G}\t {MessageType}:{" Информационное"}\t {UserName}:{Environment.UserName}\t {Message}";

        }
    }
}
