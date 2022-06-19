using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAMP.Models
{
    public class Pencil : Tool
    {
        int size;
        public Pencil()
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
            l.setPixel(PrimaryColour, x, y);            
        }

        public void onRightClick(Layer l, int x, int y)
        {
            l.setPixel(SecondaryColour, x, y);
        }
    }
}
