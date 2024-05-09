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
            List<DoanhNghiep> lst = new List<DoanhNghiep>();
            var dt = dnDAO.getList();
            return dt;
            //foreach (DataRow dr in dt.Rows)
            //{
            //    var sv = new DoanhNghiep()
            //    {
            //        MaSoThue = dr["MaSoThue"].ToString(),
            //        TenCongTy = dr["TenCongTy"].ToString(),
            //        DiaChi = dr["DiaChi"].ToString(),
            //        Email = dr["Email"].ToString()
            //    };

            //    int laDNTN, laDNTNLon;
            //    if (int.TryParse(dr["LaDNTN"].ToString(), out laDNTN))
            //    {
            //        sv.LaDNTN = laDNTN;
            //    }
            //    else
            //    {
            //        // Handle non-integer value
            //    }

            //    if (int.TryParse(dr["LaDNTNLon"].ToString(), out laDNTNLon))
            //    {
            //        sv.LaDNTNLon = laDNTNLon;
            //    }
            //    else
            //    {
            //        // Handle non-integer value
            //    }

            //    lst.Add(sv);
            //}

            //return lst;
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