using PAMP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAMP.ViewModels
{
    public class LayerViewModel : ViewModelBase
    {
        public int Width { get; }
        public int Height { get;  }
        public string Name { get;  }
        public Colour[,] Bmp { get; }
        public bool IsVisible { get;  }

        public LayerViewModel(Layer layer)
        {
            Width = layer.Width;
            Height = layer.Height;
            Name = layer.Name;
            Bmp = layer.BMP;
            IsVisible = layer.IsVisible;
        }
    }
}
