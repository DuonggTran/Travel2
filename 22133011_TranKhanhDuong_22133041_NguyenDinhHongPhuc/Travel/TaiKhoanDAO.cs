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
    }
}
