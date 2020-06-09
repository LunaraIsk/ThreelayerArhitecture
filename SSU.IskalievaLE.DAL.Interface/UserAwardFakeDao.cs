using SSU.IskalievaLE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSU.IskalievaLE.DAL.Interface
{
    public class UserAwardFakeDao: IUserAwardDao
    {
        private static List<UserAward> _repoUsersAwards;

        public UserAwardFakeDao()
        {
            _repoUsersAwards = new List<UserAward>();
        }
        public IEnumerable<UserAward> GetAllUsersAwards()
        {
            return _repoUsersAwards.ToList();
        }
    }
}
