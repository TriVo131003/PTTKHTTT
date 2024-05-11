using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApplication1.DAO
{
    public class HinhThucThanhToanDAO : Database
    {
        public DataTable getList()
        {
            string sql = string.Format("Select * from HinhThucThanhToan");
            return getDataTable(sql);
        }
    }
}