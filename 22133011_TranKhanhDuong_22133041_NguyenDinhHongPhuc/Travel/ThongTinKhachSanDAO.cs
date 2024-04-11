﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travel;
using static Guna.UI2.WinForms.Suite.Descriptions;

namespace GUI
{
    internal class ThongTinKhachSanDAO
    {
        public void Them(ThongTinKhachSan kSan, DataConnection db)
        {
            string SQL = string.Format("INSERT INTO ThongTinKhachSan(TenKhachSan, DiaDiemKhachSan, Loai, MoTa, HinhAnh1, HinhAnh2, HinhAnh3, HinhAnh4, IDChuKhachSan) VALUES (N'{0}', N'{1}', N'{2}', N'{3}', '{4}', '{5}', '{6}', '{7}','{8}')", kSan.TenKhachSan, kSan.DiaDiemKhachSan, kSan.Loai, kSan.MoTa, kSan.HinhAnh1, kSan.HinhAnh2, kSan.HinhAnh3, kSan.HinhAnh4,kSan.IDChuKhachSan);
            db.ThucThi(SQL);
        }
        public void Xoa(int iDKhachSan, DataConnection db)
        {
            string SQL = string.Format("DELETE FROM ThongTinKhachSan WHERE IDKhachSan = '{0}'", iDKhachSan);
            db.ThucThi(SQL);
        }
        public void Sua(ThongTinKhachSan kSan, DataConnection db)
        {
            string SQL = string.Format("UPDATE ThongTinKhachSan SET TenKhachSan = N'{0}', DiaDiemKhachSan = N'{1}', Loai = N'{2}', MoTa = N'{3}', HinhAnh1 = '{4}', HinhAnh2 = '{5}', HinhAnh3 = '{6}', HinhAnh4 = '{7}' WHERE IDKhachSan = {8}", kSan.TenKhachSan, kSan.DiaDiemKhachSan, kSan.Loai, kSan.MoTa, kSan.HinhAnh1, kSan.HinhAnh2, kSan.HinhAnh3, kSan.HinhAnh4, kSan.IDKhachSan);
            db.ThucThi(SQL);
        }
        public void AddImageToPictureBox(PictureBox pictureBox)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)| *.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(opf.FileName);               
            }
        }
    }
}
