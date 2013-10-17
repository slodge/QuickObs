using System.Collections.ObjectModel;
using Cirrious.MvvmCross.ViewModels;

namespace QuickObs.Core.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
		private string _hello = "Hello MvvmCross";
        public string Hello
		{ 
			get { return _hello; }
			set { _hello = value; RaisePropertyChanged(() => Hello); }
		}

        public IMvxCommand Go
        {
            get { return new MvxCommand(() => ShowViewModel<SecondViewModel>());}
        }
    }

    public class SecondViewModel
        : MvxViewModel
    {
        private static ObservableCollection<string> _StaticThings = new ObservableCollection<string>()
            {
                "One",
                "TWo"
            };

        private ObservableCollection<string> _things = _StaticThings;
        public ObservableCollection<string> Things
        {
            get { return _things; }
            set { _things = value; RaisePropertyChanged(() => Things); }
        }

        public IMvxCommand Add
        {
            get
            {
                return new MvxCommand(() => _StaticThings.Insert(0, "New" + _StaticThings.Count.ToString()));
            }
        }
    }
}
