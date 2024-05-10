using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GiamDoc_MENU : Form
    {
        public GiamDoc_MENU()
        {
            InitializeComponent();
        }

        private void GiamDoc_MENU_Load(object sender, EventArgs e)
        {
            DNTiemNang sup = new DNTiemNang();
            sup.TopLevel = false;
            panel1.Controls.Add(sup);
            sup.Show();

            LapDanhSachDoanhNghiepTiemNang doanhNghiepTiemNang = new LapDanhSachDoanhNghiepTiemNang();
            doanhNghiepTiemNang.TopLevel = false;
            panel4.Controls.Add(doanhNghiepTiemNang);
            doanhNghiepTiemNang.Show();

            DoanhNghiepCanGiaHanHD dnGH = new DoanhNghiepCanGiaHanHD();
            dnGH.TopLevel = false;
            panel2.Controls.Add(dnGH);
            dnGH.Show();
        }
    }
}
