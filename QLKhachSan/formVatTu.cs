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
    public partial class formVatTu : Form
    {
        private bool isAddingMode;
        private int mavatu { get; set; }
        private string tenvattu { get; set; }
        private int soluong { get; set; }
        private float dongia { get; set; }
        private string ghichu { get; set; }
        public formVatTu()
        {
            InitializeComponent();
        }
        public void SetValues(int id, string tenVatTu, int soLuong, float donGia, string ghiChu)
        {

            mavatu = id;
            tenvattu = tenVatTu;
            soluong = soLuong;
            dongia = donGia;
            ghichu = ghiChu;
            txtid.Text = mavatu.ToString();
            txttenvattu.Text = tenvattu;
            txtdongia.Text = dongia.ToString();
            txtsoluong.Text = soluong.ToString();
            txtghichu.Text = ghichu;
        }
        public void SetMode(string mode)
        {
            if (mode == "Thêm")
            {
                isAddingMode = true;
                // Xóa dữ liệu trước khi thêm
                txttenvattu.Text = "";
                txtghichu.Text = "";
                txtdongia.Text = "";
                txtsoluong.Text = "";
                
                
                this.lbtitle.Text = "Thêm vật tư";
            }
            else if (mode == "Sửa")
            {
                isAddingMode = false;
                this.lbtitle.Text = "Sửa vật tư";
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            if (isAddingMode) { 
               
                tenvattu = txttenvattu.Text;
                soluong = int.Parse(txtsoluong.Text);
                dongia = int.Parse(txtdongia.Text);
                ghichu = txtghichu.Text;

                if (VatTuDAO.Instance.InsertVatTu(tenvattu, soluong, dongia, ghichu))
                {
                    MessageBox.Show($"Thêm {tenvattu} thành công");
                }
                else
                {
                    MessageBox.Show($"Thêm {tenvattu} thất bại");
                }
            }
            else 
            {
                mavatu = int.Parse(txtid.Text);
                tenvattu = txttenvattu.Text;
                soluong = int.Parse(txtsoluong.Text);
                dongia = int.Parse(txtdongia.Text);
                ghichu = txtghichu.Text;
                if (VatTuDAO.Instance.UpdateVaTu(tenvattu, soluong, dongia, ghichu,mavatu))
                {
                    MessageBox.Show($"Sửa {tenvattu} thành công");
                }
                else
                {
                    MessageBox.Show($"Sửa {tenvattu} thất bại");
                }
            }

            this.Close();
            

            
        }
    }
}
