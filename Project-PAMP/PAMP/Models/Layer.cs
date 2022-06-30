using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PAMP.Models
{
    [Serializable()]
    public class Layer : ISerializable
    {   
        int width, height;
        string name;
        Colour[,] bmp;
        bool isVisible = true;

        public Layer(string name, int w, int h)
        {
            this.name = name;
            width = w;
            height = h;
            bmp = new Colour[w, h];
            for(int i = 0; i < w; i++)
            {
                for(int j = 0; j < h; j++)
                {
                    bmp[i, j] = new Colour(0,0,0,0);
                }
            }
        }

        public void setPixel(Colour c, int x, int y)
        {
            if (x < 0 && y < 0) throw new ArgumentException();
            if (x >= width && y >= height) throw new ArgumentException();
            bmp[x, y].setColour(c.Red, c.Green, c.Blue, c.Alpha);
        }

        public void toggleVisibility()
        {
            isVisible = !isVisible;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("name", name);
            info.AddValue("width", width);
            info.AddValue("height", height);
            info.AddValue("isVisible", IsVisible);
            info.AddValue("bmp", BMP);
        }

        public Layer(SerializationInfo info, StreamingContext context)
        {
            name = info.GetString("name");
            width = info.GetInt32("width");
            height = info.GetInt32("height");
            isVisible = info.GetBoolean("isVisible");
            bmp = (Colour[,])info.GetValue("bmp", typeof(Colour[,]));
        }

        public string Name { get { return name; } }
        public int Width { get { return width; } }
        public int Height { get { return height; } }
        public Colour[,] BMP { get { return bmp; } }
        public bool IsVisible { get { return isVisible; } }
    }
}
