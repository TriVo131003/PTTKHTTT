using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebApplication1.DTO;

namespace WebApplication1.DAO
{
    public class DoanhNghiepDAO: Database
    {
        public DataTable getList()
        {
            string sql = "Select * from DoanhNghiep";
            return getDataTable(sql);
        }
        public DataTable getDoanhNghiep(string MaSoThue)
        {
            string sql = string.Format("Select * from DoanhNghiep where MaSoThue = {0}",MaSoThue);
            return getDataTable(sql);
        }
        public int Insert(DoanhNghiep dn)
        {
            string sql = string.Format("Insert Into DoanhNghiep" +
              "Values({0}, '{1}', '{2}', '{3}')", dn.MaSoThue, dn.TenCongTy, dn.DiaChi,dn.Email);
            return ExecuteNonQuery(sql);
        }

        public int Update(DoanhNghiep dn)
        {
            string sql = string.Format("Update DoanhNghiep Set TenCongTy='{1}', DiaChi='{2}', Email={3} " +
                "Where MaSoThue={0}", dn.MaSoThue, dn.TenCongTy, dn.DiaChi, dn.Email);
            return ExecuteNonQuery(sql);
        }

        public int Delete(string MaSoThue)
        {
            string sql = string.Format("Delete from DoanhNghiep " +
               "Where MaSoThue={0}", MaSoThue);
            return ExecuteNonQuery(sql);
        }
    }
}