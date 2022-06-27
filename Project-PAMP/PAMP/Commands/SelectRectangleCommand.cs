using PAMP.Models;
using PAMP.Stores;
using PAMP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAMP.Commands
{
    public class SelectRectangleCommand : CommandBase
    {
        readonly Workspace _workspace;
        readonly ToolboxViewModel _toolboxViewModel;
        readonly ToolOptionsStore _toolOpts;

        public SelectRectangleCommand(Workspace ws, ToolboxViewModel tbVM, ToolOptionsStore tos)
        {
            _workspace = ws;
            _toolboxViewModel = tbVM;
            _toolOpts = tos;
        }
        public override void Execute(object? parameter)
        {
            _toolboxViewModel.SelectedTool = new Rectangle();
            _toolOpts.CurrentViewModel = new RectOptViewModel(_workspace);
        }
    }
}
