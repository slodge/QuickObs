using System;
using System.Collections;
using System.Collections.Specialized;
using Android.Content;
using Android.Views;
using Android.Widget;
using Cirrious.CrossCore.Exceptions;
using Cirrious.CrossCore.Platform;
using Cirrious.CrossCore.WeakSubscription;
using Cirrious.MvvmCross.Binding;
using Cirrious.MvvmCross.Binding.Attributes;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Binding.Droid.BindingContext;
using Cirrious.MvvmCross.Binding.Droid.Views;
using Cirrious.MvvmCross.Binding.ExtensionMethods;
using Object = Java.Lang.Object;

namespace QuickObs.Droid.Views
{
    public class MyAdapter
        : MvxAdapter
          , IMvxAdapter
    {
        public MyAdapter(Context context) : base(context)
        {
        }

        public MyAdapter(Context context, IMvxAndroidBindingContext bindingContext) : base(context, bindingContext)
        {
        }

        protected override MvxListItemView CreateBindableView(object dataContext, int templateId)
        {
            return new MyListItemView(Context, BindingContext.LayoutInflater, dataContext, templateId);
        }
    }

    public class MyListItemView
          : MvxListItemView
    {
        public MyListItemView(Context context, IMvxLayoutInflater layoutInflater, object dataContext, int templateId) : base(context, layoutInflater, dataContext, templateId)
        {
        }

        protected override void OnDetachedFromWindow()
        {
            base.OnDetachedFromWindow();
            DataContext = null;
        }
    }
}