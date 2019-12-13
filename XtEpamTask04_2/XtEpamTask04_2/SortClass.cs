using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask04_1
{
    public static class SortClass //typizaton of a QuickSort
    {
        public delegate int Compare<T>(T firstElem, T secondElem);
        private static void Sort<T>(T[] numbers, int startIndex, int endIndex, Compare<T> compare)
        {
            //Choose pivot element
            //This pivot element is element with an average index
            T pivot = numbers[(endIndex - startIndex) / 2 + startIndex];

            //Additional index
            int i = startIndex;
            int j = endIndex;

            while (i <= j)
            {
                //Find element and swap
                while (compare.Invoke(numbers[i], pivot) == -1 && i <= endIndex)
                //while (numbers[i] < pivot && i <= end_idx)
                {
                    ++i;
                }
                while (compare.Invoke(numbers[j], pivot) == 1 && j >= startIndex)
                //while (numbers[j] > pivot && j >= start_idx)
                {
                    --j;
                }

                if (i <= j)
                {
                    //Swap
                    T temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                    ++i;
                    --j;
                }
            }
            //Call recursion for left and right array
            if (j > startIndex)
            {
                Sort(numbers, startIndex, j, compare);
            }
            if (i < endIndex)
            {
                Sort(numbers, i, endIndex, compare);
            }
        }

        //Overload
        public static void Sort<T>(T[] numbers, Compare<T> compare)
        {
            if (compare != null)
            {
                Sort(numbers, 0, numbers.Length - 1, compare);
            }
        }
    }
}
