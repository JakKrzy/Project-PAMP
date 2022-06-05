using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAMP.Models
{
    public abstract class Tool
    {
        Colour primaryColour = new(0,0,0,255), secondaryColour = new(255,255,255,255);

        public void setPrimaryColour(int r, int g, int b, int a)
        {
            primaryColour.setColour(r, g, b, a);
        }

        public void setSecondaryColour(int r, int g, int b, int a)
        {
            secondaryColour.setColour(r, g, b, a);
        }

        public Colour PrimaryColour { get => primaryColour; }
        public Colour SecondaryColour { get => secondaryColour; }
    }
}
