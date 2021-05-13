using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Umler.Commands;

namespace Umler.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;


        private string _title = "Umler";
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        private IApplicationCommands _applicationCommands;
        public IApplicationCommands ApplicationCommands
        {
            get => _applicationCommands;
            set => SetProperty(ref _applicationCommands, value);
        }

        public ICommand ExitCommand { get; private set; }

        public MainWindowViewModel(IRegionManager regionManager, IApplicationCommands applicationCommands)
        {
            _regionManager = regionManager;

            ExitCommand = new DelegateCommand(ExitAction);

            ApplicationCommands = applicationCommands;
            ApplicationCommands.ExitApplication.RegisterCommand(ExitCommand);
        }

        private void ExitAction()
        {
            System.Windows.Application.Current.MainWindow.Close();

        }
    }
}
