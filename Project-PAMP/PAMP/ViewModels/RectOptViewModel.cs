using PAMP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAMP.ViewModels
{
    public class RectOptViewModel : ViewModelBase
    {
        Workspace _workspace;
        Rectangle rect;
        bool fill;
        int width, height;

        public RectOptViewModel(Workspace ws)
        {
            _workspace = ws;
            rect = (Rectangle)_workspace.Toolbox.SelectedTool;
            Width = 1;
            Height = 1;
        }

        public int Width
        {
            get { return width; }
            set
            {
                width = value;
                rect.Width = value;
                OnPropertyChange(nameof(Width));
            }
        }
        public int Height
        {
            get { return height; }
            set
            {
                height = value;
                rect.Height = value;
                OnPropertyChange(nameof(Height));
            }
        }
        public bool Fill
        {
            get { return fill; }
            set
            {
                fill = value;
                rect.Fill = value;
                OnPropertyChange(nameof(Fill));
            }
        }

        
    }
}
