using Miamy.Umler.Core.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Miamy.Umler.Modules.ToolbarModule.Models
{
    public class ToolbarItem : BaseModel
    {
        private string _source;
        public string Source
        {
            get => _source;
            set => SetProperty(ref _source, value);
        }

        public string FullSource => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "resources", Source);

        public ToolbarItem(string name, string source) : base(name)
        {
            Source = source ?? throw new ArgumentNullException(nameof(source));
        }


    }
}
