namespace QLKhachSan.UseControl
{
    partial class useUser
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            txtid = new TextBox();
            txtdiachi = new TextBox();
            label8 = new Label();
            txtcccd = new TextBox();
            dtnamsinh = new DateTimePicker();
            txtgioitinh = new TextBox();
            txtsdt = new TextBox();
            txtName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnHuy = new Button();
            label2 = new Label();
            dtgvKhachHang = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            cccd = new DataGridViewTextBoxColumn();
            gioitinh = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvKhachHang).BeginInit();
            SuspendLayout();
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
            tableLayoutPanel1.Size = new Size(1149, 270);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtid);
            panel1.Controls.Add(txtdiachi);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtcccd);
            panel1.Controls.Add(dtnamsinh);
            panel1.Controls.Add(txtgioitinh);
            panel1.Controls.Add(txtsdt);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(963, 264);
            panel1.TabIndex = 0;
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
            txtdiachi.Location = new Point(142, 202);
            txtdiachi.Multiline = true;
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(520, 30);
            txtdiachi.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 206);
            label8.Name = "label8";
            label8.Size = new Size(71, 23);
            label8.TabIndex = 11;
            label8.Text = "Địa chỉ :";
            // 
            // txtcccd
            // 
            txtcccd.BorderStyle = BorderStyle.FixedSingle;
            txtcccd.Location = new Point(452, 98);
            txtcccd.Name = "txtcccd";
            txtcccd.Size = new Size(210, 30);
            txtcccd.TabIndex = 10;
            // 
            // dtnamsinh
            // 
            dtnamsinh.Location = new Point(142, 98);
            dtnamsinh.Name = "dtnamsinh";
            dtnamsinh.Size = new Size(210, 30);
            dtnamsinh.TabIndex = 9;
            // 
            // txtgioitinh
            // 
            txtgioitinh.BorderStyle = BorderStyle.FixedSingle;
            txtgioitinh.Location = new Point(452, 150);
            txtgioitinh.Multiline = true;
            txtgioitinh.Name = "txtgioitinh";
            txtgioitinh.Size = new Size(210, 30);
            txtgioitinh.TabIndex = 8;
            // 
            // txtsdt
            // 
            txtsdt.BorderStyle = BorderStyle.FixedSingle;
            txtsdt.Location = new Point(142, 150);
            txtsdt.Multiline = true;
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(210, 30);
            txtsdt.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Left;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(142, 47);
            txtName.Name = "txtName";
            txtName.Size = new Size(520, 30);
            txtName.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(360, 152);
            label7.Name = "label7";
            label7.Size = new Size(84, 23);
            label7.TabIndex = 5;
            label7.Text = "Giới tính :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(360, 101);
            label6.Name = "label6";
            label6.Size = new Size(64, 23);
            label6.TabIndex = 4;
            label6.Text = "CCCD :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 156);
            label5.Name = "label5";
            label5.Size = new Size(49, 23);
            label5.TabIndex = 3;
            label5.Text = "SĐT :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(25, 101);
            label4.Name = "label4";
            label4.Size = new Size(96, 23);
            label4.TabIndex = 2;
            label4.Text = "Ngày sinh :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(25, 47);
            label3.Name = "label3";
            label3.Size = new Size(95, 23);
            label3.TabIndex = 1;
            label3.Text = "Họ và tên :";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 5, 0, 5);
            label1.Size = new Size(961, 31);
            label1.TabIndex = 0;
            label1.Text = "Thông tin khách hàng";
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
            panel2.Location = new Point(972, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(174, 264);
            panel2.TabIndex = 1;
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
            btnXoa.Click += button4_Click;
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
            btnHuy.Click += button1_Click;
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
            // dtgvKhachHang
            // 
            dtgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { id, name, date, phone, cccd, gioitinh, address });
            dtgvKhachHang.Dock = DockStyle.Fill;
            dtgvKhachHang.Location = new Point(0, 270);
            dtgvKhachHang.Name = "dtgvKhachHang";
            dtgvKhachHang.RowHeadersWidth = 51;
            dtgvKhachHang.Size = new Size(1149, 204);
            dtgvKhachHang.TabIndex = 1;
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
            name.DataPropertyName = "name";
            name.HeaderText = "Họ và tên";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 183;
            // 
            // date
            // 
            date.DataPropertyName = "sinhnam";
            date.HeaderText = "Năm sinh";
            date.MinimumWidth = 6;
            date.Name = "date";
            // 
            // phone
            // 
            phone.DataPropertyName = "sdt";
            phone.HeaderText = "SĐT";
            phone.MinimumWidth = 6;
            phone.Name = "phone";
            phone.ReadOnly = true;
            // 
            // cccd
            // 
            cccd.DataPropertyName = "cccd";
            cccd.HeaderText = "CCCD";
            cccd.MinimumWidth = 6;
            cccd.Name = "cccd";
            cccd.ReadOnly = true;
            // 
            // gioitinh
            // 
            gioitinh.DataPropertyName = "gioitinh";
            gioitinh.HeaderText = "Giới tính";
            gioitinh.MinimumWidth = 6;
            gioitinh.Name = "gioitinh";
            gioitinh.ReadOnly = true;
            // 
            // address
            // 
            address.DataPropertyName = "diachi";
            address.HeaderText = "Địa chỉ";
            address.MinimumWidth = 6;
            address.Name = "address";
            address.ReadOnly = true;
            // 
            // useUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(dtgvKhachHang);
            Controls.Add(tableLayoutPanel1);
            Name = "useUser";
            Size = new Size(1149, 474);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvKhachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dtgvKhachHang;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnHuy;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox txtcccd;
        private DateTimePicker dtnamsinh;
        private TextBox txtgioitinh;
        private TextBox txtsdt;
        private TextBox txtName;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtdiachi;
        private Label label8;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn cccd;
        private DataGridViewTextBoxColumn gioitinh;
        private DataGridViewTextBoxColumn address;
        private TextBox txtid;
    }
}
