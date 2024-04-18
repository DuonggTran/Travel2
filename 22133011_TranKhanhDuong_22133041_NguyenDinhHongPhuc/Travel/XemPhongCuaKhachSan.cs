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
    public partial class XemPhongCuaKhachSan : Form
    {
        int iDKhachSan;
        ThongTinPhongCuaKhachSanDAO kSanDAO = new ThongTinPhongCuaKhachSanDAO();
        public XemPhongCuaKhachSan()
        {
            InitializeComponent();
        }
        public XemPhongCuaKhachSan(int iD)
        {
            InitializeComponent();
            iDKhachSan = iD;
        }
        private void XemPhongCuaKhachSan_Load(object sender, EventArgs e)
        {
            flpTrangChuKhachSan.Controls.Clear();
            UCThongTinPhongCuaKhachSan f = new UCThongTinPhongCuaKhachSan();
            f.LoadData(flpTrangChuKhachSan, iDKhachSan);                        
        }
    }
}
