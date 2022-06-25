﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PAMP.Models;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PAMP.ViewModels
{
    public class PixelViewModel : ViewModelBase
    {
        private int x, y;
        private Colour col;
        private Brush br;
        public PixelViewModel(int x, int y)
        {
            X = x; Y = y;
            Col = new Colour(255, 255, 255, 0);
            Br = Col.toBrush();
        }
        public int X
        {
            get { return x; }
            set { 
                x = value;
                OnPropertyChange(nameof(X));
            }
        }
        public int Y
        {
            get { return y; }
            set
            {
                y = value;
                OnPropertyChange(nameof(Y));
            }
        }

        public Colour Col
        {
            get { return col; }
            set
            {
                col = value; 
                OnPropertyChange(nameof(Col));
            }
        }

        public Brush Br
        {
            get { return br; }
            set
            {
                br = value;
                OnPropertyChange(nameof(Br));
            }
        }
    }
}