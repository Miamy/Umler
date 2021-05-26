using Miamy.Umler.Core;
using Miamy.Umler.Core.Models;
using Miamy.Umler.Core.ViewModels;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace Miamy.Umler.Modules.CanvasModule.ViewModels
{
    public class CanvasControlViewModel : RegionViewModelBase
    {
        private IEventAggregator _eventAggregator;

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


        private ToolbarItem _selected;
        public ToolbarItem Selected
        {
            get => _selected;
            set
            {
                SetProperty(ref _selected, value);
            }
        }
        #endregion //Properties

        public CanvasControlViewModel(IRegionManager regionManager, IEventAggregator eventAggregator) : base(regionManager)
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<ToolbarToolSelectedEvent>().Subscribe(SetSelectedItem);

            Model = new CanvasModel();

            CreateCommands();
        }


        #region Commands
        private void CreateCommands()
        {
            AddEntityCommand = new DelegateCommand(AddEntityAction);
        }

        private void AddEntityAction()
        {
            var entity = new ClassEntity("Class1");
            Model.Entities.Add(entity);

            var drawableEntity = new DrawableEntityBase(entity)
            {
                Left = 50,
                Top = 50,
                Width = 50,
                Height = 50
            };
            Entities.Add(drawableEntity);
        }

        public ICommand AddEntityCommand { get; private set; }
        #endregion


        private void SetSelectedItem(ToolbarItem item)
        {
            Selected = item;
        }

    }
}
