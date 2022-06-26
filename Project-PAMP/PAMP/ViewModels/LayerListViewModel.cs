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
    public class LayerListViewModel
    {
        public LayerListViewModel()
        {
            _layers = new ObservableCollection<LayerViewModel>();
            Layer bg = new("Background", 147, 100);
            _layers.Add(new LayerViewModel(bg));
        }

        Layer selLayer;
        private readonly ObservableCollection<LayerViewModel> _layers;
        public IEnumerable<LayerViewModel> Layers => _layers;

        public ICommand NewLayerCommand { get; }
        public ICommand DeleteLayerCommand { get; }
    }
}
