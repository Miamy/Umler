using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Umler.Models
{
    public class Item : BaseModel
    {
        #region Properties
        private List<Property> _properties;
        public List<Property> Properties
        {
            get => _properties;
            set
            {
                _properties = value;
                OnPropertyChanged();
            }
        }

        #endregion //Properties

        public Item(string name)
        {
            Name = name;
            Properties = new List<Property>();
        }

    }
}
