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
    public partial class ChiTietKhachSanAdmin : Form
    {
        SqlConnection cnnStr = new SqlConnection(Properties.Settings.Default.cnnStr);
        ThongTinKhachSanDAO kSanDAO = new ThongTinKhachSanDAO();
        DataConnection dB = new DataConnection();      
        public int iD;
        public int iDChuKS;
        public ChiTietKhachSanAdmin()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            flpPhongKhachSan.Controls.Clear();
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.cnnStr);
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
        public ChiTietKhachSanAdmin(ThongTinKhachSan kSan)
        {
            InitializeComponent();
            txtTenKhachSan.Text = kSan.TenKhachSan;
            txtDiaDiem.Text = kSan.DiaDiemKhachSan;
            txtLoai.Text = kSan.Loai;
            richTextBoxMoTa.Text = kSan.MoTa;
            iD = kSan.IDKhachSan;
            iDChuKS = kSan.IDChuKhachSan;
            LoadData();
        }
        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            ThemPhongChoKhachSan f = new ThemPhongChoKhachSan(iD);
            f.ShowDialog();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            ThongTinKhachSan kSan = new ThongTinKhachSan();
            kSanDAO.Xoa(iD, dB);
            this.Hide();
            TrangChuAdmin f = new TrangChuAdmin();
            f.ShowDialog();
            f = null;
            this.Close();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            ThongTinKhachSan kSan = new ThongTinKhachSan(txtTenKhachSan.Text, txtDiaDiem.Text, txtLoai.Text, richTextBoxMoTa.Text, null, null, null, null, iDChuKS);
            kSan.IDKhachSan = iD;
            kSanDAO.Sua(kSan, dB);
            this.Hide();
            ChiTietKhachSanAdmin f = new ChiTietKhachSanAdmin(kSan);
            f.ShowDialog();
            f = null;
            this.Close();
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnSuaAnh1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)| *.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pic_Anh1.Image = Image.FromFile(opf.FileName);
            }
        }
        private void btnSuaAnh2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)| *.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pic_Anh2.Image = Image.FromFile(opf.FileName);
            }
        }
        private void btnSuaAnh3_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)| *.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pic_Anh3.Image = Image.FromFile(opf.FileName);
            }
        }
        private void btnSuaAnh4_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)| *.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pic_Anh4.Image = Image.FromFile(opf.FileName);
            }
        }     
    }
}
