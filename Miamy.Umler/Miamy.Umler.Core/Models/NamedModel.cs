using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Miamy.Umler.Core.Models
{
    public class NamedModel : BindableBase
    {
        #region Properties
        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);

        }
        #endregion //Properties


        public NamedModel(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
    }
}
