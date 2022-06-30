using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PAMP.Models
{
    [Serializable()]
    public class Toolbox : ISerializable
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

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("SelectedTool", selectedTool);
        }
    }
}
