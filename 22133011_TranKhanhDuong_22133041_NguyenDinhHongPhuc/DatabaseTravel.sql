Use DoAnCuoiKy

CREATE TABLE TaiKhoan
(
	IDNguoiDung INT PRIMARY KEY,
	TenDangNhap nvarchar(max) null,
	MatKhau nvarchar(max) null,
	LoaiNguoiDung nvarchar(max) null
);
SELECT *FROM TaiKhoan
DROP TABLE TaiKhoan

insert into TaiKhoan values
(1,'admin','admin','admin');
insert into TaiKhoan values
(2,'user','user','user');


CREATE TABLE ThongTinKhachSan
(
	IDKhachSan INT PRIMARY KEY IDENTITY,
	TenKhachSan nvarchar(max) Null,
	DiaDiemKhachSan nvarchar(max)Null,
	Loai nvarchar(max)Null,
	MoTa nvarchar(max)Null,
	HinhAnh1 nvarchar(max)Null,
	HinhAnh2 nvarchar(max)Null,
	HinhAnh3 nvarchar(max)Null,
	HinhAnh4 nvarchar(max)Null,
	IDChuKhachSan INT Foreign key References TaiKhoan(IDNguoiDung)
);
SELECT *FROM ThongTinKhachSan
DROP TABLE ThongTinKhachSan

insert into ThongTinKhachSan(TenKhachSan, DiaDiemKhachSan, Loai, MoTa, HinhAnh1, HinhAnh2, HinhAnh3, HinhAnh4, IDChuKhachSan ) values 
('KSan 1','Nha Trang','Hotel','5 sao','6.png','6.png','6.png','6.png',1)
insert into ThongTinKhachSan(TenKhachSan, DiaDiemKhachSan, Loai, MoTa, HinhAnh1, HinhAnh2, HinhAnh3, HinhAnh4, IDChuKhachSan ) values 
('KSan 2','Nha Trang','Hotel','5 sao','6.png','6.png','6.png','6.png',1)
insert into ThongTinKhachSan(TenKhachSan, DiaDiemKhachSan, Loai, MoTa, HinhAnh1, HinhAnh2, HinhAnh3, HinhAnh4, IDChuKhachSan )values 
('KSan 3',N'Huế','Hotel','5 sao','6.png','6.png','6.png','6.png',1)
insert into ThongTinKhachSan(TenKhachSan, DiaDiemKhachSan, Loai, MoTa, HinhAnh1, HinhAnh2, HinhAnh3, HinhAnh4, IDChuKhachSan ) values 
('KSan 4',N'Huế','Hotel','5 sao','6.png','6.png','6.png','6.png',1)
insert into ThongTinKhachSan(TenKhachSan, DiaDiemKhachSan, Loai, MoTa, HinhAnh1, HinhAnh2, HinhAnh3, HinhAnh4, IDChuKhachSan )values 
('KSan 5',N'Đà Nẵng','Hotel','5 sao','6.png','6.png','6.png','6.png',1)
insert into ThongTinKhachSan(TenKhachSan, DiaDiemKhachSan, Loai, MoTa, HinhAnh1, HinhAnh2, HinhAnh3, HinhAnh4, IDChuKhachSan )values 
('KSan 6',N'Đà Nẵng','Hotel','5 sao','6.png','6.png','6.png','6.png',1)


CREATE TABLE ThongTinPhongCuaKhachSan
(
	IDPhong INT PRIMARY KEY IDENTITY,
	TenPhong nvarchar(max) null,
	KichThuocPhong nvarchar(max) null,
	GiaPhong nvarchar (max) null,
	TienNghiPhongTam1 nvarchar (max) null,
	TienNghiPhongTam2 nvarchar (max) null,
	TienNghiPhongTam3 nvarchar (max) null,
	TienNghiPhongTam4 nvarchar (max) null,
	HuongTamNhin1 nvarchar (max) null,
	HuongTamNhin2 nvarchar (max) null,
	TienNghiPhong1 nvarchar (max) null,
	TienNghiPhong2 nvarchar (max) null,
	TienNghiPhong3 nvarchar (max) null,
	TienNghiPhong4 nvarchar (max) null,
	TienNghiPhong5 nvarchar (max) null,
	TienNghiPhong6 nvarchar (max) null,
	HutThuoc1 nvarchar (max) null,
	HutThuoc2 nvarchar (max) null,
	UuDai nvarchar (max) null,
	HinhAnh1 nvarchar(max)Null,
	HinhAnh2 nvarchar(max)Null,
	TrangThai nvarchar(max) null,
IDKhachSan INT Foreign key References ThongTinKhachSan(IDKhachSan)
);
SELECT *FROM ThongTinPhongCuaKhachSan
DROP TABLE ThongTinPhongCuaKhachSan

insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HutThuoc2, UuDai, HinhAnh1, HinhAnh2, TrangThai, IDKhachSan) values 
(N'Phòng Thường','20','500.000',N'Dép',N'Vòi Sen',N'Bồn Tắm',N'Máy Sấy Tóc',N'Nhìn Ra Biến',N'Núi',N'Minibar',N'Điện Thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Không Hút Thuốc',N'Có nơi hút thuốc',null,'2.png','2.png',N'Đã Được Thuê',1)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HutThuoc2, UuDai, HinhAnh1, HinhAnh2, TrangThai, IDKhachSan) values 
(N'Phòng Thường','20','500.000',N'Dép',N'Vòi Sen',N'Bồn Tắm',N'Máy Sấy Tóc',N'Nhìn Ra Biến',N'Núi',N'Minibar',N'Điện Thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Không Hút Thuốc',N'Có nơi hút thuốc',null,'2.png','2.png',N'Còn Trống',1)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HutThuoc2, UuDai, HinhAnh1, HinhAnh2, TrangThai, IDKhachSan) values 
(N'Phòng Thường','20','500.000',N'Dép',N'Vòi Sen',N'Bồn Tắm',N'Máy Sấy Tóc',N'Nhìn Ra Biến',N'Núi',N'Minibar',N'Điện Thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Không Hút Thuốc',N'Có nơi hút thuốc',null,'2.png','2.png',N'Đã Được Thuê',2)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HutThuoc2, UuDai, HinhAnh1, HinhAnh2, TrangThai, IDKhachSan) values 
(N'Phòng Thường','20','500.000',N'Dép',N'Vòi Sen',N'Bồn Tắm',N'Máy Sấy Tóc',N'Nhìn Ra Biến',N'Núi',N'Minibar',N'Điện Thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Không Hút Thuốc',N'Có nơi hút thuốc',null,'2.png','2.png',N'Còn Trống',2)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HutThuoc2, UuDai, HinhAnh1, HinhAnh2, TrangThai, IDKhachSan) values 
(N'Phòng Thường','20','500.000',N'Dép',N'Vòi Sen',N'Bồn Tắm',N'Máy Sấy Tóc',N'Nhìn Ra Biến',N'Núi',N'Minibar',N'Điện Thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Không Hút Thuốc',N'Có nơi hút thuốc',null,'2.png','2.png',N'Đã Được Thuê',3)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HutThuoc2, UuDai, HinhAnh1, HinhAnh2, TrangThai, IDKhachSan) values 
(N'Phòng Thường','20','500.000',N'Dép',N'Vòi Sen',N'Bồn Tắm',N'Máy Sấy Tóc',N'Nhìn Ra Biến',N'Núi',N'Minibar',N'Điện Thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Không Hút Thuốc',N'Có nơi hút thuốc',null,'2.png','2.png',N'Còn Trống',3)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HutThuoc2, UuDai, HinhAnh1, HinhAnh2, TrangThai, IDKhachSan) values 
(N'Phòng Thường','20','500.000',N'Dép',N'Vòi Sen',N'Bồn Tắm',N'Máy Sấy Tóc',N'Nhìn Ra Biến',N'Núi',N'Minibar',N'Điện Thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Không Hút Thuốc',N'Có nơi hút thuốc',null,'2.png','2.png',N'Còn Trống',4)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HutThuoc2, UuDai, HinhAnh1, HinhAnh2, TrangThai, IDKhachSan) values 
(N'Phòng Thường','20','500.000',N'Dép',N'Vòi Sen',N'Bồn Tắm',N'Máy Sấy Tóc',N'Nhìn Ra Biến',N'Núi',N'Minibar',N'Điện Thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Không Hút Thuốc',N'Có nơi hút thuốc',null,'2.png','2.png',N'Còn Trống',4)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HutThuoc2, UuDai, HinhAnh1, HinhAnh2, TrangThai, IDKhachSan) values
(N'Phòng Thường','20','500.000',N'Dép',N'Vòi Sen',N'Bồn Tắm',N'Máy Sấy Tóc',N'Nhìn Ra Biến',N'Núi',N'Minibar',N'Điện Thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Không Hút Thuốc',N'Có nơi hút thuốc',null,'2.png','2.png',N'Còn Trống',5)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HutThuoc2, UuDai, HinhAnh1, HinhAnh2, TrangThai, IDKhachSan) values 
(N'Phòng Thường','20','500.000',N'Dép',N'Vòi Sen',N'Bồn Tắm',N'Máy Sấy Tóc',N'Nhìn Ra Biến',N'Núi',N'Minibar',N'Điện Thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Không Hút Thuốc',N'Có nơi hút thuốc',null,'2.png','2.png',N'Còn Trống',5)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HutThuoc2, UuDai, HinhAnh1, HinhAnh2, TrangThai, IDKhachSan) values 
(N'Phòng Thường','20','500.000',N'Dép',N'Vòi Sen',N'Bồn Tắm',N'Máy Sấy Tóc',N'Nhìn Ra Biến',N'Núi',N'Minibar',N'Điện Thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Không Hút Thuốc',N'Có nơi hút thuốc',null,'2.png','2.png',N'Còn Trống',6)
insert into ThongTinPhongCuaKhachSan (TenPhong, KichThuocPhong, GiaPhong, TienNghiPhongTam1, TienNghiPhongTam2, TienNghiPhongTam3, TienNghiPhongTam4, HuongTamNhin1, HuongTamNhin2, TienNghiPhong1, TienNghiPhong2, TienNghiPhong3, TienNghiPhong4, TienNghiPhong5, TienNghiPhong6, HutThuoc1, HutThuoc2, UuDai, HinhAnh1, HinhAnh2, TrangThai, IDKhachSan) values 
(N'Phòng Thường','20','500.000',N'Dép',N'Vòi Sen',N'Bồn Tắm',N'Máy Sấy Tóc',N'Nhìn Ra Biến',N'Núi',N'Minibar',N'Điện Thoại',N'TV',N'Bàn',N'Ghế',N'Két',N'Không Hút Thuốc',N'Có nơi hút thuốc',null,'2.png','2.png',N'Còn Trống',6)


