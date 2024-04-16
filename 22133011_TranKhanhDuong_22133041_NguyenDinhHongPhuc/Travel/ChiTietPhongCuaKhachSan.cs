using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel
{
    public partial class ChiTietPhongCuaKhachSan : Form
    {
        string appDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        public ChiTietPhongCuaKhachSan()
        {
            InitializeComponent();
        }
        public ChiTietPhongCuaKhachSan(ThongTinPhongCuaKhachSan kSan)
        {
            InitializeComponent();
            lblTenPhong.Text = kSan.TenPhong;
            lblKichThuocPhong.Text = kSan.KichThuocPhong;
            lblGiaPhong.Text = kSan.GiaPhong;
            lblTienNghiPhongTam1.Text = kSan.TienNghiPhongTam1;
            lblTienNghiPhongTam2.Text = kSan.TienNghiPhongTam2;
            lblTienNghiPhongTam3.Text = kSan.TienNghiPhongTam3;
            lblTienNghiPhongTam4.Text = kSan.TienNghiPhongTam4;
            lblHuongTamNhin1.Text = kSan.HuongTamNhin1;
            lblHuongTamNhin2.Text = kSan.HuongTamNhin2;
            lblHutThuoc1.Text = kSan.HutThuoc1;
            lblHutThuoc2.Text = kSan.hutThuoc2;
            lblTienNghiPhong1.Text = kSan.TienNghiPhong1;
            lblTienNghiPhong2.Text = kSan.TienNghiPhong2;
            lblTienNghiPhong3.Text = kSan.TienNghiPhong3;
            lblTienNghiPhong4.Text = kSan.TienNghiPhong4;
            lblTienNghiPhong5.Text = kSan.TienNghiPhong5;
            lblTienNghiPhong6.Text = kSan.TienNghiPhong6;
            // Load Anh
            string image1 = Path.Combine(appDirectory, kSan.HinhAnh1);
            string image2 = Path.Combine(appDirectory, kSan.HinhAnh2);          
            pic_Anh1.Image = Image.FromFile(image1);
            pic_Anh2.Image = Image.FromFile(image2);
            
        }      
    }
}
