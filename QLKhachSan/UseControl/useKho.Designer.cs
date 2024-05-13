namespace QLKhachSan.UseControl
{
    partial class useKho
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
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            panel2 = new Panel();
            btnxemchitiet = new Button();
            btnxuatfile = new Button();
            txttimkiem = new TextBox();
            btntim = new Button();
            button3 = new Button();
            btnSua = new Button();
            btnThem = new Button();
            dtgvKho = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            TenVatTu = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            GhiChu = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvKho).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dtgvKho, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.167038F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 74.83296F));
            tableLayoutPanel1.Size = new Size(945, 512);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(939, 122);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 37.38318F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 62.61682F));
            tableLayoutPanel2.Size = new Size(939, 122);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(933, 45);
            label1.TabIndex = 0;
            label1.Text = "Quản lý kho";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnxemchitiet);
            panel2.Controls.Add(btnxuatfile);
            panel2.Controls.Add(txttimkiem);
            panel2.Controls.Add(btntim);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(btnSua);
            panel2.Controls.Add(btnThem);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(933, 71);
            panel2.TabIndex = 1;
            // 
            // btnxemchitiet
            // 
            btnxemchitiet.Location = new Point(351, 21);
            btnxemchitiet.Name = "btnxemchitiet";
            btnxemchitiet.Size = new Size(126, 29);
            btnxemchitiet.TabIndex = 6;
            btnxemchitiet.Text = "Xem chi tiết";
            btnxemchitiet.UseVisualStyleBackColor = true;
            btnxemchitiet.Click += btnxemchitiet_Click;
            // 
            // btnxuatfile
            // 
            btnxuatfile.Location = new Point(496, 21);
            btnxuatfile.Name = "btnxuatfile";
            btnxuatfile.Size = new Size(94, 29);
            btnxuatfile.TabIndex = 5;
            btnxuatfile.Text = "Xuất file";
            btnxuatfile.UseVisualStyleBackColor = true;
            btnxuatfile.Click += btnxuatfile_Click;
            // 
            // txttimkiem
            // 
            txttimkiem.Location = new Point(27, 21);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(195, 27);
            txttimkiem.TabIndex = 4;
            txttimkiem.TextChanged += textBox1_TextChanged;
            // 
            // btntim
            // 
            btntim.Location = new Point(228, 21);
            btntim.Name = "btntim";
            btntim.Size = new Size(94, 29);
            btntim.TabIndex = 3;
            btntim.Text = "Tìm";
            btntim.UseVisualStyleBackColor = true;
            btntim.Click += btntim_Click;
            // 
            // button3
            // 
            button3.Location = new Point(819, 19);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(713, 19);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa ";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(605, 21);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dtgvKho
            // 
            dtgvKho.AllowUserToAddRows = false;
            dtgvKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvKho.Columns.AddRange(new DataGridViewColumn[] { id, TenVatTu, SoLuong, DonGia, GhiChu });
            dtgvKho.Dock = DockStyle.Fill;
            dtgvKho.Location = new Point(3, 131);
            dtgvKho.Name = "dtgvKho";
            dtgvKho.RowHeadersWidth = 51;
            dtgvKho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvKho.Size = new Size(939, 378);
            dtgvKho.TabIndex = 1;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "Mã vật tư";
            id.MinimumWidth = 6;
            id.Name = "id";
            // 
            // TenVatTu
            // 
            TenVatTu.DataPropertyName = "TenVatTu";
            TenVatTu.HeaderText = "Tên vật tư";
            TenVatTu.MinimumWidth = 6;
            TenVatTu.Name = "TenVatTu";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn giá";
            DonGia.MinimumWidth = 6;
            DonGia.Name = "DonGia";
            // 
            // GhiChu
            // 
            GhiChu.DataPropertyName = "GhiChu";
            GhiChu.HeaderText = "Ghi chú";
            GhiChu.MinimumWidth = 6;
            GhiChu.Name = "GhiChu";
            // 
            // useKho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "useKho";
            Size = new Size(945, 512);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvKho).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private TextBox txttimkiem;
        private Button btntim;
        private Button button3;
        private Button btnSua;
        private Button btnThem;
        private Button btnxemchitiet;
        private Button btnxuatfile;
        private DataGridView dtgvKho;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn TenVatTu;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn GhiChu;
    }
}
