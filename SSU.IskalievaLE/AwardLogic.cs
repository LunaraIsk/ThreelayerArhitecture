using SSU.IskalievaLE.BLL.Interface;
using SSU.IskalievaLE.DAL;
using SSU.IskalievaLE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSU.IskalievaLE
{
    public class AwardLogic: IAwardLogic
    {
        private readonly AwardDao _awardDao;
        public AwardLogic()
        {
            this._awardDao = new AwardDao();
        }
        public int AddAward(Award award)
        {
            return this._awardDao.AddAward(award);
        }

        public IEnumerable<Award> GetAllAwards()
        {
            return this._awardDao.GetAllAwards();
        }
    }
}
