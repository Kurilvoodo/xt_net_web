using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask04_1
{
    class Program
    {
       static int Compare(int a, int b)
        {
            if (a > b)
                return 1;
            else if (a < b)
                return -1;
            else
                return 0;
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 8, 2, 3, 11, 76, 33 };
            SortClass.Sort<int>(array, Compare);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
