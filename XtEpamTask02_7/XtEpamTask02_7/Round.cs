using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask02_7
{
    internal class Round: Circle,IFigure
    {

        #region Properties 
        public double Square
        {
            get
            {
                return Math.Pow(Radius, 2) * Math.PI;
            }

        }
        public double LengthOfRing
        {
            get
            {
                return 2 * Radius * Math.PI;
            }
        }
        #endregion
        #region Counstructor Round()
        public Round(double x, double y,double radius) : base(x,y,radius)
        {}
        
        #endregion
        public new void ShowObject() // there was a cnoflict so we have to override it for polymorph
        {
            Console.WriteLine("Round with coloered Square with radius {0} at place X = {1} Y = {2} has been created" 
                ,Radius, X, Y);
        }

    }
}
