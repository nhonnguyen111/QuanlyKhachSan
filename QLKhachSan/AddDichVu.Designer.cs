namespace QLKhachSan
{
    partial class AddDichVu
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
            label1 = new Label();
            label2 = new Label();
            lbdichvu = new Label();
            label4 = new Label();
            lbgia = new Label();
            nmdropdown = new NumericUpDown();
            btnThem = new Button();
            btnHuy = new Button();
            iddichvu = new Label();
            ((System.ComponentModel.ISupportInitialize)nmdropdown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 24);
            label1.Name = "label1";
            label1.Size = new Size(111, 23);
            label1.TabIndex = 0;
            label1.Text = "Tên dịch vụ : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(318, 71);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 2;
            label2.Text = "Số lượng : ";
            // 
            // lbdichvu
            // 
            lbdichvu.AutoSize = true;
            lbdichvu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbdichvu.Location = new Point(139, 19);
            lbdichvu.Name = "lbdichvu";
            lbdichvu.Size = new Size(27, 28);
            lbdichvu.TabIndex = 3;
            lbdichvu.Text = "...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(93, 71);
            label4.Name = "label4";
            label4.Size = new Size(49, 23);
            label4.TabIndex = 4;
            label4.Text = "Giá : ";
            // 
            // lbgia
            // 
            lbgia.AutoSize = true;
            lbgia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbgia.Location = new Point(139, 66);
            lbgia.Name = "lbgia";
            lbgia.Size = new Size(27, 28);
            lbgia.TabIndex = 5;
            lbgia.Text = "...";
            // 
            // nmdropdown
            // 
            nmdropdown.Location = new Point(417, 69);
            nmdropdown.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nmdropdown.Minimum = new decimal(new int[] { 20, 0, 0, int.MinValue });
            nmdropdown.Name = "nmdropdown";
            nmdropdown.Size = new Size(47, 27);
            nmdropdown.TabIndex = 6;
            nmdropdown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnThem
            // 
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Location = new Point(110, 127);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnHuy
            // 
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Location = new Point(308, 127);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 8;
            btnHuy.Text = "Hủy bỏ";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // iddichvu
            // 
            iddichvu.AutoSize = true;
            iddichvu.Font = new Font("Segoe UI", 1.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iddichvu.Location = new Point(9, 7);
            iddichvu.Name = "iddichvu";
            iddichvu.Size = new Size(2, 3);
            iddichvu.TabIndex = 9;
            iddichvu.Text = "...";
            // 
            // AddDichVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 177);
            Controls.Add(iddichvu);
            Controls.Add(btnHuy);
            Controls.Add(btnThem);
            Controls.Add(nmdropdown);
            Controls.Add(lbgia);
            Controls.Add(label4);
            Controls.Add(lbdichvu);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddDichVu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm dịch vụ";
            Load += AddDichVu_Load;
            ((System.ComponentModel.ISupportInitialize)nmdropdown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbdichvu;
        private Label label4;
        private Label lbgia;
        private NumericUpDown nmdropdown;
        private Button btnThem;
        private Button btnHuy;
        private Label iddichvu;
    }
}