CREATE TABLE DanhGia
(
	TraiNghiem nvarchar(max),
	DiemDanhGia nvarchar(max),
	DanhGiaNguoiDung nvarchar(max),
	IDNguoiDanhGia INT Foreign key References TaiKhoan(IDNguoiDung),
	IDKhachSan INT Foreign key References ThongTinKhachSan(IDKhachSan) 
);
SELECT *FROM DanhGia
DROP TABLE DanhGia

insert into DanhGia values 
(N'Tuyệt Hảo',N'9+',N'Rất tuyệt vời, 10 điểm',2,1)
insert into DanhGia values 
(N'Tuyệt Hảo',N'9+',N'Rất tuyệt vời, 10 điểm',2,2)
insert into DanhGia values 
(N'Tuyệt Hảo',N'9+',N'Rất tuyệt vời, 10 điểm',2,3)
insert into DanhGia values 
(N'Tuyệt Hảo',N'9+',N'Rất tuyệt vời, 10 điểm',2,4)
insert into DanhGia values 
(N'Tuyệt Hảo',N'9+',N'Rất tuyệt vời, 10 điểm',2,5)
insert into DanhGia values 
(N'Tuyệt Hảo',N'9+',N'Rất tuyệt vời, 10 điểm',2,6)


CREATE TABLE ThongTinKhachHang
(
TenKhachHang nvarchar(max),
	SDT nvarchar(max),
	CCCD nvarchar(max),
	Mail nvarchar(max),
	NgayNhanPhong datetime,
	NgayTraPhong datetime,
	IDPhong INT Foreign key References ThongTinPhongCuaKhachSan(IDPhong)
);
SELECT *FROM ThongTinKhachHang
DROP TABLE ThongTinKhachHang

insert into ThongTinKhachHang values
(N'Nguyễn Văn A', '0123456789','99999999','A@gmail.com','2024-2-25','2024-2-27',1)
insert into ThongTinKhachHang values
(N'Nguyễn Văn B', '0123456789','99999999','A@gmail.com','2024-2-25','2024-2-27',3)
insert into ThongTinKhachHang values
(N'Nguyễn Văn C', '0123456789','99999999','A@gmail.com','2024-2-25','2024-2-27',5)