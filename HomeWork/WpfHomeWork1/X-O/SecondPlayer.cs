using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace X_O
{
    public class SecondPlayer //Второй игрок
    {
        public ImageBrush OPainting() //Установка заднего фона "O"
        {
            var brush = new ImageBrush();
            brush.ImageSource = new BitmapImage(new Uri("zero.png", UriKind.Relative));
            return brush;
        }
    }
}
