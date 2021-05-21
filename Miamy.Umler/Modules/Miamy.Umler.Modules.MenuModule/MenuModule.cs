using Miamy.Umler.Core;
using Miamy.Umler.Modules.MenuModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Miamy.Umler.Modules.MenuModule
{
    public class MenuModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public MenuModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(RegionNames.MenuBarRegion, "MenuControl");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MenuControl>();
        }
    }
}