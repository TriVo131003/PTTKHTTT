using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebApplication1.DTO;

namespace WebApplication1.DAO
{
    public class HoaDonDAO : Database
    {
        public DataTable getList(string MaPhieuTTTT)
        {
            string sql = string.Format("Select * from HoaDon where MaPhieuTTTT = {0}", MaPhieuTTTT);
            return getDataTable(sql);
        }
    }
}