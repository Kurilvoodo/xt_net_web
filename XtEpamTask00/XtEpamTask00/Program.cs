using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask00
{
     class Program
    {
        #region Function for 0.1
        static void  SequenceFunction(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", i);
            }
            Console.Write("\n");
        }
        #endregion

        #region SimpleCheckFunction for 0.2
        
        static bool IsSimple(int k)
        {
            for (int i = 2; i <= k / 2; i++)
            {
                if (k % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region SquareFunction
        static void SquareFunction(int n)
        {
            if (n % 2 != 0 && n > 0)
            {
                int e = n / 2; // empty slot	index
                for (int i = 0; i < n; i++)
                {
                    if (i == e)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (j == e)
                            {
                                Console.Write(" ");
                            }
                            else
                            {
                                Console.Write("*");
                            }
                        }
                    }
                    else
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write("*");
                        }
                    }
                    Console.Write("\n");
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода. Число не является нечетным.");
            }

        }
        #endregion

        #region ArrayFunctionTask0.4
        static void print(int[][] a) //вывод массива
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write("{0} ", a[i][j]);
                }
                Console.WriteLine();
            }
        }

      

        static int[][] ArrayFunction(int n) //злоебучий ступенчатый массив 
        {
            int[][] OuterMassive = new int[n][];
            Console.WriteLine("Вводите размерность каждой строчки массива");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Размерность {0} точки = ", i);
                int t;
                
                t = int.Parse(Console.ReadLine());
                OuterMassive[i] = new int[t];

                for (int j = 0; j < t; j++)
                {
                    Console.Write("Massive[{0}][{1}] = ",i,j);
                    OuterMassive[i][j] = int.Parse(Console.ReadLine());
                }
            }
           
            return OuterMassive;

        }

        #endregion
        static void Main(string[] args)
        {
            #region Task0.1 Sequence
            Console.WriteLine("Task 0.1 Sequence function till the N");
            Console.Write("Enter N = ");
            int n;
            if (int.TryParse(Console.ReadLine(), out n))
            {
                if (n > 0)
                {
                    SequenceFunction(n);
                }
                else
                {
                    Console.WriteLine("Ошибка ввода, n < 0"+Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода "+ Environment.NewLine);
            }
            
            
            #endregion

            #region Task0.2 Simple
            Console.WriteLine("Task 0.2 Simple function to check the digit");
            Console.Write("Enter the digit = ");
            int k;
            if (int.TryParse(Console.ReadLine(), out k))
            {
                if (IsSimple(k))
                {
                    Console.WriteLine("Число простое"+Environment.NewLine);
                }
                else
                {
                    Console.WriteLine("Число не простое"+Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода" + Environment.NewLine);
            }
            
            
           
            #endregion

            #region Task0.3
            Console.WriteLine("Task 0.3: Мы используем для вывода таблицы звездочек существующее число из Task 0.1");
            SquareFunction(n);
            #endregion

            #region Task0.4
            Console.WriteLine("Task 0.4: Массивы. Используем размерность N в начале проекта.");


           int[][] a =  ArrayFunction( n);

            //Printinh generated massive
            print(a);

            for (int i = 0; i < n; i++) //sort
            {
                Array.Sort(a[i]);
            }
            
            Console.WriteLine("Отсортированный массив");
            print(a);
            Console.ReadKey();
            #endregion


        }
    }
}
