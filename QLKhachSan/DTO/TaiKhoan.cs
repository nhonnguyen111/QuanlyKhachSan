using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class TaiKhoan
    {
        public TaiKhoan(string username, string displayname, int quyen, string password)
        {
            this.Username = username;
            this.Displayname = displayname;
            this.Type = quyen;
            this.Password = password;
           
        }
        public TaiKhoan(DataRow row)
        {
            
            this.Type = (int)row["idQuyen"];      
            this.Username = (string)row["UserName"];
            this.Displayname = (string)row["DisplayName"];
            this.Password = (string)row["PassWord"];
        }
        private string username;
        
   
        public string Username { get => username; set => username = value; }

        private string password;
        public string Password { get => password; set => password = value; }

        private string displayname;       
        public string Displayname { get => displayname; set => displayname = value; }

        private int type;        
        public int Type { get => type; set => type = value; }
    }
}
