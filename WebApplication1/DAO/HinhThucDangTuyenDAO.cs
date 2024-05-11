using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApplication1.DAO
{
    public class HinhThucDangTuyenDAO : Database
    {
        public DataTable getList()
        {
            string sql = string.Format("Select * from HinhThucDangTuyen");
            return getDataTable(sql);
        }
        public DataTable getDonGia(string MaHTDT)
        {
            string sql = string.Format("Select * from HinhThucDangTuyen where MaHTDT = {0}", MaHTDT);
            return getDataTable(sql);
        }
    }
}