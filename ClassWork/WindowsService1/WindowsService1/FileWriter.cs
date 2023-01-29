using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService1
{
    class FileWriter
    {
        FileStream fileStream;
        StreamWriter streamWriter;
        public FileWriter()
        {
            fileStream = new FileStream("D:\\службы\\1.txt", FileMode.OpenOrCreate);
            streamWriter = new StreamWriter(fileStream);
            streamWriter.Close();
        }
        public void Write(string text)
        {
            fileStream = new FileStream("D:\\службы\\1.txt", FileMode.Append);
            streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine(text);
            streamWriter.Flush();
            streamWriter.Close();
        }
        /*public void Dispose() //Деструктор
        {
            streamWriter.Close();
        }*/
    }
}
