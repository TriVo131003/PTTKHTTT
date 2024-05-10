using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApplication1.DAO
{
    public class DoanhNghiepTiemNangDAO : Database
    {
        public DataTable getListTiemNang()
        {
            string sql = "Select * from DoanhNghiepCanGiaHan where (CoLaDNTiemNang is not null or CoLaDNTiemNangLon is not null);";
            return getDataTable(sql);
        }
        public DataTable getListGiaHan()
        {
            string sql = "Select * from DoanhNghiepCanGiaHan where (CoLaDNTiemNang is null and CoLaDNTiemNangLon is null)";
            return getDataTable(sql);
        }
        public int themDNTN(string MaDN)
        {
            string sql = string.Format("Update DoanhNghiepCanGiaHan set CoLaDNTiemNang = 'co' where MaDN = {0}", MaDN);
            return ExecuteNonQuery(sql);
        }
        public int themDNTNLon(string MaDN, string MaUuDai)
        {
            string sql = string.Format("Update DoanhNghiepCanGiaHan set CoLaDNTiemNangLon = 'co', MaUuDai = {1} where MaDN = {0}", MaDN,MaUuDai);
            return ExecuteNonQuery(sql);
        }
    }
}