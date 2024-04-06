using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travel
{
    public partial class ChiTietKhachSanAdmin : Form
    {
        public int iD;
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
        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            ThemPhongChoKhachSan f = new ThemPhongChoKhachSan(iD);
            f.ShowDialog();
        }
    }
}
