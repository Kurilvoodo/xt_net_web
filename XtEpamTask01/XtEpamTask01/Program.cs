using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask01
{
    class Program
    {
        #region Method 1.1
        static int RectangleSquare(int a, int b)
        {
            return a * b;
        }
        #endregion

        #region Method for 1.2
        static void SimpleTriangle(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                for (int t = 0; t < i; t++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region Method for 1.3
        static void NoSoSimpleTriangle(int n)
        {
            for (int i = 1; i <= n * 2; i += 2)
            {
                Console.WriteLine(new string(' ', (n * 2 - 1) / 2 - i / 2) + new string('*', i));
            }
        }
        #endregion

        #region Method for 1.4
        static void XmasMethod(int n)
        {
            for (int i = 1; i <= n+1; i ++)
            {
                for (int t = 1; t <=i*2; t+=2)
                {
                    Console.WriteLine(new string(' ', (n * 2) / 2 - t / 2) + new string('*', t));
                }
            }
        }
        #endregion

        #region Method for 1.5

        static int CapriciousAmount()
        {
            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        #endregion

        #region Structure for 1.6
        [Flags]
        enum Fonts
        {
            None = 0,
            Bold = 1,
            Italic = 2,
            underline = 3,
            exit = 4 
        }
        static void FontMethod(ref List<Fonts> styles, int n )
        {
            if (styles.Contains((Fonts)n))
            {
                styles.Remove((Fonts)n);
            }
            else
            {
                styles.Add((Fonts)n);
            }
        }
        #endregion
        static void Main(string[] args)
        {
            #region 1.1 Rectangle
            //Square of rectangle with a,b with exception of negative number and 0
            //Else kind of incorrect form ignore

            Console.WriteLine("Hi and welcome to Rectangle Square program part " + Environment.NewLine + "Plesae enter the 'a' side");
            Console.Write("a = ");
            int a;

            if (int.TryParse(Console.ReadLine(), out a) & !(a <= 0))
            {
                Console.WriteLine("Enter the 'b' side ");
                Console.Write("b = ");
                int b;
                if (int.TryParse(Console.ReadLine(), out b) & !(b <= 0))
                {
                    Console.WriteLine("" + RectangleSquare(a, b));
                }
                else
                {
                    if (b <= 0)
                    {
                        //exception
                        throw new System.ArgumentException("Parameter cannot be negative or equal to 0", "b");
                    }
                    else
                    {
                        //ignore code
                        Console.WriteLine("Incorrect input" + Environment.NewLine);
                    }

                }
            }
            else
            {
                if (a <= 0)
                {
                    //exception
                    throw new System.ArgumentException("Parameter cannot be negative or equal to 0", "a");
                }
                else
                {
                    //ingore code
                    Console.WriteLine("Incorrect input" + Environment.NewLine);
                }

            }

            #endregion

            #region 1.2 Triangle version 1 :D
            //Triangle for N strings, where number was entered from the console.
            Console.WriteLine("Welcome to another part of Task 01, the Triangle painting! " + Environment.NewLine + "Please enter the N number of strings");
            Console.Write("Enter N = ");
            int n;
            if (int.TryParse(Console.ReadLine(), out n))
            {
                SimpleTriangle(n);
            }
            else
            {
                Console.WriteLine("Incorrect input " + Environment.NewLine);
            }
            #endregion

            #region Task 1.3 Another Triangle :D
            Console.Write("Enter N = ");
            if (int.TryParse(Console.ReadLine(), out n))
            {
                NoSoSimpleTriangle(n);
            }
            else
            {
                Console.WriteLine("Incorrect input" + Environment.NewLine);
            }
            #endregion

            #region Task 1.4 Xmas Triangle Tree :'D
            Console.WriteLine("Enter N = ");
            if (int.TryParse(Console.ReadLine(), out n))
            {
                XmasMethod(n);
            }
            else
            {
                Console.WriteLine("Incorrect input" + Environment.NewLine);
            }
            #endregion

            #region Task 1.5 Summ
            // Summ of numbers lower than 1000 and aliquot to 3 and 5
            Console.WriteLine(" Summ of numbers lower than 1000 and aliquot to 3 and 5"+ Environment.NewLine);
            Console.Write(CapriciousAmount()+Environment.NewLine);
            #endregion

            #region Task 1.6 
            Fonts op = new Fonts();
            
            List<Fonts> styles = new List<Fonts>();
            string result ="";
            do
            {
                StringBuilder fontKeeper = new StringBuilder();

                foreach (Fonts item in styles)
                {
                    if (fontKeeper.Length > 0)
                    {
                        fontKeeper.Append(", " + item);
                    }
                    else
                    {
                        fontKeeper.Append(item);
                    }

                }

                if (fontKeeper.Length == 0)
                    fontKeeper.Append("None");

                Console.WriteLine(
                    "Параметры надписи: {0}", fontKeeper + Environment.NewLine +
                    "\t 1: bold" + Environment.NewLine +
                    "\t 2: italic" + Environment.NewLine +
                    "\t 3: underline" + Environment.NewLine +
                    "\t 4: exit format changing" + Environment.NewLine
                    );
                if (int.TryParse(Console.ReadLine(), out n))
                {

                    switch (n)
                    {
                        case 1:
                            op = Fonts.Bold;
                            FontMethod(ref styles, n);
                            Console.Write("You added {0} to your font styler", op + Environment.NewLine);
                            break;
                        case 2:
                            op = Fonts.Italic;
                            FontMethod(ref styles, n);
                            Console.Write("You added {0} to your font styler", op + Environment.NewLine);
                            break;
                        case 3:
                            op = Fonts.underline;
                            FontMethod(ref styles, n);
                            Console.Write("You added {0} to your font styler", op + Environment.NewLine);
                            break;
                        case 4:
                            op = Fonts.exit;
                            Console.Write("You've ended to edit your font styler" + Environment.NewLine);
                             result = fontKeeper.ToString();
                            break;
                        
                    }
                    

                }
                else
                {
                    Console.Write("Incorrect input" + Environment.NewLine);
                }
                
            } while (op != Fonts.exit);
            Console.WriteLine("Параметры надписи: {0}", result + Environment.NewLine);
            #endregion
            Console.WriteLine("End of program");
            Console.ReadLine();
        }
    }
}
