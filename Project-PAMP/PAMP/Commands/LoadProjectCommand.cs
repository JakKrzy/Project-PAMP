using PAMP.Models;
using PAMP.Stores;
using PAMP.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PAMP.Commands
{
    public class LoadProjectCommand : CommandBase
    {
        NavigationStore _navigationStore;
        public LoadProjectCommand(NavigationStore ns)
        {
            _navigationStore = ns;
        }
        public override void Execute(object? parameter)
        {
            Stream stream = File.Open("NewProject.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                Workspace loadedWorkspace = (Workspace)bf.Deserialize(stream);
                _navigationStore.CurrentViewModel = new WorkspaceViewModel(loadedWorkspace);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load file.", "Load error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
