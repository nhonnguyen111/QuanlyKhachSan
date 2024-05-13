using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return instance; }
            private set { instance = value; }
        }
        public BillInfoDAO() { }
        public void DeleteBillInfoRoom(int id)
        {
            DataProvider.Instance.ExecuQuery("DELETE dbo.BillInfo WHERE idPhong = " + id);
        }
        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> list = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExecuQuery("SELECT * FROM dbo.BillInfo WHERE idBill = " + id);
            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                list.Add(info);
            }
            return list;

        }
        public void InserBillInfo(int idBill, int idDichvu, int count)
        {
            string query = $"EXEC USP_InsertBillInfo @idBill={idBill}, @idDichvu={idDichvu}, @count={count}";
            SqlConnection conn = new SqlConnection(DataProvider.Instance.connectionData);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
