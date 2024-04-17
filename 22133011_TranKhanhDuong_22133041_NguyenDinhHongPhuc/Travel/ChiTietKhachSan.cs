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
    public partial class ChiTietKhachSan : Form
    {
        public int iD,iDChuKS;        
        public ChiTietKhachSan()
        {
            InitializeComponent();
        }
        public ChiTietKhachSan(ThongTinKhachSan kSan)
        {
            InitializeComponent();
            txtTenKhachSan.Text = kSan.TenKhachSan;
            lblDiaDiem.Text = kSan.DiaDiemKhachSan;
            lblLoai.Text = kSan.Loai;
            richTextBoxMoTa.Text = kSan.MoTa;
            iD = kSan.IDKhachSan;
            iDChuKS = kSan.IDChuKhachSan;
        }

        private void linklbDanhGia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           DanhGia f = new DanhGia(iD);
            f.ShowDialog();
        }

        private void btnXemPhongTrong_Click(object sender, EventArgs e)
        {
            XemPhongCuaKhachSan f = new XemPhongCuaKhachSan(iD);
            f.ShowDialog();
        }
    }
}
