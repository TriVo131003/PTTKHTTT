using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using WebApplication1.DTO;

namespace WebApplication1.DAO
{
    public class PhieuDKUngTuyenDAO : Database
    {
        public DataTable getList()
        {
            string sql = "Select * from PhieuDKUngTuyen";
            return getDataTable(sql);
        }
        public DataTable getListMa()
        {
            string sql = "Select MaDKUT from PhieuDKUngTuyen";
            return getDataTable(sql);
        }
        public DataTable getListKiemTraThem(string MaPTTDT, string MaUV)
        {
            string sql = string.Format("Select Count(*) as count from PhieuDKUngTuyen where MaPTTDT = {0} and MaUV = {1}", MaPTTDT, MaUV);
            return getDataTable(sql);
        }

        public int Insert(PhieuDKUngTuyen pdkut)
        {
            string sql = string.Format("Insert Into PhieuDKUngTuyen(MaPTTDT, MaUV, NgayLapPhieu)" +
              "Values('{0}', '{1}', '{2}')", pdkut.MaPTTDT, pdkut.MaUV, pdkut.NgayLapPhieu);
            return ExecuteNonQuery(sql);
        }
    }
}