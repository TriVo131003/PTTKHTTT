using System;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Data;
using Newtonsoft.Json;

namespace WindowsFormsApp1.BUS
{
    public class PhieuThongTinThanhToanBus
    {
        public DataTable LayDanhSach()
        {
            HttpClient client = ThietLapThongTinAPI();

            var response = client.GetStringAsync("PhieuThongTinThanhToan/getList").Result;
            var data = JsonConvert.DeserializeObject<DataTable>(response);
            return data;
        }

        public int TongTienThanhToan(string MaPhieuDangTuyen, int Ngay)
        {
            HttpClient client = ThietLapThongTinAPI();

            string maHTDT = "";
            int DonGia = 0;

            HinhThucDangTuyenBUS htdt = new HinhThucDangTuyenBUS();
            PhieuQuangCaoBUS pqc = new PhieuQuangCaoBUS();
            
            var phieuQC = pqc.LayPQCTheoPDT(MaPhieuDangTuyen);
            maHTDT = phieuQC.Rows[0]["MaHTDT"].ToString();
            DonGia = int.Parse(htdt.LayDonGia(maHTDT).Rows[0]["DonGia"].ToString());
            return DonGia * Ngay;
        }


        public int SoTienThanhToan(string MaPTTDT)
        {
            HttpClient client = ThietLapThongTinAPI();

            var response = client.GetStringAsync($"PhieuThongTinThanhToan/{MaPTTDT}").Result;
            var data = JsonConvert.DeserializeObject<DataTable>(response);

            int TongTienCanThanhToan = int.Parse(data.Rows[0]["TongSoTien"].ToString());

            int MaPTTTT = int.Parse(data.Rows[0]["MaPhieuTTTT"].ToString());

            var response1 = client.GetStringAsync($"HoaDon/{MaPTTTT}").Result;
            var data1 = JsonConvert.DeserializeObject<DataTable>(response);
            return 0;
        }

        //public int SoTienCanThanhToan(int SoNgayDT, int DonGia)
        //{
        //    return SoNgayDT * DonGia;
        //}
        private static HttpClient ThietLapThongTinAPI()
        {
            // In the class
            HttpClient client = new HttpClient();

            // Put the following code where you want to initialize the class
            // It can be the static constructor or a one-time initializer
            client.BaseAddress = new Uri("http://localhost:44374/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }
    }
}
