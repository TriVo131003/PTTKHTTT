using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApplication1.DAO;

namespace WebApplication1.Controllers
{
    public class PhieuDangKyQuangCaoController : ApiController
    {
        // GET: PhieuQuangCao
        PhieuDangKyQuangCaoDAO pdkDAO = new PhieuDangKyQuangCaoDAO();
        [Route("api/PhieuDangKyQuangCao/getList")]
        [HttpGet]
        public DataTable LayDanhSach()
        {
            var dt = pdkDAO.getList();
            return dt;
        }


        [Route("api/PhieuDangKyQuangCao/getAccordingTo/{MaPDT}")]
        [HttpGet]
        public DataTable LayPhieuDangTuyen(String MaPDT)
        {
            var dt = pdkDAO.getListTheoCongTy(MaPDT);
            return dt;
        }
    }
}