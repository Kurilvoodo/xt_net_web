using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XtEpamTask04_1;

namespace XtEpamTask04_2
{
    class Program
    {
        static int Compare(string a, string b)
        {
            if (a.Length > b.Length)
                return 1;
            else if (a.Length < b.Length)
                return -1;
            else
                return 0;
        }
        static void Main(string[] args)
        {
            string[] array = new string[] { "we're calling", "for", "freedom", "aaaaaaaaaaaaaaaaaaaaaaaa", "fantasy_is_about_to_end" };
            SortClass.Sort(array, Compare);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
