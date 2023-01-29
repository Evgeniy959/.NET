using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisSubbota
{
   abstract class PixelGame
    {
        public int[,] GameArea { get; protected set; }
        public int Height { get; protected set; }
        public int Width { get; protected set; }
        List<Figure> figures;
        public bool IsGameOver { get; protected set; }
        public string Name { get; set; }
        public List<string> TopScores { get; protected set; }
        public int Score { get; private set; }

        public PixelGame(string name,int height =20, int width =10)
        {
            Name = name;
            Height = height;
            Width = width;
            GameArea = new int[height, width];
            IsGameOver = false;
            Score = 0;
        }
        public abstract void KeyDown(string key);
    }
}
