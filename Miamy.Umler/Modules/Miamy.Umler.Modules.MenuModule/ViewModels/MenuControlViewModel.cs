using Miamy.Umler.Core.ViewModels;
using Miamy.Umler.Services.Interfaces;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services;
using System.Windows.Input;
//using Microsoft.Practices.ServiceLocation;

namespace Miamy.Umler.Modules.MenuModule.ViewModels
{
    public class MenuControlViewModel : RegionViewModelBase
    {
        private string _message;
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }

        /// <summary>
        /// Gets MenuItemCommand
        /// </summary>
        public ICommand MenuItemCommand { get; private set; }

        public MenuControlViewModel(IRegionManager regionManager, IMessageService messageService) : base(regionManager)
        {
            //Message = messageService.GetMessage();

            //IEventAggregator eventAggregator = ServiceLocator.Current.GetInstance<IEventAggregator>();

            MenuItemCommand = new DelegateCommand<string>(param =>
            {
                if (param == "Exit")
                {
                    System.Windows.Application.Current.Shutdown();
                }
            });
        }

        /*
        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            //do something
        }
        */
    }
}

