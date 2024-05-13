using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class Quyen
    {
        public Quyen(int idquyen, int id, string tenquyen, string username, string displayname, string password) 
        {
            this.Id = id;
            this.Tenquyen = tenquyen;
            this.Username = username;
            this.Displayname = displayname;
            this.Password = password;
            this.Idquyen = idquyen;
        }
        public Quyen(DataRow row)
        {
            this.Id = (int)row["type"];
            this.Username = (string)row["UserName"];
            this.Displayname = (string)row["DisplayName"];
            this.Tenquyen = (string)row["TenQuyen"];
            this.Password = (string)row["Password"];
            this.Idquyen = (int)row["idQuyen"];
        }
        private int id;
        private string tenquyen;
        private string username;
        private int idquyen;
        public string Username { get => username; set => username = value; }

        private string password;
        public string Password { get => password; set => password = value; }

        private string displayname;
        public string Displayname
        {
            get => displayname; set => displayname = value;
        }

        public int Id { get => id; set => id = value; }
        public string Tenquyen { get => tenquyen; set => tenquyen = value; }
        public int Idquyen { get => idquyen; set => idquyen = value; }
    }
}
