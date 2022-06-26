using PAMP.Models;
using PAMP.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace PAMP.ViewModels
{
    public class WorkspaceViewModel : ViewModelBase
    {


        readonly ImageViewModel imgV;
        readonly ToolboxViewModel toolVM;
        readonly LayerListViewModel layersVM;

        readonly ToolOptionsStore toolOptionsStore;

        public ToolboxViewModel ToolVM { get { return toolVM; } }
        public ImageViewModel Image { get { return imgV; } }
        public LayerListViewModel LayerList { get { return layersVM; } }
        
        public WorkspaceViewModel(Workspace ws)
        {
            toolOptionsStore = new ToolOptionsStore();
            imgV = new ImageViewModel(ws);
            toolVM = new ToolboxViewModel(ws, toolOptionsStore);
            layersVM = new LayerListViewModel();
        }

        public ICommand ExportCommand { get; }
        public ICommand SaveCommand { get; }
    }
}
