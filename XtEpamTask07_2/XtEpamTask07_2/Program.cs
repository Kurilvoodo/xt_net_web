using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace XtEpamTask07_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text: ");
            string text = Console.ReadLine();
            text = Regex.Replace(text, @"\<.+?\>", "_");
            Console.WriteLine(text);
        }
    }
}
