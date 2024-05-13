namespace QLKhachSan
{
    partial class Admin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            dtgvPhong = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            panel6 = new Panel();
            lbstatus = new Label();
            txtphong = new TextBox();
            lbidphong = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            panel1 = new Panel();
            btnxemchitiet = new Button();
            btnxoa = new Button();
            btnsua = new Button();
            btnthem = new Button();
            tabPage2 = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            dtgvdichvu = new DataGridView();
            iddichvu = new DataGridViewTextBoxColumn();
            namedichvu = new DataGridViewTextBoxColumn();
            dongia = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
            lbiddichvu = new Label();
            txtprice = new TextBox();
            txtnamedichvu = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            tabPage3 = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel3 = new Panel();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            dtgvnguoidung = new DataGridView();
            UserName = new DataGridViewTextBoxColumn();
            DisplayName = new DataGridViewTextBoxColumn();
            TenQuyen = new DataGridViewTextBoxColumn();
            idQuyen = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            btnresetpass = new Button();
            cbquyen = new ComboBox();
            txtmatkhau = new TextBox();
            txttenhienthi = new TextBox();
            txttendangnhap = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvPhong).BeginInit();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvdichvu).BeginInit();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            tabPage3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvnguoidung).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tabControl1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(912, 517);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(906, 511);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(898, 478);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Danh sách phòng";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel7, 0, 1);
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.2881355F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 87.71186F));
            tableLayoutPanel2.Size = new Size(892, 472);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.6480446F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.3519554F));
            tableLayoutPanel7.Controls.Add(dtgvPhong, 0, 0);
            tableLayoutPanel7.Controls.Add(panel6, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 61);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(886, 408);
            tableLayoutPanel7.TabIndex = 2;
            // 
            // dtgvPhong
            // 
            dtgvPhong.AllowUserToAddRows = false;
            dtgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvPhong.Columns.AddRange(new DataGridViewColumn[] { id, name, status });
            dtgvPhong.Dock = DockStyle.Fill;
            dtgvPhong.Location = new Point(3, 3);
            dtgvPhong.Name = "dtgvPhong";
            dtgvPhong.RowHeadersWidth = 51;
            dtgvPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvPhong.Size = new Size(495, 402);
            dtgvPhong.TabIndex = 0;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "Mã phòng";
            id.MinimumWidth = 6;
            id.Name = "id";
            // 
            // name
            // 
            name.DataPropertyName = "name";
            name.HeaderText = "Số phòng";
            name.MinimumWidth = 6;
            name.Name = "name";
            // 
            // status
            // 
            status.DataPropertyName = "status";
            status.HeaderText = "Trạng thái";
            status.MinimumWidth = 6;
            status.Name = "status";
            // 
            // panel6
            // 
            panel6.Controls.Add(lbstatus);
            panel6.Controls.Add(txtphong);
            panel6.Controls.Add(lbidphong);
            panel6.Controls.Add(label14);
            panel6.Controls.Add(label13);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(label11);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(504, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(379, 402);
            panel6.TabIndex = 1;
            // 
            // lbstatus
            // 
            lbstatus.AutoSize = true;
            lbstatus.Location = new Point(133, 157);
            lbstatus.Name = "lbstatus";
            lbstatus.Size = new Size(18, 20);
            lbstatus.TabIndex = 6;
            lbstatus.Text = "...";
            // 
            // txtphong
            // 
            txtphong.Location = new Point(129, 104);
            txtphong.Name = "txtphong";
            txtphong.Size = new Size(210, 27);
            txtphong.TabIndex = 5;
            // 
            // lbidphong
            // 
            lbidphong.AutoSize = true;
            lbidphong.Location = new Point(129, 61);
            lbidphong.Name = "lbidphong";
            lbidphong.Size = new Size(18, 20);
            lbidphong.TabIndex = 4;
            lbidphong.Text = "...";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(41, 157);
            label14.Name = "label14";
            label14.Size = new Size(86, 20);
            label14.TabIndex = 3;
            label14.Text = "Trạng thái : ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(40, 108);
            label13.Name = "label13";
            label13.Size = new Size(80, 20);
            label13.TabIndex = 2;
            label13.Text = "Số phòng :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(35, 61);
            label12.Name = "label12";
            label12.Size = new Size(88, 20);
            label12.TabIndex = 1;
            label12.Text = "Mã phòng : ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(121, 18);
            label11.Name = "label11";
            label11.Size = new Size(145, 23);
            label11.TabIndex = 0;
            label11.Text = "Thông tin phòng";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnxemchitiet);
            panel1.Controls.Add(btnxoa);
            panel1.Controls.Add(btnsua);
            panel1.Controls.Add(btnthem);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(886, 52);
            panel1.TabIndex = 0;
            // 
            // btnxemchitiet
            // 
            btnxemchitiet.Location = new Point(311, 12);
            btnxemchitiet.Name = "btnxemchitiet";
            btnxemchitiet.Size = new Size(117, 29);
            btnxemchitiet.TabIndex = 3;
            btnxemchitiet.Text = "Xem chi tiết";
            btnxemchitiet.UseVisualStyleBackColor = true;
            btnxemchitiet.Click += btnxemchitiet_Click;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(211, 12);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(94, 29);
            btnxoa.TabIndex = 2;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(111, 12);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(94, 29);
            btnsua.TabIndex = 1;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(11, 12);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(94, 29);
            btnthem.TabIndex = 0;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(898, 478);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Danh sách dịch vụ";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel3.Controls.Add(panel2, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 11.7894735F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 88.2105255F));
            tableLayoutPanel3.Size = new Size(892, 472);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.6480446F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.3519554F));
            tableLayoutPanel6.Controls.Add(dtgvdichvu, 0, 0);
            tableLayoutPanel6.Controls.Add(panel5, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 58);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(886, 411);
            tableLayoutPanel6.TabIndex = 2;
            // 
            // dtgvdichvu
            // 
            dtgvdichvu.AllowUserToAddRows = false;
            dtgvdichvu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvdichvu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvdichvu.Columns.AddRange(new DataGridViewColumn[] { iddichvu, namedichvu, dongia });
            dtgvdichvu.Dock = DockStyle.Fill;
            dtgvdichvu.Location = new Point(3, 3);
            dtgvdichvu.Name = "dtgvdichvu";
            dtgvdichvu.RowHeadersWidth = 51;
            dtgvdichvu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvdichvu.Size = new Size(495, 405);
            dtgvdichvu.TabIndex = 0;
            // 
            // iddichvu
            // 
            iddichvu.DataPropertyName = "idDichvu";
            iddichvu.HeaderText = "Mã dịch vụ";
            iddichvu.MinimumWidth = 6;
            iddichvu.Name = "iddichvu";
            // 
            // namedichvu
            // 
            namedichvu.DataPropertyName = "name";
            namedichvu.HeaderText = "Tên dịch vụ";
            namedichvu.MinimumWidth = 6;
            namedichvu.Name = "namedichvu";
            // 
            // dongia
            // 
            dongia.DataPropertyName = "price";
            dongia.HeaderText = "Đơn giá";
            dongia.MinimumWidth = 6;
            dongia.Name = "dongia";
            // 
            // panel5
            // 
            panel5.Controls.Add(lbiddichvu);
            panel5.Controls.Add(txtprice);
            panel5.Controls.Add(txtnamedichvu);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(504, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(379, 405);
            panel5.TabIndex = 1;
            // 
            // lbiddichvu
            // 
            lbiddichvu.AutoSize = true;
            lbiddichvu.Location = new Point(137, 58);
            lbiddichvu.Name = "lbiddichvu";
            lbiddichvu.Size = new Size(18, 20);
            lbiddichvu.TabIndex = 7;
            lbiddichvu.Text = "...";
            // 
            // txtprice
            // 
            txtprice.Location = new Point(137, 152);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(204, 27);
            txtprice.TabIndex = 6;
            // 
            // txtnamedichvu
            // 
            txtnamedichvu.Location = new Point(137, 103);
            txtnamedichvu.Name = "txtnamedichvu";
            txtnamedichvu.Size = new Size(204, 27);
            txtnamedichvu.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(61, 155);
            label9.Name = "label9";
            label9.Size = new Size(69, 20);
            label9.TabIndex = 3;
            label9.Text = "Đơn giá :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 106);
            label8.Name = "label8";
            label8.Size = new Size(90, 20);
            label8.TabIndex = 2;
            label8.Text = "Tên dịch vụ :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 56);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 1;
            label7.Text = "Mã dịch vụ : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(117, 14);
            label6.Name = "label6";
            label6.Size = new Size(151, 23);
            label6.TabIndex = 0;
            label6.Text = "Thông tin dịch vụ";
            // 
            // panel2
            // 
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(886, 49);
            panel2.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new Point(311, 13);
            button4.Name = "button4";
            button4.Size = new Size(115, 29);
            button4.TabIndex = 3;
            button4.Text = "Xem chi tiết";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(211, 13);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(111, 13);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(11, 13);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tableLayoutPanel4);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(898, 478);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Danh sách người dùng";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(panel3, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 12.7615061F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 87.2384949F));
            tableLayoutPanel4.Size = new Size(898, 478);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(button8);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(892, 55);
            panel3.TabIndex = 0;
            // 
            // button8
            // 
            button8.Location = new Point(312, 14);
            button8.Name = "button8";
            button8.Size = new Size(118, 29);
            button8.TabIndex = 3;
            button8.Text = "Làm mới ";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(212, 14);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 2;
            button7.Text = "Xóa";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(112, 14);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 1;
            button6.Text = "Sửa";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(12, 14);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 0;
            button5.Text = "Thêm";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.6480446F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.3519554F));
            tableLayoutPanel5.Controls.Add(dtgvnguoidung, 0, 0);
            tableLayoutPanel5.Controls.Add(panel4, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 64);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(892, 411);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // dtgvnguoidung
            // 
            dtgvnguoidung.AllowUserToAddRows = false;
            dtgvnguoidung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvnguoidung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvnguoidung.Columns.AddRange(new DataGridViewColumn[] { UserName, DisplayName, TenQuyen, idQuyen });
            dtgvnguoidung.Dock = DockStyle.Fill;
            dtgvnguoidung.Location = new Point(3, 3);
            dtgvnguoidung.Name = "dtgvnguoidung";
            dtgvnguoidung.RowHeadersWidth = 51;
            dtgvnguoidung.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvnguoidung.Size = new Size(499, 405);
            dtgvnguoidung.TabIndex = 0;
            // 
            // UserName
            // 
            UserName.DataPropertyName = "UserName";
            UserName.HeaderText = "Tên đăng nhập";
            UserName.MinimumWidth = 6;
            UserName.Name = "UserName";
            // 
            // DisplayName
            // 
            DisplayName.DataPropertyName = "DisplayName";
            DisplayName.HeaderText = "Tên hiển thị";
            DisplayName.MinimumWidth = 6;
            DisplayName.Name = "DisplayName";
            // 
            // TenQuyen
            // 
            TenQuyen.DataPropertyName = "TenQuyen";
            TenQuyen.HeaderText = "Chức năng";
            TenQuyen.MinimumWidth = 6;
            TenQuyen.Name = "TenQuyen";
            // 
            // idQuyen
            // 
            idQuyen.DataPropertyName = "idQuyen";
            idQuyen.HeaderText = "idQuyen";
            idQuyen.MinimumWidth = 6;
            idQuyen.Name = "idQuyen";
            idQuyen.Visible = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnresetpass);
            panel4.Controls.Add(cbquyen);
            panel4.Controls.Add(txtmatkhau);
            panel4.Controls.Add(txttenhienthi);
            panel4.Controls.Add(txttendangnhap);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(508, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(381, 405);
            panel4.TabIndex = 1;
            // 
            // btnresetpass
            // 
            btnresetpass.Location = new Point(68, 354);
            btnresetpass.Name = "btnresetpass";
            btnresetpass.Size = new Size(265, 29);
            btnresetpass.TabIndex = 4;
            btnresetpass.Text = "Đặt lại mật khẩu";
            btnresetpass.UseVisualStyleBackColor = true;
            btnresetpass.Click += btnresetpass_Click;
            // 
            // cbquyen
            // 
            cbquyen.FormattingEnabled = true;
            cbquyen.Location = new Point(145, 163);
            cbquyen.Name = "cbquyen";
            cbquyen.Size = new Size(207, 28);
            cbquyen.TabIndex = 8;
            // 
            // txtmatkhau
            // 
            txtmatkhau.Location = new Point(142, 211);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.Size = new Size(210, 27);
            txtmatkhau.TabIndex = 7;
            txtmatkhau.UseSystemPasswordChar = true;
            // 
            // txttenhienthi
            // 
            txttenhienthi.Location = new Point(142, 110);
            txttenhienthi.Name = "txttenhienthi";
            txttenhienthi.Size = new Size(210, 27);
            txttenhienthi.TabIndex = 6;
            // 
            // txttendangnhap
            // 
            txttendangnhap.Location = new Point(142, 62);
            txttendangnhap.Name = "txttendangnhap";
            txttendangnhap.Size = new Size(210, 27);
            txttendangnhap.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 214);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 4;
            label5.Text = "Mật khẩu : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 165);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 3;
            label4.Text = "Quyền : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 113);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên hiển thị : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 65);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(122, 17);
            label1.Name = "label1";
            label1.Size = new Size(161, 23);
            label1.TabIndex = 0;
            label1.Text = "Thông người dùng";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 517);
            Controls.Add(tableLayoutPanel1);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản trị admin";
            tableLayoutPanel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvPhong).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvdichvu).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvnguoidung).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Button btnxemchitiet;
        private Button btnxoa;
        private Button btnsua;
        private Button btnthem;
        private TabPage tabPage3;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel3;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private TableLayoutPanel tableLayoutPanel7;
        private DataGridView dtgvPhong;
        private TableLayoutPanel tableLayoutPanel6;
        private DataGridView dtgvdichvu;
        private TableLayoutPanel tableLayoutPanel5;
        private DataGridView dtgvnguoidung;
        private Panel panel4;
        private TextBox txttendangnhap;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbquyen;
        private TextBox txtmatkhau;
        private TextBox txttenhienthi;
        private Button btnresetpass;
        private Panel panel5;
        private Label lbiddichvu;
        private TextBox txtprice;
        private TextBox txtnamedichvu;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Panel panel6;
        private Label lbstatus;
        private TextBox txtphong;
        private Label lbidphong;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn DisplayName;
        private DataGridViewTextBoxColumn TenQuyen;
        private DataGridViewTextBoxColumn idQuyen;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn iddichvu;
        private DataGridViewTextBoxColumn namedichvu;
        private DataGridViewTextBoxColumn dongia;
    }
}