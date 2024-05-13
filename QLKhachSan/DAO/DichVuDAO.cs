using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DAO
{
    internal class DichVuDAO
    {
        private static DichVuDAO instance;
        public static DichVuDAO Instance
        {
            get { if (instance == null) instance = new DichVuDAO(); return instance; }
            private set { instance = value; }
        }
        public DichVuDAO() { }


        public List<DichVu> GetListThucAn()
        {
            List<DichVu> list = new List<DichVu>();
            DataTable data = DataProvider.Instance.ExecuQuery("USP_GetListDichVuThucAn");
            foreach (DataRow item in data.Rows)
            {
                DichVu dichVu = new DichVu(item);
                list.Add(dichVu);
            }
            return list;
        }
        public List<DichVu> GetGiaPhong()
        {
            List<DichVu> list = new List<DichVu>();
            string query = string.Format("SELECT * FROM DichVu WHERE idDichvu = 1");
            DataTable data = DataProvider.Instance.ExecuQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DichVu dichVuPhong = new DichVu(item);
                list.Add(dichVuPhong);
            }
            return list;
        }
        public bool UpdateGiaPhong(  float price)
        {
            string query = string.Format("UPDATE DichVu SET price = {0} WHERE id = 3", price);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        public bool InsertDichvu(string name, float price)
        {
            string query = string.Format("INSERT INTO DichVu (name, price, idDichvu) VALUES (N'{0}',{1}, 2)", name, price);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        
        public bool UpdateDichVu(string name, float price, int id)
        {

            string query = string.Format("UPDATE DichVu SET name = N'{0}',price = {1} where id = {2}", name, price, id);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
        //Xóa khách hàng
        public bool DeleteDichVu(int id)
        {
            //BillinfoDAO.Instance.DeleteBillInfoFood(idFood);
            string query = string.Format("DELETE DichVu WHERE id = {0}", id);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
    }
}
