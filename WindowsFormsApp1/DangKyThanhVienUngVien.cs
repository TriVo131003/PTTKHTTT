using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;

namespace WindowsFormsApp1
{
    public partial class DangKyThanhVienUngVien : Form
    {
        public DangKyThanhVienUngVien()
        {
            InitializeComponent();
            thongBaoLabel.Visible = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String hoTen = hoTenTextBox.Text;
            String sdt = sdtTextBox.Text;
            DateTime ngaySinh = ngaySinhPicker.Value;
            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(sdt))
            {
                // MessageBox.Show("Bạn chưa điền đủ hết các trường");
                thongBaoLabel.Visible = true;
                thongBaoLabel.ForeColor = Color.Red;
                thongBaoLabel.Text = "Bạn chưa điền đủ hết các trường";
                return;
            }
            UngVienBUS ungVienBUS = new UngVienBUS();
            bool result = ungVienBUS.themUngVien(hoTen, sdt, ngaySinh.ToString("yyyy-MM-dd"));
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
