using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAMP.Models
{
    public class Rectangle : Tool
    {
        bool fill;
        int width;
        int height;
        public bool Fill { get { return fill; } set { fill = value; } }
        public int Width { get { return width; } set { width = value; } }
        public int Height { get { return height; } set { height = value; } }

        public Rectangle()
        {
            fill = false;
        }
    }
}
