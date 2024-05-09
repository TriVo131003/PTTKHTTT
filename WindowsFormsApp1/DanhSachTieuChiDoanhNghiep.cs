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
    public partial class DanhSachTieuChiDoanhNghiep : Form
    {
        TieuChiDoanhNghiepBUS tcdnBUS = new TieuChiDoanhNghiepBUS();
        public DanhSachTieuChiDoanhNghiep()
        {
            InitializeComponent();
        }

        private void DanhSachTieuChiDoanhNghiep_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tcdnBUS.LayDanhSach();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
