using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApplication1.DAO;

namespace WebApplication1.Controllers
{
    public class NhanVienController : ApiController
    {
        NhanVienDAO nvDao = new NhanVienDAO();

        [Route("api/NhanVien/Login/{MaNV}")]
        [HttpGet]
        public DataTable LayThongTinDangNhap(String MaNV)
        {
            var dt = nvDao.getNhanVien(MaNV);
            return dt;
        }
    }
}