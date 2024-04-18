using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Drawing;
using Travel;
using static Guna.UI2.WinForms.Suite.Descriptions;

namespace GUI
{
    internal class ThongTinPhongCuaKhachSanDAO
    {
        public void Them(ThongTinPhongCuaKhachSan kSan, DataConnection db)
        {           
            string SQL = string.Format("INSERT INTO ThongTinPhongCuaKhachSan(TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HutThuoc2, HinhAnh1, HinhAnh2, IDKhachSan) VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}', N'{9}', N'{10}', N'{11}', N'{12}', N'{13}', N'{14}', N'{15}', N'{16}', '{17}', '{18}','{19}')", kSan.TenPhong, kSan.KichThuocPhong, kSan.GiaPhong, kSan.TienNghiPhongTam1, kSan.TienNghiPhongTam2, kSan.TienNghiPhongTam3, kSan.TienNghiPhongTam4, kSan.HuongTamNhin1, kSan.HuongTamNhin2, kSan.TienNghiPhong1, kSan.TienNghiPhong2, kSan.TienNghiPhong3, kSan.TienNghiPhong4, kSan.TienNghiPhong5, kSan.TienNghiPhong6, kSan.HutThuoc1, kSan.HutThuoc2, kSan.HinhAnh1, kSan.HinhAnh2,kSan.IDKhachSan);
            db.ThucThi(SQL);
        }
        public void Xoa(int iDPhong, DataConnection db)
        {
            string SQL = string.Format("DELETE FROM ThongTinPhongCuaKhachSan WHERE IDPhong = '{0}'", iDPhong);
            db.ThucThi(SQL);
        }
        public void Sua(ThongTinPhongCuaKhachSan phongKSan, DataConnection db)
        {
            string SQL = string.Format("UPDATE ThongTinPhongCuaKhachSan SET TenPhong = N'{0}', KichThuocPhong = '{1}', GiaPhong = '{2}', TienNghiPhongTam1 = N'{3}', TienNghiPhongTam2 = '{4}', TienNghiPhongTam3 = N'{5}', TienNghiPhongTam4 = N'{6}', HuongTamNhin1 = N'{7}', HuongTamNhin2 = N'{8}', TienNghiPhong1 = N'{9}', TienNghiPhong2 = N'{10}', TienNghiPhong3 = N'{11}', TienNghiPhong4 = N'{12}', TienNghiPhong5 = N'{13}', TienNghiPhong6 = N'{14}', HutThuoc1 = N'{15}', HutThuoc2 = N'{16}', HinhAnh1 = '{17}', HinhAnh2 = '{18}' WHERE IDPhong = '{19}'", phongKSan.TenPhong, phongKSan.KichThuocPhong, phongKSan.GiaPhong, phongKSan.TienNghiPhongTam1, phongKSan.TienNghiPhongTam2, phongKSan.TienNghiPhongTam3, phongKSan.TienNghiPhongTam4, phongKSan.HuongTamNhin1, phongKSan.HuongTamNhin2, phongKSan.TienNghiPhong1, phongKSan.TienNghiPhong2, phongKSan.TienNghiPhong3, phongKSan.TienNghiPhong4, phongKSan.TienNghiPhong5, phongKSan.TienNghiPhong6, phongKSan.HutThuoc1, phongKSan.HutThuoc2, phongKSan.HinhAnh1, phongKSan.HinhAnh2, phongKSan.IDPhong);
            db.ThucThi(SQL);
        }
        public void LoadData(FlowLayoutPanel flpPhongKhachSan, int iD)
        {
            flpPhongKhachSan.Controls.Clear();
            SqlConnection connection = new SqlConnection(Travel.Properties.Settings.Default.cnnStr);
            connection.Open();
            string query = "SELECT* FROM ThongTinPhongCuaKhachSan WHERE IDKhachSan = @IDKhachSan";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IDKhachSan", iD);
            SqlDataReader reader = command.ExecuteReader();
            UCPhongKhachSan f = new UCPhongKhachSan();
            while (reader.Read())
            {
                f.LoadDataPhong(flpPhongKhachSan, iD);
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
                image.Image = System.Drawing.Image.FromFile(opf.FileName);
                filename = Path.GetFileName(opf.FileName);
                string appDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
                string dest = Path.Combine(appDirectory, filename);
                File.Copy(opf.FileName, dest, true);
            }
        }
        public List<UCThongTinPhongCuaKhachSan> LoadData(int id)
        {
            List<UCThongTinPhongCuaKhachSan> PhongList = new List<UCThongTinPhongCuaKhachSan>();
            try
            {
                SqlConnection connection = new SqlConnection(Travel.Properties.Settings.Default.cnnStr);
                connection.Open();
                string query = "SELECT * FROM ThongTinPhongCuaKhachSan WHERE IDKhachSan = @IDKhachSan";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IDKhachSan", id);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    UCThongTinPhongCuaKhachSan uc = new UCThongTinPhongCuaKhachSan();
                    uc.linklblChiTietPhong.Text = reader[1].ToString();
                    uc.lblKichThuocPhong.Text = reader[2].ToString();
                    uc.lblSoGiaTien.Text = reader[3].ToString();
                    uc.TienNghiPhongTam1 = reader[4].ToString();
                    uc.TienNghiPhongTam2 = reader[5].ToString();
                    uc.TienNghiPhongTam3 = reader[6].ToString();
                    uc.TienNghiPhongTam4 = reader[7].ToString();
                    uc.HuongTamNhin1 = reader[8].ToString();
                    uc.HuongTamNhin2 = reader[9].ToString();
                    uc.TienNghiPhong1 = reader[10].ToString();
                    uc.TienNghiPhong2 = reader[11].ToString();
                    uc.TienNghiPhong3 = reader[12].ToString();
                    uc.TienNghiPhong4 = reader[13].ToString();
                    uc.TienNghiPhong5 = reader[14].ToString();
                    uc.TienNghiPhong6 = reader[15].ToString();
                    uc.HutThuoc1 = reader[16].ToString();
                    uc.HutThuoc2 = reader[17].ToString();
                    uc.HinhAnh1 = reader[19].ToString();
                    uc.HinhAnh2 = reader[20].ToString();
                    uc.lblTrangThai.Text = reader[21].ToString();
                    PhongList.Add(uc);
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return PhongList;
        }
        public List<UCPhongKhachSan> LoadDataPhong(int id)
        {
            List<UCPhongKhachSan> phongKhachSanList = new List<UCPhongKhachSan>();
            try
            {
                SqlConnection connection = new SqlConnection(Travel.Properties.Settings.Default.cnnStr);
                connection.Open();
                string query = "SELECT * FROM ThongTinPhongCuaKhachSan WHERE IDKhachSan = @IDKhachSan";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IDKhachSan", id);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    UCPhongKhachSan uc = new UCPhongKhachSan();
                    uc.iDKhachSan = id;
                    uc.iDPhongKhachSan = (int)reader[0];
                    uc.linklblTenPhong.Text = reader[1].ToString();
                    uc.lbKichThuocPhong.Text = reader[2].ToString();
                    uc.lbSoGiaTien.Text = reader[3].ToString();
                    uc.tienNghiPhongTam1 = reader[4].ToString();
                    uc.tienNghiPhongTam2 = reader[5].ToString();
                    uc.tienNghiPhongTam3 = reader[6].ToString();
                    uc.tienNghiPhongTam4 = reader[7].ToString();
                    uc.huongTamNhin1 = reader[8].ToString();
                    uc.huongTamNhin2 = reader[9].ToString();
                    uc.tienNghiPhong1 = reader[10].ToString();
                    uc.tienNghiPhong2 = reader[11].ToString();
                    uc.tienNghiPhong3 = reader[12].ToString();
                    uc.tienNghiPhong4 = reader[13].ToString();
                    uc.tienNghiPhong5 = reader[14].ToString();
                    uc.tienNghiPhong6 = reader[15].ToString();
                    uc.hutThuoc1 = reader[16].ToString();
                    uc.hutThuoc2 = reader[17].ToString();
                    uc.hinhAnh1 = reader[19].ToString();
                    uc.hinhAnh2 = reader[20].ToString();
                    uc.lblTrangThai.Text = reader[21].ToString();
                    phongKhachSanList.Add(uc);
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return phongKhachSanList;
        }
    }
}

