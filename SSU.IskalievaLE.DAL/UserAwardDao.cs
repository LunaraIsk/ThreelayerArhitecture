using SSU.IskalievaLE.DAL.Interface;
using SSU.IskalievaLE.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSU.IskalievaLE.DAL
{
    public class UserAwardDao: IUserAwardDao
    {
        private string connnectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=UsersAwards;Integrated Security=True";

        public IEnumerable<UserAward> GetAllUsersAwards()
        {
            var result = new List<UserAward>();
            using (SqlConnection connection = new SqlConnection(connnectionString))
            {
                SqlCommand cmd = new SqlCommand("GetAll", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var useraward = new UserAward
                    {
                        Id_user = (int)reader["Id_users"],
                        Id_award = (int)reader["Id_awards"]
                    };

                    result.Add(useraward);
                }
            }

            return result;
        }
    }
}
