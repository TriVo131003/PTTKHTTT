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
    public class TieuChiDoanhNghiepController : ApiController
    {
        TieuChiDoanhNghiepDAO tcdnDAO = new TieuChiDoanhNghiepDAO();

        [Route("api/TieuChi/getList")]
        [HttpGet]
        public DataTable LayDanhSach()
        {
            var dt = tcdnDAO.getList();
            return dt;
        }

        [Route("api/TieuChi/getListMa")]
        [HttpGet]
        public DataTable LayDanhSachMaTieuChi()
        {
            var dt = tcdnDAO.getListMaTieuChi();
            return dt;
        }
    }
}