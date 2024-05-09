namespace WindowsFormsApp1
{
    partial class DangKyUngTuyenCuaUngVien
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
            this.label2 = new System.Windows.Forms.Label();
            this.PTTDTDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DKBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.MaPTTDTTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PTTDTDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "PHIẾU THÔNG TIN ĐĂNG KÝ ỨNG TUYỂN";
            // 
            // PTTDTDataGrid
            // 
            this.PTTDTDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PTTDTDataGrid.Location = new System.Drawing.Point(46, 118);
            this.PTTDTDataGrid.Name = "PTTDTDataGrid";
            this.PTTDTDataGrid.RowHeadersWidth = 51;
            this.PTTDTDataGrid.RowTemplate.Height = 24;
            this.PTTDTDataGrid.Size = new System.Drawing.Size(725, 226);
            this.PTTDTDataGrid.TabIndex = 34;
            this.PTTDTDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PTTDTDataGrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Phiếu thông tin đăng tuyển";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Click vào phiếu thông tin đăng tuyển mà bạn muốn ứng tuyển";
            // 
            // DKBtn
            // 
            this.DKBtn.Location = new System.Drawing.Point(331, 394);
            this.DKBtn.Name = "DKBtn";
            this.DKBtn.Size = new System.Drawing.Size(75, 23);
            this.DKBtn.TabIndex = 37;
            this.DKBtn.Text = "Đăng ký ứng tuyển";
            this.DKBtn.UseVisualStyleBackColor = true;
            this.DKBtn.Click += new System.EventHandler(this.DKBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Bạn chọn (Mã PTTDT): ";
            // 
            // MaPTTDTTxt
            // 
            this.MaPTTDTTxt.Location = new System.Drawing.Point(198, 363);
            this.MaPTTDTTxt.Name = "MaPTTDTTxt";
            this.MaPTTDTTxt.Size = new System.Drawing.Size(100, 22);
            this.MaPTTDTTxt.TabIndex = 39;
            // 
            // DangKyUngTuyenCuaUngVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 431);
            this.Controls.Add(this.MaPTTDTTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DKBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PTTDTDataGrid);
            this.Controls.Add(this.label2);
            this.Name = "DangKyUngTuyenCuaUngVien";
            this.Text = "DangKyUngTuyenCuaUngVien";
            ((System.ComponentModel.ISupportInitialize)(this.PTTDTDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView PTTDTDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DKBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MaPTTDTTxt;
    }
}