using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            // TODO
        }
    }
}
