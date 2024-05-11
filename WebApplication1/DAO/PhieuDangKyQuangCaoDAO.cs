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
        public DataTable DSPhieuTheoMST(string MaSoThue)
        {
            string sql = string.Format("Select * from PhieuDangKyQuangCao Where MaPTTDT in (Select MaPTTDT from PhieuDangTuyen Where MaSoThue='{0}')", MaSoThue);
            return getDataTable(sql);
        }

        public DataTable PhieuQCTheoPDT(string MaPTTDT)
        {
            string sql = string.Format("Select * from PhieuDangKyQuangCao Where MaPTTDT = {0}", MaPTTDT);
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
    }
}