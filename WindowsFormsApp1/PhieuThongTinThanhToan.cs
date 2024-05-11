using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;

namespace WindowsFormsApp1
{
    public partial class PhieuThongTinThanhToan : Form
    {
        PhieuQuangCaoBUS pqc = new PhieuQuangCaoBUS();
        PhieuDangTuyenBUS pdt = new PhieuDangTuyenBUS();
        HinhThucThanhToanBUS httt = new HinhThucThanhToanBUS();
        PhieuThongTinThanhToanBus ptttt = new PhieuThongTinThanhToanBus();
        HinhThucDangTuyenBUS htdt = new HinhThucDangTuyenBUS();
        public static DataTable dsHTTT;
        public static DataTable dsPhieuDangTuyen;
        public static DataTable dsPhieuQC;
        public static DataTable dsHTDT;
        public static int SoNgayDangTuyen = 0;
        public PhieuThongTinThanhToan()
        {
            InitializeComponent();
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            //dsHTTT = httt.LayHTTT();
            //foreach (DataRow row in dsHTTT.Rows)
            //{
            //    comboBox2.Items.Add(row["TenHTTT"].ToString());
            //}
            //comboBox3.Items.Add("Thanh toán toàn bộ");
            //comboBox3.Items.Add("Thanh toán từng đợt");
            //dsHTDT = htdt.LayHTDT();
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
                comboBox1.Items.Add(row["MaPTTDT"].ToString());
            }
        }
        
        private void MaPhieuDangTuyen_OnTextChanged(object sender, EventArgs e)
        {
            string maPDT = "";
            SoNgayDangTuyen = 0;
            foreach(DataRow rows in dsPhieuDangTuyen.Rows)
            {
                maPDT = comboBox1.Text;
                if (maPDT.Equals(rows["MaPTTDT"].ToString()))
                {
                    SoNgayDangTuyen = int.Parse(rows["ThoiGianDangTuyen"].ToString());
                    textBox2.Text = ptttt.TongTienThanhToan(maPDT, SoNgayDangTuyen).ToString();
                    return;
                }
            }            
        }

        //private void LoaiThanhToan_OnTextChanged(object sender, EventArgs e)
        //{
        //    //string LoaiThanhToan = comboBox3.Text;
        //    if(SoNgayDangTuyen<30 && LoaiThanhToan.Equals("Thanh toán từng đợt"))
        //    {
        //        MessageBox.Show("Số ngày đăng tuyển không đủ điều kiện thanh toán từng đợt");
        //        //comboBox3.Text = string.Empty;
        //        return;
        //    }
        //}

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }
    }
}
