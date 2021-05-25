using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miamy.Umler.Core.Models
{
    public class BaseModel : NamedModel
    {
        #region Properties
        private AccessModifier _accessModifier;
        public AccessModifier AccessModifier
        {
            get => _accessModifier;
            set => SetProperty(ref _accessModifier, value);
        }

        private bool _isStatic;
        public bool IsStatic
        {
            get => _isStatic;
            set => SetProperty(ref _isStatic, value);
        }

        #endregion //Properties

        public BaseModel(string name) : base(name)
        {
        }
    }
}
