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
    public partial class ThanhToanHoaDon : Form
    {
        PhieuQuangCaoBUS pqc = new PhieuQuangCaoBUS();
        PhieuDangTuyenBUS pdt = new PhieuDangTuyenBUS();
        HinhThucThanhToanBUS httt = new HinhThucThanhToanBUS();
        PhieuThongTinThanhToanBus ptttt = new PhieuThongTinThanhToanBus();
        HinhThucDangTuyenBUS htdt = new HinhThucDangTuyenBUS();
        public static DataTable dsPhieuDangTuyen;
        public static DataTable dsHTTT;
        int SoNgayDangTuyen = 0;
        public ThanhToanHoaDon()
        {
            InitializeComponent();
        }

        private void ThanhToanHoaDon_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("Thanh toán toàn bộ");
            comboBox2.Items.Add("Thanh toán từng đợt");
            dsHTTT = httt.LayHTTT();
            foreach (DataRow row in dsHTTT.Rows)
            {
                comboBox2.Items.Add(row["TenHTTT"].ToString());
            }
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            dsPhieuDangTuyen = pdt.LayDSTheoMST(textBox1.Text);
            if (dsPhieuDangTuyen.Rows.Count > 0)
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
                comboBox3.Items.Add(row["MaPTTDT"].ToString());
            }
        }
        private void MaPhieuDangTuyen_OnTextChanged(object sender, EventArgs e)
        {
            string maPDT = "";
            foreach(DataRow rows in dsPhieuDangTuyen.Rows)
            {
                maPDT = comboBox3.Text;
                if (maPDT.Equals(rows["MaPTTDT"].ToString()))
                {
                    
                    textBox2.Text = ptttt.SoTienThanhToan(maPDT).ToString();
                    return;
                }
            }            
        }
    }
}
