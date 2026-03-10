using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;

namespace NetCoreWebApp_Example.Models
{
    public class AccountModel
    {
        private string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\24SOECE13046_Harmis_Teravadiya\\.NetCore\\Tanna-sir\\NetCoreWebApp Example\\App_Data\\Database.mdf\";Integrated Security=True";

        [Key]
        public int savingsActNo { get; set; }
        public string actHolderName { get; set; }
        public string profession {  get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }

        public List<AccountModel> getData()
        {
            var result = new List<AccountModel>();
            string query = "SELECT * FROM Account";

            using (var con = new SqlConnection(conString))
            using (var adapter = new SqlDataAdapter(query, con))
            {
                var ds = new DataSet();
                adapter.Fill(ds);

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    result.Add(new AccountModel
                    {
                        savingsActNo = Convert.ToInt32(dr["savingsActNo"]),
                        actHolderName = dr["actHolderName"].ToString(),
                        profession = dr["profession"].ToString(),
                        Email = dr["Email"].ToString(),
                        ContactNo = dr["ContactNo"].ToString()
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
                    cmd.CommandText = "INSERT INTO Account (savingsActNo, actHolderName, profession, Email, ContactNo) VALUES (@savingsActNo, @actHolderName, @profession, @Email, @ContactNo)";
                    cmd.Parameters.AddWithValue("@savingsActNo", savingsActNo);
                    cmd.Parameters.AddWithValue("@actHolderName", actHolderName ?? "");
                    cmd.Parameters.AddWithValue("@profession", profession ?? "");
                    cmd.Parameters.AddWithValue("@Email", Email ?? "");
                    cmd.Parameters.AddWithValue("@ContactNo", ContactNo ?? "");

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch { return false; }
        }

        public bool Update()
        {
            try
            {
                using (var con = new SqlConnection(conString))
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Account SET actHolderName = @actHolderName, profession = @profession, Email = @Email, ContactNo = @ContactNo WHERE savingsActNo = @savingsActNo";
                    cmd.Parameters.AddWithValue("@savingsActNo", savingsActNo);
                    cmd.Parameters.AddWithValue("@actHolderName", actHolderName ?? "");
                    cmd.Parameters.AddWithValue("@profession", profession ?? "");
                    cmd.Parameters.AddWithValue("@Email", Email ?? "");
                    cmd.Parameters.AddWithValue("@ContactNo", ContactNo ?? "");

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch { return false; }
        }

        public bool Delete(int actNo)
        {
            try
            {
                using (var con = new SqlConnection(conString))
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Account WHERE savingsActNo = @actNo";
                    cmd.Parameters.AddWithValue("@actNo", actNo);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch { return false; }
        }

        public AccountModel GetByAccountNo(int actNo)
        {
            string query = "SELECT * FROM Account WHERE savingsActNo = @actNo";
            using (var con = new SqlConnection(conString))
            using (var cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@actNo", actNo);
                con.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new AccountModel
                        {
                            savingsActNo = Convert.ToInt32(reader["savingsActNo"]),
                            actHolderName = reader["actHolderName"].ToString(),
                            profession = reader["profession"].ToString(),
                            Email = reader["Email"].ToString(),
                            ContactNo = reader["ContactNo"].ToString()
                        };
                    }
                }
            }
            return null;
        }
    }
}
