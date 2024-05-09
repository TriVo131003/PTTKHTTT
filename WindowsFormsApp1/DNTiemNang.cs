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
        DoanhNghiepBUS dnBUS = new DoanhNghiepBUS();
        public DNTiemNang()
        {
            InitializeComponent();
        }

        private void DNTiemNang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dnBUS.LayDanhSach();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
