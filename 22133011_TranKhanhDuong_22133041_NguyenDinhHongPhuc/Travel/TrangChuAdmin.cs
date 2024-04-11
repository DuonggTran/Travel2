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
        DataConnection dB = new DataConnection();
        TaiKhoan tK = new TaiKhoan();
        TaiKhoanDAO tKDAO = new TaiKhoanDAO();
        bool logOut;
        public TrangChuAdmin()
        {
            InitializeComponent();
        }
        public TrangChuAdmin(string tenTaiKhoan)
        {
            InitializeComponent();
            lblTenTaiKhoan.Text = tenTaiKhoan;  
        }
        private void btnChoThue_Click(object sender, EventArgs e)
        {         
            DangThongTinKhachSan f = new DangThongTinKhachSan();
            f.ShowDialog();        
        }
        public void TrangChuAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
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
        private void pic_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                logOut = true; // Đánh dấu đã đăng xuất
                this.Hide();
                DangNhap f = new DangNhap(logOut);
                f.ShowDialog();
                f = null;
                this.Close(); // Đóng form đăng nhập khi đã đăng xuất
            }
        }
    }   
}
