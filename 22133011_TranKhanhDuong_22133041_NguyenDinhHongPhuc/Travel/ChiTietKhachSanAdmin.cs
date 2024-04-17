using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Travel
{
    public partial class ChiTietKhachSanAdmin : Form
    {    
        ThongTinKhachSanDAO kSanDAO = new ThongTinKhachSanDAO();
        ThongTinPhongCuaKhachSanDAO pKSanDAO = new ThongTinPhongCuaKhachSanDAO();
        DataConnection dB = new DataConnection();      
        int iD, iDChuKS;      
        string Anh1, Anh2, Anh3, Anh4;
        string appDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        public ChiTietKhachSanAdmin()
        {
            InitializeComponent();
        }       
        public ChiTietKhachSanAdmin(ThongTinKhachSan kSan)
        {
            InitializeComponent();
            // Thong tin chi tiet
            txtTenKhachSan.Text = kSan.TenKhachSan;
            txtDiaDiem.Text = kSan.DiaDiemKhachSan;
            txtLoai.Text = kSan.Loai;
            richTextBoxMoTa.Text = kSan.MoTa;
            iD = kSan.IDKhachSan;
            iDChuKS = kSan.IDChuKhachSan;
            Anh1 = kSan.HinhAnh1;
            Anh2 = kSan.HinhAnh2;
            Anh3 = kSan.HinhAnh3;
            Anh4 = kSan.HinhAnh4;
            // Load Anh
            string image1 = Path.Combine(appDirectory, kSan.HinhAnh1);
            string image2 = Path.Combine(appDirectory, kSan.HinhAnh2);
            string image3 = Path.Combine(appDirectory, kSan.HinhAnh3);
            string image4 = Path.Combine(appDirectory, kSan.HinhAnh4);
            pic_Anh1.Image = Image.FromFile(image1);
            pic_Anh2.Image = Image.FromFile(image2);
            pic_Anh3.Image = Image.FromFile(image3);
            pic_Anh4.Image = Image.FromFile(image4);
            // Load Data Moi
            pKSanDAO.LoadData(flpPhongKhachSan,iD);
        }
        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            ThemPhongChoKhachSan f = new ThemPhongChoKhachSan(iD, this);
            f.ShowDialog();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // ThongTinKhachSan kSan = new ThongTinKhachSan();
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
            pKSanDAO.LoadData(flpPhongKhachSan,iD);
        }
        private void btnSuaAnh1_Click(object sender, EventArgs e)
        {
            kSanDAO.SaveImage(pic_Anh1, out Anh1);
        }
        private void btnSuaAnh2_Click(object sender, EventArgs e)
        {
            kSanDAO.SaveImage(pic_Anh2, out Anh2);
        }
        private void btnSuaAnh3_Click(object sender, EventArgs e)
        {
            kSanDAO.SaveImage(pic_Anh3, out Anh3);
        }
        private void btnSuaAnh4_Click(object sender, EventArgs e)
        {
            kSanDAO.SaveImage(pic_Anh4, out Anh4);
        }               
    }
}
