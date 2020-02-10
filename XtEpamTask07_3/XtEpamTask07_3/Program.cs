using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace XtEpamTask07_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text: ");
            string text = Console.ReadLine();
            Regex regex = new Regex(@"\b[a-z0-9][a-z0-9_\.-]*[a-z0-9]@([a-z0-9\.]*\.[a-z0-9]{2,6})\b");
            MatchCollection matches = regex.Matches(text);

            if (matches.Count > 0)
            {
                Console.WriteLine("Text contains the email");
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("No email");
            }
        }
    }
}