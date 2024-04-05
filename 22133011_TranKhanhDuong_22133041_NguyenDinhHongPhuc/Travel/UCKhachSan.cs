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
    public partial class UCKhachSan : UserControl
    {
        public UCKhachSan()
        {
            InitializeComponent();
        }
        public string loai, mota;
        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            ThongTinKhachSan kSan = new ThongTinKhachSan();
            kSan.TenKhachSan = txtTenKhachSan.Text;
            kSan.DiaDiemKhachSan = txtDiaDiemKhachSan.Text;
            kSan.Loai = loai;
            kSan.MoTa = mota;          
            this.Hide();
            ChiTietKhachSanAdmin f = new ChiTietKhachSanAdmin(kSan);
            ThemPhongChoKhachSan k = new ThemPhongChoKhachSan(iDKhachSan);
            f.ShowDialog();                      
        }
        public int iDKhachSan;
        public void LoadDataTimKiem(FlowLayoutPanel flpTrangChuAdmin, int id)
        {
            List<UCKhachSan> khachSanList = new List<UCKhachSan>();
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
                    UCKhachSan uc = new UCKhachSan();
                    uc.iDKhachSan = reader.GetInt32(0);                    
                    uc.txtTenKhachSan.Text = reader[1].ToString();
                    uc.txtDiaDiemKhachSan.Text = reader[2].ToString();
                    uc.loai = reader[3].ToString();
                    uc.mota = reader[4].ToString();
                    khachSanList.Add(uc);
                }
                reader.Close();
                connection.Close();
                foreach (UCKhachSan uc in khachSanList)
                {
                    flpTrangChuAdmin.Controls.Add(uc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
