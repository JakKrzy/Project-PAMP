using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PAMP.Models
{
    [Serializable()]
    public class Colour : ISerializable
    {
        int red, green, blue, alpha;

        public Colour()
        {
            red = 255;
            green = 255;
            blue = 255;
            alpha = 255;
        }
        public Colour(int r, int g, int b)
        {
            if (r < 0 || g < 0 || b < 0) throw new ArgumentException();
            if (r > 255 || g > 255 || b > 255) throw new ArgumentException();
            red = r;
            green = g;
            blue = b;
            alpha = 255;
        }
        public Colour(int r, int g, int b, int a)
        {
            if (r < 0 || g < 0 || b < 0) throw new ArgumentException();
            if (r > 255 || g > 255 || b > 255) throw new ArgumentException();
            red = r;
            green = g;
            blue = b;
            alpha = a;
        }

        public void setColour(int r, int g, int b, int a)
        {
            if (r < 0 || g < 0 || b < 0) throw new ArgumentException();
            if (r > 255 || g > 255 || b > 255) throw new ArgumentException();
            red = r;
            blue = b;
            green = g;
            alpha = a;
        }

        public Brush toBrush()
        {
            return new SolidColorBrush(Color.FromArgb((byte)alpha, (byte)red, (byte)green, (byte)blue));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Red", red);
            info.AddValue("Green", green);
            info.AddValue("Blue", blue);
            info.AddValue("Alpha", alpha);
        }

        public Colour(SerializationInfo info, StreamingContext context)
        {
            red = (int)info.GetValue("Red", typeof(int));
            green = (int)info.GetValue("Green", typeof(int));
            blue = (int)info.GetValue("Blue", typeof(int));
            alpha = (int)info.GetValue("Alpha", typeof(int));
        }

        public int Red { get { return red; } set { red = value; } }
        public int Green { get { return green; } set { green = value; } }
        public int Blue { get { return blue; } set { blue = value; } }
        public int Alpha { get { return alpha; } set { alpha = value; } }
    }
}
