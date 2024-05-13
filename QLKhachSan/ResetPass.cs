using QLKhachSan.DAO;
using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class ResetPass : Form
    {
        private TaiKhoan loginAccount;
        public TaiKhoan LoginAccount
        {
            get => loginAccount;
            set
            {
                loginAccount = value;
                ChangAccount(LoginAccount);
            }
        }
        public ResetPass(TaiKhoan acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }
        void ChangAccount(TaiKhoan acc)
        {
            txtusername.Text = LoginAccount.Username;
            txtdisplay.Text = LoginAccount.Displayname;
        }
        void UpdateAccount()
        {
            string username = txtusername.Text;
            string displayname =  txtdisplay.Text;
            string pass = txtPass.Text;
            string newpass = txtNewPass.Text;
            string repass = txtRePass.Text;
            if (!repass.Equals(newpass))
            {
                MessageBox.Show("Mật khẩu không trùng với mật khẩu mới !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (TaiKhoanDAO.Instance.UpdateAccount(username, displayname, pass, newpass))
                {
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (updateAccount != null)
                    {
                        updateAccount(this, new AccountEvent(TaiKhoanDAO.Instance.GetAccountByUserName(username)));
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Vui lòng điền mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> Updateaccount
        {
            add { updateAccount += value; }
            remove
            {
                updateAccount -= value;
            }
        }
        public class AccountEvent : EventArgs
        {
            private TaiKhoan acc;

            public TaiKhoan Acc { get => acc; set => acc = value; }
            public AccountEvent(TaiKhoan acc)
            {
                this.acc = acc;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }
    }
}
