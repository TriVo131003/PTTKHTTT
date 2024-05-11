using System;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Data;
using Newtonsoft.Json;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

namespace WindowsFormsApp1.BUS
{
    public class HoaDonBUS
    {

       
        public bool ThemHoaDon(int soTien, int maHTTT, string coThanhToanTheoDot, int maNV, int maPhieuTTTT)
        {
            HttpClient client = ThietLapThongTinAPI();

            string url = $"?soTien={soTien}&maHTTT={maHTTT}&coThanhToanTheoDot={coThanhToanTheoDot}&maNV={maNV}&maPhieuTTTT={maPhieuTTTT}";
            var response = client.PostAsync("HoaDon/them" + url, null).Result;

            return response.IsSuccessStatusCode;
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
