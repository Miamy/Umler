using Miamy.Umler.Core.ViewModels;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miamy.Umler.Modules.StatusBarModule.ViewModels
{
    public class StatusBarViewModel : RegionViewModelBase
    {
        private string _message;
        public string Message
        {
            get => _message; 
            set => SetProperty(ref _message, value); 
        }

        public StatusBarViewModel(IRegionManager regionManager) : base(regionManager)
        {
            Message = "StatusBarViewModel from your Prism Module";
        }
    }
}
