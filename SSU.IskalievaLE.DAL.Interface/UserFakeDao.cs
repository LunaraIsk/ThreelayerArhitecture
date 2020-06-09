using SSU.IskalievaLE.DAL.Interface;
using SSU.IskalievaLE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSU.IskalievaLE.DAL.Interface
{
    public class UserFakeDao: IUserDao
    {
        private static Dictionary<int, User> _repoUsers;

        public UserFakeDao()
        {
            _repoUsers = new Dictionary<int, User>();
        }
        public int AddUser(User user)
        {
            var lastId = _repoUsers.Any() ? _repoUsers.Keys.Max() : 0;
            user.IdUser = ++lastId;
            _repoUsers.Add(user.IdUser, user);
            return user.IdUser;
        }

        public void DeleteUser(int id)
        {
            //return _repoUsers.Remove(id);
            _repoUsers.Remove(id);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _repoUsers.Values;
        }

    }
}
