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
    public partial class DangKyUngTuyenCuaUngVien : Form
    {
        PhieuDangTuyenBUS pdtBUS = new PhieuDangTuyenBUS();
        public DangKyUngTuyenCuaUngVien()
        {
            InitializeComponent();
            PDT_Load();
        }
        private void PDT_Load()
        {
            PTTDTDataGrid.DataSource = pdtBUS.LayDanhSach();
        }

        private void PTTDTDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DKBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
