using Miamy.Umler.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miamy.Umler.Core.ViewModels
{
    public class DrawableEntityBase : BaseModel
    {
        #region Properties
        private EntityBase _entity; 
        public EntityBase Entity
        {
            get => _entity;
            set => SetProperty(ref _entity, value);

        }

        private int _left;
        public int Left
        { 
            get => _left;
            set => SetProperty(ref _left, value); 
        }

        private int _top;
        public int Top
        {
            get => _top;
            set => SetProperty(ref _top, value);
        }

        private int _width;
        public int Width
        {
            get => _width;
            set => SetProperty(ref _width, value);
        }

        private int _height;
        public int Height
        {
            get => _height;
            set => SetProperty(ref _height, value);
        }
        #endregion //Properties

        public DrawableEntityBase(EntityBase entity) : base(entity?.Name)
        {
            Entity = entity ?? throw new ArgumentNullException(nameof(entity));
        }
    }
}
