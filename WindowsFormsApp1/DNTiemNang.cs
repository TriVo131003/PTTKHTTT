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
    public partial class DNTiemNang : Form
    {
        DoanhNghiepTiemNangBUS dnBUS = new DoanhNghiepTiemNangBUS();
        public DNTiemNang()
        {
            InitializeComponent();
        }

        private void DNTiemNang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dnBUS.LayDanhSachTN();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DNTiemNang_Load(sender, e);
        }
    }
}
