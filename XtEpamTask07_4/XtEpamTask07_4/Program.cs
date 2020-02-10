using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace XtEpamTask07_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text: ");
            string text = Console.ReadLine();

            Regex regexNormal = new Regex(@"^[-+]?[0-9]*[.,][0-9]+$");
            Regex regexScientific = new Regex(@"^[-+]?[0-9]*[.,][0-9]+(?:[eE][-+]?[0-9]+)?$");

            MatchCollection matches = regexNormal.Matches(text);

            if (matches.Count > 0)
            {
                Console.WriteLine("Normal notation");
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            }
            else
            {
                matches = regexScientific.Matches(text);

                if (matches.Count > 0)
                {
                    Console.WriteLine("Scientific notation");
                    foreach (Match match in matches)
                        Console.WriteLine(match.Value);
                }
                else
                {

                    Console.WriteLine("Not a number");
                }
            }
        }
    }
}