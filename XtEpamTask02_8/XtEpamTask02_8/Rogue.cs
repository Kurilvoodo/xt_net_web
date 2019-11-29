using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask02_8
{
    class Rogue : IEnemy
    {
        #region override intefrace methods
        public void MoveTo()
        { }
        public void DeathGrisp()
        {
            Console.WriteLine("My brothers *caugh* will come *caugh*, after... you anyway...*sigh*");
        }
        #endregion
    }
}
