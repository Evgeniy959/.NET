using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorLib
{
    public interface IFileWorker
    {
        public Document Create();
        public Document Open(string path);
        public void SaveAs(string path, Document document);
        public void Save(Document document);
    }
}
