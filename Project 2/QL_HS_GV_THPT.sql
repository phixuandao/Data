CREATE TABLE HocSinh(
	ID_Hs CHAR(10) NOT NULL,
	HoTen NVARCHAR(50) NOT NULL,
	GT CHAR(3),
	NgaySinh datetime,
	ID_Lop CHAR(10),
	ID_MonHoc CHAR(10)
)

CREATE TABLE GiaoVien(
	ID_Gv CHAR(10) NOT NULL,
	HoTen NVARCHAR(50) NOT NULL,
	GT CHAR(3),
	NgaySinh datetime,
	ChucVu NVARCHAR(50),
	ID_MonHoc CHAR(10),
	ID_Lop CHAR(10)
)

CREATE TABLE MonHoc(
	ID_MonHoc CHAR(10) NOT NULL,
	Ten_MonHoc NVARCHAR(50)
)

CREATE TABLE LopHoc(
	ID_Lop CHAR(10) NOT NULL,
	Ten_Lop NVARCHAR(30),
	ID_Gv char(10)--giao vien chu nhiem
)

alter table GiaoVien add constraint GV_ID_PK primary key(ID_Gv)
alter table HocSinh add constraint HS_ID_PK primary key(ID_Hs)
alter table LopHoc add constraint LH_ID_PK primary key(ID_Lop)
alter table MonHoc add constraint MH_ID_PK primary key(ID_MonHoc)

insert into HocSinh(ID_Hs,HoTen,GT,NgaySinh,ID_Lop,ID_MonHoc)
values
('HS001',N'Lê Công Tuấn Anh','Nam',01/01/1994,'LOP01','MH01'),
('HS002',N'Nguyễn Chí Công','Nam',01/01/1994,'LOP01','MH01'),
('HS003',N'Nguyễn Đức Cảnh','Nam',01/01/1994,'LOP01','MH01'),
('HS004',N'Nguyễn Anh Dũng','Nam',01/01/1994,'LOP01','MH01'),
('HS005',N'Phí Xuân Đạo','Nam',01/01/1994,'LOP02','MH01'),
('HS006',N'Hoàng Đình Đạt','Nam',01/01/1994,'LOP02','MH01'),
('HS007',N'Khương Duy Hoàng','Nam',01/01/1994,'LOP02','MH01'),
('HS008',N'Nguyễn Mạnh Hải','Nam',01/01/1994,'LOP02','MH01'),

('HS009',N'Lưu Văn Lâm','Nam',01/01/1994,'LOP03','MH02'),
('HS010',N'Lương Văn Luận','Nam',01/01/1994,'LOP03','MH02'),
('HS011',N'Võ Khương Lĩnh','Nam',01/01/1994,'LOP03','MH02'),
('HS012',N'Lê Tuấn Minh','Nam',01/01/1994,'LOP03','MH02'),

('HS013',N'Phạm Đình Minh','Nam',01/01/1994,'LOP04','MH03'),
('HS014',N'Ngô Hồng Quân','Nam',01/01/1994,'LOP04','MH03'),
('HS015',N'Đinh Ngọc San','Nam',01/01/1994,'LOP04','MH03'),
('HS016',N'Nguyễn Quang Trường','Nam',01/01/1994,'LOP04','MH03')

insert into GiaoVien(ID_Gv,HoTen,GT,NgaySinh,ChucVu,ID_MonHoc,ID_Lop)
values
('GV01',N'Đào Thanh Tĩnh','Nam',null,null,'MH01','LOP01'),
('GV02',N'Ngô Thành Long','Nam',null,null,'MH01','LOP02'),
('GV04',N'Phan Nguyên Hải','Nam',null,null,'MH03','LOP04'),
('GV05',N'Phạm Hoàng Uyên','Nữ',null,null,'MH02','LOP03')

insert into MonHoc(ID_MonHoc,Ten_MonHoc)
values
('MH01','Toán'),
('MH02','Văn'),
('MH03','Hóa')

insert into LopHoc(ID_Lop,Ten_Lop,ID_Gv)
values
('LOP01','10A1','GV01'),
('LOP02','11A1','GV03'),
('LOP03','12A1','GV04'),
('LOP04','9A1','GV05')

alter table HocSinh add constraint fk_hocsinh_lophoc foreign key (ID_Lop) references LopHoc(ID_Lop)
alter table GiaoVien add constraint fk_giaovien_monhoc foreign key(ID_MonHoc) references MonHoc(ID_MonHoc)
alter table HocSinh add constraint fk_hocsinh_monhoc foreign key(ID_MonHoc) references MonHoc(ID_MonHoc)
alter table GiaoVien add constraint fk_giaovien_lophoc foreign key(ID_Lop) references LopHoc(ID_Lop)