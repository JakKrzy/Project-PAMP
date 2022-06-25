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
        public IEnumerable<PixelViewModel> Pixels 
        { 
            get { return _pixels; } 
        }
        public ImageViewModel()
        {
            for(int i = 0; i < 147; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    _pixels.Add(new PixelViewModel(i, j));
                }
            }
        }
    }
}
