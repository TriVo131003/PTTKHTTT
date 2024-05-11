using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApplication1.DAO;

namespace WebApplication1.Controllers
{
    public class HinhThucDangTuyenController : ApiController
    {
        HinhThucDangTuyenDAO htdtDAO = new HinhThucDangTuyenDAO();

        [Route("api/HTDT/getList")]
        [HttpGet]
        public DataTable LayHTDT()
        {
            var dt = htdtDAO.getList();
            return dt;
        }

        [Route("api/HTDT/{maHTDT}")]
        [HttpGet]
        public DataTable LayDonGia(string maHTDT)
        {
            var dt = htdtDAO.getDonGia(maHTDT);
            return dt;
        }
    }
}