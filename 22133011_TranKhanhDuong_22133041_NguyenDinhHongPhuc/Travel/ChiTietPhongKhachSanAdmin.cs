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
    public partial class ChiTietPhongKhachSanAdmin : Form
    {       
        ThongTinPhongCuaKhachSanDAO phongKSanDAO = new ThongTinPhongCuaKhachSanDAO();
        DataConnection dB = new DataConnection();
        int iD, iDKhachSan;
        string Anh1, Anh2;
        string appDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        public ChiTietPhongKhachSanAdmin()
        {
            InitializeComponent();
        }
        public ChiTietPhongKhachSanAdmin(ThongTinPhongCuaKhachSan kSan)
        {
            InitializeComponent();
            iD = kSan.IDPhong;
            iDKhachSan = kSan.IDKhachSan;
            cboTenPhong.Text = kSan.TenPhong;
            txtKichThuocPhong.Text = kSan.KichThuocPhong;
            txtGiaPhong.Text = kSan.GiaPhong;
            cboTienNghiPhongTam1.Text = kSan.TienNghiPhongTam1;
            cboTienNghiPhongTam2.Text = kSan.TienNghiPhongTam2;
            cboTienNghiPhongTam3.Text = kSan.TienNghiPhongTam3;
            cboTienNghiPhongTam4.Text = kSan.TienNghiPhongTam4;
            cboHuongTamNhin1.Text = kSan.HuongTamNhin1;
            cboHuongTamNhin2.Text = kSan.HuongTamNhin2;
            cboTienNghiPhong1.Text = kSan.TienNghiPhong1;
            cboTienNghiPhong2.Text = kSan.TienNghiPhong2;
            cboTienNghiPhong3.Text = kSan.TienNghiPhong3;
            cboTienNghiPhong4.Text = kSan.TienNghiPhong4;
            cboTienNghiPhong5.Text = kSan.TienNghiPhong5;
            cboTienNghiPhong6.Text = kSan.TienNghiPhong6;
            cboHutThuoc1.Text = kSan.HutThuoc1;
            cboHutThuoc2.Text = kSan.HutThuoc2;
            // Load Anh
            string image1 = Path.Combine(appDirectory, kSan.HinhAnh1);
            string image2 = Path.Combine(appDirectory, kSan.HinhAnh2);
            pic_Anh1.Image = Image.FromFile(image1);
            pic_Anh2.Image = Image.FromFile(image2);
            Anh1 = kSan.HinhAnh1;
            Anh2 = kSan.HinhAnh2;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            ThongTinPhongCuaKhachSan phongKSan = new ThongTinPhongCuaKhachSan(cboTenPhong.Text, txtKichThuocPhong.Text, txtGiaPhong.Text, cboTienNghiPhongTam1.Text, cboTienNghiPhongTam2.Text, cboTienNghiPhongTam3.Text, cboTienNghiPhongTam4.Text, cboHuongTamNhin1.Text, cboHuongTamNhin2.Text, cboTienNghiPhong1.Text, cboTienNghiPhong2.Text, cboTienNghiPhong3.Text, cboTienNghiPhong4.Text, cboTienNghiPhong5.Text, cboTienNghiPhong6.Text, cboHutThuoc1.Text, cboHutThuoc2.Text, Anh1, Anh2, null, iDKhachSan);
            phongKSan.IDPhong = iD;
            phongKSanDAO.Sua(phongKSan, dB);
            this.Close();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            ThongTinPhongCuaKhachSan phongKSan = new ThongTinPhongCuaKhachSan();
            phongKSanDAO.Xoa(iD, dB);
            this.Close();
        }
        private void btnSuaAnh1_Click(object sender, EventArgs e)
        {
            phongKSanDAO.SaveImage(pic_Anh1, out Anh1);
        }
        private void btnSuaAnh2_Click(object sender, EventArgs e)
        {
            phongKSanDAO.SaveImage(pic_Anh2, out Anh2);
        }              
        
    }
}
