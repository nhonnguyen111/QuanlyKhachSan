namespace QLKhachSan
{
    partial class ResetPass
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
            txtPass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNewPass = new TextBox();
            txtRePass = new TextBox();
            button1 = new Button();
            txtusername = new TextBox();
            txtdisplay = new TextBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtPass
            // 
            txtPass.Location = new Point(222, 134);
            txtPass.Margin = new Padding(4);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(318, 31);
            txtPass.TabIndex = 0;
            txtPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 136);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(166, 25);
            label1.TabIndex = 1;
            label1.Text = "Nhập mật khẩu cũ :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 197);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(179, 25);
            label2.TabIndex = 2;
            label2.Text = "Nhập mật khẩu mới :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 259);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(165, 25);
            label3.TabIndex = 3;
            label3.Text = "Nhập lại mật khẩu :";
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(222, 194);
            txtNewPass.Margin = new Padding(4);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(318, 31);
            txtNewPass.TabIndex = 4;
            txtNewPass.UseSystemPasswordChar = true;
            // 
            // txtRePass
            // 
            txtRePass.Location = new Point(222, 257);
            txtRePass.Margin = new Padding(4);
            txtRePass.Name = "txtRePass";
            txtRePass.Size = new Size(318, 31);
            txtRePass.TabIndex = 5;
            txtRePass.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(125, 324);
            button1.Name = "button1";
            button1.Size = new Size(318, 37);
            button1.TabIndex = 6;
            button1.Text = "Cập nhật";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtusername
            // 
            txtusername.Location = new Point(222, 21);
            txtusername.Margin = new Padding(4);
            txtusername.Name = "txtusername";
            txtusername.ReadOnly = true;
            txtusername.Size = new Size(318, 31);
            txtusername.TabIndex = 7;
            // 
            // txtdisplay
            // 
            txtdisplay.Location = new Point(222, 77);
            txtdisplay.Margin = new Padding(4);
            txtdisplay.Name = "txtdisplay";
            txtdisplay.ReadOnly = true;
            txtdisplay.Size = new Size(318, 31);
            txtdisplay.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 80);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 25);
            label4.TabIndex = 9;
            label4.Text = "Tên hiển thị :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 23);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(138, 25);
            label5.TabIndex = 10;
            label5.Text = "Tên đăng nhập :";
            // 
            // ResetPass
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(585, 377);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtdisplay);
            Controls.Add(txtusername);
            Controls.Add(button1);
            Controls.Add(txtRePass);
            Controls.Add(txtNewPass);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPass);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "ResetPass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đổi mật khẩu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPass;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNewPass;
        private TextBox txtRePass;
        private Button button1;
        private TextBox txtusername;
        private TextBox txtdisplay;
        private Label label4;
        private Label label5;
    }
}