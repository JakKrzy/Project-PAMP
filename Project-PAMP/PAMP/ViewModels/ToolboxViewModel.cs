using PAMP.Commands;
using PAMP.Models;
using PAMP.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace PAMP.ViewModels
{
    public class ToolboxViewModel : ViewModelBase
    {
        public ICommand SelectPencilCommand { get; }
        public ICommand SelectEraserCommand { get; }
        public ICommand SelectRectangleCommand { get; }

        Brush PCBrush;
        Brush SCBrush;

        Colour PrimCol;
        Colour SecCol;
        public Colour PC
        {
            get { return PrimCol; }
            set 
            { 
                PrimCol = value;
                _workspace.Toolbox.SelectedTool.PrimaryColour = value;  
            }
        }

        public Colour SC
        {
            get { return SecCol; }
            set
            {
                SecCol = value;
                _workspace.Toolbox.SelectedTool.SecondaryColour = value;
            }
        }

        Workspace _workspace;
        ToolOptionsStore _toolOptionsStore;

        public ViewModelBase CurrentToolOptions => _toolOptionsStore.CurrentViewModel;

        public ToolboxViewModel(Workspace ws, ToolOptionsStore tos)
        {
            _workspace = ws;
            _toolOptionsStore = tos;
            _toolOptionsStore.CurrentViewModel = new PencilOptViewModel(ws);
            PC = new Colour(0,0,0);
            SC = new Colour(255,255,255); 
            PBrush = PC.toBrush();
            SBrush = SC.toBrush();
            SelectPencilCommand = new SelectPencilCommand(ws, this, _toolOptionsStore);
            SelectEraserCommand = new SelectEraserCommand(ws, this, _toolOptionsStore);
            SelectRectangleCommand = new SelectRectangleCommand(ws, this, _toolOptionsStore);
            _toolOptionsStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }
        private void OnCurrentViewModelChanged()
        {
            OnPropertyChange(nameof(CurrentToolOptions));
        }

        public Tool SelectedTool 
        {
            get { return _workspace.Toolbox.SelectedTool; } 
            set 
            { 
                _workspace.Toolbox.SelectedTool = value; 
                OnPropertyChange(nameof(SelectedTool));
            }
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
