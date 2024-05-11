using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using WebApplication1.DTO;

namespace WebApplication1.DAO
{
    public class PhieuDangTuyenDAO : Database
    {
        public DataTable getList()
        {
            string sql = "Select * from PhieuDangTuyen";
            return getDataTable(sql);
        }

        public int Insert(PhieuDangTuyen pdt)
        {
            string sql = string.Format("INSERT INTO PhieuDangTuyen (MaSoThue, ViTriUngTuyen, SoLuongTuyen, MaTieuChi, NgayDK, ThoiGianDangTuyen) " +
                "VALUES ({0}, '{1}', {2}, '{3}', '{4}', '{5}')",
                pdt.MaSoThue, pdt.ViTriUngTuyen, pdt.SoLuongTuyen, pdt.MaTieuChi, pdt.NgayDK, pdt.ThoiGianDangTuyen);
            return ExecuteNonQuery(sql);
        }
        public DataTable DSPhieuTheoMST(string MaSoThue)
        {
            string sql = string.Format("Select * from PhieuDangTuyen Where MaSoThue='{0}'", MaSoThue);
            return getDataTable(sql);
        }
    }
}