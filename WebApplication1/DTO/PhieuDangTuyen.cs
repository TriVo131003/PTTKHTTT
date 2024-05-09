using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace WebApplication1.DTO
{
    public class PhieuDangTuyen
    {
        public int MaPTTDT { get; set; }
        public string MaSoThue { get; set; }
        public string ViTriUngTuyen { get; set; }
        public int SoLuongTuyen { get; set; }
        public int MaTieuChi { get; set; }
        public DateTime NgayDK { get; set; }
        public int ThoiGianDangTuyen { get; set; }
        public string TinhTrangHopLe { get; set; }
    }
}