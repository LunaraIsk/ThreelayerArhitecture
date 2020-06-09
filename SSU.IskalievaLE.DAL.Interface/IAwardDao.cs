﻿using SSU.IskalievaLE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSU.IskalievaLE.DAL.Interface
{
    public interface IAwardDao
    {
        int AddAward(Award award);
        IEnumerable<Award> GetAllAwards();
    }
}
