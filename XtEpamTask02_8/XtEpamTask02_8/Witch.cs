using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask02_8
{
    class Witch: IEnemy
    {
        public void MoveTo()
        { }
        public void DeathGrisp()
        {
            Console.WriteLine("I'll die, but my curses continue to live!");
        }
    }
}
