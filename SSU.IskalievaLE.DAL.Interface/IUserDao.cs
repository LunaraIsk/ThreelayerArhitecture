using SSU.IskalievaLE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSU.IskalievaLE.DAL.Interface
{
    public interface IUserDao
    {
        int AddUser(User user);

        void DeleteUser(int id);

        IEnumerable<User> GetAllUsers();

        //Dictionary<User, Award> GetAllUsersAndAwards();
    }
}
