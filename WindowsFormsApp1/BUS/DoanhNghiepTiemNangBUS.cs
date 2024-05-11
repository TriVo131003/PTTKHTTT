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
    internal class DoanhNghiepTiemNangBUS
    {
        public DataTable LayDanhSachTN()
        {
            HttpClient client = ThietLapThongTinAPI();

            var response = client.GetStringAsync("DoanhNghiepTiemNang/getList").Result;
            var data = JsonConvert.DeserializeObject<DataTable>(response);
            return data;
        }
        public DataTable LayDanhSachGiaHan()
        {
            HttpClient client = ThietLapThongTinAPI();

            var response = client.GetStringAsync("DoanhNghiepGiaHan/getList").Result;
            var data = JsonConvert.DeserializeObject<DataTable>(response);
            return data;
        }
        public bool themDNTN(string MaDN)
        {
            HttpClient client = ThietLapThongTinAPI();
            string url = $"?MaDN={MaDN}";
            var response = client.PostAsync("DoanhNghiepTiemNang/them" + url, null).Result;
            if (response.IsSuccessStatusCode)
            {
                var jsonString = response.Content.ReadAsStringAsync().Result;
                return (jsonString != "-1");
            }
            return false;
        }

        //    return response.IsSuccessStatusCode;
        //}
        public bool themDNTNLon(string MaDN, string MaUuDai)
        {
            HttpClient client = ThietLapThongTinAPI();
            string url = $"?MaDN={MaDN}&MaUuDai={MaUuDai}";
            var response = client.PostAsync("DoanhNghiepTiemNangLon/them" + url, null).Result;
            if (response.IsSuccessStatusCode)
            {
                var jsonString = response.Content.ReadAsStringAsync().Result;
                return (jsonString != "-1");
            }
            return false;
        }

        //    return response.IsSuccessStatusCode;
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
