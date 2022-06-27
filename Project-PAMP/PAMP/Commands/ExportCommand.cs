using PAMP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAMP.Commands
{
    public class ExportCommand : CommandBase
    {
        Workspace _workspace;

        public ExportCommand(Workspace ws)
        {
            _workspace = ws;
        }
        public override void Execute(object? parameter)
        {
            _workspace.exportImage();
        }
    }
}
