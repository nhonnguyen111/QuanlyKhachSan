using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class Menu
    {
        public Menu(string dichvu, int count, float price, float totalprice) 
        {
            this.Dichvu = dichvu;
            this.Count = count;
            this.Price = price;
            this.Totalprice = totalprice;
        }
        public Menu( DataRow row)
        {
            this.Dichvu = row["name"].ToString();
            this.Count = (int)row["count"];
            this.price = (float)Convert.ToDouble(row["price"].ToString());
            this.Totalprice = (float)Convert.ToDouble(row["totalPrice"].ToString());
        }

        private string dichvu;
        private int count;
        private float price;
        private float totalprice;

        public string Dichvu { get => dichvu; set => dichvu = value; }
        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public float Totalprice { get => totalprice; set => totalprice = value; }
    }
}
