using GUI;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Travel
{
    public partial class TrangChu : Form
    {
        SqlConnection cnnStr = new SqlConnection(Properties.Settings.Default.cnnStr);
        ThongTinKhachSanDAO kSanDAO = new ThongTinKhachSanDAO();    
        DataConnection dB = new DataConnection();
        public TrangChu()
        {
            InitializeComponent();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            flpTrangChu.Controls.Clear();
            UCThongTinKhachSan uc1 = new UCThongTinKhachSan();
            flpTrangChu.Controls.Add(uc1);
            UCThongTinKhachSan uc2 = new UCThongTinKhachSan();
            flpTrangChu.Controls.Add(uc2);
            UCThongTinKhachSan uc3 = new UCThongTinKhachSan();
            flpTrangChu.Controls.Add(uc3);
            UCThongTinKhachSan uc4 = new UCThongTinKhachSan();
            flpTrangChu.Controls.Add(uc4);
            UCThongTinKhachSan uc5 = new UCThongTinKhachSan();
            flpTrangChu.Controls.Add(uc5);
            UCThongTinKhachSan uc6 = new UCThongTinKhachSan();
            flpTrangChu.Controls.Add(uc6);
            UCThongTinKhachSan uc7 = new UCThongTinKhachSan();
            flpTrangChu.Controls.Add(uc7);
            UCThongTinKhachSan uc8 = new UCThongTinKhachSan();
            flpTrangChu.Controls.Add(uc8);
            UCThongTinKhachSan uc9 = new UCThongTinKhachSan();
            flpTrangChu.Controls.Add(uc9);
        }
    }
}
