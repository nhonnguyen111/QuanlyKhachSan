using QLKhachSan.DAO;
using QLKhachSan.DTO;
using QLKhachSan.UseControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QLKhachSan.ResetPass;

namespace QLKhachSan
{
    public partial class Dashboard : Form
    {
        private TaiKhoan loginAccount;
        public TaiKhoan LoginAccount
        {
            get => loginAccount;
            set
            {
                loginAccount = value;
                ChangAccount(loginAccount.Type);
            }
        }

        public Dashboard(TaiKhoan acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;


        }

        void ChangAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            lbdisplay.Text = LoginAccount.Displayname;
            CapNhatGiaPhong capNhatGia = new CapNhatGiaPhong();
            if (type == 1)
            {
                capNhatGia.ShowDialog();
            }
            else
            {
                capNhatGia.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát khỏi chương trình ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            this.Close();


        }

        private useRoom useroom;
        private void button2_Click_2(object sender, EventArgs e)
        {
            if (useControl.Controls.Contains(useroom) == false)
            {
                useroom = new useRoom();
                useroom.Dock = DockStyle.Fill;
                useControl.Controls.Add(useroom);
                useroom.BringToFront();
            }
            else
            {
                useroom.BringToFront();
            }
        }
        private useUser user;

        private void button3_Click(object sender, EventArgs e)
        {
            if (useControl.Controls.Contains(user) == false)
            {
                user = new useUser();
                user.Dock = DockStyle.Fill;
                useControl.Controls.Add(user);
                user.BringToFront();
            }
            else
            {
                user.BringToFront();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetPass resetPass = new ResetPass(loginAccount);
            resetPass.ShowDialog();
        }
        private useOrderRoom OrderRoom;
        private void button4_Click(object sender, EventArgs e)
        {

            if (useControl.Controls.Contains(OrderRoom) == false)
            {
                OrderRoom = new useOrderRoom();
                OrderRoom.Dock = DockStyle.Fill;
                useControl.Controls.Add(OrderRoom);
                OrderRoom.BringToFront();
            }
            else
            {
                OrderRoom.BringToFront();
            }
        }
        private usePay usepay;
        private void button2_Click(object sender, EventArgs e)
        {
            if (useControl.Controls.Contains(usepay) == false)
            {
                usepay = new usePay();
                usepay.Dock = DockStyle.Fill;
                useControl.Controls.Add(usepay);
                usepay.BringToFront();
            }
            else
            {
                usepay.BringToFront();
            }
        }
        private useKho useKho;
        private void button5_Click(object sender, EventArgs e)
        {
            if (useControl.Controls.Contains(useKho) == false)
            {
                useKho = new useKho();
                useKho.Dock = DockStyle.Fill;
                useControl.Controls.Add(useKho);
                useKho.BringToFront();
            }
            else
            {
                useKho.BringToFront();
            }
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin fAdmin = new Admin();
            fAdmin.ShowDialog();
            
        }
    }
}
