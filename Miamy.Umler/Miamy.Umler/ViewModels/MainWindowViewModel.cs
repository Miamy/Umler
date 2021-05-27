using Miamy.Umler.Core.ViewModels;
using Prism.Mvvm;
using Prism.Regions;

namespace Miamy.Umler.ViewModels
{
    public class MainWindowViewModel : RegionViewModelBase
    {
        private string _title = "Umler";
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public MainWindowViewModel(IRegionManager regionManager) : base(regionManager)
        {

        }
    }
}
