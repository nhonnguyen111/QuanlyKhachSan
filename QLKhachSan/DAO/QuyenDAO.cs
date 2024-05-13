using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLKhachSan.DAO
{
    public class QuyenDAO
    {
        private static QuyenDAO instance;
        public static QuyenDAO Instance
        {
            get { if (instance == null) instance = new QuyenDAO(); return instance; }
            private set { instance = value; }
        }
        public QuyenDAO() { }
        public List<Quyen> GetListQuyen()
        {
            List<Quyen> queyns = new List<Quyen>();
            string query = "select * from Quyen a, TaiKhoan b WHERE a.type = b.idQuyen";
            DataTable data = DataProvider.Instance.ExecuQuery(query);
            foreach (DataRow row in data.Rows)
            {
                Quyen quyen = new Quyen(row);
                queyns.Add(quyen);
            }
            return queyns;
        }
        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuQuery("SELECT a.UserName , a.DisplayName, a.idQuyen , b.TenQuyen FROM TaiKhoan a, Quyen b WHERE a.idQuyen = b.Type");
        }
        public bool InsertTaiKhoan(string userName, string displayName, int idquyen, string password)
        {
            string query = string.Format("INSERT dbo.TaiKhoan (Username ,DisplayName, idQuyen,PassWord)VALUES (N'{0}',N'{1}',{2},N'{3}')", userName, displayName, idquyen, password);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool UpdateTaiKhoan( string displayName, int idquyen,string userName)
        {
            string query = string.Format("UPDATE TaiKhoan SET DisplayName =N'{0}', idQuyen ={1} WHERE UserName = N'{2}'",displayName, idquyen, userName );
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool DeleteTaiKhoan(string username)
        {
            
            string query = string.Format("DELETE TaiKhoan WHERE UserName = N'{0}'", username);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool ResetPassword(string username)
        {

            string query = string.Format("UPDATE TaiKhoan SET PassWord = N'0' WHERE UserName = N'{0}'", username);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
    }
}
