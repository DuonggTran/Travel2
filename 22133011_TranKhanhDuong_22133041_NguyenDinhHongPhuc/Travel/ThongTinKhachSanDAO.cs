﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travel;

namespace GUI
{
    internal class ThongTinKhachSanDAO
    {
        public void Them(ThongTinKhachSan kSan, DataConnection db)
        {
            string SQL = string.Format("INSERT INTO ThongTinKhachSan(TenKhachSan, DiaDiemKhachSan, Loai, MoTa, HinhAnh1, HinhAnh2, HinhAnh3, HinhAnh4, IDChuKhachSan) VALUES (N'{0}', N'{1}', N'{2}', N'{3}', '{4}', '{5}', '{6}', '{7}','{8}')", kSan.TenKhachSan, kSan.DiaDiemKhachSan, kSan.Loai, kSan.MoTa, kSan.HinhAnh1, kSan.HinhAnh2, kSan.HinhAnh3, kSan.HinhAnh4,kSan.IDChuKhachSan);
            db.ThucThi(SQL);
        }
    }
}
