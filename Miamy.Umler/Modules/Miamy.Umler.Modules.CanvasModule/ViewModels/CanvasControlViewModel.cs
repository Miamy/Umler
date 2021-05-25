using Miamy.Umler.Core.Models;
using Miamy.Umler.Core.ViewModels;
using Prism.Mvvm;
using Prism.Regions;
using System.Collections.ObjectModel;
using System.Linq;

namespace Miamy.Umler.Modules.CanvasModule.ViewModels
{
    public class CanvasControlViewModel : RegionViewModelBase
    {
        #region Properties
        private string _title = "CanvasControlViewModel";
        public string Title
        {
            get => _title; 
            set => SetProperty(ref _title, value); 
        }

        private CanvasModel _model;
        public CanvasModel Model
        {
            get => _model;
            set
            {
                SetProperty(ref _model, value);
                if (_model != null)
                {
                    Entities = new ObservableCollection<DrawableEntityBase>(_model.Entities.Select(e => new DrawableEntityBase(e)));
                }
            }
        }

        private ObservableCollection<DrawableEntityBase> _entities;
        public ObservableCollection<DrawableEntityBase> Entities
        {
            get => _entities;
            set => SetProperty(ref _entities, value);
        }
        #endregion //Properties

        public CanvasControlViewModel(IRegionManager regionManager) : base(regionManager)
        {
            Model = new CanvasModel();
        }
    }
}
