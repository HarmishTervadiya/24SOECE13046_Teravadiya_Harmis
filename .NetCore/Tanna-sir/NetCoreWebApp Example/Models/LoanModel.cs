using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;

namespace NetCoreWebApp_Example.Models
{
    public class LoanModel
    {
        private string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\24SOECE13046_Harmis_Teravadiya\\.NetCore\\Tanna-sir\\NetCoreWebApp Example\\App_Data\\Database.mdf\";Integrated Security=True";
        [Required(ErrorMessage = "*")]
        public int LoanNo { get; set; }
        [Required(ErrorMessage = "*")]
        public int AccountNo { get; set; }
        [Required(ErrorMessage = "*")]
        public int Amount { get; set; }
        [Required(ErrorMessage = "*")]
        public string LoanType { get; set; }
        [Required(ErrorMessage = "*")]
        public string LoanCategory { get; set; }
        [Required(ErrorMessage = "*")]
        public string CurrentAddress { get; set; }
        [Required(ErrorMessage = "*")]
        public string LoanRemarks { get; set; }

        public List<LoanModel> getData()
        {
            var result = new List<LoanModel>();
            string query = "SELECT * FROM Loan";

            using (var con = new SqlConnection(conString))
            using (var adapter = new SqlDataAdapter(query, con))
            {
                var ds = new DataSet();
                adapter.Fill(ds);

                if (ds.Tables.Count == 0) return result;

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    var obj = new LoanModel();

                    obj.LoanNo = Convert.ToInt32(dr["LoanNo"]);
                    obj.AccountNo = Convert.ToInt32(dr["AccountNo"]);
                    obj.Amount = Convert.ToInt32(dr["Amount"]);
                    obj.LoanType = dr["LoanType"].ToString();
                    obj.LoanCategory =dr["LoanCategory"].ToString();
                    obj.CurrentAddress =dr["CurrentAddress"].ToString();
                    obj.LoanRemarks =dr["LoanRemarks"].ToString();

                    result.Add(obj);
                }
            }

            return result;
        }
    }
}
