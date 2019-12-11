using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpa_Task03_3
{
    class Program
    {
        #region ViewCapacity
        static void ViewCapacity(DynamicArray<string> arr, DynamicArray<int> arr1, DynamicArray<double> arr2)
        {
            Console.WriteLine("Capacity arr: {0}" + Environment.NewLine +
                    "Capacity arr1: {1}" + Environment.NewLine +
                    "Capacity arr2: {2}", arr.Capacity, arr1.Capacity, arr2.Capacity);
        }
        #endregion

        #region VeiwCount
        static void ViewCount(DynamicArray<string> arr, DynamicArray<int> arr1, DynamicArray<double> arr2)
        {
            Console.WriteLine("Count arr: {0}" + Environment.NewLine +
                    "Count arr1: {1}" + Environment.NewLine +
                    "Count arr2: {2}", arr.Count, arr1.Count, arr2.Count);
        }
        #endregion

        #region ViewArray
        static void ViewArray(DynamicArray<string> arr, DynamicArray<int> arr1, DynamicArray<double> arr2)
        {
            foreach (var item in arr)
                Console.Write(item + " ");
            Console.WriteLine();
            foreach (var item in arr1)
                Console.Write(item + " ");
            Console.WriteLine();
            foreach (var item in arr2)
                Console.Write(item + " ");
            Console.WriteLine();
        }
        #endregion

        #region TestArray
        static void TestArray()
        {
            DynamicArray<string> arr = new DynamicArray<string>();
            DynamicArray<int> arr1 = new DynamicArray<int>(50);
            DynamicArray<double> arr2 = new DynamicArray<double>(new List<double> { 25.3, 60.6, 32.5 });
            ViewCapacity(arr, arr1, arr2);
            arr1.Add(5);
            for (int i = 0; i < 100; i++)
            {
                arr.Add(i.ToString());
            }
            arr2.AddRange(new double[] { 1.1, 1.2, 3.4, 3.1, 1.4 });
            ViewCount(arr, arr1, arr2);
            ViewArray(arr, arr1, arr2);
            ViewCapacity(arr, arr1, arr2);
            Console.WriteLine("Index 1 from arr: {0}" + Environment.NewLine +
            "Index 0 from arr1: {1}" + Environment.NewLine +
                "Index 6 from arr2: {2}", arr[1], arr1[0], arr2[6]);
            arr2.Remove(25.3);
            arr.Remove("5");
            ViewArray(arr, arr1, arr2);
            arr.Insert(40, "new element");
            ViewArray(arr, arr1, arr2);
        }
        #endregion

        static void Main(string[] args)
        {
            TestArray();
        }
    }
}
