using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask02_7
{
    class Ring: Round, IFigure
    {
        #region Fields and properties
        private double _innerRadius;
        public double InnerRadius
        {
            get 
            {
                return _innerRadius;
            }

            set
            {

                if (value < Radius && value > 0)
                {
                    _innerRadius = value;
                }
                else
                {
                    throw new Exception("Error, inner Radius can't be negative or bigger than normal Radius");
                }
            }
        }
        public new double Square
        {
            get
            {
                return Math.Pow(_innerRadius, 2) * Math.PI;
            }

        }
        public double RingSquare
        {
            get
            {
                return base.Square - Square;
            }
        }
        public new double LengthOfRing
        {
            get
            {
                return 2 * _innerRadius * Math.PI;
            }
        }
        #endregion
        #region Constructor
        public Ring(double x, double y, double radius, double inner_radius) :
           base(x, y, radius)
        {
            InnerRadius = inner_radius;
        }
        #endregion
        public new void ShowObject()
        {
            Console.WriteLine("Ring with radius {0} and inner radius {1} at place X= {2} Y= {3} and square {4}",
                Radius, InnerRadius,X,Y, RingSquare );
        }
    }
}
