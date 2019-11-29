using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask02_7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<IFigure> keeper = new List<IFigure>();
            keeper.Add(new Line(new System.Drawing.Point(2, 3), new System.Drawing.Point(5, 4)));
            keeper.Add(new Rectangle(4, 17));
            keeper.Add(new Circle(6,6,10));
            keeper.Add(new Round(0,12,3));
            keeper.Add(new Ring(12,0,3,2.5));
            foreach (IFigure item in keeper)
            {
                item.ShowObject();
            }

            Console.ReadLine();
        }
    }
}
