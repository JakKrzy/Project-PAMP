using PAMP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
            try
            {
                _workspace.exportImage();
                MessageBox.Show("File saved succesfully", "Succesfull export",MessageBoxButton.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save file, try again.", "Save error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }
    }
}
