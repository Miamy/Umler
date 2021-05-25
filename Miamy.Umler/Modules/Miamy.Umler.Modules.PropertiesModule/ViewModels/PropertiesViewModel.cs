using Miamy.Umler.Core.Models;
using Miamy.Umler.Core.ViewModels;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miamy.Umler.Modules.PropertiesModule.ViewModels
{
    public class PropertiesViewModel : ToolWindowBaseViewModel
    {

        public PropertiesViewModel(IRegionManager regionManager) : base(regionManager)
        {
            Title = "Properties";

        }
    }
}
