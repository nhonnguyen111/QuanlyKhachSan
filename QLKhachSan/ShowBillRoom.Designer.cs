namespace QLKhachSan
{
    partial class ShowBillRoom
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
            panel1 = new Panel();
            dtgvFood = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            idDichvu = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panel4 = new Panel();
            label2 = new Label();
            txtdiscount = new TextBox();
            label1 = new Label();
            txttotalPrice = new TextBox();
            button1 = new Button();
            panel3 = new Panel();
            lsvBill = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFood).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvFood);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 456);
            panel1.TabIndex = 0;
            // 
            // dtgvFood
            // 
            dtgvFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvFood.BorderStyle = BorderStyle.None;
            dtgvFood.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgvFood.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dtgvFood.ColumnHeadersHeight = 29;
            dtgvFood.Columns.AddRange(new DataGridViewColumn[] { name, idDichvu, price });
            dtgvFood.Dock = DockStyle.Fill;
            dtgvFood.Location = new Point(0, 0);
            dtgvFood.Name = "dtgvFood";
            dtgvFood.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgvFood.RowHeadersVisible = false;
            dtgvFood.RowHeadersWidth = 51;
            dtgvFood.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvFood.Size = new Size(323, 456);
            dtgvFood.TabIndex = 0;
            dtgvFood.CellClick += dtgvFood_CellClick;
            // 
            // name
            // 
            name.DataPropertyName = "name";
            name.HeaderText = "Tên dịch vụ";
            name.MinimumWidth = 6;
            name.Name = "name";
            // 
            // idDichvu
            // 
            idDichvu.DataPropertyName = "idDichVu";
            idDichvu.HeaderText = "id";
            idDichvu.MinimumWidth = 6;
            idDichvu.Name = "idDichvu";
            idDichvu.Visible = false;
            // 
            // price
            // 
            price.DataPropertyName = "price";
            price.HeaderText = "Giá";
            price.MinimumWidth = 6;
            price.Name = "price";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(327, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(433, 456);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(label2);
            panel4.Controls.Add(txtdiscount);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(txttotalPrice);
            panel4.Controls.Add(button1);
            panel4.Location = new Point(3, 378);
            panel4.Name = "panel4";
            panel4.Size = new Size(427, 78);
            panel4.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 14);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 7;
            label2.Text = "Giảm giá";
            // 
            // txtdiscount
            // 
            txtdiscount.BorderStyle = BorderStyle.FixedSingle;
            txtdiscount.ForeColor = Color.ForestGreen;
            txtdiscount.Location = new Point(19, 41);
            txtdiscount.Name = "txtdiscount";
            txtdiscount.Size = new Size(125, 27);
            txtdiscount.TabIndex = 6;
            txtdiscount.Text = "0";
            txtdiscount.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 14);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 4;
            label1.Text = "Tổng tiền";
            // 
            // txttotalPrice
            // 
            txttotalPrice.BorderStyle = BorderStyle.FixedSingle;
            txttotalPrice.ForeColor = Color.ForestGreen;
            txttotalPrice.Location = new Point(150, 41);
            txttotalPrice.Name = "txttotalPrice";
            txttotalPrice.Size = new Size(149, 27);
            txttotalPrice.TabIndex = 2;
            txttotalPrice.Text = "0";
            txttotalPrice.TextAlign = HorizontalAlignment.Center;
            txttotalPrice.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(305, 7);
            button1.Name = "button1";
            button1.Size = new Size(115, 61);
            button1.TabIndex = 0;
            button1.Text = "Thanh toán";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(lsvBill);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(427, 376);
            panel3.TabIndex = 0;
            // 
            // lsvBill
            // 
            lsvBill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader3, columnHeader2 });
            lsvBill.Dock = DockStyle.Fill;
            lsvBill.GridLines = true;
            lsvBill.HoverSelection = true;
            lsvBill.ImeMode = ImeMode.Off;
            lsvBill.Location = new Point(0, 0);
            lsvBill.Name = "lsvBill";
            lsvBill.Scrollable = false;
            lsvBill.Size = new Size(427, 376);
            lsvBill.TabIndex = 0;
            lsvBill.UseCompatibleStateImageBehavior = false;
            lsvBill.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên dịch vụ";
            columnHeader1.Width = 160;
            // 
            // columnHeader3
            // 
            columnHeader3.DisplayIndex = 2;
            columnHeader3.Text = "Số lượng";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.DisplayIndex = 1;
            columnHeader2.Text = "Giá";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 150;
            // 
            // ShowBillRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 460);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ShowBillRoom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dịch vụ phòng :";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvFood).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private TextBox txttotalPrice;
        private Button button1;
        private ListView lsvBill;
        private Button button2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label1;
        private TextBox txtdiscount;
        private DataGridView dtgvFood;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn idDichvu;
        private DataGridViewTextBoxColumn price;
        private Label label2;
    }
}