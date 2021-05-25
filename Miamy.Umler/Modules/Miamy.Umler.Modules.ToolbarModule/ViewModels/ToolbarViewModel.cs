using Miamy.Umler.Core.Models;
using Miamy.Umler.Core.ViewModels;
using Miamy.Umler.Modules.ToolbarModule.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miamy.Umler.Modules.ToolbarModule.ViewModels
{
    public class ToolbarViewModel : ToolWindowBaseViewModel
    {

        private ObservableCollection<ToolbarItem> _items;
        public ObservableCollection<ToolbarItem> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        public ToolbarViewModel(IRegionManager regionManager) : base(regionManager)
        {
            Title = "Toolbox";

            _items = new ObservableCollection<ToolbarItem>()
            {
                new ToolbarItem("Select", "select_16x.png"),
                new ToolbarItem("Interface", "interface_16x.png"),
                new ToolbarItem("Class", "class_16x.png"),
            };
        }
    }
}
