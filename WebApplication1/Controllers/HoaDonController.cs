using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Http;
// using System.Web.Mvc;
using WebApplication1.DAO;
using WebApplication1.DTO;

namespace WebApplication1.Controllers
{
    public class HoaDonController : ApiController
    {
        HoaDonDAO hdDAO = new HoaDonDAO();

        [Route("api/HoaDon/{MaPhieuTTTT}")]
        [HttpGet]
        public DataTable LayDanhSachHD(string MaPhieuTTTT)
        {
            var dt = hdDAO.getList(MaPhieuTTTT);
            return dt;
        }

        [Route("api/HoaDon/them")]
        [HttpPost]
        public int ThemHoaDon(int soTien, int maHTTT, string coThanhToanTheoDot, int maNV, int maPhieuTTTT)
        {
            HoaDon hd = new HoaDon
            {
                SoTien = soTien,
                NgayThanhToan = DateTime.Today.ToString("yyyy-MM-dd"),
                MaHTTT = maHTTT,
                CoThanhToanTheoDot = coThanhToanTheoDot,
                MaNV = maNV,
                MaPhieuTTTT = maPhieuTTTT
            };
            int insertedRows = hdDAO.Insert(hd);
            return insertedRows;
        }
    }
}