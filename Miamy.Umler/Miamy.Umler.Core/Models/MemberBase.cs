using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miamy.Umler.Core.Models
{
    public class MemberBase : BaseModel
    {
        #region Properties

        private MemberModifier _memberModifier;
        public MemberModifier MemberModifier
        {
            get => _memberModifier;
            set => SetProperty(ref _memberModifier, value);
        }
        #endregion //Properties

        public MemberBase(string name) : base(name)
        {
        }
    }
}
