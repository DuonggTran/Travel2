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
    public partial class UCThongTinPhongCuaKhachSan : UserControl
    {
        public UCThongTinPhongCuaKhachSan()
        {
            InitializeComponent();
        }
        public string TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HutThuoc2;
        private void linklblChiTietPhong_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ThongTinPhongCuaKhachSan kSan = new ThongTinPhongCuaKhachSan();
            kSan.TenPhong = linklblChiTietPhong.Text;
            kSan.KichThuocPhong = lblKichThuoc.Text;
            kSan.GiaPhong = lblSoGiaTien.Text;
            kSan.TienNghiPhongTam1 = TienNghiPhongTam1;
            kSan.TienNghiPhongTam2 = TienNghiPhongTam2;
            kSan.TienNghiPhongTam3 = TienNghiPhongTam3;
            kSan.TienNghiPhongTam4 = TienNghiPhongTam4;
            kSan.HuongTamNhin1 = HuongTamNhin1;
            kSan.HuongTamNhin2 = HuongTamNhin2;
            kSan.HutThuoc1 = HutThuoc1;
            kSan.hutThuoc2 = HutThuoc2;
            kSan.TienNghiPhong1 = TienNghiPhong1;
            kSan.TienNghiPhong2 = TienNghiPhong2;
            kSan.TienNghiPhong3 = TienNghiPhong3;
            kSan.TienNghiPhong4 = TienNghiPhong4;
            kSan.TienNghiPhong5 = TienNghiPhong5;
            kSan.TienNghiPhong6 = TienNghiPhong6;
            ChiTietPhongCuaKhachSan f = new ChiTietPhongCuaKhachSan(kSan);
            f.ShowDialog();
        }
        public void LoadData(FlowLayoutPanel flpTrangChuKhachSan, int id)
        {
            List<UCThongTinPhongCuaKhachSan> PhongList = new List<UCThongTinPhongCuaKhachSan>();
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.cnnStr);
                connection.Open();
                string query = "SELECT* FROM ThongTinPhongCuaKhachSan WHERE IDKhachSan = @IDKhachSan";
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
                    PhongList.Add(uc);
                }
                reader.Close();
                connection.Close();
                foreach (UCThongTinPhongCuaKhachSan uc in PhongList)
                {
                    flpTrangChuKhachSan.Controls.Add(uc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}