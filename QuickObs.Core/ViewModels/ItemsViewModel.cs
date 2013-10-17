using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;

namespace QuickObs.Core.ViewModels
{
    public class ItemsViewModel : MvxViewModel
    {
        private readonly ObservableCollection<string> _items = new ObservableCollection<string>()
        {
            "1",
            "2"
        };

        public ObservableCollection<string> Items
        {
            get
            {
                return this._items; 
            }
        }
    }
}
