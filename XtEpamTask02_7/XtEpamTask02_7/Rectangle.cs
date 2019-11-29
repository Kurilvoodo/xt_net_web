using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask02_7
{
    class Rectangle : IFigure
    {
        #region Firleds and propoerties
        private double _width;
        private double _height;
        public double Width
        {
            get
            {
                return _width;
            }

            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    throw new Exception("Width of rectangle can't be negative or beloew Zero");
                }
            }
        }
        public double Height
        {
            get
            {
                return _height;
            }

            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    throw new Exception("Height of rectangle can't be negative or beloew Zero");
                }
            }
        }
        public double Square
        {
            get
            {
                return Height * Width;
            }

        }
        public double Perimeter
        {
            get
            {
                return Height*2+Width*2;
            }
        }
        #endregion
        #region Constructor
        public Rectangle(double h, double w)
        {
            Height = h;
            Width = w;
        }

        #endregion
        #region Interface override 
        public void ShowObject()
        {
            Console.WriteLine("A rectangle with height {0} and width {1} has been created", Height, Width);
        }
        #endregion
    }
}
