using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Umler.Models;

namespace Umler.ViewModels
{
    public class ToolbarControlViewModel : BindableBase
    {
        private List<ItemViewModel> _items;
        public List<ItemViewModel> Items 
        { 
            get => _items; 
            set => SetProperty(ref _items, value);
        }

        public ToolbarControlViewModel()
        {
            CreateItems();
        }

        private void CreateItems()
        {
            Items = new List<ItemViewModel>();

            var item = new Item("Select");
            var viewItem = new ItemViewModel(item, @"..\Resources\Select_16x.png");
            Items.Add(viewItem);

            item = new Item("Class");
            viewItem = new ItemViewModel(item, @"/Umler;component/resources/class_16x.png");
            Items.Add(viewItem);

            item = new Item("Interface");
            viewItem = new ItemViewModel(item, @"/Resources/Interface_16x.png");
            Items.Add(viewItem);
        }
    }
}
