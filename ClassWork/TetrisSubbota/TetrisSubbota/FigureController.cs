using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisSubbota
{
    class FigureController
    {
        PixelGame pixelGame;

        public FigureController (PixelGame pixelGame)
        {
            this.pixelGame = pixelGame;
        }
       
        public int CanMove(Figure figure, int top, int left)
        {
            return 0;
        }
        public void Move(Figure figure, int top, int left)
        {
            
        }
        public void NextLayer (Figure figure)
        {

        }
    }
}
