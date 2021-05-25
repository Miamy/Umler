using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miamy.Umler.Core.Models
{
    public class CanvasModel : BindableBase
    {
        #region Properties
        private List<EntityBase> _entities;
        public List<EntityBase> Entities
        {
            get => _entities;
            set => SetProperty(ref _entities, value);
        }

        #endregion //Properties

        public CanvasModel()
        {
            Entities = new List<EntityBase>();
        }
    }
}
