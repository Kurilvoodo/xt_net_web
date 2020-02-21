using System;
using Task10.Dao.Interfaces;
using Task10.Entities;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Task10.DAL
{
    public class UserFakeDao : IUserDao
    {
        private static Dictionary<int, User> _users = new Dictionary<int, User>();
        public void Add(User user)
        {
            int lastKey = _users.Keys.LastOrDefault();
            user.Id = lastKey + 1;
            _users.Add(user.Id, user);
        }
        public void Remove(int id)
        {
            _users.Remove(id);
        }

        public User GetById(int id)
        {
            try 
            {
                return _users[id];
            }
            catch(KeyNotFoundException)
            {
                return null;
            }
        }
        public IEnumerable<User> GetAll()
        {
            return _users.Values;
        }
        public void Reward(int userId, Award award)
        {
            GetById(userId).Awards.Add(award);
        }
    }
}
