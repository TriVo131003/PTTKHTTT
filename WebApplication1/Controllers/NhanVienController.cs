using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class NhanVienController : ApiController
    {
        [Route("api/PhieuDangKyQuangCao/getAccordingTo/{MaPDT}")]
        [HttpGet]
        public DataTable LayPhieuDangTuyen(String MaPDT)
        {
            var dt = pdkDAO.getListTheoCongTy(MaPDT);
            return dt;
        }
    }
}