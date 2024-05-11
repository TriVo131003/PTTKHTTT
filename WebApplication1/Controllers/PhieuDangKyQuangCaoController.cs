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
    public class PhieuDangKyQuangCaoController : ApiController
    {
        // GET: PhieuQuangCao
        PhieuDangKyQuangCaoDAO pdkDAO = new PhieuDangKyQuangCaoDAO();
        [Route("api/PhieuDangKyQuangCao/getList")]
        [HttpGet]
        public DataTable LayDanhSach()
        {
            var dt = pdkDAO.getList();
            return dt;
        }

        [Route("api/PhieuDangKyQuangCao/DSPhieuTheoMST/{MaSoThue}")]
        [HttpGet]
        public DataTable LayDSTheoMST(String MaSoThue)
        {
            var dt = pdkDAO.DSPhieuTheoMST(MaSoThue);
            return dt;
        }

        [Route("api/PhieuDangKyQuangCao/KT/{MaPTTDT}")]
        [HttpGet]
        public int KTPhieuQuangCao(String MaPTTDT)
        {
            var dt = pdkDAO.KTPhieuQuangCao(MaPTTDT);
            return int.Parse(dt.Rows[0]["cnt"].ToString());
        }

        [Route("api/PhieuDangKyQuangCao/addNew")]
        [HttpPost]
        public int themPhieuQuangCao(string ThoiGianDangTuyen, string MaPTTDT, string MaHTDT)
        {
            PhieuDangKyQuangCao pdkqc = new PhieuDangKyQuangCao
            {
                ThoiGianDangTuyen = ThoiGianDangTuyen,
                MaPTTDT = int.Parse(MaPTTDT),
                MaHTDT = int.Parse(MaHTDT)
            };
            int dt = pdkDAO.Insert(pdkqc);
            return dt;
        }
    }
}