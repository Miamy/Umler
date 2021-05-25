using Miamy.Umler.Core;
using Miamy.Umler.Modules.PropertiesModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Miamy.Umler.Modules.PropertiesModule
{
    public class PropertiesModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public PropertiesModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(RegionNames.PropertiesRegion, "PropertiesView");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<PropertiesView>();
        }
    }
}