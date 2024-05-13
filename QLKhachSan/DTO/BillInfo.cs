using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachSan.DTO
{
    public class BillInfo
    {
        public BillInfo(int id, int billId, int dichvuId, int count)
        { 
            this.Id = id;
            this.Billid = billId;
            this.Dichvuid = dichvuId;
            this.Count = count;
        }
        public BillInfo (DataRow  row) 
        {
            this.Id = (int)row["ID"];
            this.Billid = (int)row["idBill"];
            this.Dichvuid = (int)row["idDichVu"];
            this.Count = (int)row["count"];
        }
        private int id;
        private int billid;
        private int dichvuid;
        private int count;

        public int Id { get => id; set => id = value; }
        public int Billid { get => billid; set => billid = value; }
        public int Dichvuid { get => dichvuid; set => dichvuid = value; }
        public int Count { get => count; set => count = value; }
    }
}
