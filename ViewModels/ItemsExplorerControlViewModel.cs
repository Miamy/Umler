﻿using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Umler.Models;

namespace Umler.ViewModels
{
    public class ItemsExplorerControlViewModel : BindableBase
    {
        private List<Item> _items;
        public ItemsExplorerControlViewModel()
        {

        }
    }
}
