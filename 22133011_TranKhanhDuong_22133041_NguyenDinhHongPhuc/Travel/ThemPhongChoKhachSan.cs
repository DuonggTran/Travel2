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
    public partial class ThemPhongChoKhachSan : Form
    {
        SqlConnection cnnStr = new SqlConnection(Properties.Settings.Default.cnnStr);
        ThongTinPhongCuaKhachSanDAO kSanDAO = new ThongTinPhongCuaKhachSanDAO();      
        DataConnection dB = new DataConnection();
        public int idKhachSan;
        public ThemPhongChoKhachSan()
        {
            InitializeComponent();
        }
        public ThemPhongChoKhachSan(int id)
        {
            InitializeComponent();
            idKhachSan = id;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {       
            this.Hide();
            ThongTinPhongCuaKhachSan kSan = new ThongTinPhongCuaKhachSan(cboTenPhong.Text, txtKichThuocPhong.Text, txtGiaPhong.Text, cboTienNghiPhongTam1.Text, cboTienNghiPhongTam2.Text, cboTienNghiPhongTam3.Text, cboTienNghiPhongTam4.Text, cboHuongTamNhin1.Text, cboHuongTamNhin2.Text, cboTienNghiPhong1.Text, cboTienNghiPhong2.Text, cboTienNghiPhong3.Text, cboTienNghiPhong4.Text, cboTienNghiPhong5.Text, cboTienNghiPhong6.Text, cboHutThuoc1.Text, cboHutThuoc2.Text, null, null,idKhachSan);
            {
                kSanDAO.Them(kSan, dB);
            }                                                      
        }
        private void btnThemAnh1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)| *.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pic_Anh1.Image = Image.FromFile(opf.FileName);
            }
        }
        private void btnThemAnh2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)| *.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pic_Anh2.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
