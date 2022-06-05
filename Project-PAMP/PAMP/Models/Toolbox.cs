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
        List<Tool> toolList;

        public Toolbox()
        {
            toolList = new List<Tool>();
            toolList.Add(new Pencil());
            toolList.Add(new Eraser());
        }

        public void setTool(int i)
        {
            selectedTool = toolList[i];
        }

        public Tool SelectedTool { get { return selectedTool; } }
    }
}
