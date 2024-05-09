﻿using System;
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
        public DataTable getListTheoCongTy(String MaPDT)
        {
            string sql = string.Format("Select pdk.* from PhieuDangKyQuangCao pdk left join PhieuDangTuyen pdt where MaSoThue = '{0}'", MaPDT);
            return getDataTable(sql);
        }

        //public int Insert(UngVien uv)
        //{
        //     string sql = string.Format("Insert Into PhieuDangKyQuangCao" +
        //      "Values({0}, '{1}', '{2}', '{3}')", uv.MaUV, uv.HoTen, uv.NgaySinh.ToString(), uv.SDT);
        //    return ExecuteNonQuery(sql);
        //}

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