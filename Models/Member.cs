using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Umler.Models
{
    public class Member : BaseModel
    {
        #region Properties
      

        private MemberModifiers _memberModifier;
        public MemberModifiers MemberModifier
        {
            get => _memberModifier;
            set
            {
                _memberModifier = value;
                OnPropertyChanged();
            }
        }

        private bool _isStatic;
        public bool IsStatic
        {
            get => _isStatic; 
            set
            {
                _isStatic = value;
                OnPropertyChanged();
            }
        }

        private bool _isVirtual;
        public bool IsVirtual
        {
            get => _isVirtual;
            set
            {
                _isVirtual = value;
                OnPropertyChanged();
            }
        }

        private bool _isAbstract;
        public bool IsAbstract
        {
            get => _isAbstract;
            set
            {
                _isAbstract = value;
                OnPropertyChanged();
            }
        }

        private bool _isNew;
        public bool IsNew
        {
            get => _isNew;
            set
            {
                _isNew = value;
                OnPropertyChanged();
            }
        }

        private bool _isOverride;
        public bool IsOverride
        {
            get => _isOverride;
            set
            {
                _isOverride = value;
                OnPropertyChanged();
            }
        }

        private bool _isSealed;
        public bool IsSealed
        {
            get => _isSealed;
            set
            {
                _isSealed = value;
                OnPropertyChanged();
            }
        }

        #endregion //Properties
     
    }
}
