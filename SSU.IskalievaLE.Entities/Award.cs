﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSU.IskalievaLE.Entities
{
    public class Award
    {
        public int IdAward { get; set; }

        public string Title { get; set; }

        public override string ToString()
        {
            return $"{IdAward} {Title}";
        }


    }
}
