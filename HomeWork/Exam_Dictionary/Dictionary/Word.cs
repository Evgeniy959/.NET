using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class Word
    {
        public string Russian { get; set; }
        public string English { get; set; }
        //public string English1 { get; set; }
        public Word() { }
        public Word(string russian, string english) 
        {
            Russian = russian;
            English = english;
        }
    }
    
}
