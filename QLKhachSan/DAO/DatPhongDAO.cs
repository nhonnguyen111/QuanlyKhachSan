using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DAO
{
    public class DatPhongDAO
    {
        private static DatPhongDAO instance;

        public static DatPhongDAO Instance
        {
            get { if (instance == null) instance = new DatPhongDAO(); return instance; }
            private set { instance = value; }
        }
        public DatPhongDAO() { }
        public List<DatPhong> GetListDatPhong()
        {
            List<DatPhong> datphong = new List<DatPhong>();
            string query = "select * from DatPhong";
            DataTable data = DataProvider.Instance.ExecuQuery(query);
            foreach (DataRow row in data.Rows)
            {
                DatPhong DatPhong = new DatPhong(row);
                datphong.Add(DatPhong);
            }
            return datphong;
        }
        public bool InsertDatPhong(string tenkhachhang, string phongdat, DateTime ngaynhan, DateTime ngaytra, float tamtinh, string dichvu)
        {
            string query = string.Format("INSERT INTO DatPhong (TenKhachHang, PhongDat, NgayNhan, NgayTra, TamTinh, DichVu) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', N'{5}')", tenkhachhang, phongdat, ngaynhan.ToString("yyyy-MM-dd"), ngaytra.ToString("yyyy-MM-dd"), tamtinh, dichvu);

            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool UpdateDatPhong( string tenkhachhang, string phongdat, DateTime ngaynhan, DateTime ngaytra, float tamtinh, string dichvu,int id)
        {

            string query = string.Format("UPDATE DatPhong SET TenKhachHang = N'{0}', PhongDat =N'{1}', NgayNhan ='{2}',NgayTra = '{3}', TamTinh ={4} ,DichVu= N'{5}' WHERE id = {6}", tenkhachhang,phongdat, ngaynhan.ToString("yyyy-MM-dd"), ngaytra.ToString("yyyy-MM-dd"), tamtinh, dichvu,id);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool DeleteDatPhong(int id)
        {
            //BillinfoDAO.Instance.DeleteBillInfoFood(idFood);
            string query = string.Format("DELETE DatPhong WHERE id = {0}", id);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
    }
}
