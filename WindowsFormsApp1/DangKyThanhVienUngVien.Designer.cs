namespace WindowsFormsApp1
{
    partial class DangKyThanhVienUngVien
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
            this.thongBaoLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ngaySinhPicker = new System.Windows.Forms.DateTimePicker();
            this.sdtTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hoTenTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // thongBaoLabel
            // 
            this.thongBaoLabel.AutoSize = true;
            this.thongBaoLabel.Location = new System.Drawing.Point(351, 112);
            this.thongBaoLabel.Name = "thongBaoLabel";
            this.thongBaoLabel.Size = new System.Drawing.Size(73, 16);
            this.thongBaoLabel.TabIndex = 36;
            this.thongBaoLabel.Text = "Thông báo";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "Xác nhận";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ngaySinhPicker
            // 
            this.ngaySinhPicker.Location = new System.Drawing.Point(354, 278);
            this.ngaySinhPicker.Name = "ngaySinhPicker";
            this.ngaySinhPicker.Size = new System.Drawing.Size(274, 22);
            this.ngaySinhPicker.TabIndex = 34;
            // 
            // sdtTextBox
            // 
            this.sdtTextBox.Location = new System.Drawing.Point(354, 212);
            this.sdtTextBox.Name = "sdtTextBox";
            this.sdtTextBox.Size = new System.Drawing.Size(274, 22);
            this.sdtTextBox.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Số điện thoại";
            // 
            // hoTenTextBox
            // 
            this.hoTenTextBox.Location = new System.Drawing.Point(354, 149);
            this.hoTenTextBox.Name = "hoTenTextBox";
            this.hoTenTextBox.Size = new System.Drawing.Size(274, 22);
            this.hoTenTextBox.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Họ Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "Đăng Ký Thông Tin Ứng Viên";
            // 
            // DangKyThanhVienUngVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.thongBaoLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ngaySinhPicker);
            this.Controls.Add(this.sdtTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hoTenTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DangKyThanhVienUngVien";
            this.Text = "DangKyThanhVienUngVien";
            this.Load += new System.EventHandler(this.DangKyThanhVienUngVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label thongBaoLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker ngaySinhPicker;
        private System.Windows.Forms.TextBox sdtTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hoTenTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}