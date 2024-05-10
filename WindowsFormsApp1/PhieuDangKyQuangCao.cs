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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class PhieuDangKyQuangCao : Form
    {
        PhieuQuangCaoBUS pqc = new PhieuQuangCaoBUS();
        PhieuDangTuyenBUS pdt = new PhieuDangTuyenBUS();
        HinhThucDangTuyenBUS htdt = new HinhThucDangTuyenBUS();
        public DataTable dsHTDT;
        public PhieuDangKyQuangCao()
        {
            InitializeComponent();
        }

        private void PhieuDangKyQuangCao_Load(object sender, EventArgs e)
        {
            dsHTDT = htdt.LayHTDT();
            foreach (DataRow row in dsHTDT.Rows)
            {
                comboBox3.Items.Add(row["TenHTDT"].ToString());
            }
            label7.Text = Program.TenNV;
            dateTimePicker1.Value = DateTime.Now;
        }
        private void ThongBao(bool status)
        {
            if (status)
            {
                MessageBox.Show("Them phieu quang cao thanh cong");
            }
            else MessageBox.Show("Them phieu quang cao that bai");
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(comboBox3.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(comboBox2.Text))
            {
                return;
            }
            string MaHTDT = "";
            foreach (DataRow row in dsHTDT.Rows)
            {
                if(comboBox3.Text == row["TenHTDT"].ToString())
                {
                    MaHTDT = row["MaHTDT"].ToString();
                }
            }
            var IsExist = pqc.KTPhieuDangTuyen(comboBox2.Text);
            if (IsExist == 1)
            {
                MessageBox.Show("Phieu quang cao da ton tai");
                return;
            }


            var result = pqc.themPhieuQuangCao(dateTimePicker1.Value.ToString("yyyy-MM-dd"), comboBox2.Text, MaHTDT);
            ThongBao(result);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable dsPhieuDangTuyen = pdt.LayDSTheoMST(textBox1.Text);
            if(dsPhieuDangTuyen.Rows.Count > 0)
            {
                MessageBox.Show("Tim thanh cong");
            }
            else
            {
                MessageBox.Show("Doanh nghiep khong ton tai");
                return;
            }
            foreach (DataRow row in dsPhieuDangTuyen.Rows)
            {
                comboBox2.Items.Add(row["MaPTTDT"].ToString());
            }
        }
    }
}
