using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miamy.Umler.Core.Mvvm
{
    public class ToolWindowBaseViewModel : RegionViewModelBase
    {
        private string _title;
        public string Title
        {
            get => _title; 
            set => SetProperty(ref _title, value); 
        }
        public ToolWindowBaseViewModel(IRegionManager regionManager) : base(regionManager)
        {
        }
    }
}
