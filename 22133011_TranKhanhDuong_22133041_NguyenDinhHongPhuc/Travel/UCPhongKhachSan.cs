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
    public partial class UCPhongKhachSan : UserControl
    {
        public int iDPhongKhachSan, iDKhachSan;
        public string tienNghiPhongTam1, tienNghiPhongTam2, tienNghiPhongTam3, tienNghiPhongTam4, huongTamNhin1, huongTamNhin2, tienNghiPhong1, tienNghiPhong2, tienNghiPhong3, tienNghiPhong4, tienNghiPhong5, tienNghiPhong6, hutThuoc1, hutThuoc2, hinhAnh1, hinhAnh2;

        

        private void btnChiTiet_Click(object sender, EventArgs e)
        {

        }

        public UCPhongKhachSan()
        {
            InitializeComponent();
        }
        private void linklblChiTietPhong_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ThongTinPhongCuaKhachSan kSan = new ThongTinPhongCuaKhachSan();
            kSan.IDPhong = iDPhongKhachSan;
            kSan.IDKhachSan = iDKhachSan;
            kSan.TenPhong = linklblTenPhong.Text;
            kSan.KichThuocPhong = lbKichThuocPhong.Text;
            kSan.GiaPhong = lbSoGiaTien.Text;
            kSan.TienNghiPhongTam1 = tienNghiPhongTam1;
            kSan.TienNghiPhongTam2 = tienNghiPhongTam2;
            kSan.TienNghiPhongTam3 = tienNghiPhongTam3;
            kSan.TienNghiPhongTam4 = tienNghiPhongTam4;
            kSan.HuongTamNhin1 = huongTamNhin1;
            kSan.HuongTamNhin2 = huongTamNhin2;
            kSan.TienNghiPhong1 = tienNghiPhong1;
            kSan.TienNghiPhong2 = tienNghiPhong2;
            kSan.TienNghiPhong3 = tienNghiPhong3;
            kSan.TienNghiPhong4 = tienNghiPhong4;
            kSan.TienNghiPhong5 = tienNghiPhong5;
            kSan.TienNghiPhong6 = tienNghiPhong6;
            kSan.HutThuoc1 = hutThuoc1;
            kSan.HutThuoc2 = hutThuoc2;
            kSan.HinhAnh1 = hinhAnh1;
            kSan.HinhAnh2 = hinhAnh2;
            kSan.TrangThai = lblTrangThai.Text;
            ChiTietPhongKhachSanAdmin f = new ChiTietPhongKhachSanAdmin(kSan);
            f.ShowDialog();
        }
        public void LoadDataPhong(FlowLayoutPanel flpPhongKhachSan, int id)
        {
            List<UCPhongKhachSan> phongKhachSanList = new List<UCPhongKhachSan>();
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
                    UCPhongKhachSan uc = new UCPhongKhachSan();
                    iDKhachSan = id;
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
                foreach (UCPhongKhachSan uc in phongKhachSanList)
                {
                    flpPhongKhachSan.Controls.Add(uc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
