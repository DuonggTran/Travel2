using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel;

namespace GUI
{
    internal class ThongTinPhongCuaKhachSanDAO
    {
        public void Them(ThongTinPhongCuaKhachSan kSan, DataConnection db)
        {           
            string SQL = string.Format("INSERT INTO ThongTinPhongCuaKhachSan(TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HutThuoc2, HinhAnh1, HinhAnh2, IDKhachSan) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}','{19}')", kSan.TenPhong, kSan.KichThuocPhong, kSan.GiaPhong, kSan.TienNghiPhongTam1, kSan.TienNghiPhongTam2, kSan.TienNghiPhongTam3, kSan.TienNghiPhongTam4, kSan.HuongTamNhin1, kSan.HuongTamNhin2, kSan.TienNghiPhong1, kSan.TienNghiPhong2, kSan.TienNghiPhong3, kSan.TienNghiPhong4, kSan.TienNghiPhong5, kSan.TienNghiPhong6, kSan.HutThuoc1, kSan.HutThuoc2, kSan.HinhAnh1, kSan.HinhAnh2,kSan.IDKhachSan);
            db.ThucThi(SQL);
        }
        public void Xoa(ThongTinPhongCuaKhachSan kSan, DataConnection db)
        {
            string SQL = string.Format("DELETE FROM ThongTinPhongCuaKhachSan WHERE IDPhong = '{0}'", kSan.IDPhong);
            db.ThucThi(SQL);
        }
        public void Sua(ThongTinPhongCuaKhachSan kSan, DataConnection db)
        {
            string SQL = string.Format("UPDATE ThongTinKhachSan SET TenPhong = '{0}', KichThuocPhong = '{1}', GiaPhong = '{2}', TienNghiPhongTam1 = '{3}', TienNghiPhongTam2 = '{4}', TienNghiPhongTam3 = '{5}', TienNghiPhongTam4 = '{6}', HuongTamNhin1 = '{7}', HuongTamNhin2 = '{8}', TienNghiPhong1 = '{9}', TienNghiPhong2 = '{10}', TienNghiPhong3 = '{11}', TienNghiPhong4 = '{12}', TienNghiPhong5 = '{13}', TienNghiPhong6 = '{14}', HutThuoc1 = '{15}', HutThuoc2 = '{16}', HinhAnh1 = '{17}', HinhAnh2 = '{18}' WHERE IDPhong = '{19}'", kSan.TenPhong, kSan.KichThuocPhong, kSan.GiaPhong, kSan.TienNghiPhongTam1, kSan.TienNghiPhongTam2, kSan.TienNghiPhongTam3, kSan.TienNghiPhongTam4, kSan.HuongTamNhin1, kSan.HuongTamNhin2, kSan.TienNghiPhong1, kSan.TienNghiPhong2, kSan.TienNghiPhong3, kSan.TienNghiPhong4, kSan.TienNghiPhong5, kSan.TienNghiPhong6, kSan.HutThuoc1, kSan.HutThuoc2, kSan.HinhAnh1, kSan.HinhAnh2);
            db.ThucThi(SQL);
        }
    }
}

