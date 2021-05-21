using Miamy.Umler.Core;
using Miamy.Umler.Modules.CanvasModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Miamy.Umler.Modules.CanvasModule
{
    public class CanvasModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public CanvasModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(RegionNames.CanvasRegion, "CanvasControl");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<CanvasControl>();
        }
    }
}