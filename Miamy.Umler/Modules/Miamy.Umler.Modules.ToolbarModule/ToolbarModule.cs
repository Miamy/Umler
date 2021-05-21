using Miamy.Umler.Core;
using Miamy.Umler.Modules.ToolbarModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Miamy.Umler.Modules.ToolbarModule
{
    public class ToolbarModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public ToolbarModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(RegionNames.ToolbarRegion, "ToolbarView");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ToolbarView>();
        }
    }
}