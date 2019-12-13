using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask04_3
{
    class Program
    {
        #region Compare
        static int CompareString(string a, string b)
        {
            if (a.Length > b.Length)
                return 1;
            else if (a.Length < b.Length)
                return -1;
            else
                return 0;
        }

        static int CompareInt(int a, int b)
        {
            if (a > b)
                return 1;
            else if (a < b)
                return -1;
            else
                return 0;
        }

        static int CompareDoble(double a, double b)
        {
            if (a > b)
                return 1;
            else if (a < b)
                return -1;
            else
                return 0;
        }
        #endregion
        static void Main(string[] args)
        {
            int[] arrayInt = new int[] { 50, 63, 32, 11, 85, 67 };
            string[] arrayString = new string[] { "asdasd", "asda", "awda", "gogorego", "a" };
            double[] arrayDouble = new double[] { 65.2, 2.2, 13.4, 11.4, 76.2 };

            MultiThreadedSort<int>.Start(arrayInt, CompareInt);
            MultiThreadedSort<string>.Start(arrayString, CompareString);
            MultiThreadedSort<double>.Start(arrayDouble, CompareDoble);
        }
    }
}
