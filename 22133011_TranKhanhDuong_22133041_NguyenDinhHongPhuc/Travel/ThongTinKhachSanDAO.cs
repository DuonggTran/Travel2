using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travel;
using static Guna.UI2.WinForms.Suite.Descriptions;

namespace GUI
{
    internal class ThongTinKhachSanDAO
    {
        public void Them(ThongTinKhachSan kSan, DataConnection db)
        {
            string SQL = string.Format("INSERT INTO ThongTinKhachSan(TenKhachSan, DiaDiemKhachSan, Loai, MoTa, HinhAnh1, HinhAnh2, HinhAnh3, HinhAnh4, IDChuKhachSan) VALUES (N'{0}', N'{1}', N'{2}', N'{3}', '{4}', '{5}', '{6}', '{7}','{8}')", kSan.TenKhachSan, kSan.DiaDiemKhachSan, kSan.Loai, kSan.MoTa, kSan.HinhAnh1, kSan.HinhAnh2, kSan.HinhAnh3, kSan.HinhAnh4,kSan.IDChuKhachSan);
            db.ThucThi(SQL);
        }
        public void Xoa(int iDKhachSan, DataConnection db)
        {
            string SQL = string.Format("DELETE FROM ThongTinKhachSan WHERE IDKhachSan = '{0}'", iDKhachSan);
            db.ThucThi(SQL);
        }
        public void Sua(ThongTinKhachSan kSan, DataConnection db)
        {
            string SQL = string.Format("UPDATE ThongTinKhachSan SET TenKhachSan = N'{0}', DiaDiemKhachSan = N'{1}', Loai = N'{2}', MoTa = N'{3}', HinhAnh1 = '{4}', HinhAnh2 = '{5}', HinhAnh3 = '{6}', HinhAnh4 = '{7}' WHERE IDKhachSan = {8}", kSan.TenKhachSan, kSan.DiaDiemKhachSan, kSan.Loai, kSan.MoTa, kSan.HinhAnh1, kSan.HinhAnh2, kSan.HinhAnh3, kSan.HinhAnh4, kSan.IDKhachSan);
            db.ThucThi(SQL);
        }
        public void LoadData(FlowLayoutPanel flpTrangChu, int id)
        {
            flpTrangChu.Controls.Clear();
            SqlConnection connection = new SqlConnection(Travel.Properties.Settings.Default.cnnStr);
            connection.Open();
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
        public void SaveImage(PictureBox image, out string filename)
        {
            filename = string.Empty;
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)| *.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                image.Image = Image.FromFile(opf.FileName);
                filename = Path.GetFileName(opf.FileName);
                string appDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
                string dest = Path.Combine(appDirectory, filename);
                File.Copy(opf.FileName, dest, true);
            }
        }
        public List<UCThongTinKhachSan> GetAllKhachSan()
        {
            List<UCThongTinKhachSan> khachSanList = new List<UCThongTinKhachSan>();
            try
            {
                using (SqlConnection connection = new SqlConnection(Travel.Properties.Settings.Default.cnnStr))
                {
                    connection.Open();
                    string query = "SELECT * FROM ThongTinKhachSan";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        UCThongTinKhachSan uc = CreateUCThongTinKhachSanFromReader(reader);
                        khachSanList.Add(uc);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return khachSanList;
        }
        public List<UCThongTinKhachSan> SearchKhachSanByDiaDiem(string diaDiem)
        {
            List<UCThongTinKhachSan> khachSanList = new List<UCThongTinKhachSan>();
            try
            {
                using (SqlConnection connection = new SqlConnection(Travel.Properties.Settings.Default.cnnStr))
                {
                    connection.Open();
                    string query = "SELECT * FROM ThongTinKhachSan WHERE DiaDiemKhachSan = @dd";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@dd", diaDiem);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        UCThongTinKhachSan uc = CreateUCThongTinKhachSanFromReader(reader);
                        khachSanList.Add(uc);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return khachSanList;
        }
        public List<UCDanhGia> DataDanhGia(int id)
        {
            List<UCDanhGia> khachSanList = new List<UCDanhGia>();
            try
            {
                using (SqlConnection connection = new SqlConnection(Travel.Properties.Settings.Default.cnnStr))
                {
                    connection.Open();
                    string query = "SELECT * FROM DanhGia WHERE IDKhachSan = @IDKhachSan";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDKhachSan", id);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        UCDanhGia uc = CreateUCDanhGiaFromReader(reader);
                        khachSanList.Add(uc);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return khachSanList;
        }
        public List<UCKhachSan> LoadDataTimKiem(int id)
        {
            List<UCKhachSan> khachSanList = new List<UCKhachSan>();
            try
            {
                SqlConnection connection = new SqlConnection(Travel.Properties.Settings.Default.cnnStr);
                connection.Open();
                string query = "SELECT * FROM ThongTinKhachSan WHERE IDChuKhachSan = @IDChuKhachSan";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IDChuKhachSan", id);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    UCKhachSan uc = new UCKhachSan();
                    uc.iDKhachSan = (int)reader[0];
                    uc.txtTenKhachSan.Text = reader[1].ToString();
                    uc.txtDiaDiemKhachSan.Text = reader[2].ToString();
                    uc.loai = reader[3].ToString();
                    uc.moTa = reader[4].ToString();
                    uc.anh1 = reader[5].ToString();
                    uc.anh2 = reader[6].ToString();
                    uc.anh3 = reader[7].ToString();
                    uc.anh4 = reader[8].ToString();
                    khachSanList.Add(uc);
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return khachSanList;
        }
        public UCThongTinKhachSan CreateUCThongTinKhachSanFromReader(SqlDataReader reader)
        {
            UCThongTinKhachSan uc = new UCThongTinKhachSan();          
            uc.iDKhachSan = (int)reader[0];
            uc.txtTenKhachSan.Text = reader[1].ToString();
            uc.txtDiaDiemKhachSan.Text = reader[2].ToString();
            uc.loai = reader[3].ToString();
            uc.moTa = reader[4].ToString();               
            return uc;
        }
        public UCDanhGia CreateUCDanhGiaFromReader(SqlDataReader reader)
        {
            UCDanhGia uc = new UCDanhGia();
            uc.lblTenKhachHang.Text = reader[0].ToString();
            uc.lblTraiNghiem.Text = reader[1].ToString();
            uc.lblDiemDanhGia.Text = reader[2].ToString();
            uc.richTextBoxDanhGia.Text = reader[3].ToString();          
            return uc;
        }
    }
}
