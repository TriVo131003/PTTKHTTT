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
    public class DoanhNghiepController : ApiController
    {
        DoanhNghiepDAO dnDAO = new DoanhNghiepDAO();

        [Route("api/DoanhNghiep/getList")]
        [HttpGet]
        public DataTable LayDanhSach_test()
        {
            var dt = dnDAO.getList();
            return dt;
        }

        [Route("api/DoanhNghiep/get1DN")]
        [HttpGet]
        public DataTable LayDoanhNghiep(string MaSoThue)
        {
            var dt = dnDAO.getDoanhNghiep(MaSoThue);
            return dt;
        }
        //[Route("api/DoanhNghiep/insert")]
        //[HttpPost]
        //public ActionResult Create(DoanhNghiep doanhNghiep)
        //{
        //    dnDAO.Insert(doanhNghiep);
        //    return RedirectToAction("Index");
        //}
    }
}