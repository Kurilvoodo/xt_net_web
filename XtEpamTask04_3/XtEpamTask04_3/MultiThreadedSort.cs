using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XtEpamTask04_1;

namespace XtEpamTask04_3
{
    class MultiThreadedSort<T>
    {
        //Event notification
        public static event Action<T[]> OnSorting;

        #region Start
        //Method start sorting on a new thread
        static public void Start(T[] array, Compare<T> compare)
        {
            if (array != null && compare != null)
            {
                OnSorting += OnSortingArrayHandler<T>;
                Thread thread = new Thread(Sort);
                thread.Start(new ArrayAndComparer<T>(array, compare));
            }
            else
            {
                throw new NullReferenceException("One of the arguments equal null");
            }
        }
        #endregion

        #region Sort
        //Method call QuickSort
        private static void Sort(object o)
        {
            if (o is ArrayAndComparer<T>)
            {
                //Cast object and appeal to array
                ArrayAndComparer<T> args = o as ArrayAndComparer<T>;
                SortClass.Sort<T>(args.Array, args.Compare);
                //Notificaton that sorting is complete
                OnSorting?.Invoke(args.Array);
                OnSorting -= OnSortingArrayHandler<T>;
            }
            else
            {
                throw new InvalidCastException("Object is not array and comparer");
            }
        }
        #endregion

        #region class ArrayAndComparer
        //Object wich stores array and compare delegate
        private class ArrayAndComparer<T1>
        {
            private Compare<T1> _compare;
            private T1[] _array;
            public Compare<T1> Compare => _compare;
            public T1[] Array => _array;

            public ArrayAndComparer(T1[] array, Compare<T1> compare)
            {
                _array = array;
                _compare = compare;
            }
        }
        #endregion

        #region OnSortingArrayHandler<T>(T[] array)
        public static void OnSortingArrayHandler<T>(T[] array)
        {
            ShowSortingArray<T>(array);
        }
        #endregion

        #region ShowSortingArray<T>(T[] array)
        public static void ShowSortingArray<T>(T[] array)
        {
            Console.WriteLine("Sort complete!");
            foreach (T item in array)
            {
                Console.WriteLine(item.ToString());
            }
        }
        #endregion
    }
}

