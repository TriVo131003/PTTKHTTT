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
        [Route("api/UngVien/getListMa")]
        [HttpGet]
        public DataTable getListMa()
        {
            DataTable dt = ungVienDAO.getListMa();
            return dt;
        }

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

        [Route("api/UngVien/kiemTraSDT")]
        [HttpGet]
        public DataTable KiemTraSDT(string hoTen, string sdt, string ngaySinh)
        {
            
            UngVien ungVien = new UngVien
            {
                HoTen = hoTen,
                SDT = sdt,
                NgaySinh = ngaySinh
            };
            DataTable dt = ungVienDAO.KiemTraTonTaiSDT(ungVien);
            return dt;
        }
    }
}