namespace QLKhachSan
{
    partial class formVatTu
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
            lbtitle = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txttenvattu = new TextBox();
            txtsoluong = new TextBox();
            txtdongia = new TextBox();
            txtghichu = new TextBox();
            btnXacnhan = new Button();
            btnHuy = new Button();
            txtid = new TextBox();
            SuspendLayout();
            // 
            // lbtitle
            // 
            lbtitle.AutoSize = true;
            lbtitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbtitle.Location = new Point(150, 9);
            lbtitle.Name = "lbtitle";
            lbtitle.Size = new Size(71, 28);
            lbtitle.TabIndex = 0;
            lbtitle.Text = "Vật tư";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 80);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên vật tư : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 139);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 2;
            label2.Text = "Số lượng :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 197);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 3;
            label3.Text = "Đơn giá : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 256);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 4;
            label4.Text = "Ghi chú :";
            // 
            // txttenvattu
            // 
            txttenvattu.Location = new Point(121, 77);
            txttenvattu.Name = "txttenvattu";
            txttenvattu.Size = new Size(218, 27);
            txttenvattu.TabIndex = 5;
            // 
            // txtsoluong
            // 
            txtsoluong.Location = new Point(121, 139);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(218, 27);
            txtsoluong.TabIndex = 6;
            // 
            // txtdongia
            // 
            txtdongia.Location = new Point(121, 194);
            txtdongia.Name = "txtdongia";
            txtdongia.Size = new Size(218, 27);
            txtdongia.TabIndex = 7;
            // 
            // txtghichu
            // 
            txtghichu.Location = new Point(121, 253);
            txtghichu.Name = "txtghichu";
            txtghichu.Size = new Size(218, 27);
            txtghichu.TabIndex = 8;
            // 
            // btnXacnhan
            // 
            btnXacnhan.Location = new Point(52, 328);
            btnXacnhan.Name = "btnXacnhan";
            btnXacnhan.Size = new Size(94, 29);
            btnXacnhan.TabIndex = 10;
            btnXacnhan.Text = "Xác nhận";
            btnXacnhan.UseVisualStyleBackColor = true;
            btnXacnhan.Click += btnXacnhan_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(215, 328);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 11;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // txtid
            // 
            txtid.Location = new Point(121, 44);
            txtid.Name = "txtid";
            txtid.Size = new Size(113, 27);
            txtid.TabIndex = 12;
            // 
            // formVatTu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 390);
            Controls.Add(txtid);
            Controls.Add(btnHuy);
            Controls.Add(btnXacnhan);
            Controls.Add(txtghichu);
            Controls.Add(txtdongia);
            Controls.Add(txtsoluong);
            Controls.Add(txttenvattu);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbtitle);
            Name = "formVatTu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vật tư";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbtitle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txttenvattu;
        private TextBox txtsoluong;
        private TextBox txtdongia;
        private TextBox txtghichu;
        private Button btnXacnhan;
        private Button btnHuy;
        private TextBox txtid;
    }
}