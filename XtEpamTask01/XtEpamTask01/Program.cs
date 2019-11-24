using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask01
{
    class Program
    {
        #region Method 1.1 RectangleSquare(int a, int b)
        static int RectangleSquare(int a, int b)
        {
            return a * b;
        }
        #endregion

        #region Method for 1.2 SimpleTriangle(int n)
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

        #region Method for 1.3 NoSoSimpleTriangle(int n)
        static void NoSoSimpleTriangle(int n)
        {
            for (int i = 1; i <= n * 2; i += 2)
            {
                Console.WriteLine(new string(' ', (n * 2 - 1) / 2 - i / 2) + new string('*', i));
            }
        }
        #endregion

        #region Method for 1.4 XmasMethod(int n)
        static void XmasMethod(int n)
        {
            for (int i = 1; i <= n + 1; i++)
            {
                for (int t = 1; t <= i * 2; t += 2)
                {
                    Console.WriteLine(new string(' ', (n * 2) / 2 - t / 2) + new string('*', t));
                }
            }
        }
        #endregion

        #region Method for 1.5 CapriciousAmount()

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

        #region Structure for 1.6 FontMethod(ref List<Fonts> styles, int n)
        [Flags]
        enum Fonts
        {
            None = 0,
            Bold = 1,
            Italic = 2,
            underline = 3,
            exit = 4
        }
        static void FontMethod(ref List<Fonts> styles, int n)
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

        #region Method for 1.7 QuickSort(int i, int j, int[] a)
        static void Randomization(ref int[] a)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(-150, 150);
            }
        }
        static int FindPivot(int i, int j, int[] a)
        {
            int firstKey = a[i]; for (int k = i + 1; k <= j; k++)
            {
                if (a[k] > firstKey) { return k; }
                else if (a[k] < firstKey)
                { return i; }
            }
            return -1;
        }
        static int Partition(int i, int j, int pivot, int[] a)
        {
            int temp;
            int left = i;
            int right = j;
            do
            {
                temp = a[left]; a[left] = a[right]; a[right] = temp;
                while (a[left] < pivot) { left++; }
                while (a[right] >= pivot) { right--; }
            } while (left < right);
            return left;
        }

        static void QuickSort(int i, int j, int[] a)
        {
            int index = FindPivot(i, j, a);
            if (index != -1)
            {
                int pivot = a[index];
                int k = Partition(i, j, pivot, a);
                QuickSort(i, k - 1, a);
                QuickSort(k, j, a);

            }
        }
        static void Print(int[] a)
        {
            foreach (int item in a)
            {
                Console.Write(" {0} ", item);
            }
            Console.WriteLine();
        }
        #endregion

        #region Methods for 1.8 MultipleChanges(ref int[,,] a, int n)
        static void Randomization(ref int[,,] a, int n)
        {
            Random rnd = new Random();
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    for (int z = 0; z < n - 1; z++)
                    {
                        a[i, j, z] = rnd.Next(-150, 150);
                    }
                }

            }
        }
        static void MultipleChanges(ref int[,,] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    for (int z = 0; z < n - 1; z++)
                    {
                        if (a[i, j, z] > 0)
                        {
                            a[i, j, z] = 0;
                        }
                    }
                }
            }
            Console.WriteLine("Hang out, work is done.");
        }
        static void Print(int[,,] a)
        {
            foreach (int item in a)
            {
                Console.Write("{0} ", item);
            }
            Console.Write("" + Environment.NewLine);
        }
        #endregion

        #region Methods for 1.9 Summing(int [] a)
        static int Summing(int [] a)
        {
            int summ = 0;
            foreach (int item in a)
            {
                if (item > 0)
                {
                    summ += item;
                }  
            }
            return summ;
        }
        #endregion

        #region methods for 1.10 Summing(int [,] a,int n)
        static void Randomization(ref int [,] a, int n)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i,j] = rnd.Next(-150, 150);
                }
            }
        }
        static void Print(int [,] a)
        {
            foreach (int item in a)
            {
                Console.Write(" {0} ", item);
            }
            Console.WriteLine();
        }
        static int Summing(int [,] a,int n)
        {
            int summ = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ( (i+j) % 2 == 0)
                    {
                        summ += a[i,j];
                    }
                }
            }
            return summ;
        }
        #endregion


        #region Methods for 1.11 string  AverageLengthOfTheString(string test)
        static float AverageLengthOfTheString(string test)
        {
            test += " "; //add the separator to mention the last word of a string and method IsSeparator

            float result=0; // average length of word in string

            int lenOfWord = 0;
            int wordsCounter = 0;

            for (int i = 0; i < test.Length; i++)
            {
                if (char.IsPunctuation(test[i]) || char.IsDigit(test[i]) ||
                    char.IsNumber(test[i]) || char.IsSeparator(test[i]))
                {
                    if (lenOfWord > 0)
                    {
                        wordsCounter++;
                        result += (float)lenOfWord;
                    }
                    lenOfWord = 0;
                }
                else
                {
                    lenOfWord++;
                }
            }
            return result / wordsCounter;
        }
        #endregion

        #region for 1.12
        static void DoubleSubSymbols(ref string str, string substr)
        {
            str.ToLower();
            substr.ToLower(); //to make all the sybmols equal to similar format
            substr = new string(substr.Distinct().ToArray());//first to do is to delete not unique symbols in substr

            foreach (char item in substr)
            {
                str = str.Replace(item.ToString(), new string(item, 2)); // replace in main str all the symbols that exists in new string with doubled symbols, where item = symbol to double.
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
                Console.WriteLine("Enter the 'b' side " + Environment.NewLine);
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
                        throw new System.ArgumentException("Parameter cannot be negative or equal to 0", "b" + Environment.NewLine);
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
                    throw new System.ArgumentException("Parameter cannot be negative or equal to 0", "a" + Environment.NewLine);
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
            Console.WriteLine("Welcome to another part of Task 01, the Triangle painting! " + Environment.NewLine + "Please enter the N number of strings" + Environment.NewLine);
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
            Console.WriteLine(" Summ of numbers lower than 1000 and aliquot to 3 and 5" + Environment.NewLine);
            Console.Write(CapriciousAmount() + Environment.NewLine);
            #endregion

            #region Task 1.6 Font Adjustment
            Fonts op = new Fonts();

            List<Fonts> styles = new List<Fonts>();
            string result = "";
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

            #region Task 1.7 Array processing
            Console.WriteLine("Enter the number of elements in array" + Environment.NewLine);
            
            if (int.TryParse(Console.ReadLine(), out n))
            {
                //Array and random generating
                int[] array = new int[n];
                Randomization(ref array);
                Console.WriteLine("Randomized array" + Environment.NewLine);
                Print(array);
                Console.WriteLine("Sorted array" + Environment.NewLine);
                QuickSort(0, array.Length - 1, array); // main sort method
                Print(array);
            }
            else
            {
                Console.WriteLine("Incorrect input" + Environment.NewLine);
            }
            #endregion

            #region Task 1.8 No Positive, Multiple array
            Console.WriteLine("Enter the capacity of multiple array t x t x t" + Environment.NewLine);
            if (int.TryParse(Console.ReadLine(), out n))
            {
                int[,,] multipleArray = new int[n, n, n];
                Randomization(ref multipleArray, n);
                MultipleChanges(ref multipleArray, n);
                Print( multipleArray);
            }
            else
            {
                Console.WriteLine("Incorrect input" + Environment.NewLine);
            }
            #endregion

            #region Task 1.9 Non negative summ
            Console.WriteLine("Enter number of elements in array" + Environment.NewLine);
            if (int.TryParse(Console.ReadLine(), out n))
            {
                
                int[] arrayNonNegative = new int[n];
                Randomization(ref arrayNonNegative);
                Console.WriteLine("Randomized array" + Environment.NewLine);
                Print(arrayNonNegative);
                int summ = Summing(arrayNonNegative);
                Console.WriteLine("Summ of non negative elements in arra equal to {0}", summ + Environment.NewLine); //concatenation of argument
            }
            else
            {
                Console.WriteLine("Incorrect input" + Environment.NewLine);
            }

            #endregion

            #region Task 1.10  2D Array
            Console.WriteLine("Enter capacity n x n"+ Environment.NewLine);
            if (int.TryParse(Console.ReadLine(), out n))
            {
                int[,] doubledArray = new int[n,n];
                
                Randomization(ref doubledArray, n);
                Console.WriteLine("Randomized array" + Environment.NewLine);
                Print(doubledArray);
                int summ = Summing(doubledArray, n);
                Console.WriteLine("Summ of 'even' elements in array equal to {0}", summ + Environment.NewLine); //concatenation of argument
            }
            else
            {
                Console.WriteLine("Incorrect input" + Environment.NewLine);
            }

            #endregion

            #region Task 1.11 c# Avergge String Length
            //string enteringTestOne = Console.ReadLine();
            //string enteringTestTwo = Console.ReadLine();
            string enteringTestOne = "Way way true hate inspiring codeing is fun hehe";
            string enteringTestTwo = "I don't know when it's over for me :D, I have to think out a bigger words";
            Console.WriteLine("Average number of words in string 1 is equal to {0}", AverageLengthOfTheString(enteringTestOne) + Environment.NewLine);//concetanation of arguement to make it more workable :d
            Console.WriteLine("Average number of words in string 2 is equal to {0}", AverageLengthOfTheString(enteringTestTwo) + Environment.NewLine);
            #endregion

            #region Task 1.12 
            string test1 = "Написать программу которая";
            string test2 = "описание ";
            Console.WriteLine("Change: {0}", test1 + Environment.NewLine + " and substring is {0}", test2 + Environment.NewLine );
            DoubleSubSymbols(ref test1, test2);
            Console.WriteLine("Example from the task: {0}", test1+ Environment.NewLine);
            Console.WriteLine("Now you can enter your own tests." + Environment.NewLine + "Enter String number 1:" + Environment.NewLine);
            test1=Console.ReadLine();
            Console.WriteLine("Enter String number 2:" + Environment.NewLine);
            test2 = Console.ReadLine();
            DoubleSubSymbols(ref test1, test2);
            Console.WriteLine("Your own result {0}", test1);
            #endregion
            Console.WriteLine("End of program");
            Console.ReadLine();
        }
    }
}
