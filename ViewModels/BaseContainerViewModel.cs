using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Umler.ViewModels
{
    public class BaseContainerViewModel : BindableBase
    {
        private int _left;
        public int Left
        {
            get => _left;
            set => SetProperty(ref _left, value);
        }

        private int _top;
        public int Top
        {
            get => _top;
            set => SetProperty(ref _top, value);
        }

        private int _width;
        public int Width
        {
            get => _width;
            set => SetProperty(ref _width, value);
        }

        private int _height;
        public int Height
        {
            get => _height;
            set => SetProperty(ref _height, value);
        }

        private bool _isSelected;
        public bool IsSelected
        {
            get => _isSelected;
            set => SetProperty(ref _isSelected, value);
        }


        public void Draw(Canvas canvas)
        {
            //canvas
        }
    }
}
