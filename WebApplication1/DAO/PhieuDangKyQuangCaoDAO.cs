using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using WebApplication1.DTO;

namespace WebApplication1.DAO
{
    public class PhieuDangKyQuangCaoDAO : Database
    {
        public DataTable getList()
        {
            string sql = "Select * from PhieuDangKyQuangCao";
            return getDataTable(sql);
        }
        public DataTable KTPhieuQuangCao(String MaPTTDT)
        {
            string sql = string.Format("Select count(*) as cnt from PhieuDangKyQuangCao where MaPTTDT = {0}", MaPTTDT);
            return getDataTable(sql);
        }


        public int Insert(PhieuDangKyQuangCao pdkqc)
        {
            string sql = string.Format("Insert Into PhieuDangKyQuangCao (MaHTDT, MaPTTDT,  ThoiGianDangTuyen) Values({0}, {1}, '{2}')", pdkqc.MaHTDT, pdkqc.MaPTTDT, pdkqc.ThoiGianDangTuyen);
            return ExecuteNonQuery(sql);
        }

        //public int Update(UngVien uv)
        //{
        //    string sql = string.Format("Update PhieuDangKyQuangCao Set HoTen='{1}', NgaySinh='{2}', SDT={3} " +
        //        "Where MaUV={0}", uv.MaUV, uv.HoTen, uv.NgaySinh.ToString(), uv.SDT);
        //    return ExecuteNonQuery(sql);
        //}

        //public int Delete(string MaUV)
        //{
        //    string sql = string.Format("Delete from PhieuDangKyQuangCao " +
        //       "Where MaUV={0}", MaUV);
        //    return ExecuteNonQuery(sql);
        //}
    }
}