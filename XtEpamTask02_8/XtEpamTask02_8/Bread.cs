using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask02_8
{
    class Bread: IBonus
    {
        public void BonusAquire()
        {
            Console.WriteLine("You eat the Bread, Yummy. 5 HP restored");
        }
    }
}
