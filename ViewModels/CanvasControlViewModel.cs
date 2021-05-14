using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace Umler.ViewModels
{
    public class CanvasControlViewModel : BindableBase
    {
        public ObservableCollection<BaseContainerViewModel> Items { get; set; }

        public ICommand MyCommand { get; private set; }

        public CanvasControlViewModel()
        {
            Items = new ObservableCollection<BaseContainerViewModel>();
            var item = new BaseContainerViewModel()
            { Left = 10, Top = 10, Height = 40, Width = 40 };
            Items.Add(item);

            item = new BaseContainerViewModel()
            { Left = 60, Top = 60, Height = 40, Width = 40 };
            Items.Add(item);


            MyCommand = new DelegateCommand(MyAction);
        }

        private void MyAction()
        {
            
        }
    }
}
