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
    public partial class TrangChuAdmin : Form
    {
        SqlConnection cnnStr = new SqlConnection(Properties.Settings.Default.cnnStr);
        ThongTinKhachSanDAO kSanDAO = new ThongTinKhachSanDAO();
        DataConnection dB = new DataConnection();
        TaiKhoan tK = new TaiKhoan();
        TaiKhoanDAO tKDAO = new TaiKhoanDAO();
        public TrangChuAdmin()
        {
            InitializeComponent();
        }

        private void btnChoThue_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangThongTinKhachSan f = new DangThongTinKhachSan();
            f.ShowDialog();
            f = null;
            this.Close();
        }
        private void TrangChuAdmin_Load(object sender, EventArgs e)
        {
            tKDAO.load(tK, dB, "admin");
            flpTrangChu.Controls.Clear();
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.cnnStr);
            connection.Open();
            int id = tK.ID;
            string query = "SELECT* FROM ThongTinKhachSan WHERE IDChuKhachSan = @IDChuKhachSan";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IDChuKhachSan", id);
            SqlDataReader reader = command.ExecuteReader();
            UCKhachSan f = new UCKhachSan();
            while (reader.Read())
            {               
                f.LoadDataTimKiem(flpTrangChu, id);
                break;
            }
            connection.Close();
        }
    }   
}
