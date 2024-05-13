using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QLKhachSan.DAO
{
    public class VatTuDAO
    {
        private static VatTuDAO instance;
        public static VatTuDAO Instance
        {
            get { if (instance == null) instance = new VatTuDAO(); return instance; }
            private set { instance = value; }
        }
        public VatTuDAO() { }
        public List<VatTu> GetVatTu()
        {
            List<VatTu> list = new List<VatTu>();
            string query = "SELECT * FROM VatTu";
            DataTable vattu = DataProvider.Instance.ExecuQuery(query);
            foreach (DataRow row in vattu.Rows)
            {
                VatTu vt = new VatTu(row);
                list.Add(vt);
            }
            return list;
        }
        public bool InsertVatTu(string tenvattu, int soluong, float dongia, string ghichu)
        {
            string query = string.Format("INSERT VatTu (TenVatTu, SoLuong, DonGia, GhiChu)VALUES(N'{0}', {1},{2},N'{3}')", tenvattu, soluong,dongia, ghichu);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool UpdateVaTu( string tenvattu, int soluong, float dongia, string ghichu, int mavattu)
        {

            string query = string.Format("UPDATE VatTu SET TenVatTu = N'{0}', SoLuong ={1}, DonGia ={2}, GhiChu =N'{3}' WHERE MaVatTu = {4}", tenvattu, soluong, dongia, ghichu, mavattu);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool DeleteVatTu(int mavattu)
        {
            //BillinfoDAO.Instance.DeleteBillInfoFood(idFood);
            string query = string.Format("DELETE VatTu WHERE MaVatTu = {0}", mavattu);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public List<VatTu> SearchVatTuByName(string tenvattu)
        {
            List<VatTu> vattu = new List<VatTu>();
            string query = string.Format("SELECT *FROM VatTu WHERE LOWER(TenVatTu) COLLATE Latin1_General_CI_AI LIKE '%' + LOWER(N'{0}') + '%';", tenvattu);
            DataTable data = DataProvider.Instance.ExecuQuery(query);
            foreach (DataRow row in data.Rows)
            {
                VatTu vt = new VatTu(row);
                vattu.Add(vt);
            }
            return vattu;
        }
    }
}
