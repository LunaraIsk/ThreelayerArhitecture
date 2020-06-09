using SSU.IskalievaLE.BLL.Interface;
using SSU.IskalievaLE.DAL;
using SSU.IskalievaLE.DAL.Interface;
using SSU.IskalievaLE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSU.IskalievaLE.BLL
{
    public class UserAwardLogic: IUserAwardLogic
    {
        private readonly IUserAwardDao _userawardDao;
        public UserAwardLogic()
        {
            this._userawardDao = new UserAwardDao();
        }
        public IEnumerable<UserAward> GetAllUsersAwards()
        {
            return this._userawardDao.GetAllUsersAwards();
        }
    }
}
