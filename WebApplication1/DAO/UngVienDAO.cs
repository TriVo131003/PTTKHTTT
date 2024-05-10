using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using WebApplication1.DTO;
using System.Web.Services.Description;


namespace WebApplication1.DAO
{
    public class UngVienDAO : Database
    {
        public DataTable getList()
        {
            string sql = "Select * from UngVien";
            return getDataTable(sql);
        }
        public DataTable getListMa()
        {
            string sql = "Select MaUV from UngVien";
            return getDataTable(sql);
        }

        public int Insert(UngVien uv)
        {
            string sql = string.Format("Insert Into UngVien(HoTen, SDT, NgaySinh)" +
              "Values('{0}', '{1}', '{2}')", uv.HoTen, uv.SDT, uv.NgaySinh);
            return ExecuteNonQuery(sql);
        }
        
        public DataTable KiemTraTonTaiSDT(UngVien uv)
        {
            string sql = string.Format("select 1 from UngVien where SDT = '{0}'", uv.SDT);

            return getDataTable(sql);
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