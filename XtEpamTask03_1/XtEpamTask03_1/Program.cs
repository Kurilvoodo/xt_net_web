using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask03_1 //LOST 
{
    class Program
    {
        #region CollectionMethod
        /// <summary>
        /// Remove every second human from the circle
        /// </summary>
        /// <param name="people"></param>
        /// <param name=""></param>
        /// 
        public static void RemoveFromCircle(List<byte> circle, int currentPos = 0)
        {
            bool isRemovable = false;
            while (circle.Count > 1)
            {
                if (isRemovable)
                {
                    circle.RemoveAt(currentPos);
                    isRemovable = false;
                }
                else
                {
                    currentPos++;
                    isRemovable = true;
                }
            }
            
        }
        #endregion
        static void Main(string[] args)
        {
            #region Execution
            int n = 0;// base initialization for sure to be a good code :P
            Console.Write("Enter the number  of people in the cirlce of Lost=");
            if (int.TryParse(Console.ReadLine(),out n))
            {
                //Creating of collection 
                List<byte> circle = new List<byte>();
                Random rnd = new Random();
                for (int i = 0; i < n; i++)
                {
                    circle.Add((byte)rnd.Next(0,7)); // we do the random bytes from 0-7. Doesn't metter the names of a ma to survive
                }
                RemoveFromCircle(circle, n);
                Console.WriteLine();
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Input Error!");
            }
            
            #endregion
        }
    }
}
