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
    public partial class LapDanhSachDoanhNghiepTiemNang : Form
    {
        DoanhNghiepTiemNangBUS dntnBUS = new DoanhNghiepTiemNangBUS();
        UuDaiBUS UuDaiBUS = new UuDaiBUS();
        DataTable UuDai = new DataTable();
        public LapDanhSachDoanhNghiepTiemNang()
        {
            InitializeComponent();
        }
        private void LapDanhSachDoanhNghiepTiemNang_Load(object sender, EventArgs e)
        {
            var data1 = dntnBUS.LayDanhSachGiaHan();
            var data2 = dntnBUS.LayDanhSachTN();
            foreach (DataRow row in data1.Rows)
            {
                comboBox1.Items.Add(row["MaDN"].ToString());
            }
            foreach (DataRow row in data2.Rows)
            {
                comboBox2.Items.Add(row["MaDN"].ToString());
            }
            UuDai = UuDaiBUS.LayDanhSach();
            foreach (DataRow row in UuDai.Rows)
            {
                comboBox3.Items.Add(row["ThongTinUuDai"].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox2.Text = string.Empty;
            comboBox3.Text = string.Empty;
        }
        // insert DNTN
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text)) return;
            if (dntnBUS.themDNTN(comboBox1.Text))
            {
                MessageBox.Show("Doanh nghiệp đã được thêm thành công");
            }
            else MessageBox.Show("Thêm doanh nghiệp thất bại");
        }
        // insert Big DNTN
        private void button3_Click(object sender, EventArgs e)
        {
            string uudaiaa = "";
            if (string.IsNullOrEmpty(comboBox2.Text) || string.IsNullOrEmpty(comboBox3.Text)) return;
            foreach (DataRow row in UuDai.Rows)
            {
                if (row["ThongTinUuDai"].ToString().Equals(comboBox3.Text))
                {
                    uudaiaa = row["MaUuDai"].ToString();
                    break;
                }
            }
            if (dntnBUS.themDNTNLon(comboBox2.Text,uudaiaa))
            {
                MessageBox.Show("Doanh nghiệp đã được thêm thành công");
            }
            else MessageBox.Show("Thêm doanh nghiệp thất bại");
        }
    }
}
