using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umler.Models;

namespace Umler.ViewModels
{
    public class ItemViewModel : BindableBase
    {
        private Item _item;

        public Item Item
        {
            get => _item;
            set => SetProperty(ref _item, value);
        }

        private string _source;
        public string Source 
        { 
            get => _source; 
            set => SetProperty(ref _source, value);
        }

        public ItemViewModel(Item item, string source)
        {
            Item = item ?? throw new ArgumentNullException(nameof(item));
            Source = source ?? throw new ArgumentNullException(nameof(source));
        }
    }
}
