using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
using WebApplication1.DAO;
using WebApplication1.DTO;

namespace WebApplication1.Controllers
{
    public class PhieuDangTuyenController : ApiController
    {
        PhieuDangTuyenDAO pdtDAO = new PhieuDangTuyenDAO();
        // GET: Phieu
        [Route("api/PhieuDangTuyen/getList")]
        [HttpGet]
        public DataTable LayDanhSach()
        {
            var dt = pdtDAO.getList();
            return dt;
        }

        [Route("api/PhieuDangTuyen/them")]
        [HttpPost]
        public int ThemPhieuDangTuyen(string maSoThue,string viTriUngTuyen, int soLuongTuyen, int maTieuChi, int thoiGianDangTuyen)
        {
            PhieuDangTuyen pdt = new PhieuDangTuyen
            {
                 MaSoThue = maSoThue,
                 ViTriUngTuyen = viTriUngTuyen,
                 SoLuongTuyen = soLuongTuyen,
                 MaTieuChi = maTieuChi,
                 NgayDK = DateTime.Today.ToString("MM/dd/yyyy"),
                 ThoiGianDangTuyen = thoiGianDangTuyen,
                 TinhTrangHopLe = null,
            };
            int dt = pdtDAO.Insert(pdt);
            return dt;
        }
    }
}