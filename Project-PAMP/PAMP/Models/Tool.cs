using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAMP.Models
{
    public abstract class Tool
    {
        Colour primaryColour = new(255, 255, 255), secondaryColour = new(0, 0, 0);

        public void setPrimaryColour(Colour c)
        {
            primaryColour = c;
        }

        public void setSecondaryColour(Colour c)
        {
            secondaryColour = c;
        }

        public Colour PrimaryColour { get => primaryColour; set { primaryColour = value; } }
        public Colour SecondaryColour { get => secondaryColour; set { secondaryColour = value; } }
    }
}
