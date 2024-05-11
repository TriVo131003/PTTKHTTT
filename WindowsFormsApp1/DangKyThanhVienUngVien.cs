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
                ThongBao("Bạn chưa điền đủ hết các trường", Color.Red);
                return;
            }
            UngVienBUS ungVienBUS = new UngVienBUS();
            if (ungVienBUS.KiemTraTonTaiSDT(hoTen, sdt, ngaySinh.ToString("yyyy-MM-dd")))
            {
                ThongBao("Đã có số điện thoại", Color.Red);
                return;
            }
            bool result = ungVienBUS.themUngVien(hoTen, sdt, ngaySinh.ToString("yyyy-MM-dd"));
            if (result) ThongBao("Đăng ký thành công", Color.Blue);
            else ThongBao("Đăng ký thất bại", Color.Red);
        }

        private void ThongBao(string thongBao, Color color)
        {
            thongBaoLabel.Visible = true;
            thongBaoLabel.ForeColor = color;
            thongBaoLabel.Text = thongBao;

            Timer timer = new Timer();
            timer.Interval = 2000; 
            timer.Tick += OnTimeout;
            timer.Start();
        }

        private void OnTimeout(object sender, EventArgs e)
        {
            thongBaoLabel.Visible = false;
            ((Timer)sender).Stop();
        }

        private void DangKyThanhVienUngVien_Load(object sender, EventArgs e)
        {

        }
    }
}
