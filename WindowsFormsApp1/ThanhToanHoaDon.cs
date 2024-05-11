﻿using System;
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
        public int SoNgayDangTuyen = 0;
        public int tiencanthanhtoan = 0;
        public string maPDT = "";
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
                comboBox1.Items.Add(row["TenHTTT"].ToString());
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
            maPDT = "";
            tiencanthanhtoan = 0;
            foreach(DataRow rows in dsPhieuDangTuyen.Rows)
            {
                maPDT = comboBox3.Text;
                if (maPDT.Equals(rows["MaPTTDT"].ToString()))
                {
                    SoNgayDangTuyen = int.Parse(rows["ThoiGianDangTuyen"].ToString());
                    tiencanthanhtoan = int.Parse(ptttt.SoTienThanhToan(maPDT).ToString());
                    if (tiencanthanhtoan <= 0)
                    {
                        MessageBox.Show("Da hoan tat thanh toan");
                    }
                    textBox2.Text = tiencanthanhtoan.ToString();
                    return;
                }
            }            
        }

        private void LoaiThanhToan_OnTextChanged(object sender, EventArgs e)
        {

        }
    }
}
