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
    public partial class DanhGia : Form
    {
        public DanhGia()
        {
            InitializeComponent();
        }
        public DanhGia(int id)
        {
            InitializeComponent();
            ThongTinKhachSanDAO khachSanDAO = new ThongTinKhachSanDAO();
            List<UCDanhGia> khachSanList = khachSanDAO.DataDanhGia(id);
            foreach (UCDanhGia uc in khachSanList)
            {
                flpDanhGia.Controls.Add(uc);
            }
        }
    }
}
