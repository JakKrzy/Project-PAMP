using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAMP.Models
{
    public class Eraser : Tool
    {
        int size;
        public Eraser()
        {
            size = 1;
        }

        public int Size { get { return size; } }

        public void setSize(int n)
        {
            size = n;
        }

        public void onLeftClick(Layer l, int x, int y)
        {
            l.setPixel(new Colour(0,0,0), x, y);
        }
    }
}
