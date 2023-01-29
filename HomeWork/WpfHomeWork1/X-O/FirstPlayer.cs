using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace X_O
{
    public class FirstPlayer //Первый игрок
    {
        public ImageBrush XPainting() //установка заднего фона "X"
        {
            var brush = new ImageBrush();
            brush.ImageSource = new BitmapImage(new Uri("cross.png", UriKind.Relative));
            return brush;
        }
    }
}
