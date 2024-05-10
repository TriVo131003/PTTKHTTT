using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;
using WebApplication1.DAO;

namespace WebApplication1.Controllers
{
    public class UuDaiController : ApiController
    {
        UuDaiDAO nvDao = new UuDaiDAO();

        [Route("api/UuDai/getList")]
        [HttpGet]
        public DataTable LayDanhSach()
        {
            var dt = nvDao.getList();
            return dt;
        }
    }
}