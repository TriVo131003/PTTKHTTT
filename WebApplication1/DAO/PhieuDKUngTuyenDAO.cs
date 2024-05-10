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

        public int Update(UngVien uv)
        {
            string sql = string.Format("Update UngVien Set HoTen='{1}', NgaySinh='{2}', SDT={3} " +
                "Where MaUV={0}", uv.MaUV, uv.HoTen, uv.NgaySinh, uv.SDT);
            return ExecuteNonQuery(sql);
        }

        public int Delete(string MaUV)
        {
            string sql = string.Format("Delete from UngVien " +
               "Where MaUV={0}", MaUV);
            return ExecuteNonQuery(sql);
        }
    }
}