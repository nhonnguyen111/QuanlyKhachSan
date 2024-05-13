using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class Pay
    {
        public Pay(int id, DateTime datecheckin, DateTime datecheckout, string tenphong, int status, int discount = 0, float totalprice = 0)
        {
            this.Id = id;
            this.DatecheckIn = datecheckin;
            this.DatecheckOut = datecheckout;
            this.Tenphong = tenphong;
            this.Status = status;
            this.Discount = discount;
            this.Totalprice = totalprice;

        }
        public Pay(DataRow row)
        {
            this.Id = (int)row["ID"];
            this.DatecheckIn = (DateTime)row["DateCheckIn"];

            var dateCheckTemp = row["DateCheckOut"];
            this.Tenphong = (string)row["name"];
            if (dateCheckTemp.ToString() != "")
            {
                this.DatecheckOut = (DateTime)dateCheckTemp;
            }

            this.status = (int)row["status"];
            if (row["discount"].ToString() != "")
                this.discount = (int)row["discount"];
            this.Totalprice = 0.0f;

            string totalpriceString = row["totalprice"].ToString();
            if (!string.IsNullOrWhiteSpace(totalpriceString))
            {
                if (float.TryParse(totalpriceString, out float totalPriceValue))
                {
                    this.Totalprice = totalPriceValue;
                }
                else
                {
                    Console.WriteLine("Không thể chuyển đổi thành công giá trị totalprice.");
                }
            }
        }
        private int id;
        private DateTime datecheckIn;
        private DateTime datecheckOut;
        private int status;
        private int discount;
        private float totalprice;
        private string tenphong;

        public DateTime DatecheckIn { get => datecheckIn; set => datecheckIn = value; }
        public DateTime DatecheckOut { get => datecheckOut; set => datecheckOut = value; }
        public int Id { get => id; set => id = value; }
        public int Status { get => status; set => status = value; }
        public int Discount { get => discount; set => discount = value; }
        public float Totalprice { get => totalprice; set => totalprice = value; }
        public string Tenphong { get => tenphong; set => tenphong = value; }
    }
}
