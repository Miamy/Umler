using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miamy.Umler.Core.Models
{
    public class EntityBase : BaseModel
    {
        #region Properties
        private bool _isAbstract;
        public bool IsAbstract
        {
            get => _isAbstract;
            set => SetProperty(ref _isAbstract, value);
        }
        #endregion //Properties

        public EntityBase(string name) : base(name)
        {
        }
    }
}
