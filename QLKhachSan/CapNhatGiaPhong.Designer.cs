namespace QLKhachSan
{
    partial class CapNhatGiaPhong
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
            txtpriceroom = new TextBox();
            btnacpectprice = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 59);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "Giá phòng : ";
            // 
            // txtpriceroom
            // 
            txtpriceroom.Location = new Point(130, 56);
            txtpriceroom.Name = "txtpriceroom";
            txtpriceroom.Size = new Size(294, 27);
            txtpriceroom.TabIndex = 1;
            // 
            // btnacpectprice
            // 
            btnacpectprice.Location = new Point(187, 118);
            btnacpectprice.Name = "btnacpectprice";
            btnacpectprice.Size = new Size(94, 29);
            btnacpectprice.TabIndex = 2;
            btnacpectprice.Text = "Xác nhận";
            btnacpectprice.UseVisualStyleBackColor = true;
            btnacpectprice.Click += btnacpectprice_Click;
            // 
            // CapNhatGiaPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 172);
            Controls.Add(btnacpectprice);
            Controls.Add(txtpriceroom);
            Controls.Add(label1);
            Name = "CapNhatGiaPhong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giá phòng hôm nay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtpriceroom;
        private Button btnacpectprice;
    }
}