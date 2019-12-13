using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask04_4
{
   
        public static class ArrayExtension
        {
            public static byte Sum(this byte[] array)
            {
                byte sum = 0;
                foreach (byte item in array)
                    sum += item;
                return sum;
            }

            public static sbyte Sum(this sbyte[] array)
            {
                sbyte sum = 0;
                foreach (sbyte item in array)
                    sum += item;
                return sum;
            }

            public static short Sum(this short[] array)
            {
                short sum = 0;
                foreach (short item in array)
                    sum += item;
                return sum;
            }

            public static ushort Sum(this ushort[] array)
            {
                ushort sum = 0;
                foreach (ushort item in array)
                    sum += item;
                return sum;
            }
            public static int Sum(this int[] array)
            {
                int sum = 0;
                foreach (int item in array)
                    sum += item;
                return sum;
            }
            public static uint Sum(this uint[] array)
            {
                uint sum = 0;
                foreach (uint item in array)
                    sum += item;
                return sum;
            }
            public static long Sum(this long[] array)
            {
                long sum = 0;
                foreach (long item in array)
                    sum += item;
                return sum;
            }
            public static ulong Sum(this ulong[] array)
            {
                ulong sum = 0;
                foreach (ulong item in array)
                    sum += item;
                return sum;
            }
            public static float Sum(this float[] array)
            {
                float sum = 0;
                foreach (float item in array)
                    sum += item;
                return sum;
            }
            public static double Sum(this double[] array)
            {
                double sum = 0;
                foreach (double item in array)
                    sum += item;
                return sum;
            }
            public static decimal Sum(this decimal[] array)
            {
                decimal sum = 0;
                foreach (decimal item in array)
                    sum += item;
                return sum;
            }
        }
    }
