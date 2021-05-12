using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umler.Models
{
    public class Property : Member
    {
        #region Properties

        private bool _hasSetter;
        public bool HasSetter
        {
            get => _hasSetter;
            set
            {
                _hasSetter = value;
                OnPropertyChanged();
            }
        }

        private bool _hasGetter;
        public bool HasGetter
        {
            get => _hasGetter;
            set
            {
                _hasGetter = value;
                OnPropertyChanged();
            }
        }

        private bool _isPrivateSetter;
        public bool IsPrivateSetter
        {
            get => _isPrivateSetter;
            set
            {
                _isPrivateSetter = value;
                OnPropertyChanged();
            }
        }

        private bool _isPrivateGetter;
        public bool IsPrivateGetter
        {
            get => _isPrivateGetter;
            set
            {
                _isPrivateGetter = value;
                OnPropertyChanged();
            }
        }

        #endregion //Properties



    }
}
