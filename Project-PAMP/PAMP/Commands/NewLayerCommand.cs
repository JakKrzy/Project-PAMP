using PAMP.Models;
using PAMP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAMP.Commands
{
    public class NewLayerCommand : CommandBase
    {
        readonly Workspace _workspace;
        readonly LayerListViewModel _layerListVM;

        public NewLayerCommand(Workspace ws, LayerListViewModel llVM)
        {
            _workspace = ws;
            _layerListVM = llVM;
        }

        public override void Execute(object? parameter)
        {
            string newName = _layerListVM.NewLayerName;
            LayerViewModel lvm = new LayerViewModel(new Layer(newName, 147, 100), _workspace, _layerListVM);
            _layerListVM.LayerVMs.Add(lvm);
            _workspace.Image.LayerList.Add(lvm.Layer);
        }
    }
}
