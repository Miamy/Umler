using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using Umler.Models;

namespace Umler.ViewModels
{
    public class ToolbarControlViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        private List<ItemViewModel> _items;
        public List<ItemViewModel> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        private BaseModel _selected;
        public BaseModel Selected
        {
            get => _selected;
            private set
            {
                SetProperty(ref _selected, value);

                var parameters = new NavigationParameters();
                parameters.Add("selected", _selected);
                _regionManager.RequestNavigate("PropertiesRegion", "PropertiesControl", parameters);
            }
        }

        public DelegateCommand<object[]> SelectedCommand { get; private set; }

        public ToolbarControlViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            CreateItems();
            SelectedCommand = new DelegateCommand<object[]>(OnItemSelected);
        }

        private void CreateItems()
        {
            Items = new List<ItemViewModel>();

            var item = new Item("Select");
            var viewItem = new ItemViewModel(item, @"/Resources/Select_16x.png");
            Items.Add(viewItem);

            item = new Item("Class");
            viewItem = new ItemViewModel(item, @"/Umler;component/resources/class_16x.png");
            Items.Add(viewItem);

            item = new Item("Interface");
            viewItem = new ItemViewModel(item, @"/Resources/Interface_16x.png");
            Items.Add(viewItem);
        }

        private void OnItemSelected(object[] selectedItems)
        {
            if (selectedItems != null && selectedItems.Length > 0)
            {
                Selected = ((ItemViewModel)selectedItems.FirstOrDefault()).Item;
            }
        }

        private void NavigationCompleted(NavigationResult result)
        {

        }
    }
}
