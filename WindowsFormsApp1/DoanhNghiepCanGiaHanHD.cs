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
    public partial class DoanhNghiepCanGiaHanHD : Form
    {
        DoanhNghiepTiemNangBUS dnBUS = new DoanhNghiepTiemNangBUS();
        public DoanhNghiepCanGiaHanHD()
        {
            InitializeComponent();
        }
        private void DoanhNghiepCanGiaHanHD_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dnBUS.LayDanhSachGiaHan();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoanhNghiepCanGiaHanHD_Load(sender, e);
        }
    }
}
