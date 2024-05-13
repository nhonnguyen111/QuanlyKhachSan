using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime datecheckin, DateTime datecheckout , int status, int discount = 0)
        { 
            this.Id = id;
            this.DatecheckIn = datecheckin;
            this.DatecheckOut = datecheckout;
            this.Status = status;
            this.Discount = discount;
            
            
        }
        public Bill(DataRow row) 
        {
            this.Id = (int)row["ID"];
            this.DatecheckIn = (DateTime)row["DateCheckIn"];
           
            var dateCheckTemp = row["DateCheckOut"];
            if (dateCheckTemp.ToString() != "")
            {
                this.DatecheckOut = (DateTime)dateCheckTemp;
            }

            this.status = (int)row["status"];
            if (row["discount"].ToString() != "")
                this.discount = (int)row["discount"];
            
        }
        private int id;
        private DateTime datecheckIn;
        private DateTime datecheckOut;
        private int status;
        private int discount;
     
        
        public DateTime DatecheckIn { get => datecheckIn; set => datecheckIn = value; }
        public DateTime DatecheckOut { get => datecheckOut; set => datecheckOut = value; }
        public int Id { get => id; set => id = value; }
        public int Status { get => status; set => status = value; }
        public int Discount { get => discount; set => discount = value; }
       
      
    }
}
