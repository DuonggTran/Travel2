using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Travel
{
    public partial class DangNhap : Form
    {
        string check;
        DataConnection dB = new DataConnection();
        TaiKhoan tK = new TaiKhoan();
        TaiKhoanDAO tKDao = new TaiKhoanDAO();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string LoaiTaiKhoan = check;
            tKDao.load(tK, dB, LoaiTaiKhoan);
            if (txtTenDangNhap.Text == tK.TenDangNhap && txtMatKhau.Text == tK.MatKhau && LoaiTaiKhoan == "admin")
            {
                MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                TrangChuAdmin f = new TrangChuAdmin();
                f.ShowDialog();
            }
            else if(txtTenDangNhap.Text == tK.TenDangNhap && txtMatKhau.Text == tK.MatKhau && LoaiTaiKhoan == "user")
            {
                MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                TrangChuUser f = new TrangChuUser();
                f.ShowDialog();           
            }
            else
            {
                txtTenDangNhap.ResetText();
                txtMatKhau.ResetText();
                MessageBox.Show("Loại tài khoản của bạn chưa chính xác!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
        }       
        private void chkAccAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAccAdmin.Checked)
            {
                check = "admin";              
            }
        }
        private void chkAccUser_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAccUser.Checked)
            {
                check = "user";
            }
        }
        public DangNhap()
        {
            InitializeComponent();
        }
    }
}
