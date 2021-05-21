using Miamy.Umler.Modules.CanvasModule;
using Miamy.Umler.Modules.MenuModule;
using Miamy.Umler.Modules.StatusBarModule;
using Miamy.Umler.Modules.ToolbarModule;
using Miamy.Umler.Services;
using Miamy.Umler.Services.Interfaces;
using Miamy.Umler.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using System.Windows;

namespace Miamy.Umler
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IMessageService, MessageService>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<MenuModule>();
            moduleCatalog.AddModule<StatusBarModule>();
            moduleCatalog.AddModule<ToolbarModule>();
            moduleCatalog.AddModule<CanvasModule>();
        }
    }
}
