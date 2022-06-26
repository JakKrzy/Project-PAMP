using PAMP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAMP.ViewModels
{
    public class PencilOptViewModel : ViewModelBase
    {
        Workspace _workspace;
        int size;
        Pencil _pen;
        public int Size
        {
            get { return size; }
            set 
            { 
                size = value;
                _pen.setSize(size);
                OnPropertyChange(nameof(Size));
            }
        }

        public PencilOptViewModel(Workspace ws)
        {
            _workspace = ws;
            _pen = (Pencil)_workspace.Toolbox.SelectedTool;
            Size = 1;
        }
    }
}
