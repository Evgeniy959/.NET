using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TetrisSubbota
{
    class FigureFileReader : IFigureRead
    {
        public Figure  Read(string path)
        {
            FileStream stream = new FileStream(path, FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            int n = Convert.ToInt32(reader.ReadLine());
            int deep = Convert.ToInt32(reader.ReadLine());
            int[,,] buffer = new int[n, n, deep];
            for (int k = 0; k < deep; k++)
               for (int i=0; i<n;i++)
                for(int j=0; j<n; j++)
                    {
                        buffer[i, j, k] = reader.Read() - 48;
                    }
            return new Figure(buffer, n, deep);
        }
    }
}
