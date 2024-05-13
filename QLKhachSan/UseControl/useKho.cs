using OfficeOpenXml;
using QLKhachSan.DAO;
using QLKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace QLKhachSan.UseControl
{
    public partial class useKho : UserControl
    {
        BindingSource vattu = new BindingSource();
        public useKho()
        {
            InitializeComponent();
            LoadListVatTu();
            dtgvKho.DataSource = vattu;
        }
        List<VatTu> SearchVatTuByName(string tenvattu)
        {
            List<VatTu> listfood = VatTuDAO.Instance.SearchVatTuByName(tenvattu);

            return listfood;
        }
        void LoadListVatTu()
        {
            vattu.DataSource = VatTuDAO.Instance.GetVatTu();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            formVatTu form = new formVatTu();


            form.SetMode("Thêm");


            form.ShowDialog();
            LoadListVatTu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {


            if (dtgvKho.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dtgvKho.SelectedRows[0];


                int id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                string tenVatTu = selectedRow.Cells["TenVatTu"].Value.ToString();
                int soLuong = Convert.ToInt32(selectedRow.Cells["SoLuong"].Value);
                float donGia = float.Parse(selectedRow.Cells["DonGia"].Value.ToString());
                string ghiChu = selectedRow.Cells["GhiChu"].Value.ToString();


                formVatTu form = new formVatTu();


                form.SetMode("Sửa");


                form.SetValues(id, tenVatTu, soLuong, donGia, ghiChu);


                form.ShowDialog();
                LoadListVatTu();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dtgvKho.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dtgvKho.SelectedRows[0];

                // Lấy thông tin từ các ô trong dòng được chọn
                int id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                string tenVatTu = selectedRow.Cells["TenVatTu"].Value.ToString();


                if (VatTuDAO.Instance.DeleteVatTu(id))
                {
                    MessageBox.Show($"Xóa {tenVatTu} thành công");
                    LoadListVatTu();
                }
                else
                {
                    MessageBox.Show($"Xóa {tenVatTu} thất bại");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnxemchitiet_Click(object sender, EventArgs e)
        {
            if (dtgvKho.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dtgvKho.SelectedRows[0];


                int id = Convert.ToInt32(selectedRow.Cells["id"].Value);
                string tenVatTu = selectedRow.Cells["TenVatTu"].Value.ToString();
                int soLuong = Convert.ToInt32(selectedRow.Cells["SoLuong"].Value);
                float donGia = float.Parse(selectedRow.Cells["DonGia"].Value.ToString());
                string ghiChu = selectedRow.Cells["GhiChu"].Value.ToString();


                string message = $"Mã vật tư: {id}\n" +
                                 $"Tên vật tư: {tenVatTu}\n" +
                                 $"Số lượng: {soLuong} cái\n" +
                                 $"Đơn giá: {donGia} đồng\n" +
                                 $"Ghi chú: {ghiChu}";


                MessageBox.Show(message, $"Thông tin chi tiết của {tenVatTu}", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xem chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnxuatfile_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            if (dtgvKho.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog.FileName = "Bảng vật tư.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo file = new FileInfo(saveFileDialog.FileName);
                    using (ExcelPackage package = new ExcelPackage(file))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Bills");

                        // Thêm tiêu đề cho các cột
                        for (int i = 1; i <= dtgvKho.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i].Value = dtgvKho.Columns[i - 1].HeaderText;
                        }

                        // Thêm dữ liệu từ DataGridView vào file Excel
                        for (int i = 0; i < dtgvKho.Rows.Count; i++)
                        {
                            for (int j = 0; j < dtgvKho.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1].Value = dtgvKho.Rows[i].Cells[j].Value.ToString();
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

        private void btntim_Click(object sender, EventArgs e)
        {
            vattu.DataSource = SearchVatTuByName(txttimkiem.Text);
        }
    }
}
