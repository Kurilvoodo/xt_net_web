using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace XtEpamTask05
{
    class Program
    {
        static void Main(string[] args)
        {
            BackupClass myFiles = new BackupClass("myDirectory");
            int mode;
            while (true)
            {
                Console.WriteLine("Enter mode: " + Environment.NewLine +
                "1) Watching" + Environment.NewLine +
                "2) Recovery" + Environment.NewLine);
                if (int.TryParse(Console.ReadLine(), out mode))
                {
                    if (mode == 1)
                    {
                        myFiles.Watching();
                    }
                    else if (mode == 2)
                    {
                        Console.WriteLine("Available dates:");
                        Console.WriteLine(myFiles.GetAllDateBackups());
                        Console.WriteLine("Enter the date:");

                        try
                        {
                            myFiles.Recovery(Console.ReadLine());
                        }
                        catch (DirectoryNotFoundException)
                        {
                            Console.WriteLine("Invalid date");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid mode");
                    }
                }
                else
                {
                    Console.WriteLine("Enter error");
                }
            }
        }
    }
}
