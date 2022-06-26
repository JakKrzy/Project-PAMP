using PAMP.Models;
using PAMP.Stores;
using PAMP.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAMP.Commands
{
    public class SelectPencilCommand : CommandBase
    {
        private readonly Workspace _workspace;
        readonly ToolboxViewModel _toolboxViewModel;
        readonly ToolOptionsStore _toolOptionsStore;

        public SelectPencilCommand(Workspace ws, ToolboxViewModel tbVM, ToolOptionsStore tos)
        {
            _workspace = ws;
            _toolboxViewModel = tbVM;
            _toolOptionsStore = tos;
        }
       
        public override void Execute(object? parameter)
        {
            _toolboxViewModel.SelectedTool = new Pencil();
            _toolOptionsStore.CurrentViewModel = new PencilOptViewModel(_workspace);
        }
    }
}
