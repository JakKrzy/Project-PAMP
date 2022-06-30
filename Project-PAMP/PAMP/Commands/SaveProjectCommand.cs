using PAMP.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows;

namespace PAMP.Commands
{
    public class SaveProjectCommand : CommandBase
    {
        Workspace _workspace;
        public SaveProjectCommand(Workspace ws)
        {
            _workspace = ws;
        }
        public override void Execute(object? parameter)
        {
            Stream stream = File.Open("NewProject.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                bf.Serialize(stream, _workspace);
                MessageBox.Show("Project saved succesfully.", "Succesfull save", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save project.", "Save error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            stream.Close();
        }
    }
}
