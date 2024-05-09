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
    public partial class PhieuThongTinDangTuyen : Form
    {
        TieuChiDoanhNghiepBUS tcdnBUS = new TieuChiDoanhNghiepBUS();
        public PhieuThongTinDangTuyen()
        {
            InitializeComponent();
        }

        private void PhieuThongTinDangTuyen_Load(object sender, EventArgs e)
        {

        }

        private void loadDSMaTieuChi(object sender, EventArgs e)
        {
            comboBox1.Items.Add("1"); //= tcdnBUS.LayDanhSachMaTieuChi();
            //comboBox1.DisplayMember = "MaTieuChi";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
