using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAMP.Models
{
    public class Layer
    {
        readonly int width, height;
        Colour[,] bmp;
        bool isVisible = true;

        public Layer(int w, int h)
        {
            width = w;
            height = h;
            bmp = new Colour[w, h];
        }

        public void toggleVisibility()
        {
            isVisible = !isVisible;
        }

        public void setPixel(Colour c, int x, int y)
        {
            if (x < 0 && y < 0) throw new ArgumentException();
            if (x > width && y > height) throw new ArgumentException();
            bmp[x, y].setColour(c.Red, c.Green, c.Blue, c.Alpha);
        }
    }
}
