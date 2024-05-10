using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        NhanVienBUS nvBUS = new NhanVienBUS();
        public Login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) return;
            DataTable info = nvBUS.LayThongTin(username);
            if (info.Rows.Count > 0)
            {
                DataRow row = info.Rows[0];
                Program.TenNV = row["HoTen"].ToString();
                string dbUsername = row["MaNhanVien"].ToString();
                string dbPassword = row["passwordNV"].ToString();

                if (username == dbUsername && password == dbPassword)
                {
                    MessageBox.Show("Login successful " + row["roleNV"].ToString());
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}
