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
        string Anh1, Anh2, Anh3, Anh4;
        public ChiTietKhachSanAdmin()
        {
            InitializeComponent();
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
            pic_Anh1.Image = Image.FromFile(kSan.HinhAnh1); 
            pic_Anh2.Image = Image.FromFile(kSan.HinhAnh2);
            pic_Anh3.Image = Image.FromFile(kSan.HinhAnh3); ;
            pic_Anh4.Image = Image.FromFile(kSan.HinhAnh4);
            Anh1 = kSan.HinhAnh1;
            Anh2 = kSan.HinhAnh2;
            Anh3 = kSan.HinhAnh3;
            Anh4 = kSan.HinhAnh4;
            LoadData();
        }
        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            ThemPhongChoKhachSan f = new ThemPhongChoKhachSan(iD, this);
            f.ShowDialog();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            ThongTinKhachSan kSan = new ThongTinKhachSan();
            kSanDAO.Xoa(iD, dB);          
            this.Close();
        }      
        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTinKhachSan kSan = new ThongTinKhachSan(txtTenKhachSan.Text, txtDiaDiem.Text, txtLoai.Text, richTextBoxMoTa.Text, Anh1, Anh2, Anh3, Anh4, iDChuKS);
            kSan.IDKhachSan = iD;
            kSanDAO.Sua(kSan, dB);
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
                Anh1 = opf.FileName;
            }
        }
        private void btnSuaAnh2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)| *.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pic_Anh2.Image = Image.FromFile(opf.FileName);
                Anh2 = opf.FileName;
            }
        }
        private void btnSuaAnh3_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)| *.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pic_Anh3.Image = Image.FromFile(opf.FileName);
                Anh3 = opf.FileName;
            }
        }
        private void btnSuaAnh4_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)| *.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pic_Anh4.Image = Image.FromFile(opf.FileName);
                Anh4 = opf.FileName;
            }
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
    }
}
