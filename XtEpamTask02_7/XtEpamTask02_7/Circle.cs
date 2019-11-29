using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask02_7
{
    class Circle : IFigure
    {
        #region Fields and properties
        private double _radius;
        private double _x;
        private double _y;
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                if (value > 0)
                {
                    _radius = value;
                }
                else
                {
                    throw new Exception("Radius of Circle can't be negative or beloew zero");
                }
            }
        }
         
        public double X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        public double Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
        #endregion
        #region Constructor
        public Circle(double x, double y,double radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }
        #endregion
        public void ShowObject()
        {
            Console.WriteLine("Circle with radius {0}at place x= {1}, y={2}", Radius, X, Y);
        }
    }
}
