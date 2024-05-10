using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApplication1.DAO
{
    public class NhanVienDAO : Database
    {
        public DataTable getNhanVien(string MaNV)
        {
            string sql = string.Format("Select * from NhanVien where MaNhanVien = {0}", MaNV);
            return getDataTable(sql);
        }
    }
}