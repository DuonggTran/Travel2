using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel
{
    internal class TaiKhoanDAO
    {
        public void load(TaiKhoan tK, DataConnection dB, string LoaiTaiKhoan)
        {
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.cnnStr);
                connection.Open();
                string query = "SELECT * FROM TaiKhoan Where LoaiNguoiDung = @LoaiTaiKhoan";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@LoaiTaiKhoan", LoaiTaiKhoan);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    tK.iD = (int)reader[0];
                    tK.tenDangNhap = reader[1].ToString();
                    tK.matKhau = reader[2].ToString();
                    tK.loaiNguoiDung = reader[3].ToString();
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void DangNhap(TaiKhoan tK, DangNhap f, string loaiTaiKhoan)
        {
            if (f.txtTenDangNhap.Text == tK.TenDangNhap && f.txtMatKhau.Text == tK.MatKhau && loaiTaiKhoan == "admin")
            {
                MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                f.Hide();
                TrangChuAdmin tChu = new TrangChuAdmin(tK.TenDangNhap);
                tChu.ShowDialog();
                tChu = null;
                f.Close();
            }
            else if (f.txtTenDangNhap.Text == tK.TenDangNhap && f.txtMatKhau.Text == tK.MatKhau && loaiTaiKhoan == "user")
            {
                MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                f.Hide();
                TrangChuUser tChu = new TrangChuUser(tK.TenDangNhap);
                tChu.ShowDialog();
                tChu = null;
                f.Close();
            }
            else
            {
                f.txtTenDangNhap.ResetText();
                f.txtMatKhau.ResetText();
                f.chkAccAdmin.Checked = false;
                f.chkAccUser.Checked = false;
                MessageBox.Show("Loại tài khoản của bạn chưa chính xác!", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
        }
    }
}
