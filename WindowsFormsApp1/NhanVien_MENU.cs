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
    public partial class NhanVien_MENU : Form
    {
        public NhanVien_MENU()
        {
            InitializeComponent();
        }

        private void NhanVien_MENU_Load(object sender, EventArgs e)
        {
            DangKyThanhVienUngVien sup = new DangKyThanhVienUngVien();
            sup.TopLevel = false;
            panel1.Controls.Add(sup);
            sup.Show();

            DangKyUngTuyenCuaUngVien ungTuyenCuaUngVien = new DangKyUngTuyenCuaUngVien();
            ungTuyenCuaUngVien.TopLevel = false;
            panel2.Controls.Add(ungTuyenCuaUngVien);
            ungTuyenCuaUngVien.Show();

            DanhSachTieuChiDoanhNghiep danhSachTieuChiDoanhNghiep = new DanhSachTieuChiDoanhNghiep();
            danhSachTieuChiDoanhNghiep.TopLevel = false;
            panel3.Controls.Add(danhSachTieuChiDoanhNghiep);
            danhSachTieuChiDoanhNghiep.Show();

            HienThiPhieuDangTuyen hienThiPhieuDangTuyen = new HienThiPhieuDangTuyen();
            hienThiPhieuDangTuyen.TopLevel = false;
            panel4.Controls.Add(hienThiPhieuDangTuyen);
            hienThiPhieuDangTuyen.Show();

            HienThiPhieuQuangCao hienThiPhieuQuangCao = new HienThiPhieuQuangCao();
            hienThiPhieuQuangCao.TopLevel = false;
            panel5.Controls.Add(hienThiPhieuQuangCao);
            hienThiPhieuQuangCao.Show();

            PhieuDangKyQuangCao phieuDangKyQuangCao = new PhieuDangKyQuangCao();
            phieuDangKyQuangCao.TopLevel = false;
            panel6.Controls.Add(phieuDangKyQuangCao);
            phieuDangKyQuangCao.Show();

            PhieuThongTinDangTuyen phieuThongTinDangTuyen = new PhieuThongTinDangTuyen();
            phieuThongTinDangTuyen.TopLevel = false;
            panel7.Controls.Add(phieuThongTinDangTuyen);
            phieuThongTinDangTuyen.Show();

            PhieuThongTinThanhToan phieuThongTinThanhToan = new PhieuThongTinThanhToan();
            phieuThongTinThanhToan.TopLevel = false;
            panel8.Controls.Add(phieuThongTinThanhToan);
            phieuThongTinThanhToan.Show();

            ThanhToanHoaDon thanhToanHoaDon = new ThanhToanHoaDon();
            thanhToanHoaDon.TopLevel = false;
            panel9.Controls.Add(thanhToanHoaDon);
            thanhToanHoaDon.Show();
        }
    }
}
