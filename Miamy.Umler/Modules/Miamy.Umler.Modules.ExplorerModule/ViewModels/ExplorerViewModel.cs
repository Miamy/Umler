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

namespace Miamy.Umler.Modules.ExplorerModule.ViewModels
{
    public class ExplorerViewModel : ToolWindowBaseViewModel
    {

        public ExplorerViewModel(IRegionManager regionManager) : base(regionManager)
        {
            Title = "Explorer";

        }
    }
}
