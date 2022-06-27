using PAMP.Models;
using PAMP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAMP.Commands
{
    public class DeleteLayerCommand : CommandBase
    {
        readonly Workspace _workspace;
        readonly LayerListViewModel _layersVM;
        readonly LayerViewModel _layerVM;

        public DeleteLayerCommand(Workspace ws, LayerListViewModel llvm, LayerViewModel layer)
        {
            _workspace = ws;
            _layersVM = llvm;
            _layerVM = layer;
        }
        public override void Execute(object? parameter)
        {
            _layersVM.LayerVMs.Remove(_layerVM);
            _workspace.Image.LayerList.Remove(_layerVM.Layer);
        }
    }
}
