using QLKhachSan.DAO;
using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan
{

    public partial class ShowBillRoom : Form
    {
        private DataGridViewRow? rowselected = null;
        private int roomId;
        private string roomName;

        public ShowBillRoom(int roomId, string roomName)
        {
            InitializeComponent();
            this.roomId = roomId;
            this.roomName = roomName;
            this.Text = "Dịch vụ : " + roomName;
            LoadDichVu();
            ShowBill(roomId);
        }

        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<Menu> lisbillinfo = MenuDAO.Instance.GetListMenuByRoom(id);
            float totalPrice = 0;
            foreach (Menu item in lisbillinfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.Dichvu.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.Totalprice.ToString());
                totalPrice += item.Totalprice;
                lsvBill.Items.Add(lsvItem);
            }
            txttotalPrice.Text = totalPrice.ToString("c", new CultureInfo("vi-VN"));


        }
        void LoadDichVu()
        {
            dtgvFood.DataSource = DichVuDAO.Instance.GetListThucAn();
            
        }

        private void dtgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgvFood.RowCount)
            {
                DataGridViewRow row = dtgvFood.Rows[e.RowIndex];
                string tenDichVu = row.Cells["name"].Value.ToString();
                double giaDichVu = Convert.ToDouble(row.Cells["price"].Value);
                int id = Convert.ToInt32(row.Cells["idDichvu"].Value.ToString());
                AddDichVu addDichvuForm = new AddDichVu(tenDichVu, giaDichVu, roomId, int.Parse(id.ToString()));

                addDichvuForm.ShowDialog();
                ShowBill(roomId);
            }
        }



        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lsvBill.Items.Clear();
            int idBill = BillDAO.Instance.GetBillByIDRoom(roomId);
            int discount = (int.Parse(txtdiscount.Text));
            //double totalPrice = Convert.ToDouble(txttotalPrice.Text.Split(',')[0]);
            double totalPrice = Convert.ToDouble(txttotalPrice.Text.Replace("₫", "").Replace(".", "").Split(',')[0]);
            decimal finalTotalPrice = Convert.ToDecimal(totalPrice - (totalPrice / 100) * discount);
            if (idBill != -1)
            {
                if (MessageBox.Show("Bạn muốn thanh toán hóa đơn cho " + roomName, "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    //Thêm thông tin thời gian cho hóa đơn
                    DateTime curr = DateTime.Now;
                    string time = curr.ToString("dd-MM-yyyy");

                    BillDAO.Instance.CheckOut(idBill, discount, finalTotalPrice);

                    // Hiển thị thông tin hóa đơn trong MessageBox
                    StringBuilder billInfo = new StringBuilder();
                    billInfo.AppendLine($"Khách sạn ".PadLeft(35));
                    billInfo.AppendLine($"\nSố phòng: {roomName}");
                    billInfo.AppendLine($"Thời gian: {time}");
                    billInfo.AppendLine("Chi tiết hóa đơn:");
                    billInfo.AppendLine($"-------------------------------------------------");
                    // Hiển thị thông tin món đã chọn 
                    foreach (ListViewItem item in lsvBill.Items)
                    {
                        string tenMon = item.SubItems[0].Text;
                        string sl = item.SubItems[1].Text.PadLeft(10);
                        string thanhTien = item.SubItems[3].Text.PadLeft(10);
                        billInfo.AppendLine($"Dịch vụ \t Số lượng \t Đơn giá");
                        billInfo.AppendLine($"{tenMon} {sl} {thanhTien}");
                    }
                    billInfo.AppendLine($"-------------------------------------------------");
                    billInfo.AppendLine($"Tổng: {totalPrice} đồng");
                    billInfo.AppendLine($"Giảm giá: {discount}%");
                    string totalPriceString = (finalTotalPrice).ToString("#,##0");
                    int decimalSeparatorIndex = totalPriceString.IndexOf(',');
                    if (decimalSeparatorIndex > 10)
                    {
                        totalPriceString = totalPriceString.Insert(10, ".");
                    }

                    string formattedOutput = $"Thành tiền: {totalPriceString} đồng";
                    billInfo.AppendLine(formattedOutput);
                   

                    MessageBox.Show(billInfo.ToString(), "Hóa đơn", MessageBoxButtons.OK);
                    ShowBill(roomId);
                }
            }

        }
    }
}
