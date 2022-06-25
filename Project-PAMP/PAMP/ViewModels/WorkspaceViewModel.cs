using PAMP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PAMP.ViewModels
{
    public class WorkspaceViewModel : ViewModelBase
    {
        Brush PCBrush;
        Brush SCBrush;

        Colour PC = new(255, 255, 255);
        Colour SC = new(0, 0, 0);

        readonly ImageViewModel imgV = new ImageViewModel();

        public ImageViewModel Image { get { return imgV; } }

        Layer selLayer;
        private readonly ObservableCollection<LayerViewModel> _layers;

        public IEnumerable<LayerViewModel> Layers => _layers;

        Tool selTool;
        List<Tool> toolList = new List<Tool>();
        public WorkspaceViewModel()
        {
            toolList.Add(new Pencil());
            toolList.Add(new Eraser());
            _layers = new ObservableCollection<LayerViewModel>();
            Layer bg = new("Background", 160, 90);
            Layer l1 = new("Layer 1", 160, 90);
            _layers.Add(new LayerViewModel(bg));
            _layers.Add(new LayerViewModel(l1));
            selTool = toolList[0];
            PBrush = PC.toBrush();
            SBrush = SC.toBrush();      
        }


        public int PRed
        {
            get { return PC.Red; }
            set
            {
                PC.Red = value;
                PBrush = PC.toBrush();
                OnPropertyChange(nameof(PRed));
            }
        }
       
        public int PGreen
        {
            get { return PC.Green; }
            set
            {
                PC.Green = value;
                PBrush = PC.toBrush();
                OnPropertyChange(nameof(PGreen));
            }
        }

        public int PBlue
        {
            get { return PC.Blue; }
            set
            {
                PC.Blue = value;
                PBrush = PC.toBrush();
                OnPropertyChange(nameof(PBlue));
            }
        }

        public int PAlpha
        {
            get { return PC.Alpha; }
            set
            {
                PC.Alpha = value;
                PBrush = PC.toBrush();
                OnPropertyChange(nameof(PAlpha));
            }
        }
        public int SRed
        {
            get { return SC.Red; }
            set
            {
                SC.Red = value;
                SBrush = SC.toBrush();
                OnPropertyChange(nameof(SRed));
            }
        }

        public int SGreen
        {
            get { return SC.Green; }
            set
            {
                SC.Green = value;
                SBrush = SC.toBrush();
                OnPropertyChange(nameof(SGreen));
            }
        }

        public int SBlue
        {
            get { return SC.Blue; }
            set
            {
                SC.Blue = value;
                SBrush = SC.toBrush();
                OnPropertyChange(nameof(SBlue));
            }
        }

        public int SAlpha
        {
            get { return SC.Alpha; }
            set
            {
                SC.Alpha = value;
                SBrush = SC.toBrush();
                OnPropertyChange(nameof(SAlpha));
            }
        }

        public Brush PBrush
        {
            get { return PCBrush; }
            set
            {
                PCBrush = value;
                OnPropertyChange(nameof(PBrush));
            }
        }
        public Brush SBrush
        {
            get { return SCBrush; }
            set
            {
                SCBrush = value;
                OnPropertyChange(nameof(SBrush));
            }
        }
    }
}
