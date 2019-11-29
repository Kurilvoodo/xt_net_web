using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask02_7
{
    class Line: IFigure
    {
        #region Fileds and property
        private Point _first; 
        public Point First
        {
            get
            {
                return _first;
            }
            set
            {
                if (Second.X != value.X && Second.Y != value.Y)
                {
                    _first = value;
                }
                else
                {
                    throw new Exception("Line can't exist with equal points");
                }
            }
        }
        private Point _second;
        public Point Second
        {
            get
            {
                return _second;
            }
            set
            {
                if (First.X != value.X && First.Y!= value.Y)
                {
                    _second = value;
                }
                else
                {
                    throw new Exception("Line can't exist with equal points");
                }
            }
        }

        #endregion
        #region Methods
        public double LineLength()
        {
            return Math.Abs( Math.Sqrt( Math.Pow( (Second.X-First.X) ,2 ) + Math.Pow( (Second.Y - Second.Y), 2 ) ) );
        }
        #endregion
        #region Constructor
        public Line(Point one, Point two)
        {
            First = one;
            Second = two;
        }
        #endregion
        #region Interface Override method
        public void ShowObject()
        {
            Console.WriteLine("Line between point {0} and {1} is drawn", First.ToString(), Second.ToString());
        }
        #endregion
    }
}
