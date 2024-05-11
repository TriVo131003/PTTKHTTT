﻿using System;
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
    public class PhieuThongTinThanhToanController : ApiController
    {
        PhieuThongTinThanhToanDAO pttttDAO = new PhieuThongTinThanhToanDAO();

        [Route("api/PhieuThongTinThanhToan/{MaPTTDT}")]
        [HttpGet]
        public DataTable LayDanhSachPTTTT(string MaPTTDT)
        {
            var dt = pttttDAO.getList(MaPTTDT);
            return dt;
        }
    }
}