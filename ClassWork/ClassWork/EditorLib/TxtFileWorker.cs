using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorLib
{
    public class TxtFileWorker : IFileWorker
    {
        public Document Create()
        {
            return new TxtDocument();
        }

        public Document Open(string path)
        {
            using var file = new StreamReader(path);
            var content = file.ReadToEnd();
            return new TxtDocument(path, content);
        }

        public void SaveAs(string path, Document document)
        {
            using var file = new StreamWriter(path, append: false);
            file.Write(document.Content);
        }

        public void Save(Document document)
        {
            SaveAs(document.Path, document);
        }
    }
}
