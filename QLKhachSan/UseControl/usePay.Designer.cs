namespace QLKhachSan.UseControl
{
    partial class usePay
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
            panel2 = new Panel();
            dtgvBill = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            DateCheckIn = new DataGridViewTextBoxColumn();
            DateCheckOut = new DataGridViewTextBoxColumn();
            TenPhong = new DataGridViewTextBoxColumn();
            discount = new DataGridViewTextBoxColumn();
            totalprice = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            btnTim = new Button();
            button3 = new Button();
            button2 = new Button();
            txttimkiem = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBill).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.71614F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 73.28386F));
            tableLayoutPanel1.Size = new Size(1192, 539);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtgvBill);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 147);
            panel2.Name = "panel2";
            panel2.Size = new Size(1186, 389);
            panel2.TabIndex = 1;
            // 
            // dtgvBill
            // 
            dtgvBill.AllowUserToAddRows = false;
            dtgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvBill.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBill.Columns.AddRange(new DataGridViewColumn[] { id, DateCheckIn, DateCheckOut, TenPhong, discount, totalprice, status });
            dtgvBill.Dock = DockStyle.Fill;
            dtgvBill.Location = new Point(0, 0);
            dtgvBill.Name = "dtgvBill";
            dtgvBill.RowHeadersWidth = 51;
            dtgvBill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvBill.Size = new Size(1186, 389);
            dtgvBill.TabIndex = 0;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Visible = false;
            // 
            // DateCheckIn
            // 
            DateCheckIn.DataPropertyName = "DateCheckIn";
            DateCheckIn.HeaderText = "Ngày nhận";
            DateCheckIn.MinimumWidth = 6;
            DateCheckIn.Name = "DateCheckIn";
            // 
            // DateCheckOut
            // 
            DateCheckOut.DataPropertyName = "DateCheckOut";
            DateCheckOut.HeaderText = "Ngày trả";
            DateCheckOut.MinimumWidth = 6;
            DateCheckOut.Name = "DateCheckOut";
            // 
            // TenPhong
            // 
            TenPhong.DataPropertyName = "TenPhong";
            TenPhong.HeaderText = "Số Phòng";
            TenPhong.MinimumWidth = 6;
            TenPhong.Name = "TenPhong";
            // 
            // discount
            // 
            discount.DataPropertyName = "discount";
            discount.HeaderText = "Khuyến mãi";
            discount.MinimumWidth = 6;
            discount.Name = "discount";
            // 
            // totalprice
            // 
            totalprice.DataPropertyName = "totalprice";
            totalprice.HeaderText = "Tổng tiền";
            totalprice.MinimumWidth = 6;
            totalprice.Name = "totalprice";
            // 
            // status
            // 
            status.DataPropertyName = "status";
            status.HeaderText = "Trạng thái";
            status.MinimumWidth = 6;
            status.Name = "status";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel3, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 47.1014481F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 52.8985519F));
            tableLayoutPanel2.Size = new Size(1186, 138);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1180, 59);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(404, 15);
            label1.Name = "label1";
            label1.Size = new Size(179, 28);
            label1.TabIndex = 0;
            label1.Text = "Danh sách hóa đơn";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnTim);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(txttimkiem);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 68);
            panel3.Name = "panel3";
            panel3.Size = new Size(1180, 67);
            panel3.TabIndex = 1;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(263, 21);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(90, 29);
            btnTim.TabIndex = 4;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // button3
            // 
            button3.Location = new Point(754, 20);
            button3.Name = "button3";
            button3.Size = new Size(168, 29);
            button3.TabIndex = 3;
            button3.Text = "Xuất file Excel";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(538, 20);
            button2.Name = "button2";
            button2.Size = new Size(171, 29);
            button2.TabIndex = 2;
            button2.Text = "Xem chi tiết";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txttimkiem
            // 
            txttimkiem.Location = new Point(59, 21);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(189, 27);
            txttimkiem.TabIndex = 0;
            txttimkiem.TextChanged += textBox1_TextChanged;
            // 
            // usePay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "usePay";
            Size = new Size(1192, 539);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvBill).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private DataGridView dtgvBill;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Button button3;
        private Button button2;
        private TextBox txttimkiem;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn DateCheckIn;
        private DataGridViewTextBoxColumn DateCheckOut;
        private DataGridViewTextBoxColumn TenPhong;
        private DataGridViewTextBoxColumn discount;
        private DataGridViewTextBoxColumn totalprice;
        private DataGridViewTextBoxColumn status;
        private Button btnTim;
    }
}
