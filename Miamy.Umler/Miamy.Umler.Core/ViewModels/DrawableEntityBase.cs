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
        #endregion //Properties

        public DrawableEntityBase(EntityBase entity) : base(entity?.Name)
        {
            Entity = entity ?? throw new ArgumentNullException(nameof(entity));
        }
    }
}
