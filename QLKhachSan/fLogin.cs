
using QLKhachSan.DAO;
using QLKhachSan.DTO;
using System.Security.Principal;

namespace QLKhachSan
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi chương trình ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string passWord = txtPassWord.Text;

            if (Login(userName, passWord))
            {
                TaiKhoan loginaccount = TaiKhoanDAO.Instance.GetAccountByUserName(userName);
                Dashboard f = new Dashboard(loginaccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc Mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        bool Login(string UserName, string PassWord)
        {
            return TaiKhoanDAO.Instance.Login(UserName, PassWord);
        }

       
    }
}
