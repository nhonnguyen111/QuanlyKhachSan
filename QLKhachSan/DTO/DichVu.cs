using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class DichVu
    {

        public DichVu( string name, int idDichvu, float price)
        {
            
            this.Name = name;
            this.IdDichvu = idDichvu;
            this.Price = price;
        }
        public DichVu(DataRow row)
        {
            this.Name = (string)row["name"];
            this.IdDichvu = (int)row["id"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
        } 

       
        public string Name { get => name; set => name = value; }
        public int IdDichvu { get => idDichvu; set => idDichvu = value; }
        public float Price { get => price; set => price = value; }

        private string name;
        private int idDichvu;
        private float price;
    }
}
