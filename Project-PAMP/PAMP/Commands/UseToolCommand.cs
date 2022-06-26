﻿using PAMP.Models;
using PAMP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PAMP.Commands
{
    public class UseToolCommand : CommandBase
    {
        readonly Workspace _workspace;
        readonly ImageViewModel _imageViewModel;
        int _x, _y; 
        public UseToolCommand(Workspace ws, ImageViewModel imVM, int x, int y)
        {
            _workspace = ws;
            _imageViewModel = imVM;
            _x = x;
            _y = y;
        }
        public override void Execute(object? parameter)
        {
            Colour c;
            int height = _workspace.Image.Height;
            int width = _workspace.Image.Width;
            switch (_workspace.Toolbox.SelectedTool)
            {
                case Pencil :                
                    Pencil p = (Pencil)_workspace.Toolbox.SelectedTool;
                    c = _workspace.Toolbox.SelectedTool.PrimaryColour;
                    int size = p.Size;
                    for (var i = _x - (size - 1); i < _x + size; i++)
                    {
                        for (var j = _y - (size - 1); j < _y + size; j++)
                        {
                            if (i < 0 || j < 0 || i >= width || j >= height) continue;
                            _imageViewModel.SetPixel(i, j, c);
                        }
                    }
                    break;
                case Eraser:
                    Eraser e = (Eraser)_workspace.Toolbox.SelectedTool;
                    c = new Colour(0, 0, 0, 0);
                    for (var i = _x - (e.Size - 1); i < _x + e.Size; i++)
                    {
                        for (var j = _y - (e.Size - 1); j < _y + e.Size; j++)
                        {
                            if (i < 0 || j < 0 || i >= width || j >= height) continue;
                            _imageViewModel.SetPixel(i, j, c);
                        }
                    }
                    break;
                
            }
        }
    }
}