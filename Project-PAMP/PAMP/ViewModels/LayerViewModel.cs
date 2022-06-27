using PAMP.Commands;
using PAMP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PAMP.ViewModels
{
    public class LayerViewModel : ViewModelBase
    {
        public Layer Layer { get; }
        public int Width { get; }
        public int Height { get;  }
        public string Name { get;  }
        public Colour[,] Bmp { get; }
        public bool IsVisible { get;  }

        public LayerViewModel(Layer layer, Workspace ws, LayerListViewModel llvm)
        {
            Layer = layer;
            Width = layer.Width;
            Height = layer.Height;
            Name = layer.Name;
            Bmp = layer.BMP;
            IsVisible = layer.IsVisible;
            DeleteLayerCommand = new DeleteLayerCommand(ws, llvm, this);
            SelectLayerCommand = new SelectLayerCommand(ws, Layer);
        }

        public ICommand DeleteLayerCommand { get; }
        public ICommand SelectLayerCommand { get; }
    }
}
