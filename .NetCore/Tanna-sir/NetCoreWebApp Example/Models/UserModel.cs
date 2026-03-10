using System.Data;
using System.Data.SqlClient;

namespace NetCoreWebApp_Example.Models
{
    public class UserModel
    {
        private string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\24SOECE13046_Harmis_Teravadiya\\.NetCore\\Tanna-sir\\NetCoreWebApp Example\\App_Data\\Database.mdf\";Integrated Security=True";

        public string UserEmail { get; set; }
        public string passowrd {  get; set; }

        public List<UserModel> getData()
        {
            var result = new List<UserModel>();
            string query = "SELECT * FROM [User]";

            using (var con = new SqlConnection(conString))
            using (var adapter = new SqlDataAdapter(query, con))
            {
                var ds = new DataSet();
                adapter.Fill(ds);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    result.Add(new UserModel
                    {
                        UserEmail = dr["UserEmail"].ToString(),
                        passowrd = dr["passowrd"].ToString()
                    });
                }
            }
            return result;
        }

        public bool Insert()
        {
            try
            {
                using (var con = new SqlConnection(conString))
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO [User] (UserEmail, passowrd) VALUES (@UserEmail, @passowrd)";
                    cmd.Parameters.AddWithValue("@UserEmail", UserEmail);
                    cmd.Parameters.AddWithValue("@passowrd", passowrd);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch { return false; }
        }

        public bool Update(string oldEmail)
        {
            try
            {
                using (var con = new SqlConnection(conString))
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "UPDATE [User] SET UserEmail = @UserEmail, passowrd = @passowrd WHERE UserEmail = @oldEmail";
                    cmd.Parameters.AddWithValue("@UserEmail", UserEmail);
                    cmd.Parameters.AddWithValue("@passowrd", passowrd);
                    cmd.Parameters.AddWithValue("@oldEmail", oldEmail);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch { return false; }
        }

        public bool Delete(string email)
        {
            try
            {
                using (var con = new SqlConnection(conString))
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM [User] WHERE UserEmail = @email";
                    cmd.Parameters.AddWithValue("@email", email);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch { return false; }
        }

        public UserModel GetByEmail(string email)
        {
            string query = "SELECT * FROM [User] WHERE UserEmail = @email";
            using (var con = new SqlConnection(conString))
            using (var cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@email", email);
                con.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new UserModel
                        {
                            UserEmail = reader["UserEmail"].ToString(),
                            passowrd = reader["passowrd"].ToString()
                        };
                    }
                }
            }
            return null;
        }
    }
}
