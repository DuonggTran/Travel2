using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    internal class TaiKhoan
    {
        public int iD;
        public string tenDangNhap;
        public string matKhau;
        public string loaiNguoiDung;
        public TaiKhoan() { }
        public TaiKhoan(int iD, string tenDangNhap, string matKhau, string loaiNguoiDung)
        {
            this.iD = iD;
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
            this.loaiNguoiDung = loaiNguoiDung;
        }
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        public string TenDangNhap
        { get { return tenDangNhap; } set { tenDangNhap = value; } }

        public string MatKhau
        { get { return matKhau; } set { matKhau = value; } }
        public string LoaiNguoiDung
        {
            get { return loaiNguoiDung; }
            set { loaiNguoiDung = value; }
        }
    }
}
