using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask06.BLL.Intefraces
{
    public interface IUserLogic
    {
        void Add(User user);

        void Remove(int id);

        User GetById(int id);

        IEnumerable<User> GetAll();

        
    }
}
