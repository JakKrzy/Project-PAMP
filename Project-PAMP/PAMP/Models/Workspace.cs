using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;

namespace PAMP.Models
{
    [Serializable()]
    public class Workspace : ISerializable
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
            List<Layer> layers = Image.LayerList;
            for(int i = 0; i < image.Width; i++)
            {
                for(int j = 0; j < image.Height; j++)
                {
                    Color c = Color.FromArgb(0, 0, 0, 0);
                    bmp.SetPixel(i, j, c);
                }
            }
            for(int k = 0; k < layers.Count; k++)
            {
                for (int i = 0; i < bmp.Width; i++)
                {
                    for (int j = 0; j < bmp.Height; j++)
                    {
                        Colour _c = Image.LayerList[k].BMP[i, j];
                        if (_c.Alpha == 0) continue;
                        Color c = Color.FromArgb(_c.Alpha, _c.Red, _c.Green, _c.Blue);
                        bmp.SetPixel(i, j, c);
                    }
                }
            }


                
          
            string filePath = "NewImage.png";
            FileStream fs = File.Create(filePath);
            bmp.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
            fs.Close();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
           
            info.AddValue("Image", image);
        }

        public Workspace(SerializationInfo info, StreamingContext context)
        {
            toolbox = new Toolbox();
            image = (Image)info.GetValue("Image", typeof(Image)); 
        }
    }
}
