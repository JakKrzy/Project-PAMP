using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PAMP.Models
{
    [Serializable()]
    public class Image : ISerializable
    {
        Layer selectedLayer;
        List<Layer> layerList;
        int width, height;

        public Image(int w, int h)
        {
            width = w;
            height = h;
            layerList = new List<Layer>();
            layerList.Add(new Layer("Background", width, height));
            selectedLayer = layerList[0];
        }

        public List<Layer> LayerList { get { return layerList; } }
        public int Height { get { return height; } }
        public int Width { get { return width; } }

        public Layer SelectedLayer { get; set; }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Width", Width);
            info.AddValue("Height", Height);
            info.AddValue("Layers", layerList);
        }
        public Image(SerializationInfo info, StreamingContext context)
        {
            width = info.GetInt32("Width");
            height = info.GetInt32("Height");
            layerList = (List<Layer>)info.GetValue("Layers", typeof(List<Layer>));
        }
    }
}
