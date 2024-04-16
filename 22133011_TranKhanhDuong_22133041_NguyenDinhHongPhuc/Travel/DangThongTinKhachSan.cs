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
        string Anh1, Anh2, Anh3, Anh4;
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
        private void btnThemAnh1_Click(object sender, EventArgs e)
        {
            kSanDAO.SaveImage(pic_Anh1, out Anh1);          
        }
        private void btnThemAnh2_Click(object sender, EventArgs e)
        {
            kSanDAO.SaveImage(pic_Anh2, out Anh2);        
        }
        private void btnThemAnh3_Click(object sender, EventArgs e)
        {
            kSanDAO.SaveImage(pic_Anh3, out Anh3);
        }
        private void btnThemAnh4_Click(object sender, EventArgs e)
        {
            kSanDAO.SaveImage(pic_Anh4, out Anh4);
        }               
    } 
}
