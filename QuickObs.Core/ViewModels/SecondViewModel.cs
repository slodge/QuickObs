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
    public class SecondViewModel : MvxViewModel
    {
        private readonly static ObservableCollection<ItemsViewModel> _Items = new ObservableCollection<ItemsViewModel>()
        {
            new ItemsViewModel(),
            new ItemsViewModel(),
            new ItemsViewModel(),
            new ItemsViewModel(),
        };

        public ObservableCollection<ItemsViewModel> Items
        {
            get
            {
                return SecondViewModel._Items;
            }
        }

        public IMvxCommand Add
        {
            get
            {
                return new MvxCommand(() => _Items[0].Items.Insert(0, "New" + ((IList)_Items).Count.ToString()));
            }
        }
    }
}
