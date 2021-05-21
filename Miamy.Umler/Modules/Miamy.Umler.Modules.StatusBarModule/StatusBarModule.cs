using Miamy.Umler.Core;
using Miamy.Umler.Modules.StatusBarModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Miamy.Umler.Modules.StatusBarModule
{
    public class StatusBarModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public StatusBarModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(RegionNames.StatusBarRegion, "StatusBar");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<StatusBar>();
        }
    }
}