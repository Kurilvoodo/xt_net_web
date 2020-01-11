using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XtEpamTask06.BLL;
using XtEpamTask06.Entities;
using XtEpamTask06.Ioc;

namespace XtEpamTask06.PL
{
    class Program
    {
        static void Main(string[] args)
        {
            var _userLogic = Dependency.UserLogic;
            

            
            _userLogic.Add(new User("Ivan", new DateTime(2000, 3, 16)));
            _userLogic.Add(new User("Anton", new DateTime(2002, 7, 23)));
            _userLogic.Add(new User("Anna", new DateTime(1993, 1, 12)));
            _userLogic.Add(new User("Andrey", new DateTime(1995, 12, 1)));

         
            foreach (var user in _userLogic.GetAll())
            {
                Console.WriteLine(user.ToString());
            }
        }
    }
}
