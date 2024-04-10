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
    public partial class UCThongTinKhachSan : UserControl
    {
        public string loai, moTa;
        public int iDKhachSan;
        public UCThongTinKhachSan()
        {
            InitializeComponent();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            ThongTinKhachSan kSan = new ThongTinKhachSan();
            kSan.IDKhachSan = iDKhachSan;
            kSan.TenKhachSan = txtTenKhachSan.Text;
            kSan.DiaDiemKhachSan = txtDiaDiemKhachSan.Text;
            kSan.Loai = loai;
            kSan.MoTa = moTa;
            ChiTietKhachSan f = new ChiTietKhachSan(kSan);
            f.ShowDialog();
        }
        public void LoadData(FlowLayoutPanel flpTrangChu, int id)
        {
            List<UCThongTinKhachSan> khachSanList = new List<UCThongTinKhachSan>();
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.cnnStr);
                connection.Open();
                string query = "SELECT* FROM ThongTinKhachSan WHERE IDChuKhachSan = @IDChuKhachSan";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IDChuKhachSan", id);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    UCThongTinKhachSan uc = new UCThongTinKhachSan();
                    uc.iDKhachSan = (int)reader[0];
                    uc.txtTenKhachSan.Text = reader[1].ToString();
                    uc.txtDiaDiemKhachSan.Text = reader[2].ToString();
                    uc.loai = reader[3].ToString();
                    uc.moTa = reader[4].ToString();
                    khachSanList.Add(uc);
                }
                reader.Close();
                connection.Close();
                foreach (UCThongTinKhachSan uc in khachSanList)
                {
                    flpTrangChu.Controls.Add(uc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
