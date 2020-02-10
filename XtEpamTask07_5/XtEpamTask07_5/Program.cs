using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace XtEpamTask07_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text: ");
            string text = Console.ReadLine();
            //Regex regex = new Regex(@"\b(([0,1][0-9])|(2[0-3])):[0-5][0-9]\b");
            Regex regex = new Regex(@"\b([0-1]?[0-9]|2[0-3]):[0-5][0-9]\b");
            MatchCollection matches = regex.Matches(text);

            if (matches.Count > 0)
            {
                Console.WriteLine("Time is found in the text {0} times", matches.Count);
            }
            else
            {
                Console.WriteLine("No time");
            }
        }
    }
}