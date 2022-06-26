using PAMP.Commands;
using PAMP.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PAMP.ViewModels
{
    public class SplashScreenViewModel : ViewModelBase 
    {
        public ICommand NewProjectCommand { get; }
        public SplashScreenViewModel(NavigationStore ns)
        {
            NewProjectCommand = new NewProjectCommand(ns);
        }
    }
}
