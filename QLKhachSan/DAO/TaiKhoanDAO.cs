using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return instance; }
            private set { instance = value; }
        }
        private TaiKhoanDAO() { }
        public bool Login(string userName, string passWord)
        {



            string query = "select * from TaiKhoan where UserName = N'" + userName + "' and PassWord = N'" + passWord + "'";
            DataTable result = DataProvider.Instance.ExecuQuery(query, new object[] { userName, passWord });
            return result.Rows.Count > 0;
        }
       
        public TaiKhoan GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuQuery("SELECT * FROM TaiKhoan WHERE UserName = '" + userName + "'");
            foreach (DataRow item in data.Rows)
            {
                return new TaiKhoan(item);
            }
            return null;
        }
        
        public bool UpdateAccount(string username, string displayname, string pass, string newpass)
        {
            using (SqlConnection connection = new SqlConnection(DataProvider.Instance.connectionData))
            {
                using (SqlCommand command = new SqlCommand("USP_UpdateTaiKhoan", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@userName", username);
                    command.Parameters.AddWithValue("@displayName", displayname);
                    command.Parameters.AddWithValue("@passWord", pass);
                    command.Parameters.AddWithValue("@newPassword", newpass);

                    connection.Open();
                    int affectedRows = command.ExecuteNonQuery();

                    return affectedRows > 0;
                }
            }
        }
    }
}