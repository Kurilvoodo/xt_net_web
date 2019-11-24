using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask02
{
    class Round
    {
        private float x;
        public float X
        {
            get 
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        private float y;
        public float Y
        {
            get 
            {
                return y; 
            }
            set 
            {
                y = value;
            }
        }
        private float raduis;
        public float Raduis
        {
            get 
            {
                return raduis;
            }
            set 
            {
                if (value > 0)
                {
                    raduis = value;
                }
                else 
                {
                    throw new Exception("Radius can't be negative");
                }
                
            }
        }



    }
}
