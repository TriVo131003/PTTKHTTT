using System;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Data;
using Newtonsoft.Json;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

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
            int TongTienCanThanhToan = 0;
            if (data.Rows.Count > 0)
            {
                TongTienCanThanhToan = int.Parse(data.Rows[0]["TongSoTien"].ToString());
            }

            else
            {
                MessageBox.Show("Chua co phieu thong tin thanh toan");
                return 0;
            }

            int MaPhieuTTTT = int.Parse(data.Rows[0]["MaPhieuTTTT"].ToString());

            HttpClient client2 = ThietLapThongTinAPI();
            var response1 = client2.GetStringAsync($"HoaDon/{MaPhieuTTTT}").Result;
            var data1 = JsonConvert.DeserializeObject<DataTable>(response1);
            int tiendathanhtoan = 0;
            if(data1.Rows.Count > 0)
            {
                foreach (DataRow hdrow in data1.Rows)
                {
                    tiendathanhtoan += int.Parse(hdrow["SoTien"].ToString());
                }
            }
            
            
            if(tiendathanhtoan == TongTienCanThanhToan)
            {
                return 0;
            }
            return TongTienCanThanhToan - tiendathanhtoan;
        }

        public int SoTienDuThanhToanTungDot(int soTien, string MaPTTDT)
        {
            HttpClient client = ThietLapThongTinAPI();

            var response = client.GetStringAsync($"PhieuThongTinThanhToan/{MaPTTDT}").Result;
            var data = JsonConvert.DeserializeObject<DataTable>(response);

            int TongTienCanThanhToan = int.Parse(data.Rows[0]["TongSoTien"].ToString());

            if((soTien*100/TongTienCanThanhToan)>10)
            { return 1; }

            return 0;
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
