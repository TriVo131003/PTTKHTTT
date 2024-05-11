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
    public partial class HienThiPhieuQuangCao : Form
    {
        PhieuQuangCaoBUS pcbus = new PhieuQuangCaoBUS();
        public HienThiPhieuQuangCao()
        {
            InitializeComponent();
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text.Trim()))
            {
                string maSoThue = textBox2.Text;

                DataTable dataTable = pcbus.LayDSTheoMST(maSoThue);

                dataGridView2.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Please enter MaSoThue before loading data.");
            }
        }

        private void HienThiPhieuQuangCao_Load(object sender, EventArgs e)
        {

        }
    }
}
