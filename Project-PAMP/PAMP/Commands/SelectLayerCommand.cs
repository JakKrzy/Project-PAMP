using PAMP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAMP.Commands
{
    public class SelectLayerCommand : CommandBase
    {
        Workspace _workspace;
        Layer _layer;

        public SelectLayerCommand(Workspace ws, Layer l)
        {
            _workspace = ws;
            _layer = l;
        }
        public override void Execute(object? parameter)
        {
            _workspace.Image.SelectedLayer = _layer;
        }
    }
}
