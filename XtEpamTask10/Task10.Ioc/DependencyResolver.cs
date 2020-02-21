using System;
using Task10.BLL;
using Task10.BLL.Interfaces;
using Task10.Dao.Interfaces;
using Task10.DAL;

namespace Task10.Ioc
{
    public static class DependencyResolver
    {
        private static IUserDao _userDao;
        private static IUserDao UserDao => _userDao ?? (_userDao = new UserFakeDao());


        private static IUserLogic _userLogic;
        public static IUserLogic UserLogic => _userLogic ?? (_userLogic = new UserLogic(UserDao));

        private static IAwardDao _awardDao;
        private static IAwardDao AwardDao => _awardDao ?? (_awardDao = new AwardFakeDao());


        private static IAwardLogic _awardLogic;
        public static IAwardLogic AwardLogic => _awardLogic ?? (_awardLogic = new AwardLogic(AwardDao));


    }
}
