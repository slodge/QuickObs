using System.Collections.ObjectModel;
using Cirrious.MvvmCross.ViewModels;

namespace QuickObs.Core.ViewModels
{
    public class SecondViewModel : MvxViewModel
    {
        private readonly static ObservableCollection<ItemsViewModel> _Items1 = new ObservableCollection<ItemsViewModel>()
        {
            new ItemsViewModel(),
            new ItemsViewModel(),
            new ItemsViewModel(),
        };

        private readonly static ObservableCollection<ItemsViewModel> _Items2 = new ObservableCollection<ItemsViewModel>()
        {
            new ItemsViewModel(),
            new ItemsViewModel(),
            new ItemsViewModel(),
        };

        private readonly static ObservableCollection<ItemsViewModel> _Items3 = new ObservableCollection<ItemsViewModel>()
        {
            new ItemsViewModel(),
            new ItemsViewModel(),
            new ItemsViewModel(),
        };

        public ObservableCollection<ItemsViewModel> Items1
        {
            get
            {
                return SecondViewModel._Items1;
            }
        }

        public ObservableCollection<ItemsViewModel> Items2
        {
            get
            {
                return SecondViewModel._Items2;
            }
        }

        public ObservableCollection<ItemsViewModel> Items3
        {
            get
            {
                return SecondViewModel._Items3;
            }
        }

        public int SubscriptionCount1
        {
            get
            {
                return this.Items1[0].SubscriptionCount;
            }
        }

        public int SubscriptionCount2
        {
            get
            {
                return this.Items2[0].SubscriptionCount;
            }
        }

        public int SubscriptionCount3
        {
            get
            {
                return this.Items3[0].SubscriptionCount;
            }
        }
    }
}
