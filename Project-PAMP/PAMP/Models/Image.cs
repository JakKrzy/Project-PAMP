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

        /// <summary>
        /// Creates a new Layer and changes the selected layer to newly created one
        /// </summary>
        public void newLayer(string name)
        {
            Layer nl = new Layer(name, width, height);
            layerList.Add(nl);
            selectedLayer = nl;

        }

        /// <summary>
        /// Removes a layer at index i
        /// </summary>
        /// <param name="i"> index of layer to be removed </param>
        public void removeLayer(int i)
        {
            layerList.RemoveAt(i);
        }

        public void export()
        {
            // TODO
        }
    }
}
