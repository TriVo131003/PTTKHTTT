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

        [Route("api/PhieuDangTuyen/DSPhieuTheoMST/{MaSoThue}")]
        [HttpGet]
        public DataTable LayDSTheoMST(String MaSoThue)
        {
            var dt = pdtDAO.DSPhieuTheoMST(MaSoThue);
            return dt;
        }
    }
}