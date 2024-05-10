using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
using WebApplication1.DAO;
using WebApplication1.DTO;

namespace WebApplication1.Controllers
{
    public class DoanhNghiepTiemNangController : ApiController
    {
        DoanhNghiepTiemNangDAO dnDAO = new DoanhNghiepTiemNangDAO();

        [Route("api/DoanhNghiepTiemNang/getList")]
        [HttpGet]
        public DataTable LayDanhSachTN()
        {
            var dt = dnDAO.getListTiemNang();
            return dt;
        }

        [Route("api/DoanhNghiepGiaHan/getList")]
        [HttpGet]
        public DataTable LayDanhSachGH()
        {
            var dt = dnDAO.getListGiaHan();
            return dt;
        }

        [Route("api/DoanhNghiepTiemNang/them")]
        [HttpPost]
        public int themDNTN(string MaDN)
        {
            int dt = dnDAO.themDNTN(MaDN);
            return dt;
        }

        [Route("api/DoanhNghiepTiemNangLon/them")]
        [HttpPost]
        public int themDNTLon(string MaDN,string MaUuDai)
        {
            int dt = dnDAO.themDNTNLon(MaDN,MaUuDai);
            return dt;
        }
    }
}