using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DAO;
using WebApplication1.DTO;

namespace WebApplication1.Controllers
{
    public class PhieuDangTuyenController : Controller
    {
        PhieuDangTuyenDAO pdtDAO = new PhieuDangTuyenDAO();
        // GET: Phieu
        [Route("api/PhieuDangTuyen/getList")]
        [HttpGet]
        public DataTable LayDanhSach_test()
        {
            var dt = pdtDAO.getList();
            return dt;
        }
    }
}