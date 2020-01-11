using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XtEpamTask06.BLL;
using XtEpamTask06.BLL.Interfaces;
using XtEpamTask06.DAL;
using XtEpamTask06.Dao.Interfaces;

namespace XtEpamTask06.Ioc
{
    public static class Dependency
    {
        private static IUserDao _userDao;
        public static IUserDao UserDao => _userDao ?? (_userDao = new UserFakeDao());

        private static IUserLogic _userLogic;
        public static IUserLogic UserLogic => _userLogic ?? (_userLogic = new UserLogic(UserDao));

    }
}
