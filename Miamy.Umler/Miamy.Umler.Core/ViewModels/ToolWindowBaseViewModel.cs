using Prism.Commands;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Miamy.Umler.Core.ViewModels
{
    public class ToolWindowBaseViewModel : RegionViewModelBase
    {
        private string _title;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value); 
        }

        private bool _isActive;
        public bool IsActive
        {
            get => _isActive;
            set => SetProperty(ref _isActive, value);
        }
        public ICommand SetActive { get; }
        public ICommand SetInactive { get; }

        public ToolWindowBaseViewModel(IRegionManager regionManager) : base(regionManager)
        {
            SetInactive = new DelegateCommand(SetInactiveAction);
            SetActive = new DelegateCommand(SetActiveAction);

            GlobalCommands.SetInactiveAllToolWindowsCommand.RegisterCommand(SetInactive);
        }


        private void SetActiveAction()
        {
            GlobalCommands.SetInactiveAllToolWindowsCommand.Execute(null);
            IsActive = true;
        }
        private void SetInactiveAction()
        {
            IsActive = false;
        }
    }
}
