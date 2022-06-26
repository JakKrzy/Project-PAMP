using PAMP.Commands;
using PAMP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PAMP.ViewModels
{
    public class ImageViewModel : ViewModelBase
    {
        private ObservableCollection<PixelViewModel> _pixels = new ObservableCollection<PixelViewModel>();
        private PixelViewModel[,] indexedPixels = new PixelViewModel[147,100];
        public IEnumerable<PixelViewModel> Pixels 
        { 
            get { return _pixels; } 
        }

        private readonly Workspace _workspace;
        public ImageViewModel(Workspace ws)
        {
            _workspace = ws;
            for(int i = 0; i < 147; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    PixelViewModel px = new PixelViewModel(i, j);
                    px.UseTool = new UseToolCommand(_workspace, this, i, j);
                    indexedPixels[i, j] = px;
                    _pixels.Add(px);
                }
            }
        }

        public PixelViewModel GetPixel(int x, int y) { return indexedPixels[x, y]; }
        public void SetPixel(int x, int y, Colour c) 
        {
            indexedPixels[x, y].Col = c;
            OnPropertyChange(nameof(indexedPixels));
        }
    }
}
