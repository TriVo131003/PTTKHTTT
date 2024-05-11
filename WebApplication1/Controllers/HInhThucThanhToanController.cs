using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApplication1.DAO;

namespace WebApplication1.Controllers
{
    public class HinhThucThanhToanController : ApiController
    {
        HinhThucThanhToanDAO htttDAO = new HinhThucThanhToanDAO();

        [Route("api/HTTT/getList")]
        [HttpGet]
        public DataTable LayHTDT()
        {
            var dt = htttDAO.getList();
            return dt;
        }
    }
}