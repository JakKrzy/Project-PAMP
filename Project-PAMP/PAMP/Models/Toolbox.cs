using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAMP.Models
{
    public class Toolbox
    {
        Tool selectedTool;

        public Toolbox()
        {
            selectedTool = new Pencil();
        }

        public Tool SelectedTool 
        {
            get { return selectedTool; }
            set { selectedTool = value; }
        }
    }
}
