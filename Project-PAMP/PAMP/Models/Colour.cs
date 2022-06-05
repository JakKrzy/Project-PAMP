using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAMP.Models
{
    public class Colour
    {
        int red, green, blue, alpha;

        public Colour()
        {
            red = 255;
            green = 255;
            blue = 255;
            alpha = 255;
        }
        public Colour(int r, int g, int b, int a)
        {
            if (r < 0 || g < 0 || b < 0 || a < 0) throw new ArgumentException();
            if (r > 255 || g > 255 || b > 255 || a > 255) throw new ArgumentException();
            red = r;
            green = g;
            blue = b;
            alpha = a;
        }

        public void setColour(int r, int g, int b, int a)
        {
            if (r < 0 || g < 0 || b < 0 || a < 0) throw new ArgumentException();
            if (r > 255 || g > 255 || b > 255 || a > 255) throw new ArgumentException();
            red = r;
            blue = b;
            green = g;
            alpha = a;
        }

        public int Red { get { return red; } }
        public int Green { get { return green; } }
        public int Blue { get { return blue; } }
        public int Alpha { get { return alpha; } }
    }
}
