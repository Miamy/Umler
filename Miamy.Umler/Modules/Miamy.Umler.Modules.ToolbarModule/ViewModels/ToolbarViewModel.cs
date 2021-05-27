using Miamy.Umler.Core;
using Miamy.Umler.Core.Models;
using Miamy.Umler.Core.ViewModels;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Miamy.Umler.Modules.ToolbarModule.ViewModels
{
    public class ToolbarViewModel : ToolWindowBaseViewModel
    {
        private IEventAggregator _eventAggregator;

        private ObservableCollection<ToolbarItem> _items;
        public ObservableCollection<ToolbarItem> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        private ToolbarItem _selected;
        public ToolbarItem Selected
        {
            get => _selected;
            set
            {
                SetProperty(ref _selected, value);
                _eventAggregator.GetEvent<ToolbarToolSelectedEvent>().Publish(value);
            }
        }

        public ICommand SelectToolCommand { get; }



        public ToolbarViewModel(IRegionManager regionManager, IEventAggregator eventAggregator) : base(regionManager)
        {
            _eventAggregator = eventAggregator;
            Title = "Toolbox";

            _items = new ObservableCollection<ToolbarItem>()
            {
                new ToolbarItem("Select", "select_16x.png"),
                new ToolbarItem("Interface", "interface_16x.png"),
                new ToolbarItem("Class", "class_16x.png"),
            };

            SelectToolCommand = new DelegateCommand<object[]>(SelectToolAction);
            Selected = Items[0];
        }


        private void SelectToolAction(object[] selectedItems)
        {
            if (selectedItems != null && selectedItems.Count() > 0)
            {
                Selected = (ToolbarItem)selectedItems.FirstOrDefault();
            }

        }
    }
}
