using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class VatTu
    {
        public VatTu(int id, string tenvattu, int soluong, float dongia, string ghichu) 
        { 
            this.Id = id;
            this.Tenvattu = tenvattu;
            this.Soluong = soluong;
            this.Dongia = dongia;
            this.Ghichu = ghichu;
        }
        public VatTu(DataRow row) 
        {
            this.Id = (int)row["MaVatTu"];
            this.Tenvattu = (string)row["TenVatTu"];
            this.Soluong = (int)row["SoLuong"];
            this.Dongia = (float)Convert.ToDouble(row["DonGia"].ToString());
            this.Ghichu = (string)row["GhiChu"];
        }
        private int id;
        private string tenvattu;
        private int soluong;
        private float dongia;
        private string ghichu;
        public int Id { get => id; set => id = value; }
        public string Tenvattu { get => tenvattu; set => tenvattu = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public float Dongia { get => dongia; set => dongia = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
    }
}
