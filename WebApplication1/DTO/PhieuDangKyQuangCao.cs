using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace WebApplication1.DTO
{
    public class PhieuDangKyQuangCao
    {
        public int MaPDKQC { get; set; }
        public int MaHTDT { get; set; }
        public int MaPTTDT { get; set; }
        public string ThoiGianDangTuyen { get; set; }
    }
}