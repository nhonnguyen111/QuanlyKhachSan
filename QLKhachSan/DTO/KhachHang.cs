using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class KhachHang
    {
        public KhachHang(int id, string name, DateTime?  sinhnam, int sdt, int cccd, string gioitinh, string diachi) 
        { 
            this.id = id;
            this.name = name;
            this.sinhnam = sinhnam;
            this.sdt = sdt;
            this.cccd = cccd;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
        }
        public KhachHang( DataRow row) 
        {
            this.id = (int)row["id"];
            this.name= (string)row["name"];
            this.sinhnam = (DateTime?)row["sinhnam"];
            this.sdt = (int)row["sdt"];
            this.cccd = (int)row["cccd"];
            this.gioitinh = (string)row["gioitinh"];
            this.diachi = (string)row["diachi"];
        }
        private int id;
        public int Id { get => id; set => id = value; }
        

        private string name;
        public string Name { get => name; set => name = value; }
       

        private DateTime? sinhnam;
        public DateTime? Sinhnam { get => sinhnam; set => sinhnam = value; }
        

        private int sdt;
        public int Sdt { get => sdt; set => sdt = value; }
        

        private int cccd;
        public int Cccd { get => cccd; set => cccd = value; }
       

        private string gioitinh;
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        

        private string diachi;
        public string Diachi { get => diachi; set => diachi = value; }
    }
}
