using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask02_8
{
    class Mead: IBonus
    {
        #region override intefrace methods
        public void BonusAquire()
        {
            Console.WriteLine("Nord mead still  the best drink :P. Stamina restored");
        }
        #endregion
    }
}
