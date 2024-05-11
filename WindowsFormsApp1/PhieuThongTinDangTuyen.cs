using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;

namespace WindowsFormsApp1
{
    public partial class PhieuThongTinDangTuyen : Form
    {
        TieuChiDoanhNghiepBUS tcdnBUS = new TieuChiDoanhNghiepBUS();

        DoanhNghiepBUS dnBUS = new DoanhNghiepBUS();

        PhieuDangTuyenBUS pdtBUS = new PhieuDangTuyenBUS();
        public PhieuThongTinDangTuyen()
        {
            InitializeComponent();
        }

        private void loadDSMaTieuChi(object sender, EventArgs e)
        {
            comboBox1.DataSource= tcdnBUS.LayDanhSachMaTieuChi();
            comboBox1.DisplayMember = "MaTieuChi";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string mst = textBox1.Text;
            DataTable data = dnBUS.LayTTDN(mst);
            KiemtraTTDN(data);
        }
        private void KiemtraTTDN(DataTable data)
        {
            ThongBao(data.Rows.Count > 0);
        }
        private void ThongBao(bool success)
        {
            if (success)
            {
                MessageBox.Show("Doanh nghiep ton tai.");
            }
            else
            {
                MessageBox.Show("Doanh nghiep chua dang ky.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string maSoThue = textBox1.Text;
            string viTriUngTuyen = textBox5.Text;
            int soLuongTuyen = Convert.ToInt32(textBox2.Text);
            int maTieuChi = Convert.ToInt32(comboBox1.Text);
            int thoiGianDangTuyen = Convert.ToInt32(textBox3.Text);
            DataTable data = dnBUS.LayTTDN(maSoThue);
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("Doanh nghiep chua dang ky");
                return;
            }
            
            if (soLuongTuyen <= 0)
            {
                MessageBox.Show("So Luong Tuyen > 0!");
                return;
            }
            else if (thoiGianDangTuyen <= 0)
            {
                MessageBox.Show("Thoi gian dang tuyen >= 1!");
                return;
            }
            bool success = pdtBUS.themPhieuDangTuyen(maSoThue, viTriUngTuyen, soLuongTuyen, maTieuChi, thoiGianDangTuyen);

            if (success)
            {
                MessageBox.Show("PhieuDangTuyen created successfully!");
            }
            else
            {
                MessageBox.Show("Failed to create PhieuDangTuyen.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox5.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
