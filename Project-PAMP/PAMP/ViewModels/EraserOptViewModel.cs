using PAMP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAMP.ViewModels
{
    public class EraserOptViewModel : ViewModelBase
    {
        Workspace _workspace;
        int size;
        Eraser er;
        public int Size
        {
            get { return size; }
            set
            {
                size = value;
                er.setSize(size);
                OnPropertyChange(nameof(Size));
            }
        }

        public EraserOptViewModel(Workspace ws)
        {
            _workspace = ws;
            er = (Eraser)_workspace.Toolbox.SelectedTool;
            Size = 1;
        }
    }
}
