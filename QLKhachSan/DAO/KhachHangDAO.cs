using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DAO
{
    internal class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance {
            get { if (instance == null) instance = new KhachHangDAO(); return instance; }
            private set { instance = value; }
        }
        public KhachHangDAO() { }
        //List khách hàng
        public List<KhachHang> GetListKhachhang()
        {
            List<KhachHang> khachhang = new List<KhachHang>();
            string query = "select * from KhachHang";
            DataTable data = DataProvider.Instance.ExecuQuery(query);
            foreach (DataRow row in data.Rows)
            {
                KhachHang khachHang = new KhachHang(row);
                khachhang.Add(khachHang);
            }
            return khachhang;
        }
        // Thêm khách hàng
        public bool InsertKhachHang(string name, DateTime sinhnam, int sdt, int cccd, string gioitinh, string diachi)
        {
            string query = string.Format("INSERT INTO KhachHang (name, sinhnam, sdt, cccd, gioitinh, diachi) VALUES ('{0}', '{1}', {2}, {3}, '{4}', N'{5}')", name, sinhnam, sdt, cccd, gioitinh,diachi);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        //Sửa Khách hàng
        public bool UpdateKhachHang( string name,DateTime sinhnam, int sdt, int cccd, string gioitinh, string diachi, int id )
        {
            
            string query = string.Format("UPDATE KhachHang SET name = N'{0}',sinhnam = '{1}',sdt = {2},cccd = {3},gioitinh = N'{4}',diachi = N'{5}' where id = {6}", name, sinhnam, sdt, cccd, gioitinh, diachi, id);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        //Xóa khách hàng
        public bool DeleteKhachHang(int idKhachHang)
        {
            //BillinfoDAO.Instance.DeleteBillInfoFood(idFood);
            string query = string.Format("DELETE KhachHang WHERE id = {0}", idKhachHang);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
    }
}
