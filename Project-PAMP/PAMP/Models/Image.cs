using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAMP.Models
{
    public class Image
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

        public void export()
        {
            // TODO
        }
    }
}
