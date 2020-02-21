using System;
using System.Collections.Generic;
using System.Text;
using Task10.Entities;

namespace Task10.Dao.Interfaces
{
    public interface IUserDao
    {
        void Add(User user);

        void Remove(int id);

        User GetById(int id);
        IEnumerable<User> GetAll();
        void Reward(int userId, Award award);
    }
}
