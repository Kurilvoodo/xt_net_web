using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 2.1
            Console.WriteLine("Task 2.1"+ Environment.NewLine);
            Round test1 = new Round(); // Creating of empty object and calling the base constractor
            test1.X = -212.0; //demonstration of property field _x
            
            Console.WriteLine($"The round has been created {test1.X} {test1.Y} {test1.Radius}"); //demostration of all fileds property, while they're private in class
            Console.WriteLine($"Property of Round Class for Square {test1.Square}" + Environment.NewLine + $" And Length of circle is {test1.LengthOfRing}");

            Console.WriteLine("Now it's your turn to have fun with a Round" + Environment.NewLine +
                "First type of constractor is Round(double,double,double)");
            double enter1, enter2, enter3;
            Console.Write("X = ");
            if (double.TryParse(Console.ReadLine(), out enter1))
            {

            }
            else
            {
                Console.WriteLine("Incorrect input" + Environment.NewLine);
            }
            Console.Write("Y = ");
            if (double.TryParse(Console.ReadLine(), out enter2))
            {

            }
            else
            {
                Console.WriteLine("Incorrect input" + Environment.NewLine);
            }
            Console.Write("Radius = ");
            if (double.TryParse(Console.ReadLine(), out enter3))
            {

            }
            else
            {
                Console.WriteLine("Incorrect input" + Environment.NewLine);
            }

            Round test2 = new Round(enter1,enter2,enter3);
            Console.WriteLine($"The round has been created {test1.X} {test1.Y} {test1.Radius}" +  Environment.NewLine);
            Console.WriteLine($"Property of Round Class for Square {test1.Square}" + Environment.NewLine + $" And Length of circle is {test1.LengthOfRing}");
            Console.WriteLine("You can also switch change some parameters if you want to.");
            
                
                
            Console.Write("X = ");
            if (double.TryParse(Console.ReadLine(), out enter1))
            {
                test2.X =enter1;
            }
            else
            {
                Console.WriteLine("Incorrect input" + Environment.NewLine);
            }
            Console.Write("Y = ");
            if (double.TryParse(Console.ReadLine(), out enter2))
            {
                test2.Y =enter2;
            }
            else
            {
                Console.WriteLine("Incorrect input" + Environment.NewLine);
            }
            Console.Write("Radius = ");
            if (double.TryParse(Console.ReadLine(), out enter3))
            {
                test2.Radius =enter3;
            }
            else
            {
                Console.WriteLine("Incorrect input" + Environment.NewLine);
            }
            Round test3 = new Round(enter1,enter2); // x and y counstructor
            Round test4 = new Round(enter3);// radius constructor
            Round test5 = new Round(test1); //class constructor

            Console.WriteLine("And of course we have operators oevrrideda ass ++ added +1 to radius and -- decreasing it on 1 as well");
            test1++;
            test2++;
            test3++;
            test4++;
            test5++;
            Console.WriteLine($"{test1.Radius} {test2.Radius} {test3.Radius} {test4.Radius} {test5.Radius}" + Environment.NewLine);
            test1--;
            test2--;
            test3--;
            test4--;
            test5--;
            Console.WriteLine($"{test1.Radius} {test2.Radius} {test3.Radius} {test4.Radius} {test5.Radius}" + Environment.NewLine);
            #endregion

            #region Task 2.2
            Console.WriteLine("Task 2.2"+ Environment.NewLine);
            Triangle Hi = new Triangle();
            Console.WriteLine("Propertys {0} {1} {2} Square {3} Perimter {4}",Hi.A, Hi.B, Hi.C, Hi.Square,Hi.Perimetr + Environment.NewLine);
            Console.Write("Side a = ");
            if (double.TryParse(Console.ReadLine(), out enter1))
            {

            }
            else
            {
                Console.WriteLine("Incorrect input" + Environment.NewLine);
            }
            Console.Write("Side b = ");
            if (double.TryParse(Console.ReadLine(), out enter2))
            {

            }
            else
            {
                Console.WriteLine("Incorrect input" + Environment.NewLine);
            }
            Console.Write("Side c = ");
            if (double.TryParse(Console.ReadLine(), out enter3))
            {

            }
            else
            {
                Console.WriteLine("Incorrect input" + Environment.NewLine);
            }
            Triangle Hi2 = new Triangle(enter1,enter2,enter3);
            Console.WriteLine("Propertys {0} {1} {2} Square {3} Perimter {4}", Hi.A, Hi.B, Hi.C, Hi.Square, Hi.Perimetr + Environment.NewLine);
            #endregion

            #region Task 2.3
            Console.WriteLine("Task 2.3" + Environment.NewLine);
            List<User> Users = new List<User>();
            using (StreamReader sr = new StreamReader("input_2_3.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string [] tmp = line.Split(' ');
                    User keeper = new User(tmp[0], tmp[1], tmp[2], 
                        new DateTime(int.Parse(tmp[3]), int.Parse(tmp[4]), int.Parse(tmp[5]) ) );
                    Users.Add(keeper);


                }
            }
            foreach (User item in Users)
            {
                Console.WriteLine("{0}", item.ToString() + Environment.NewLine);
            }
            User keepOne = new User("Rivian","Geralt","Vesemirovich", new DateTime(1237,2,7));
            User keepTwo = new User("Zhidkovksy", "Evgeniy", "ChortEgoZnaet", new DateTime(1989, 2, 3));
            Console.WriteLine("Age of {0}{1}{2} is {3}" + Environment.NewLine +
                "Age of {4}{5}{6} is {7}", keepOne.Name, keepOne.Surname, keepOne.Otch,keepOne.Age, keepTwo.Name, keepTwo.Surname, keepTwo.Otch, keepTwo.Age);
            Users.Add(keepOne);
            Users.Add(keepTwo);
            #endregion
            #region Task 2.4

            #endregion
            Console.ReadLine();

        }
    }
}
