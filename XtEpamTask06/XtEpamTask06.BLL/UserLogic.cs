using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XtEpamTask06.XtEpamTask06.BLL
{
    public class UserLogic : IUserLogic
    {
        private static IUserDao _userDao;

        public UserLogic(IUserDao userDao)
        {
            _userDao = userDao;
        }

        public void Add(User user)
        {
            _userDao.Add(user);
        }

        public void Remove(int id)
        {
            _userDao.Remove(id);
        }

        public User GetById(int id)
        {
            return _userDao.GetById(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _userDao.GetAll();
        }

        
    }
}
