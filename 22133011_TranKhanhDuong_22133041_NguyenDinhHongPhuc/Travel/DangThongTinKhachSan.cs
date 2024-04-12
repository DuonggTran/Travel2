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
using Travel.Properties;

namespace Travel
{
    public partial class DangThongTinKhachSan : Form
    {
        ThongTinKhachSanDAO kSanDAO = new ThongTinKhachSanDAO();
        DataConnection dB = new DataConnection();
        TaiKhoan tK = new TaiKhoan();
        TaiKhoanDAO tKDAO = new TaiKhoanDAO();
        public string filename;
        public DangThongTinKhachSan()
        {
            InitializeComponent();
        }
        private void btnDangBai_Click(object sender, EventArgs e)
        {
            this.Hide();
            tKDAO.load(tK, dB, "admin");
            ThongTinKhachSan kSan = new ThongTinKhachSan(txtTenKhachSan.Text, cboDiaDiem.Text, cboLoaiPhong.Text, txtMoTa.Text, Anh1, Anh2, Anh3, Anh4, tK.ID);
            kSanDAO.Them(kSan, dB);
            TrangChuAdmin f = new TrangChuAdmin();
            f.ShowDialog();
        }
        string Anh1, Anh2, Anh3, Anh4;
        private void btnThemAnh1_Click(object sender, EventArgs e)
        {
            SaveImage(pic_Anh1);
            Anh1 = filename;
        }
        private void btnThemAnh2_Click(object sender, EventArgs e)
        {
            SaveImage(pic_Anh2);
            Anh2 = filename;
        }
        private void btnThemAnh3_Click(object sender, EventArgs e)
        {
            SaveImage(pic_Anh3);
            Anh3 = filename;
        }
        private void btnThemAnh4_Click(object sender, EventArgs e)
        {
            SaveImage(pic_Anh4);
            Anh4 = filename;
        }
        public void SaveImage(PictureBox image)
        {
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
    } 
}
