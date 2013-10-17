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
    public class FirstViewModel : MvxViewModel
    {
        public IMvxCommand Go
        {
            get { return new MvxCommand(() => ShowViewModel<SecondViewModel>());}
        }
    }
}
