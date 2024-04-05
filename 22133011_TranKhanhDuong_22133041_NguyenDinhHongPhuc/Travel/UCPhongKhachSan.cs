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
    public partial class UCPhongKhachSan : UserControl
    {
        public UCPhongKhachSan()
        {
            InitializeComponent();
        }

        private void linklblChiTietPhong_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChiTietPhongKhachSanAdmin f = new ChiTietPhongKhachSanAdmin();
            f.ShowDialog();
        }
    }
}
