using SSU.IskalievaLE.DAL.Interface;
using SSU.IskalievaLE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSU.IskalievaLE.DAL.Interface
{
    public class AwardFakeDao: IAwardDao
    {
        private static Dictionary<int, Award> _repoAwards;

        public AwardFakeDao()
        {
            _repoAwards = new Dictionary<int, Award>();
        }
        public int AddAward(Award award)
        {
            var lastId = _repoAwards.Any() ? _repoAwards.Keys.Max() : 0;
            award.IdAward = ++lastId;
            _repoAwards.Add(award.IdAward, award);
            return award.IdAward;
            
        }

        public IEnumerable<Award> GetAllAwards()
        {
            return _repoAwards.Values;
        }
    }
}
