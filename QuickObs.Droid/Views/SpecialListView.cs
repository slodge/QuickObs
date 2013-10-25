using System;
using System.Collections.Generic;
using Android.Content;
using Android.Util;
using Cirrious.CrossCore.Core;
using Cirrious.MvvmCross.Binding.Droid.Views;

namespace QuickObs.Droid.Views
{
    public class SpecialListView : MvxListView
    {
        public SpecialListView(Context context, IAttributeSet attrs) : base(context, attrs, new MyAdapter(context))
        {
        }
    }
}