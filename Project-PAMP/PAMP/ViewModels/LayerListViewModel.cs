using PAMP.Commands;
using PAMP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PAMP.ViewModels
{
    public class LayerListViewModel : ViewModelBase
    {
        Workspace _workspace;
        string _newLayerName;
        public String NewLayerName
        {
            get { return _newLayerName; }
            set { 
                _newLayerName = value;
                OnPropertyChange(nameof(NewLayerName));
            }
        }
        public LayerListViewModel(Workspace ws)
        {
            _workspace = ws;
            _layers = new ObservableCollection<LayerViewModel>();
            Layer bg = new("Background", 147, 100);
            _layers.Add(new LayerViewModel(bg, _workspace, this));
            _workspace.Image.SelectedLayer = bg;
            NewLayerCommand = new NewLayerCommand(_workspace, this);
        }

        private readonly ObservableCollection<LayerViewModel> _layers;
        public ObservableCollection<LayerViewModel> LayerVMs
        {
            get { return _layers; }
        }
        public IEnumerable<LayerViewModel> Layers => _layers;

        public ICommand NewLayerCommand { get; }
    }
}
