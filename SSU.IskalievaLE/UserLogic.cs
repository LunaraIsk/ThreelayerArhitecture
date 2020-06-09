using SSU.IskalievaLE.BLL.Interface;
using SSU.IskalievaLE.DAL;
using SSU.IskalievaLE.DAL.Interface;
using SSU.IskalievaLE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSU.IskalievaLE
{
    public class UserLogic: IUserLogic
    {
        private readonly IUserDao _userDao;
        public UserLogic()
        {
            this._userDao = new UserDao();
        }
        public int AddUser(User user)
        {
            return this._userDao.AddUser(user);
        }

        public void DeleteUser(int id)
        {
            _userDao.DeleteUser(id);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return this._userDao.GetAllUsers();
        }
    }
}
