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
        public DangNhap()
        {
            InitializeComponent();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string LoaiTaiKhoan = check;
            tKDao.load(tK, dB, LoaiTaiKhoan);
            if (txtTenDangNhap.Text == tK.TenDangNhap && txtMatKhau.Text == tK.MatKhau && LoaiTaiKhoan == "admin")
            {
                MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                this.Hide();
                TrangChuAdmin f = new TrangChuAdmin(tK.TenDangNhap);
                f.ShowDialog();
                f = null;
                this.Close();
                
            }
            else if(txtTenDangNhap.Text == tK.TenDangNhap && txtMatKhau.Text == tK.MatKhau && LoaiTaiKhoan == "user")
            {
                MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                this.Hide();
                TrangChuUser f = new TrangChuUser(tK.TenDangNhap);
                f.ShowDialog();
                f = null;
                this.Close();
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
    }
}
