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
        UngVienBUS uvBUS = new UngVienBUS();
        public DangKyUngTuyenCuaUngVien()
        {
            InitializeComponent();
            PDT_Load();
            UV_Load();
        }
        private void PDT_Load()
        {
            PTTDTDataGrid.DataSource = pdtBUS.LayDanhSach();
        }
        private void UV_Load()
        {
            DataTable danhSachMaUV = uvBUS.LayDanhSachMaUV();
            MaUVCB.Items.Clear();
            foreach (DataRow row in danhSachMaUV.Rows)
            {
                MaUVCB.Items.Add(row["MaUV"].ToString());
            }
        }

        private void PTTDTDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = PTTDTDataGrid.Rows[e.RowIndex];
            loadMaPTTDTTxt(row.Cells["MaPTTDT"].Value.ToString());
        }
        private void loadMaPTTDTTxt(string MaPTTDT)
        {
            MaPTTDTTxt.Text = MaPTTDT;
        }

        private void DKBtn_Click(object sender, EventArgs e)
        {
            string MaUV = MaUVCB.Text;
            string MaPDT = MaPTTDTTxt.Text;
            DateTime NgayHienTai = DateTime.Now;
            string NgayLapPhieu = NgayHienTai.ToString("yyyy-MM-dd");
            if (string.IsNullOrEmpty(MaUV) || string.IsNullOrEmpty(MaPDT))
            {
                MessageBox.Show("Vui lòng điền đầy đủ các dữ liệu!");
            }
            PhieuDKUngTuyenBUS PhieuDKUTBUS = new PhieuDKUngTuyenBUS();
            if (PhieuDKUTBUS.kiemTraThemPDKUT(MaPDT, MaUV) > 0){
                MessageBox.Show("Ứng viên đã đăng ký phiếu đăng tuyển này");
                return;
            }
            bool result = PhieuDKUTBUS.themPDKUT(MaPDT, MaUV, NgayLapPhieu);
            if (result) MessageBox.Show("Đăng ký thành công");
            else MessageBox.Show("Đăng ký thất bại");

        }
    }
}
