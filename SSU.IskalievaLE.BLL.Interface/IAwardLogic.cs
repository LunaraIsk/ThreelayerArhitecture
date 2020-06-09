using SSU.IskalievaLE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSU.IskalievaLE.BLL.Interface
{
    public interface IAwardLogic
    {
        int AddAward(Award award);

        IEnumerable<Award> GetAllAwards();
    }
}
