using PAMP.Stores;
using PAMP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAMP.Commands
{
    public class NewProjectCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;
        public NewProjectCommand(NavigationStore ns)
        {
            _navigationStore = ns; 
        }
        public override void Execute(object? parameter)
        {
            _navigationStore.CurrentViewModel = new WorkspaceViewModel(new Models.Workspace(147, 100));
        }
    }
}
