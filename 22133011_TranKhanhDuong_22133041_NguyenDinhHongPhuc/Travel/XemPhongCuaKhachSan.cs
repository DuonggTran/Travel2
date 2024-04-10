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
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.cnnStr);
            connection.Open();           
            string query = "SELECT* FROM ThongTinPhongCuaKhachSan WHERE IDKhachSan = @IDKhachSan";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IDKhachSan", iDKhachSan);
            SqlDataReader reader = command.ExecuteReader();
            UCThongTinPhongCuaKhachSan f = new UCThongTinPhongCuaKhachSan();
            while (reader.Read())
            {              
                f.LoadData(flpTrangChuKhachSan, iDKhachSan);
                break;
            }
            connection.Close();
        }
    }
}
