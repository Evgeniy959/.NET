using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorLib
{
    public class TxtDocument : Document     
    {
        public TxtDocument() : base() { }
        public TxtDocument(string path, string content) : base(path, content) { }
    }
}
