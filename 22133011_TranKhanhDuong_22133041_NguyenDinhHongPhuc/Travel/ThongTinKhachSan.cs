using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class ThongTinKhachSan
    {
        public int iDKhachSan;
        public string tenKhachSan;
        public string diaDiemKhachSan;
        public string loai;
        public string moTa;
        public string hinhAnh1;
        public string hinhAnh2;
        public string hinhAnh3;
        public string hinhAnh4;
        public int iDChuKhachSan;
        public ThongTinKhachSan() { }
        public ThongTinKhachSan(string tenKhachSan, string diaDiemKhachSan, string loai, string moTa, string hinhAnh1, string hinhAnh2, string hinhAnh3, string hinhAnh4, int iDChuKhachSan)
        {
            this.tenKhachSan = tenKhachSan;
            this.diaDiemKhachSan = diaDiemKhachSan;
            this.loai = loai;
            this.moTa = moTa;
            this.hinhAnh1 = hinhAnh1;
            this.hinhAnh2 = hinhAnh2;
            this.hinhAnh3 = hinhAnh3;
            this.hinhAnh4 = hinhAnh4;
            this.iDChuKhachSan = iDChuKhachSan;
        }
        public string TenKhachSan
        {
            get { return tenKhachSan; }
            set { tenKhachSan = value; }
        }
        public string DiaDiemKhachSan
        {
            get { return diaDiemKhachSan; }
            set { diaDiemKhachSan = value; }
        }
        public string Loai
        {
            get { return loai; }
            set { loai = value; }
        }
        public string MoTa
        {
            get { return moTa; }
            set { moTa = value; }
        }
        public string HinhAnh1
        {
            get { return hinhAnh1; }
            set { hinhAnh1 = value; }
        }
        public string HinhAnh2
        {
            get { return hinhAnh2; }
            set { hinhAnh2 = value; }
        }
        public string HinhAnh3
        {
            get { return hinhAnh3; }
            set { hinhAnh3 = value; }
        }
        public string HinhAnh4
        {
            get { return hinhAnh4; }
            set { hinhAnh4 = value; }
        }
        public int IDChuKhachSan
        {
            get { return iDChuKhachSan;}
            set { iDChuKhachSan = value; }
        }
        public int IDKhachSan
        {
            get { return iDKhachSan; }
            set { iDKhachSan = value; }
        }
    }
}
