using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;
        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return instance; }
            private set { instance = value; }
        }
        public MenuDAO() { }
        public List<Menu> GetListMenuByRoom(int id)
        {
            List<Menu> list = new List<Menu>();
            string query = "SELECT f.name, bi.count, f.price, f.price*bi.count as totalPrice FROM dbo.BillInfo as bi, dbo.Bill as b, dbo.DichVu as f\r\nWHERE bi.idBill = b.id and bi.idDichvu = f.id and b.status = 0 and b.idPhong =" + id;
            DataTable data = DataProvider.Instance.ExecuQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                list.Add(menu);
            }
            return list;
        }
    }
}
