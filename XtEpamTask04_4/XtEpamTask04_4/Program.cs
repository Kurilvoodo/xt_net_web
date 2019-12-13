using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask04_4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[] { 3, 3, 2, 1, 9, 11 };
            double[] array1 = new double[] { 7.2, 8.3, 6.8, 6.9, 11.1, 12.3 };
            short[] array2 = new short[] { 3, 3, 2, 1, 9, 11 };
            float[] array3 = new float[] { 4.5f, 5.6f, 6, 7.5f, 8, 9 };
            byte[] array4 = new byte[] { 3, 3, 2, 1, 8, 4 };

            Console.WriteLine(array.Sum() + Environment.NewLine +
                array1.Sum() + Environment.NewLine +
                array2.Sum() + Environment.NewLine +
                array3.Sum() + Environment.NewLine +
                array4.Sum());

            Console.ReadLine();
        }
    }
}
