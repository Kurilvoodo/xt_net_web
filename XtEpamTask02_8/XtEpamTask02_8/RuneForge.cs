using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask02_8
{
    class RuneForge: IBonus
    {
        #region override intefrace methods
        public void BonusAquire()
        {
            // Player object RuneCounter++;
            Console.WriteLine("Might of a weapon imvroved by old runes");
        }
        #endregion
    }
}
