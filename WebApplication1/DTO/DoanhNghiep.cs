using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace WebApplication1.DTO
{
    public class DoanhNghiep
    {
        public string MaSoThue { get; set; }
        public string TenCongTy { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public int LaDNTN { get; set; }
        public int LaDNTNLon { get; set; }
    }
}