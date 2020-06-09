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
    public class UserDao: IUserDao
    {
        private string connnectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=UsersAwards;Integrated Security=True";

        public int AddUser(User value)
        {
            using (SqlConnection connection = new SqlConnection(connnectionString))
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "AddUser";

                cmd.Parameters.Add(new SqlParameter("@FirstName", value.FirstName));
                cmd.Parameters.Add(new SqlParameter("@LastName", value.LastName));
                cmd.Parameters.Add(new SqlParameter("@DateOfBirth", value.DateOfBirth));
                cmd.Parameters.Add(new SqlParameter("@Age", value.Age));

                connection.Open();


                return (int)(decimal)cmd.ExecuteScalar();
            }
        }

        public void DeleteUser(int value)
        {
            using (SqlConnection connection = new SqlConnection(connnectionString))
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteUser";

                cmd.Parameters.Add(new SqlParameter("@IdUser", value));

                connection.Open();

                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<User> GetAllUsers()
        {
            var result = new List<User>();
            using (SqlConnection connection = new SqlConnection(connnectionString))
            {
                SqlCommand cmd = new SqlCommand("GetAllUsers", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var user = new User
                    {
                        IdUser = (int)reader["IdUser"],
                        FirstName = (string)reader["FirstName"],
                        LastName = (string)reader["LastName"],
                        DateOfBirth = (DateTime)reader["DateOfBirth"],
                        Age = (int)reader["Age"]
                    };

                    result.Add(user);
                }
            }

            return result;
        }


    }
}
