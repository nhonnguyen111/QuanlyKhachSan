using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DAO
{
    public class PayDAO
    {
        private static PayDAO instance;
        public static PayDAO Instance
        {
            get { if (instance == null) instance = new PayDAO(); return instance; }
            private set { instance = value; }
        }
        public PayDAO() { }
        public List<Pay> GetBillList()
        {
            List<Pay> dsbill = new List<Pay>();
            string query = "SELECT b.DateCheckIn, b.DateCheckOut, b.id, p.name, b.status, b.discount,b.totalprice FROM Bill b, Phong p WHERE b.idPhong = p.id\r\n";
            DataTable data = DataProvider.Instance.ExecuQuery(query);
            foreach (DataRow row in data.Rows)
            {
                Pay bill = new Pay(row);
                dsbill.Add(bill);
            }
            return dsbill;
        }
        public List<Pay> SearchPayByName(string tenphong)
        {
            List<Pay> pays = new List<Pay>();
            string query = string.Format("SELECT b.DateCheckIn, b.DateCheckOut, b.id, p.name, b.status, b.discount,b.totalprice FROM Bill b, Phong p WHERE LOWER(p.name) COLLATE Latin1_General_CI_AI LIKE '%' + LOWER(N'{0}') + '%' AND b.idPhong = p.id;", tenphong);
            DataTable data = DataProvider.Instance.ExecuQuery(query);
            foreach (DataRow row in data.Rows)
            {
                Pay pay = new Pay(row);
                pays.Add(pay);
            }
            return pays;
        }
    }
}
