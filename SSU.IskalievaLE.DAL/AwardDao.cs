using SSU.IskalievaLE.DAL.Interface;
using SSU.IskalievaLE.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSU.IskalievaLE.DAL
{
    public class AwardDao: IAwardDao
    {
        private string connnectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=UsersAwards;Integrated Security=True";

        public int AddAward(Award value)
        {
            using (SqlConnection connection = new SqlConnection(connnectionString))
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "AddAward";

                cmd.Parameters.Add(new SqlParameter("@Title", value.Title));
                connection.Open();

                return (int)(decimal)cmd.ExecuteScalar();
            }
        }


        public IEnumerable<Award> GetAllAwards()
        {
            var result = new List<Award>();
            using (SqlConnection connection = new SqlConnection(connnectionString))
            {
                SqlCommand cmd = new SqlCommand("GetAllAwards", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var award = new Award
                    {
                        IdAward = (int)reader["IdAward"],
                        Title = (string)reader["Title"]
                    };

                    result.Add(award);
                }
            }

            return result;
        }
    }
}
