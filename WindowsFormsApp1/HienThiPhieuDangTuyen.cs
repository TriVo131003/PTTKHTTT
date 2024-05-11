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
    public partial class HienThiPhieuDangTuyen : Form
    {
        PhieuDangTuyenBUS pdtBUS = new PhieuDangTuyenBUS();
        public HienThiPhieuDangTuyen()
        {
            InitializeComponent();
        }

        private void HienThiPhieuDangTuyen_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                string maSoThue = textBox1.Text;

                DataTable dataTable = pdtBUS.LayDSTheoMST(maSoThue);

                dataGridView2.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Please enter MaSoThue before loading data.");
            }
        }
    }
}
