using Prism.Mvvm;

namespace Miamy.Umler.Modules.CanvasModule.ViewModels
{
    public class CanvasControlViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public CanvasControlViewModel()
        {

        }
    }
}
