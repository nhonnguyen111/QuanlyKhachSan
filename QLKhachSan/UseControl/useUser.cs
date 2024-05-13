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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLKhachSan.UseControl
{
    public partial class useUser : UserControl
    {
        BindingSource khachhanglist = new BindingSource();
        public useUser()
        {
            InitializeComponent();
            dtgvKhachHang.DataSource = khachhanglist;
            LoadListKhachHang();
            BindingKhachHang();
        }
        void BindingKhachHang()
        {
            txtid.DataBindings.Clear();
            txtName.DataBindings.Clear();
            dtnamsinh.DataBindings.Clear();
            txtcccd.DataBindings.Clear();
            txtsdt.DataBindings.Clear();
            txtgioitinh.DataBindings.Clear();
            txtdiachi.DataBindings.Clear();

            txtid.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "id", true, DataSourceUpdateMode.Never));
            txtName.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "name", true, DataSourceUpdateMode.Never));
            txtcccd.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "cccd", true, DataSourceUpdateMode.Never));
            txtsdt.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "sdt", true, DataSourceUpdateMode.Never));
            txtgioitinh.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "gioitinh", true, DataSourceUpdateMode.Never));
            txtdiachi.DataBindings.Add(new Binding("Text", dtgvKhachHang.DataSource, "diachi", true, DataSourceUpdateMode.Never));
            dtnamsinh.DataBindings.Add(new Binding("Value", dtgvKhachHang.DataSource, "sinhnam", true, DataSourceUpdateMode.Never));
        }
        void LoadListKhachHang()
        {
            dtgvKhachHang.DataSource = KhachHangDAO.Instance.GetListKhachhang();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtsdt.Clear();
            txtgioitinh.Clear();
            txtdiachi.Clear();
            txtcccd.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtid.Text);
            if (KhachHangDAO.Instance.DeleteKhachHang(id))
            {
                MessageBox.Show("Xóa khách hàng thành công");
                LoadListKhachHang();
                BindingKhachHang();
                if (deleteKhachHang != null)
                    deleteKhachHang(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Kiểm tra lại thông tin");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            string name = txtName.Text;
            DateTime sinhnam = dtnamsinh.Value;
            int sdt = int.Parse(txtsdt.Text);
            int cccd = int.Parse(txtcccd.Text);
            string gioitinh = txtgioitinh.Text;
            string diachi = txtdiachi.Text;
            if (KhachHangDAO.Instance.UpdateKhachHang(name, sinhnam, sdt, cccd, gioitinh, diachi, id))
            {
                MessageBox.Show("Cập nhật thông tin khách hàng thành công");
                LoadListKhachHang();
                BindingKhachHang(); 
                if (updateKhachHang != null)
                    updateKhachHang(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Kiểm tra lại thông tin");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            DateTime sinhnam = dtnamsinh.Value;
            int sdt = int.Parse(txtsdt.Text);
            int cccd = int.Parse(txtcccd.Text);
            string gioitinh = txtgioitinh.Text;
            string diachi = txtdiachi.Text;
            if (KhachHangDAO.Instance.InsertKhachHang(name,sinhnam, sdt, cccd, gioitinh, diachi))
            {
                MessageBox.Show("Thêm khách hàng thành công");
                LoadListKhachHang() ;
                BindingKhachHang();
                if (insertKhachHang != null)
                    insertKhachHang(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Kiểm tra lại thông tin");
            }
        }
        private event EventHandler insertKhachHang;
        public event EventHandler InsertKhachHangs
        {
            add { insertKhachHang += value; }
            remove { insertKhachHang -= value; }
        }
        private event EventHandler updateKhachHang;
        public event EventHandler UpdateKhachHangs
        {
            add { updateKhachHang += value; }
            remove { updateKhachHang -= value; }
        }
        private event EventHandler deleteKhachHang;
        public event EventHandler DeleteKhachHangs
        {
            add { deleteKhachHang += value; }
            remove { deleteKhachHang -= value; }
        }
    }
}
