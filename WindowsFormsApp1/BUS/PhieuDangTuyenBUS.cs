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
    internal class PhieuDangTuyenBUS
    {
        public DataTable LayDanhSach()
        {
            HttpClient client = new HttpClient();

            var response = client.GetStringAsync("PhieuDangTuyen/getList").Result;
            var data = JsonConvert.DeserializeObject<DataTable>(response);
            return data;
        }
        public bool themPhieuDangTuyen(string maSoThue, string viTriUngTuyen, int soLuongTuyen, int maTieuChi, int thoiGianDangTuyen)
        {
            HttpClient client = ThietLapThongTinAPI();
            var PhieuDangTuyen = new
            {
                maSoThue = maSoThue,
                viTriUngTuyen = viTriUngTuyen,
                soLuongTuyen = soLuongTuyen,
                maTieuChi = maTieuChi,
                thoiGianDangTuyen = thoiGianDangTuyen
            };
            var content = new StringContent(JsonConvert.SerializeObject(PhieuDangTuyen), System.Text.Encoding.UTF8, "application/json");
            var response = client.PostAsync("PhieuDangTuyen/Them", content).Result;
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
