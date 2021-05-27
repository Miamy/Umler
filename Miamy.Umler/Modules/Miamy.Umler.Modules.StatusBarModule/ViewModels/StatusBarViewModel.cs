using Miamy.Umler.Core;
using Miamy.Umler.Core.Models;
using Miamy.Umler.Core.ViewModels;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Miamy.Umler.Modules.StatusBarModule.ViewModels
{
    public class StatusBarViewModel : RegionViewModelBase
    {
        private IEventAggregator _eventAggregator;

        private string _message;
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }

        public ICommand SetMessageCommand { get; }

        public StatusBarViewModel(IRegionManager regionManager, IEventAggregator eventAggregator) : base(regionManager)
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<ToolbarToolSelectedEvent>().Subscribe(SetSelectedItem);

            Message = "StatusBarViewModel from your Prism Module";

        }

        private void SetSelectedItem(ToolbarItem item)
        {
            Message = item?.Name;
        }
    }
}
