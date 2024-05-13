using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class Room
    {
        public Room(int id, string name, string status)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
        }
        public Room(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = (string)row["name"];
            this.Status = (string)row["status"];

        }
        private int iD;
        
        public int ID
        {
            get => iD;
            set => iD = value;
        }


        private string name;
        
        public string Name
        {
            get => name;
            set => name = value;
        }

        private string status;
        
        public string Status
        {
            get => status;
            set => status = value;
        }
    }
}
