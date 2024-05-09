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
            string sql = string.Format("INSERT INTO PhieuDangTuyen (MaSoThue, ViTriUngTuyen, SoLuongTuyen, MaTieuChi, NgayDK, ThoiGianDangTuyen, TinhTrangHopLe) " +
                "VALUES ({0}, '{1}', {2}, '{3}', '{4}', '{5}', '{6}')",
                pdt.MaSoThue, pdt.ViTriUngTuyen, pdt.SoLuongTuyen, pdt.MaTieuChi, pdt.NgayDK, pdt.ThoiGianDangTuyen, pdt.TinhTrangHopLe);
            return ExecuteNonQuery(sql);
        }

        public int Update(UngVien uv)
        {
            string sql = string.Format("Update UngVien Set HoTen='{1}', NgaySinh='{2}', SDT={3} " +
                "Where MaUV={0}", uv.MaUV, uv.HoTen, uv.NgaySinh.ToString(), uv.SDT);
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