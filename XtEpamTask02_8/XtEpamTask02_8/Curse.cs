using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask02_8
{
    class Curse: IBonus
    {
        public void BonusAquire()
        {
            Console.WriteLine("You weapon has been cursed for next three fight states :c");
        }
    }
}
