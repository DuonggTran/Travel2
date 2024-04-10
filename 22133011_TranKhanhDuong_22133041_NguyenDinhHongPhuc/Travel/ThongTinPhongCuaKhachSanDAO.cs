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
            string SQL = string.Format("INSERT INTO ThongTinPhongCuaKhachSan(TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HutThuoc2, HinhAnh1, HinhAnh2, IDKhachSan) VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}', N'{9}', N'{10}', N'{11}', N'{12}', N'{13}', N'{14}', N'{15}', N'{16}', '{17}', '{18}','{19}')", kSan.TenPhong, kSan.KichThuocPhong, kSan.GiaPhong, kSan.TienNghiPhongTam1, kSan.TienNghiPhongTam2, kSan.TienNghiPhongTam3, kSan.TienNghiPhongTam4, kSan.HuongTamNhin1, kSan.HuongTamNhin2, kSan.TienNghiPhong1, kSan.TienNghiPhong2, kSan.TienNghiPhong3, kSan.TienNghiPhong4, kSan.TienNghiPhong5, kSan.TienNghiPhong6, kSan.HutThuoc1, kSan.HutThuoc2, kSan.HinhAnh1, kSan.HinhAnh2,kSan.IDKhachSan);
            db.ThucThi(SQL);
        }
        public void Xoa(int iDPhong, DataConnection db)
        {
            string SQL = string.Format("DELETE FROM ThongTinPhongCuaKhachSan WHERE IDPhong = '{0}'", iDPhong);
            db.ThucThi(SQL);
        }
        public void Sua(ThongTinPhongCuaKhachSan phongKSan, DataConnection db)
        {
            string SQL = string.Format("UPDATE ThongTinPhongCuaKhachSan SET TenPhong = N'{0}', KichThuocPhong = '{1}', GiaPhong = '{2}', TienNghiPhongTam1 = N'{3}', TienNghiPhongTam2 = '{4}', TienNghiPhongTam3 = N'{5}', TienNghiPhongTam4 = N'{6}', HuongTamNhin1 = N'{7}', HuongTamNhin2 = N'{8}', TienNghiPhong1 = N'{9}', TienNghiPhong2 = N'{10}', TienNghiPhong3 = N'{11}', TienNghiPhong4 = N'{12}', TienNghiPhong5 = N'{13}', TienNghiPhong6 = N'{14}', HutThuoc1 = N'{15}', HutThuoc2 = N'{16}', HinhAnh1 = '{17}', HinhAnh2 = '{18}' WHERE IDPhong = '{19}'", phongKSan.TenPhong, phongKSan.KichThuocPhong, phongKSan.GiaPhong, phongKSan.TienNghiPhongTam1, phongKSan.TienNghiPhongTam2, phongKSan.TienNghiPhongTam3, phongKSan.TienNghiPhongTam4, phongKSan.HuongTamNhin1, phongKSan.HuongTamNhin2, phongKSan.TienNghiPhong1, phongKSan.TienNghiPhong2, phongKSan.TienNghiPhong3, phongKSan.TienNghiPhong4, phongKSan.TienNghiPhong5, phongKSan.TienNghiPhong6, phongKSan.HutThuoc1, phongKSan.HutThuoc2, phongKSan.HinhAnh1, phongKSan.HinhAnh2, phongKSan.IDPhong);
            db.ThucThi(SQL);
        }
    }
}

