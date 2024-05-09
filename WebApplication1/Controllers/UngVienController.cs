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
    public class UngVienController : ApiController
    {
        // GET: UngVien
        UngVienDAO ungVienDAO = new UngVienDAO();
        [Route("api/UngVien/them")]
        [HttpPost]
        public int themUngVien(string hoTen, string sdt, string ngaySinh)
        {
            UngVien ungVien = new UngVien
            {
                HoTen = hoTen,
                SDT = sdt,
                NgaySinh = ngaySinh
            };
            int dt = ungVienDAO.Insert(ungVien);
            return dt;
        }
    }
}