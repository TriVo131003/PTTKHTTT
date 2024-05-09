using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BUS
{
    internal class UngVienBUS
    {
        public DataTable LayDanhSach()
        {
            HttpClient client = ThietLapThongTinAPI();

            var response = client.GetStringAsync("DoanhNghiep/getList").Result;
            var data = JsonConvert.DeserializeObject<DataTable>(response);
            return data;
        }
        public bool themUngVien(string hoTen, string sdt, string ngaySinh)
        {
            HttpClient client = ThietLapThongTinAPI();
            var doanhNghiep = new { hoTen = hoTen, sdt = sdt, ngaySinh = ngaySinh };
            var content = new StringContent(JsonConvert.SerializeObject(doanhNghiep), System.Text.Encoding.UTF8, "application/json");
            var response = client.PostAsync("UngVien/", content).Result;
            return response.IsSuccessStatusCode;
        }


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
