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
        ThongTinKhachSanDAO kSanDAO = new ThongTinKhachSanDAO();
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
        public void TrangChuAdmin_Load(object sender, EventArgs e)
        {
            tKDAO.load(tK, dB, "admin");
            kSanDAO.LoadData(flpTrangChu,tK.ID);
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            tKDAO.load(tK, dB, "admin");
            kSanDAO.LoadData(flpTrangChu, tK.ID);
        }
        private void btnChoThue_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangThongTinKhachSan f = new DangThongTinKhachSan();
            f.ShowDialog();
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
