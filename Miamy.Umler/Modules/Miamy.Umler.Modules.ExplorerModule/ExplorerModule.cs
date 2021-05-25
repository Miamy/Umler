using Miamy.Umler.Core;
using Miamy.Umler.Modules.ExplorerModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Miamy.Umler.Modules.ExplorerModule
{
    public class ExplorerModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public ExplorerModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(RegionNames.ExplorerRegion, "ExplorerView");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ExplorerView>();
        }
    }
}