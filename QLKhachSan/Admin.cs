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
    public partial class Admin : Form
    {
        BindingSource taikhoan = new BindingSource();
        BindingSource phong = new BindingSource();
        BindingSource dichvu = new BindingSource();
        public Admin()
        {
            InitializeComponent();
            LoadAccount();
            dtgvnguoidung.DataSource = taikhoan;
            dtgvPhong.DataSource = phong;
            dtgvdichvu.DataSource = dichvu;
            BindingTaiKhoan();
            LoadCbQuyen();
            LoadRoom();
            BindingRoom();
            LoadDichVu();
            BindingDichVu();
        }
        void LoadDichVu()
        {
            dichvu.DataSource = DichVuDAO.Instance.GetListThucAn();
        }
        void LoadRoom()
        {
            phong.DataSource = RoomDAO.Instance.LoadAllRoomList();

        }
        void BindingRoom()
        {
            lbidphong.DataBindings.Add(new Binding("Text", dtgvPhong.DataSource, "id", true, DataSourceUpdateMode.Never));
            txtphong.DataBindings.Add(new Binding("Text", dtgvPhong.DataSource, "name", true, DataSourceUpdateMode.Never));
            lbstatus.DataBindings.Add(new Binding("Text", dtgvPhong.DataSource, "status", true, DataSourceUpdateMode.Never));
        }
        void BindingDichVu()
        {
            lbiddichvu.DataBindings.Add(new Binding("Text", dtgvdichvu.DataSource, "iddichvu", true, DataSourceUpdateMode.Never));
            txtnamedichvu.DataBindings.Add(new Binding("Text", dtgvdichvu.DataSource, "name", true, DataSourceUpdateMode.Never));
            txtprice.DataBindings.Add(new Binding("Text", dtgvdichvu.DataSource, "price", true, DataSourceUpdateMode.Never));
        }
        void LoadCbQuyen()
        {
            List<Quyen> list = QuyenDAO.Instance.GetListQuyen();
            cbquyen.DataSource = list;
            cbquyen.DisplayMember = "TenQuyen";
        }
        void BindingTaiKhoan()
        {
            txttendangnhap.DataBindings.Add(new Binding("Text", dtgvnguoidung.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txttenhienthi.DataBindings.Add(new Binding("Text", dtgvnguoidung.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            cbquyen.DataBindings.Add(new Binding("Text", dtgvnguoidung.DataSource, "TenQuyen", true, DataSourceUpdateMode.Never));
        }
        void LoadAccount()
        {
            taikhoan.DataSource = QuyenDAO.Instance.GetListAccount();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string username = txttendangnhap.Text;
            string displayname = txttenhienthi.Text;
            if (cbquyen.SelectedItem != null)
            {
                string tenquyen = (cbquyen.SelectedItem as Quyen).Tenquyen;

                int quyen;
                if (tenquyen == "Quản trị")
                {
                    quyen = 1;
                }
                else
                {
                    quyen = 0;
                }
                string password = txtmatkhau.Text;

                if (QuyenDAO.Instance.InsertTaiKhoan(username, displayname, quyen, password))
                {
                    MessageBox.Show("Thêm tài khoản thành công");
                    LoadAccount();
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản thất bại");
                }
            }
            else
            {
                // Xử lý khi không có item nào được chọn trong ComboBox
                MessageBox.Show("Vui lòng chọn quyền trước khi thêm tài khoản.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string username = txttendangnhap.Text;
            string displayname = txttenhienthi.Text;
            if (cbquyen.SelectedItem != null)
            {
                string tenquyen = (cbquyen.SelectedItem as Quyen).Tenquyen;

                int quyen;
                if (tenquyen == "Quản trị")
                {
                    quyen = 1;
                }
                else
                {
                    quyen = 0;
                }


                if (QuyenDAO.Instance.UpdateTaiKhoan(displayname, quyen, username))
                {
                    MessageBox.Show("Sửa tài khoản thành công");
                    LoadAccount();
                }
                else
                {
                    MessageBox.Show("Sửa tài khoản thất bại");
                }
            }
            else
            {
                // Xử lý khi không có item nào được chọn trong ComboBox
                MessageBox.Show("Vui lòng chọn quyền trước khi Sửa tài khoản.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string username = txttendangnhap.Text;
            if (QuyenDAO.Instance.DeleteTaiKhoan(username))
            {
                MessageBox.Show("Xóa tài khoản thành công");
                LoadAccount();
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }
        }

        private void btnresetpass_Click(object sender, EventArgs e)
        {
            string username = txttendangnhap.Text;
            if (QuyenDAO.Instance.ResetPassword(username))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
                LoadAccount();
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txttendangnhap.Clear();
            txttenhienthi.Clear();
            cbquyen.Text = "Chọn quyền";
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string namephong = txtphong.Text;
            if (RoomDAO.Instance.InsertRoom(namephong))
            {
                MessageBox.Show("Thêm phòng mới thành công");
                LoadRoom();
            }
            else
            {
                MessageBox.Show("Thêm phòng mới thất bại");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int idphong = int.Parse(lbidphong.Text);
            if (RoomDAO.Instance.DeleteRoom(idphong))
            {
                MessageBox.Show("Xóa thành công");
                LoadRoom();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            int idphong = int.Parse(lbidphong.Text);
            string namephong = txtphong.Text;
            if (RoomDAO.Instance.UpdateRoom(namephong, idphong))
            {
                MessageBox.Show("Sửa thành công");
                LoadRoom();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btnxemchitiet_Click(object sender, EventArgs e)
        {
            if (dtgvPhong.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgvPhong.SelectedRows[0];


                int idphong = Convert.ToInt32(selectedRow.Cells["id"].Value);
                string tenphong = selectedRow.Cells["name"].Value.ToString();
                string status = selectedRow.Cells["status"].Value.ToString();


                string message = $"Mã phòng: {idphong}\n" +
                                 $"Số phòng: {tenphong}\n" +
                                 $"Trạng thái: {status}\n";


                MessageBox.Show(message, $"Thông tin chi tiết của {tenphong}", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xem chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tendichvu = txtnamedichvu.Text;
            float price = float.Parse(txtprice.Text);
            if (DichVuDAO.Instance.InsertDichvu(tendichvu, price))
            {
                MessageBox.Show("Thêm dịch vụ thành công");
                LoadDichVu();
            }
            else
            {
                MessageBox.Show("Thêm dịch vụ thất bại");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int iddichvu = int.Parse(lbiddichvu.Text);
            string tendichvu = txtnamedichvu.Text;
            float price = float.Parse(txtprice.Text);

            if (DichVuDAO.Instance.UpdateDichVu(tendichvu, price, iddichvu))
            {
                MessageBox.Show("Sửa thành công");
                LoadDichVu();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int iddichvu = int.Parse(lbiddichvu.Text);
            if (DichVuDAO.Instance.DeleteDichVu(iddichvu))
            {
                MessageBox.Show("Xóa thành công");
                LoadDichVu();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dtgvdichvu.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgvdichvu.SelectedRows[0];


                int iddichvu = Convert.ToInt32(selectedRow.Cells["iddichvu"].Value);
                string tendichvu = selectedRow.Cells["namedichvu"].Value.ToString();
                string gia = selectedRow.Cells["dongia"].Value.ToString();


                string message = $"Mã dịch vụ: {iddichvu}\n" +
                                 $"Tên dịch vụ: {tendichvu}\n" +
                                 $"Đơn giá: {gia} đồng \n";


                MessageBox.Show(message, $"Thông tin chi tiết của {tendichvu}", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xem chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
