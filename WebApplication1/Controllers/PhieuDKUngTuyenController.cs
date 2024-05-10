using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApplication1.DAO;
using WebApplication1.DTO;

namespace WebApplication1.Controllers
{
    public class PhieuDKUngTuyenController : ApiController
    {
        // GET: UngVien
        PhieuDKUngTuyenDAO pdkutDAO = new PhieuDKUngTuyenDAO();
        [Route("api/PhieuDKUngTuyen/them")]
        [HttpPost]
        public int themPDKUT(string MaPTTDT, string MaUV, string NgayLapPhieu)
        {
            PhieuDKUngTuyen pdkut = new PhieuDKUngTuyen
            {
                MaPTTDT = MaPTTDT,
                MaUV = MaUV,
                NgayLapPhieu = NgayLapPhieu
            };
            int dt = pdkutDAO.Insert(pdkut);
            return dt;
        }
        [Route("api/PhieuDKUngTuyen/KiemTrathem/{MaPTTDT}/{MaUV}")]
        [HttpGet]
        public int KiemTraThemPDKUT(string MaPTTDT, string MaUV)
        {
            var dt = pdkutDAO.getListKiemTraThem(MaPTTDT, MaUV);
            return int.Parse(dt.Rows[0]["count"].ToString());
        }
        [Route("api/PhieuDKUngTuyen/getListMa")]
        [HttpGet]
        public DataTable LayDanhSachMaUV()
        {
            var dt = pdkutDAO.getListMa();
            return dt;
        }
    }
}