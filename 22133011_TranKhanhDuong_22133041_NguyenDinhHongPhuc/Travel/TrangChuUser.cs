using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel
{
    public partial class TrangChuUser : Form
    {
        string tenTaiKhoan;
        public TrangChuUser()
        {
            InitializeComponent();
        }
        public TrangChuUser(string tenTaiKhoan)
        {
            InitializeComponent();
            lblTenTaiKhoan.Text = tenTaiKhoan;  
        }
        private void TrangChuUser_Load(object sender, EventArgs e)
        {         
            flpTrangChuUser.Controls.Clear();
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.cnnStr);
            connection.Open();            
            string query = "SELECT* FROM ThongTinKhachSan";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            UCThongTinKhachSan f = new UCThongTinKhachSan();
            while (reader.Read())
            {
                f.LoadData(flpTrangChuUser);
                break;
            }
            connection.Close();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            flpTrangChuUser.Controls.Clear();
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.cnnStr);
            connection.Open();
            string selectedDiaDiem = cboDiaDiemTimKiem.Text;
            string query = "SELECT DISTINCT DiaDiemKhachSan FROM ThongTinKhachSan WHERE DiaDiemKhachSan = @DiaDiemKhachSan";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DiaDiemKhachSan", selectedDiaDiem);
            SqlDataReader reader = command.ExecuteReader();
            UCThongTinKhachSan f = new UCThongTinKhachSan();
            while (reader.Read())
            {
                string diaDiem = reader["DiaDiemKhachSan"].ToString();
                f.LoadDataTimKiem(flpTrangChuUser, diaDiem);
                break;
            }
            connection.Close();
        }
    }
}
