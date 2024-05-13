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

namespace QLKhachSan.UseControl
{
    public partial class useOrderRoom : UserControl
    {
        public useOrderRoom()
        {
            InitializeComponent();
            LoadListDatPhong();
            BindingDatPhong();
            LoadComboKhachHang();
            LoadComboPhong();
            LoadComboDichVu();
        }
        void LoadComboKhachHang()
        {
            List<KhachHang> list = KhachHangDAO.Instance.GetListKhachhang();
            cbKhachHang.DataSource = list;
            cbKhachHang.DisplayMember = "name";
        }
        void LoadComboPhong()
        {
            List<Room> list = RoomDAO.Instance.LoadAllRoomList();
            cbPhong.DataSource = list;
            cbPhong.DisplayMember = "name";
        }
        void LoadComboDichVu()
        {
            List<DichVu> list = DichVuDAO.Instance.GetListThucAn();
            cbdichvu.DataSource = list;
            cbdichvu.DisplayMember = "name";
        }
        void BindingDatPhong()
        {
            txtid.DataBindings.Clear();
            cbKhachHang.DataBindings.Clear();
            dtngaynhan.DataBindings.Clear();
            dtngaytra.DataBindings.Clear();
            cbPhong.DataBindings.Clear();
            txttamtinh.DataBindings.Clear();
            cbdichvu.DataBindings.Clear();

            txtid.DataBindings.Add(new Binding("Text", dtgvDatPhong.DataSource, "id", true, DataSourceUpdateMode.Never));
            cbKhachHang.DataBindings.Add(new Binding("Text", dtgvDatPhong.DataSource, "TenKhachHang", true, DataSourceUpdateMode.Never));
            cbPhong.DataBindings.Add(new Binding("Text", dtgvDatPhong.DataSource, "PhongDat", true, DataSourceUpdateMode.Never));
            dtngaynhan.DataBindings.Add(new Binding("Value", dtgvDatPhong.DataSource, "NgayNhan", true, DataSourceUpdateMode.Never));
            dtngaytra.DataBindings.Add(new Binding("Value", dtgvDatPhong.DataSource, "NgayTra", true, DataSourceUpdateMode.Never));
            txttamtinh.DataBindings.Add(new Binding("Text", dtgvDatPhong.DataSource, "TamTinh", true, DataSourceUpdateMode.Never));
            cbdichvu.DataBindings.Add(new Binding("Text", dtgvDatPhong.DataSource, "DichVu", true, DataSourceUpdateMode.Never));
        }
        void LoadListDatPhong()
        {
            dtgvDatPhong.DataSource = DatPhongDAO.Instance.GetListDatPhong();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cbKhachHang.Text = "Chọn khách hàng";
            txttamtinh.Clear();
            cbPhong.Text = "Chọn phòng";
            cbdichvu.Text = "Chọn dịch vụ";

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            if (DatPhongDAO.Instance.DeleteDatPhong(id))
            {
                MessageBox.Show("Xóa lịch đặt phòng thành công  ");
                LoadListDatPhong();
                BindingDatPhong();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)

        {
            string tenkhachhang = (cbKhachHang.SelectedItem as KhachHang).Name;
            string phongdat = (cbPhong.SelectedItem as Room).Name;
            DateTime ngaynhan = dtngaynhan.Value;
            DateTime ngaytra = dtngaytra.Value;
            string dichvu = (cbdichvu.SelectedItem as DichVu).Name;
            List<DichVu> dichVuList = DichVuDAO.Instance.GetGiaPhong();
            float giaPhong = dichVuList[0].Price;
            TimeSpan soNgayThue = ngaytra.Date - ngaynhan.Date;
            // Tính toán giá trị tạm tính
            float tamTinh = giaPhong * (float)soNgayThue.TotalDays;
            txttamtinh.Text = tamTinh.ToString();

            if (DatPhongDAO.Instance.InsertDatPhong(tenkhachhang, phongdat, ngaynhan, ngaytra, tamTinh, dichvu))
            {
                MessageBox.Show("Đặt lịch đặt phòng thành công");
                LoadListDatPhong();
                BindingDatPhong();
                if (insertPhongDat != null)
                    insertPhongDat(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Đặt lịch thất bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            string tenkhachhang = (cbKhachHang.SelectedItem as KhachHang).Name;
            string phongdat = (cbPhong.SelectedItem as Room).Name;
            DateTime ngaynhan = dtngaynhan.Value;
            DateTime ngaytra = dtngaytra.Value;
            float tamtinh = float.Parse(txttamtinh.Text);
            string dichvu = (cbdichvu.SelectedItem as DichVu).Name;
            if (DatPhongDAO.Instance.UpdateDatPhong(tenkhachhang, phongdat, ngaynhan, ngaytra, tamtinh, dichvu, id))
            {
                MessageBox.Show("Sửa lịch đặt phòng thành công");
                LoadListDatPhong();
                BindingDatPhong();
                if (updatePhongDat != null)
                    updatePhongDat(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Sửa lịch thất bại");
            }
        }

        private void dtngaytra_ValueChanged(object sender, EventArgs e)
        {
            DateTime ngaynhan = dtngaynhan.Value;
            DateTime ngaytra = dtngaytra.Value;
            List<DichVu> dichVuList = DichVuDAO.Instance.GetGiaPhong();
            float giaPhong = dichVuList[0].Price;
            TimeSpan soNgayThue = ngaytra.Date - ngaynhan.Date;
            // Tính toán giá trị tạm tính
            float tamTinh = giaPhong * (float)soNgayThue.TotalDays;
            txttamtinh.Text = tamTinh.ToString();
        }

        private event EventHandler insertPhongDat;
        public event EventHandler InsertPhongDats
        {
            add { insertPhongDat += value; }
            remove { insertPhongDat -= value; }
        }
        private event EventHandler updatePhongDat;
        public event EventHandler UpdatePhongDats
        {
            add { updatePhongDat += value; }
            remove { updatePhongDat -= value; }
        }
    }
}
