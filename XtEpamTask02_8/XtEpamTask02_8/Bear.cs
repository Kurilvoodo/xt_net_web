using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask02_8
{
    class Bear: IEnemy
    {
        #region override intefrace methods
        public void MoveTo()
        { }
        public void DeathGrisp()
        {
            Console.WriteLine("*One a bear languae* don't toch... the honey");
        }
        #endregion
    }
}
