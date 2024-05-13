using QLKhachSan.DAO;
using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLKhachSan
{
    public partial class CapNhatGiaPhong : Form
    {
        public CapNhatGiaPhong()
        {
            InitializeComponent();
            List<DichVu> dichVuList = DichVuDAO.Instance.GetGiaPhong(); 
            float giaPhong = dichVuList[0].Price; 
            txtpriceroom.Text = giaPhong.ToString();
        }

        private void btnacpectprice_Click(object sender, EventArgs e)
        {
            float price = float.Parse(txtpriceroom.Text);
            if (DichVuDAO.Instance.UpdateGiaPhong(price))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Kiểm tra lại thông tin");
            }
        }
        

    }
}
