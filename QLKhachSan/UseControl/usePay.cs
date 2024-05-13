using OfficeOpenXml;
using QLKhachSan.DAO;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseContext = OfficeOpenXml.LicenseContext;
using QLKhachSan.DTO;

namespace QLKhachSan.UseControl
{
    public partial class usePay : UserControl
    {
        BindingSource pay = new BindingSource();
        public usePay()
        {
            InitializeComponent();
            LoadListBill();
            dtgvBill.DataSource = pay;
        }
        void LoadListBill()
        {
            pay.DataSource = PayDAO.Instance.GetBillList();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            if (dtgvBill.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog.FileName = "Danh sách hóa đơn.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo file = new FileInfo(saveFileDialog.FileName);
                    using (ExcelPackage package = new ExcelPackage(file))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Bills");

                        // Thêm tiêu đề cho các cột
                        for (int i = 1; i <= dtgvBill.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i].Value = dtgvBill.Columns[i - 1].HeaderText;
                        }

                        // Thêm dữ liệu từ DataGridView vào file Excel
                        for (int i = 0; i < dtgvBill.Rows.Count; i++)
                        {
                            for (int j = 0; j < dtgvBill.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1].Value = dtgvBill.Rows[i].Cells[j].Value.ToString();
                            }
                        }

                        package.Save();
                    }

                    MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất ra file Excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dtgvBill.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgvBill.SelectedRows[0];


                string dateCheckIn = selectedRow.Cells["DateCheckIn"].Value.ToString();
                string dateCheckOut = selectedRow.Cells["DateCheckOut"].Value.ToString();
                string id = selectedRow.Cells["id"].Value.ToString();
                string roomName = selectedRow.Cells["TenPhong"].Value.ToString();
                string status = selectedRow.Cells["status"].Value.ToString();
                string discount = selectedRow.Cells["discount"].Value.ToString();
                string totalPrice = selectedRow.Cells["totalprice"].Value.ToString();


                string message = $"STT: {id}\n" +
                                 $"Ngày nhận phòng: {dateCheckIn}\n" +
                                 $"Ngày trả phòng: {dateCheckOut}\n" +
                                 $"Phòng: {roomName}\n" +
                                 $"Trạng thái: {status}\n" +
                                 $"Khuyến mãi: {discount}% \n" +
                                 $"Thành tiền: {totalPrice} đồng";

                MessageBox.Show(message, $"Thông tin hóa đơn  chi tiết của {roomName}", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xem chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        List<Pay> SearchPayByName(string tenphong)
        {
            List<Pay> listpay = PayDAO.Instance.SearchPayByName(tenphong);

            return listpay;
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            pay.DataSource = SearchPayByName(txttimkiem.Text);
        }
    }
}
