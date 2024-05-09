using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebApplication1.DTO;

namespace WebApplication1.DAO
{
    public class TieuChiDoanhNghiepDAO: Database
    {
        public DataTable getList()
        {
            string sql = "Select * from TieuChiDoanhNghiep";
            return getDataTable(sql);
        }

        public DataTable getListMaTieuChi()
        {
            string sql = "Select MaTieuChi from TieuChiDoanhNghiep";
            return getDataTable(sql);
        }
    }
}