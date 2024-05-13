namespace QLKhachSan.UseControl
{
    partial class useOrderRoom
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            txtid = new TextBox();
            txtdiachi = new TextBox();
            label8 = new Label();
            label4 = new Label();
            dtgvDatPhong = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            cccd = new DataGridViewTextBoxColumn();
            gioitinh = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            label3 = new Label();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            panel2 = new Panel();
            btnHuy = new Button();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            cbdichvu = new ComboBox();
            label7 = new Label();
            txttamtinh = new TextBox();
            label6 = new Label();
            dtngaytra = new DateTimePicker();
            label5 = new Label();
            cbPhong = new ComboBox();
            cbKhachHang = new ComboBox();
            dtngaynhan = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dtgvDatPhong).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 5, 0, 5);
            label2.Size = new Size(172, 31);
            label2.TabIndex = 1;
            label2.Text = "Tác vụ";
            // 
            // txtid
            // 
            txtid.Location = new Point(926, 145);
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(32, 30);
            txtid.TabIndex = 13;
            // 
            // txtdiachi
            // 
            txtdiachi.Anchor = AnchorStyles.Left;
            txtdiachi.BorderStyle = BorderStyle.FixedSingle;
            txtdiachi.Location = new Point(142, 283);
            txtdiachi.Multiline = true;
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(520, 30);
            txtdiachi.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(43, 151);
            label8.Name = "label8";
            label8.Size = new Size(104, 23);
            label8.TabIndex = 11;
            label8.Text = "Ngày nhận :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(31, 101);
            label4.Name = "label4";
            label4.Size = new Size(120, 23);
            label4.TabIndex = 2;
            label4.Text = "Chọn phòng : ";
            // 
            // dtgvDatPhong
            // 
            dtgvDatPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvDatPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDatPhong.Columns.AddRange(new DataGridViewColumn[] { id, name, date, phone, cccd, gioitinh, address });
            dtgvDatPhong.Dock = DockStyle.Fill;
            dtgvDatPhong.Location = new Point(0, 270);
            dtgvDatPhong.Name = "dtgvDatPhong";
            dtgvDatPhong.RowHeadersWidth = 51;
            dtgvDatPhong.Size = new Size(1064, 287);
            dtgvDatPhong.TabIndex = 3;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Visible = false;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            name.DataPropertyName = "TenKhachHang";
            name.HeaderText = "Khách hàng";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 183;
            // 
            // date
            // 
            date.DataPropertyName = "PhongDat";
            date.HeaderText = "Phòng";
            date.MinimumWidth = 6;
            date.Name = "date";
            // 
            // phone
            // 
            phone.DataPropertyName = "NgayNhan";
            phone.HeaderText = "Ngày nhận";
            phone.MinimumWidth = 6;
            phone.Name = "phone";
            phone.ReadOnly = true;
            // 
            // cccd
            // 
            cccd.DataPropertyName = "NgayTra";
            cccd.HeaderText = "Ngày trả";
            cccd.MinimumWidth = 6;
            cccd.Name = "cccd";
            cccd.ReadOnly = true;
            // 
            // gioitinh
            // 
            gioitinh.DataPropertyName = "DichVu";
            gioitinh.HeaderText = "Dịch vụ(nếu có)";
            gioitinh.MinimumWidth = 6;
            gioitinh.Name = "gioitinh";
            gioitinh.ReadOnly = true;
            // 
            // address
            // 
            address.DataPropertyName = "TamTinh";
            address.HeaderText = "Tạm tính";
            address.MinimumWidth = 6;
            address.Name = "address";
            address.ReadOnly = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(36, 54);
            label3.Name = "label3";
            label3.Size = new Size(115, 23);
            label3.TabIndex = 1;
            label3.Text = "Khách hàng : ";
            // 
            // btnXoa
            // 
            btnXoa.BackgroundImageLayout = ImageLayout.Zoom;
            btnXoa.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(46, 206);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 36);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackgroundImageLayout = ImageLayout.Zoom;
            btnSua.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(46, 152);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 36);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackgroundImageLayout = ImageLayout.Zoom;
            btnThem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(46, 101);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 36);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnThem);
            panel2.Controls.Add(btnHuy);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(887, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(174, 264);
            panel2.TabIndex = 1;
            // 
            // btnHuy
            // 
            btnHuy.BackgroundImageLayout = ImageLayout.Zoom;
            btnHuy.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.Location = new Point(46, 47);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 36);
            btnHuy.TabIndex = 2;
            btnHuy.Text = "Hủy bỏ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 5, 0, 5);
            label1.Size = new Size(876, 31);
            label1.TabIndex = 0;
            label1.Text = "Đặt phòng";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1064, 270);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cbdichvu);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txttamtinh);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dtngaytra);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cbPhong);
            panel1.Controls.Add(cbKhachHang);
            panel1.Controls.Add(txtid);
            panel1.Controls.Add(txtdiachi);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(dtngaynhan);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(878, 264);
            panel1.TabIndex = 0;
            // 
            // cbdichvu
            // 
            cbdichvu.FormattingEnabled = true;
            cbdichvu.Location = new Point(501, 192);
            cbdichvu.Name = "cbdichvu";
            cbdichvu.Size = new Size(225, 31);
            cbdichvu.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(409, 196);
            label7.Name = "label7";
            label7.Size = new Size(77, 23);
            label7.TabIndex = 20;
            label7.Text = "Dịch vụ :";
            // 
            // txttamtinh
            // 
            txttamtinh.Location = new Point(172, 193);
            txttamtinh.Name = "txttamtinh";
            txttamtinh.Size = new Size(225, 30);
            txttamtinh.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 196);
            label6.Name = "label6";
            label6.Size = new Size(92, 23);
            label6.TabIndex = 18;
            label6.Text = "Tạm tính : ";
            // 
            // dtngaytra
            // 
            dtngaytra.Location = new Point(501, 148);
            dtngaytra.Name = "dtngaytra";
            dtngaytra.Size = new Size(225, 30);
            dtngaytra.TabIndex = 17;
            dtngaytra.ValueChanged += dtngaytra_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(409, 152);
            label5.Name = "label5";
            label5.Size = new Size(86, 23);
            label5.TabIndex = 16;
            label5.Text = "Ngày trả :";
            // 
            // cbPhong
            // 
            cbPhong.FormattingEnabled = true;
            cbPhong.Location = new Point(172, 98);
            cbPhong.Name = "cbPhong";
            cbPhong.Size = new Size(554, 31);
            cbPhong.TabIndex = 15;
            // 
            // cbKhachHang
            // 
            cbKhachHang.FormattingEnabled = true;
            cbKhachHang.Location = new Point(172, 47);
            cbKhachHang.Name = "cbKhachHang";
            cbKhachHang.Size = new Size(554, 31);
            cbKhachHang.TabIndex = 14;
            // 
            // dtngaynhan
            // 
            dtngaynhan.Location = new Point(172, 148);
            dtngaynhan.Name = "dtngaynhan";
            dtngaynhan.Size = new Size(225, 30);
            dtngaynhan.TabIndex = 9;
            // 
            // useOrderRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dtgvDatPhong);
            Controls.Add(tableLayoutPanel1);
            Name = "useOrderRoom";
            Size = new Size(1064, 557);
            ((System.ComponentModel.ISupportInitialize)dtgvDatPhong).EndInit();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private TextBox txtid;
        private TextBox txtdiachi;
        private Label label8;
        private Label label4;
        private DataGridView dtgvDatPhong;
        private Label label3;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Panel panel2;
        private Button btnHuy;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private ComboBox cbKhachHang;
        private DateTimePicker dtngaynhan;
        private DateTimePicker dtngaytra;
        private Label label5;
        private ComboBox cbPhong;
        private Label label6;
        private Label label7;
        private TextBox txttamtinh;
        private ComboBox cbdichvu;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn cccd;
        private DataGridViewTextBoxColumn gioitinh;
        private DataGridViewTextBoxColumn address;
    }
}
