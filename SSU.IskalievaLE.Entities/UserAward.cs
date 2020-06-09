using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSU.IskalievaLE.Entities
{
    public class UserAward
    {
        public int Id_user { get; set; }

        public int Id_award { get; set; }

        public override string ToString()
        {
            return $"{Id_user} {Id_award}";
        }
    }
}
