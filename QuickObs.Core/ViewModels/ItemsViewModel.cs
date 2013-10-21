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
        #region PObservableCollection
        private class PObservableCollection<T> : INotifyCollectionChanged, IList<T>, IList
        {
            private readonly ObservableCollection<T> _inner = new ObservableCollection<T>();

            public PObservableCollection()
            {
                _inner.CollectionChanged += InnerChanged;
            }

            private void InnerChanged(object sender, NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs)
            {
                var handler = _collectionChanged;
                if (handler != null)
                    handler(this, notifyCollectionChangedEventArgs);
            }

            private int _count;
            private event NotifyCollectionChangedEventHandler _collectionChanged;
            public event NotifyCollectionChangedEventHandler CollectionChanged
            {
                add
                {
                    _collectionChanged += value;
                    _count++;
                    Mvx.Trace("Count up to {0}", _count);
                }
                remove
                {
                    _collectionChanged -= value;
                    _count--;
                    Mvx.Trace("Count down to {0}", _count);
                }
            }

            public IEnumerator<T> GetEnumerator()
            {
                return _inner.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            public void Add(T item)
            {
                _inner.Add(item);
            }

            public int Add(object value)
            {
                _inner.Add((T)value);
                return _inner.Count;
            }

            void IList.Clear()
            {
                _inner.Clear();
            }

            public bool Contains(object value)
            {
                return _inner.Contains((T)value);
            }

            public int IndexOf(object value)
            {
                return _inner.IndexOf((T)value);
            }

            public void Insert(int index, object value)
            {
                _inner.Insert(index, (T)value);
            }

            public void Remove(object value)
            {
                _inner.Remove((T)value);
            }

            void IList.RemoveAt(int index)
            {
                _inner.RemoveAt(index);
            }

            public bool IsFixedSize { get { return false; } }
            bool IList.IsReadOnly { get { return false; } }

            object IList.this[int index]
            {
                get { return _inner[index]; }
                set { throw new NotImplementedException(); }
            }

            void ICollection<T>.Clear()
            {
                _inner.Clear();
            }

            public bool Contains(T item)
            {
                return _inner.Contains(item);
            }

            public void CopyTo(T[] array, int arrayIndex)
            {
                throw new NotImplementedException();
            }

            public bool Remove(T item)
            {
                throw new NotImplementedException();
            }

            public void CopyTo(Array array, int index)
            {
                throw new NotImplementedException();
            }

            int ICollection.Count { get { return _inner.Count; } }
            public bool IsSynchronized { get { return false; } }
            public object SyncRoot { get { return _inner; } }
            int ICollection<T>.Count { get { return _inner.Count; } }
            bool ICollection<T>.IsReadOnly { get { return false; } }
            public int IndexOf(T item)
            {
                return _inner.IndexOf(item);
            }

            public void Insert(int index, T item)
            {
                _inner.Insert(index, item);
            }

            void IList<T>.RemoveAt(int index)
            {
                throw new NotImplementedException();
            }

            public T this[int index]
            {
                get { return _inner[index]; }
                set { throw new NotImplementedException(); }
            }
        }
        #endregion

        private readonly PObservableCollection<string> _items = new PObservableCollection<string>()
        {
            "1",
            "2"
        };

        public IEnumerable Items
        {
            get
            {
                return this._items; 
            }
        }
    }
}
