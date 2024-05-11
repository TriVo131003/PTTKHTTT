using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebApplication1.DTO;

namespace WebApplication1.DAO
{
    public class PhieuThongTinThanhToanDAO : Database
    {
        public DataTable getList(string MaPTTDT)
        {
            string sql = string.Format("Select * from PhieuThongTinThanhToan where (TinhTrangThanhToan is null) and MaPTTDT = {0}", MaPTTDT);
            return getDataTable(sql);
        }
    }
}