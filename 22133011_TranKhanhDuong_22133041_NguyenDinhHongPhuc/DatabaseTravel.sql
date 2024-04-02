Use DoAnCuoiKy

CREATE TABLE TaiKhoan
(
	IDNguoiDung INT PRIMARY KEY IDENTITY,
	TenDangNhap nvarchar(50) null,
	MatKhau nvarchar(50) null,
	LoaiNguoiDung nvarchar(30) null
);
SELECT *FROM TaiKhoan
DROP TABLE TaiKhoan

CREATE TABLE ThongTinKhachSan
(
	IDKhachSan INT PRIMARY KEY IDENTITY,
	TenKhachSan nvarchar(100) Null,
	DiaDiemKhachSan nvarchar(100)Null,
	Loai nvarchar(100)Null,
	MoTa nvarchar(500)Null,
	HinhAnh1 IMAGE,
	HinhAnh2 IMAGE,
	HinhAnh3 IMAGE,
	HinhAnh4 IMAGE,
	IDChuKhachSan INT Foreign key References TaiKhoan(IDNguoiDung)
);
SELECT *FROM ThongTinKhachSan
DROP TABLE ThongTinKhachSan


CREATE TABLE ThongTinPhongCuaKhachSan
(
	TenPhong nvarchar(30) null,
	KichThuocPhong nvarchar(30) null,
	GiaPhong nvarchar (30) null,
	TienNghiPhongTam1 nvarchar (30) null,
	TienNghiPhongTam2 nvarchar (30) null,
	TienNghiPhongTam3 nvarchar (30) null,
	TienNghiPhongTam4 nvarchar (30) null,
	HuongTamNhin1 nvarchar (30) null,
	HuongTamNhin2 nvarchar (30) null,
	TienNghiPhong1 nvarchar (30) null,
	TienNghiPhong2 nvarchar (30) null,
	TienNghiPhong3 nvarchar (30) null,
	TienNghiPhong4 nvarchar (30) null,
	TienNghiPhong5 nvarchar (30) null,
	TienNghiPhong6 nvarchar (30) null,
	HutThuoc1 nvarchar (30) null,
	HutThuoc2 nvarchar (30) null,
	HinhAnh1 IMAGE,
	HinhAnh2 IMAGE,
	IDKhachSan INT Foreign key References ThongTinKhachSan(IDKhachSan)
);
SELECT *FROM ThongTinPhongCuaKhachSan
DROP TABLE ThongTinPhongCuaKhachSan