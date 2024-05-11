using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebApplication1.DTO;

namespace WebApplication1.DAO
{
    public class HoaDonDAO : Database
    {
        public int Insert(HoaDon hd)
        {
            string sql = string.Format("INSERT INTO HoaDon (SoTien, NgayThanhToan, MaHTTT, CoThanhToanTheoDot, MaNV, MaPhieuTTTT) " +
                                       "VALUES ({0}, '{1}', {2}, '{3}', {4}, {5})",
                                       hd.SoTien, hd.NgayThanhToan, hd.MaHTTT, hd.CoThanhToanTheoDot, hd.MaNV, hd.MaPhieuTTTT);

            return ExecuteNonQuery(sql);
        }
        public DataTable getList(string MaPhieuTTTT)
        {
            string sql = string.Format("Select * from HoaDon where MaPhieuTTTT = {0}", MaPhieuTTTT);
            return getDataTable(sql);
        }
    }
}