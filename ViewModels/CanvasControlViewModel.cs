using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Umler.ViewModels
{
    public class CanvasControlViewModel : BindableBase
    {
        public ObservableCollection<BaseContainerViewModel> Items { get; set; }

        public CanvasControlViewModel()
        {
            Items = new ObservableCollection<BaseContainerViewModel>();
            var item = new BaseContainerViewModel()
            { Left = 10, Top = 10, Height = 40, Width = 40 };
            Items.Add(item);

            item = new BaseContainerViewModel()
            { Left = 60, Top = 60, Height = 40, Width = 40 };
            Items.Add(item);
        }
    }
}
