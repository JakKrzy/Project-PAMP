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
        string swidth, sheight;

        public RectOptViewModel(Workspace ws)
        {
            _workspace = ws;
            SWidth = "1";
            SHeight = "1";
            rect = (Rectangle)_workspace.Toolbox.SelectedTool;  
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

        public string SWidth
        {
            get { return swidth; }
            set
            {
                swidth = value;
                Width = int.Parse(value);
                OnPropertyChange(nameof(SWidth));
            }
        }

        public string SHeight
        {
            get { return sheight; }
            set
            {
                sheight = value;
                Height = int.Parse(value);
                OnPropertyChange(nameof(SWidth));
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
