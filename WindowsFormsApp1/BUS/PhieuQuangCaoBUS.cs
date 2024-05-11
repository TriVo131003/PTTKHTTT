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
    internal class PhieuQuangCaoBUS
    {
        public DataTable LayDanhSach()
        {
            HttpClient client = ThietLapThongTinAPI();

            var response = client.GetStringAsync("PhieuDangKyQuangCao/getList").Result;
            var data = JsonConvert.DeserializeObject<DataTable>(response);
            return data;
        }
        public DataTable LayDSTheoMST(String MaSoThue)
        {
            HttpClient client = ThietLapThongTinAPI();

            var response = client.GetStringAsync($"PhieuDangKyQuangCao/DSPhieuTheoMST/{MaSoThue}").Result;
            var data = JsonConvert.DeserializeObject<DataTable>(response);
            return data;
        }

        public DataTable LayPQCTheoPDT(String MaPDT)
        {
            HttpClient client = ThietLapThongTinAPI();

            var response = client.GetStringAsync($"PhieuDangKyQuangCao/PhieuQCTheoPDT/{MaPDT}").Result;
            var data = JsonConvert.DeserializeObject<DataTable>(response);
            return data;
        }
        public bool themPhieuQuangCao(string ThoiGianDangTuyen, string MaPTTDT, string MaHTDT)
        {
            HttpClient client = ThietLapThongTinAPI();

            string url = $"?MaPTTDT={MaPTTDT}&ThoiGianDangTuyen={ThoiGianDangTuyen}&MaHTDT={MaHTDT}";
            var response = client.PostAsync("PhieuDangKyQuangCao/addNew" + url, null).Result;

/*            if (response.IsSuccessStatusCode)
            {
                var jsonString = response.Content.ReadAsStringAsync().Result;
                return (jsonString != "-1");
            }
            return false;
        }*/

            return response.IsSuccessStatusCode;
        }

        public int KTPhieuDangKyQuangCao(string MaPTTDT)
        {
            HttpClient client = ThietLapThongTinAPI();

            var response = client.GetStringAsync($"PhieuDangKyQuangCao/KT/{MaPTTDT}").Result;
            var data = JsonConvert.DeserializeObject<int>(response);
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
