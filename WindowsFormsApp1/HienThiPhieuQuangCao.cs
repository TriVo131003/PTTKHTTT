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
    public partial class HienThiPhieuQuangCao : Form
    {
        PhieuQuangCaoBUS pcbus = new PhieuQuangCaoBUS();

        private void btnTim_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = pcbus.LayTheoPhieuDangTuyen(textBox2.Text);
        }
    }
}
