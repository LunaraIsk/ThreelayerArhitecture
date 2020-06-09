using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSU.IskalievaLE.Entities
{
    public class User
    {
        public int IdUser { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{IdUser} {FirstName} {LastName} {DateOfBirth} {Age}";
        }

    }
}
