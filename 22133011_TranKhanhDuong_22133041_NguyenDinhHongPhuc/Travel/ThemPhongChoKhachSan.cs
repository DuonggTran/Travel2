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
    public partial class ThemPhongChoKhachSan : Form
    {       
        ThongTinPhongCuaKhachSanDAO phongKSanDAO = new ThongTinPhongCuaKhachSanDAO();      
        DataConnection dB = new DataConnection();      
        public int idKhachSan;
        public string Anh1, Anh2, filename;
        public ThemPhongChoKhachSan()
        {
            InitializeComponent();
        }
        public ThemPhongChoKhachSan(int id, ChiTietKhachSanAdmin f)
        {
            InitializeComponent();
            idKhachSan = id;         
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {       
            this.Hide();
            ThongTinPhongCuaKhachSan kSan = new ThongTinPhongCuaKhachSan(cboTenPhong.Text, txtKichThuocPhong.Text, txtGiaPhong.Text, cboTienNghiPhongTam1.Text, cboTienNghiPhongTam2.Text, cboTienNghiPhongTam3.Text, cboTienNghiPhongTam4.Text, cboHuongTamNhin1.Text, cboHuongTamNhin2.Text, cboTienNghiPhong1.Text, cboTienNghiPhong2.Text, cboTienNghiPhong3.Text, cboTienNghiPhong4.Text, cboTienNghiPhong5.Text, cboTienNghiPhong6.Text, cboHutThuoc1.Text, cboHutThuoc2.Text, Anh1, Anh2, null ,idKhachSan);
            {
                phongKSanDAO.Them(kSan, dB);              
            }
        }
        private void btnThemAnh1_Click(object sender, EventArgs e)
        {
            phongKSanDAO.SaveImage(pic_Anh1, out Anh1);
        }
        private void btnThemAnh2_Click(object sender, EventArgs e)
        {
            phongKSanDAO.SaveImage(pic_Anh1, out Anh1);
        }       
    }
}
