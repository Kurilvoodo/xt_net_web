using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask04_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            string number = Console.ReadLine();
            if (number.IsNumber())
                Console.WriteLine("Positive int has been entered");
            else
                Console.WriteLine("Entered int number isn't positive");
        }
    }
}
