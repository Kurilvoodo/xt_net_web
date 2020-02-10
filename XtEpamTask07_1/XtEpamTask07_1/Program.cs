using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace XtEpamTask07_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text: ");
            string text = Console.ReadLine();

            Regex regex = new Regex(@"\b(0[1-9]|1[0-9]|2[0-9]|3[01])-(0[1-9]|1[012])-[0-9]{4}\b");
            MatchCollection matches = regex.Matches(text);

            if (matches.Count > 0)
            {
                Console.WriteLine("Text contains the date");
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("No date");
            }
        }
    }
}