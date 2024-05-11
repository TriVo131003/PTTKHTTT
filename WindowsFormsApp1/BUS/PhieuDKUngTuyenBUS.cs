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
    internal class PhieuDKUngTuyenBUS
    {
        public DataTable LayDanhSach()
        {
            HttpClient client = ThietLapThongTinAPI();

            var response = client.GetStringAsync("PhieuDKUngTuyen/getList").Result;
            var data = JsonConvert.DeserializeObject<DataTable>(response);
            return data;
        }

        public DataTable LayDanhSachMaDKUT()
        {
            HttpClient client = ThietLapThongTinAPI();

            var response = client.GetStringAsync("PhieuDKUngTuyen/getListMa").Result;
            var data = JsonConvert.DeserializeObject<DataTable>(response);
            return data;
        }
        public bool themPDKUT(string MaPTTDT, string MaUV, string NgayLapPhieu)
        {
            HttpClient client = ThietLapThongTinAPI();
            string url = $"?MaPTTDT={MaPTTDT}&MaUV={MaUV}&NgayLapPhieu={NgayLapPhieu}";
            var response = client.PostAsync("PhieuDKUngTuyen/them" + url, null).Result;
            if (response.IsSuccessStatusCode)
            {
                var jsonString = response.Content.ReadAsStringAsync().Result;
                return (jsonString != "-1");
            }
            return false;
        }
        //    return response.IsSuccessStatusCode;
        //}
        public int kiemTraThemPDKUT(string MaPTTDT, string MaUV)
        {
            HttpClient client = ThietLapThongTinAPI();
            string url = $"/{MaPTTDT}/{MaUV}";
            var response = client.GetStringAsync("PhieuDKUngTuyen/KiemTrathem" + url).Result;
            int data = JsonConvert.DeserializeObject<int>(response);
            return data;
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
