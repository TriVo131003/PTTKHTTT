using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApplication1.DAO
{
    public class UuDaiDAO : Database
    {
        public DataTable getList()
        {
            string sql = "Select * from UuDai";
            return getDataTable(sql);
        }
        public DataTable getUuDai(string MaUuDai)
        {
            string sql = string.Format("Select * from UuDai where MaUuDai = {0}", MaUuDai);
            return getDataTable(sql);
        }
    }
}