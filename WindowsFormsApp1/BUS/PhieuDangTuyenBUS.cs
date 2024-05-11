using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.BUS
{
    internal class PhieuDangTuyenBUS
    {
        public DataTable LayDanhSach()
        {
            HttpClient client = ThietLapThongTinAPI();

            var response = client.GetStringAsync("PhieuDangTuyen/getList").Result;
            var data = JsonConvert.DeserializeObject<DataTable>(response);
            return data;
        }

        public DataTable LayDSTheoMST(String MaSoThue)
        {
            HttpClient client = ThietLapThongTinAPI();

            var response = client.GetStringAsync($"PhieuDangTuyen/DSPhieuTheoMST/{MaSoThue}").Result;
            var data = JsonConvert.DeserializeObject<DataTable>(response);
            return data;
        }

        public bool themPhieuDangTuyen(string maSoThue, string viTriUngTuyen, int soLuongTuyen, int maTieuChi, int thoiGianDangTuyen)
        {
            HttpClient client = ThietLapThongTinAPI();
            string url = $"?MaSoThue={maSoThue}&ViTriUngTuyen={viTriUngTuyen}&SoLuongTuyen={soLuongTuyen}&MaTieuChi={maTieuChi}&ThoiGianDangTuyen={thoiGianDangTuyen}";
            var response = client.PostAsync("PhieuDangTuyen/Them" + url, null).Result;
            return response.IsSuccessStatusCode;
            // them khuc nay vao la dc
/*            if (response.IsSuccessStatusCode)
            {
                var jsonString = response.Content.ReadAsStringAsync().Result;
                return (jsonString != "-1");
            }
            return false;*/


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
