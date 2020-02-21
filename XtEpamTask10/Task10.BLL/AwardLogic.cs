using System;
using System.Collections.Generic;
using System.Text;
using Task10.BLL.Interfaces;
using Task10.Dao.Interfaces;
using Task10.Entities;

namespace Task10.BLL
{
    public class AwardLogic : IAwardLogic
    {
        private static IAwardDao _awardDao;
        public AwardLogic(IAwardDao awardDao)
        {
            _awardDao = awardDao;
        }
        public void Add(Award award)
        {
            _awardDao.Add(award);
        }
        public void Remove(int id)
        {
            _awardDao.Remove(id);
        }
        public Award GetById(int id)
        {
            return _awardDao.GetById(id);
        }
        public IEnumerable<Award> GetAll()
        {
            return _awardDao.GetAll();
        }
    }
}
