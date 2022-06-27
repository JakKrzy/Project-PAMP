using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Drawing;
using System.IO;

namespace PAMP.Models
{
    public class Workspace
    {
        Toolbox toolbox;
        Image image;
        
        public Workspace(int w, int h)
        {
            toolbox = new Toolbox();
            image = new Image(w, h);
        }

        public Toolbox Toolbox { get { return toolbox; } }
        public Image Image { get { return image; } }

        public void saveWorkspace()
        {
           // TODO
        }

        public void exportImage()
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            for(int i = 0; i < bmp.Width; i++)
            {
                for(int j = 0; j < bmp.Height; j++)
                {
                    Colour _c = Image.SelectedLayer.BMP[i, j];
                    Color c = Color.FromArgb(_c.Alpha, _c.Red, _c.Green, _c.Blue);
                    bmp.SetPixel(i, j, c);
                }
            }
            string filePath = "NewImage.png";
            FileStream fs = File.Create(filePath);
            bmp.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}
