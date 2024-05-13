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

namespace QLKhachSan
{
    public partial class AddDichVu : Form
    {
        private int roomId;
        public AddDichVu(string tenDichVu, double giaDichVu, int roomId, int id)
        {
            InitializeComponent();
            lbdichvu.Text = tenDichVu;
            lbgia.Text = giaDichVu.ToString();
            iddichvu.Text = id.ToString();
            this.roomId = roomId;
        }

        private void AddDichVu_Load(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            int idBill = BillDAO.Instance.GetBillByIDRoom(roomId);
            int id = (int.Parse(iddichvu.Text));
            int count = (int)nmdropdown.Value;
            if (true)
            {
                if (idBill == -1)
                {
                    BillDAO.Instance.InserBill(roomId);
                    BillInfoDAO.Instance.InserBillInfo(BillDAO.Instance.GetBill(), id, count);
                }
                else
                {
                    BillInfoDAO.Instance.InserBillInfo(idBill, id, count);
                }
                MessageBox.Show("Thêm dịch vụ thành công");
                this.Close();
            }

        }
        

    }

        

    
}
