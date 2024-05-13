using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class DatPhong
    {
        public DatPhong(int id, string tenkhachhang, string phongdat, DateTime ngaynhan, DateTime ngaytra, float tamtinh, string dichvu) 
        {
            this.Id = id;
            this.Tenkhachhang = tenkhachhang;
            this.Phongdat = phongdat;
            this.Ngaynhan = ngaynhan;
            this.Ngaytra = ngaytra;
            this.Tamtinh = tamtinh;
            this.Dichvu = dichvu; 
        }
        public DatPhong(DataRow row) 
        {

            this.Id = (int)row["id"];
            this.Tenkhachhang = (string)row["TenKhachHang"];
            this.Phongdat = (string)row["PhongDat"];
            this.Ngaynhan = (DateTime)row["NgayNhan"];
            var dateCheckTemp = row["NgayTra"];
            if (dateCheckTemp.ToString() != "")
            {
                this.Ngaytra = (DateTime)dateCheckTemp;
            }

            this.Tamtinh = (float)Convert.ToDouble(row["TamTinh"].ToString());
            this.Dichvu = (string)row["DichVu"];
        }
        private int id;
        private string tenkhachhang;
        private string phongdat;
        private DateTime ngaynhan;
        private DateTime ngaytra;
        private float tamtinh;
        private string dichvu;
        public int Id { get => id; set => id = value; }
        public string Tenkhachhang { get => tenkhachhang; set => tenkhachhang = value; }
        public string Phongdat { get => phongdat; set => phongdat = value; }
        public DateTime Ngaynhan { get => ngaynhan; set => ngaynhan = value; }
        public DateTime Ngaytra { get => ngaytra; set => ngaytra = value; }
        public float Tamtinh { get => tamtinh; set => tamtinh = value; }
        public string Dichvu { get => dichvu; set => dichvu = value; }
    }
}
