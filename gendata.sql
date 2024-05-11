USE byurnw82eioyoixoulvr;
INSERT INTO DoanhNghiep(MaSoThue, TenCongTy, DiaChi, Email, LaDNTN, LaDNTNLon)
VALUES
    (123456789, 'ABC Company', '123 Main St, City', 'abc@example.com', 1, 1),
    (987654321, 'XYZ Corporation', '456 Elm St, Town', 'xyz@example.com', 1, null),
    (246810121, 'LMN Industries', '789 Oak St, Village', 'lmn@example.com', null, null),
    (135791113, 'PQR Ltd', '1011 Pine St, Suburb', 'pqr@example.com', null, null),
    (567891011, 'DEF Enterprises', '1314 Maple St, District', 'def@example.com', 1, null),
    (101214161, 'GHI Co.', '1618 Cedar St, County', 'ghi@example.com', 1, 1),
    (182430364, 'JKL Ltd.', '2022 Birch St, Hamlet', 'jkl@example.com', 1, 1),
    (2224262, 'UVW Corporation', '2426 Fir St, Township', 'uvw@zexample.com', null, null),
    (32343638, 'RST Industries', '2830 Willow St, Borough', 'rst@example.com', 1, null),
    (4445464, 'OPQ Enterprises', '3246 Ash St, Quarter', 'opq@example.com', null, null);
SELECT * FROM DoanhNghiep;
-- PhieuDangKyThongTinThanhVien

INSERT INTO PhieuDangKyThongTinThanhVien(TenNguoiDaiDien, NgayDK, MaDN)
VALUES
	('Nguyen Van A', '2023-04-30', 123456789),
	('Nguyen Van B', '2023-05-23', 987654321),
	('Nguyen Van C', '2023-05-30', 246810121),
	('Nguyen Van D', '2023-05-30', 135791113),
	('Nguyen Van E', '2023-05-30', 567891011),
	('Nguyen Van F', '2023-05-30', 101214161),
	('Nguyen Van T', '2023-05-30', 182430364),
	('Nguyen Van R', '2023-05-30', 2224262),
	('Nguyen Van Q', '2023-05-30', 32343638),
	('Nguyen Van U', '2023-05-30', 4445464);

-- HopDongTuyenDung

INSERT INTO HopDongTuyenDung(MaDN, NgayKyHopDong, NgayHetHanHopDong)
VALUES
    (123456789, '2023-04-30', '2025-04-30'),
    (987654321, '2023-05-02', '2025-05-02'),
    (246810121, '2023-05-30', '2025-05-30'),
    (135791113, '2023-05-30', '2025-05-30'),  
    (567891011, '2023-05-30', '2025-05-30'),  
    (101214161, '2023-05-30', '2025-05-30'),  
    (182430364, '2023-05-30', '2025-05-30'),  
    (2224262, '2023-05-30', '2025-05-30'),   
    (32343638, '2023-05-30', '2025-05-30'),  
    (4445464, '2023-05-30', '2025-05-30');

-- NhanVien

INSERT INTO NhanVien(HoTen, passwordNV, roleNV)
VALUES
	('Quach Khanh Duy', '123', 'Giam Doc'),
    ('Quach Thanh Danh', '123', 'Nhan Vien'),
    ('Do Thanh Son', '123', 'Nhan Vien'),
    ('Nguyen Thanh Son', '123', 'Nhan Vien'),
    ('Nguyen Thi An', '123', 'Nhan Vien'),
    ('Tran Thi Thanh', '123', 'Nhan Vien'),
    ('Nguen Thanh Binh', '123', 'Nhan Vien'),
    ('Nguyen Thanh Sang', '123', 'Nhan Vien'),
    ('Tran Thi Phi', '123', 'Nhan Vien'),
    ('Tu Phuoc Toan', '123', 'Nhan Vien');
SELECT * FROM NhanVien;

-- HinhThucThanhToan

INSERT INTO HinhThucThanhToan(TenHTTT)
VALUES
	('Tien mat'),
    ('Bank');

-- HinhThucDangTuyen

INSERT INTO HinhThucDangTuyen(TenHTDT, DonGia)
VALUES
	('Dang Tuyen Tren Bao Giay', 3000),
    ('Dang Banner Quang Cao', 3000),
	('Dang Tren Cac Trang Mang', 3000);
    
-- Tieuchidoanhnghiep
INSERT INTO TieuChiDoanhNghiep (SoNamKN, BacHoc, GPA)
VALUES
    (5, "Dai hoc", 3),
    (3, "Dai hoc", 2),
    (2, "Cao dang", 3),
    (4, "Cao Dang", 2);
select * from TieuChiDoanhNghiep;
-- PhieuDangTuyen

INSERT INTO PhieuDangTuyen(MaSoThue, ViTriUngTuyen, SoLuongTuyen, MaTieuChi, NgayDK, ThoiGianDangTuyen, TinhTrangHopLe)
VALUES
    (123456789, 'Backend engineer', 10, 1, '2024-02-23', 10, null),
    (123456789, 'Frontend engineer', 20, 1, '2024-02-23', 20, null),
    (123456789, 'Database administrator', 10, 3, '2024-02-23', 3, 'Da het han'),
    (123456789, 'QA engineer', 15, 2, '2024-02-23', 15, null),
    (123456789, 'Software developer', 12, 1, '2024-02-23', 16, null),
    (123456789, 'UI/UX designer', 8, 4, '2024-02-23', 17, null),
    (987654321, 'Backend engineer', 10, 2, '2024-02-23', 18, 'Da het han'),
    (987654321, 'Frontend engineer', 20, 3, '2024-02-23', 30, null),
    (987654321, 'Frontend engineer', 20, 3, '2024-02-23', 10, null),
    (987654321, 'Database administrator', 10, 1, '2024-02-23', 8, 'Da het han'),
    (135791113, 'QA engineer', 15, 2, '2024-02-23', 7, null),
    (135791113, 'Software developer', 12, 3, '2024-02-23', 10, null),
    (135791113, 'UI/UX designer', 8, 2, '2024-02-23', 13, null);
-- select count(*) as cnt from PhieuDangKyQuangCao where MaPTTDT = 22;
-- select * from PhieuDangTuyen;
-- select * from PhieuDangKyQuangCao;
-- Select count(*) as cnt from PhieuDangKyQuangCao where MaPTTDT =1;

-- PHIEUDKQUANGCAO
INSERT INTO PhieuDangKyQuangCao (MaHTDT, MaPTTDT,  ThoiGianDangTuyen)
VALUES 
    (1, 1, '2024-02-25'),
    (1, 2, '2024-02-25'),
    (1, 3, '2024-02-25'),
    (1, 4, '2024-02-25'),
    (1, 5, '2024-02-25'),
    (3, 6, '2024-02-25'),
    (3, 7, '2024-02-25'),
    (2, 8, '2024-02-25'),
    (3, 9, '2024-02-25'),
    (1, 10, '2024-02-25');
    
    
select PhieuDangKyQuangCao;
-- UNG VIEN
INSERT INTO UngVien (HoTen, NgaySinh, SDT)
VALUES
    ('Nguyen Van An', '1990-01-01', '0123456789'),
    ('Tran Thi Ba', '1995-02-02', '0987654321'),
    ('Le Hoang Can', '1988-03-03', '0365987412'),
    ('Pham Thanh Dinh', '1992-04-04', '0891234567'),
    ('Vu Thi En', '1997-05-05', '0765432198'),
    ('Dinh Van Kha', '1985-06-06', '0654987321'),
    ('Hoang Anh Giang', '1993-07-07', '0978563412'),
    ('Nguyen Thi Linh', '1994-08-08', '0542136879'),
    ('Tran Van Ung', '1996-09-09', '0321654987'),
    ('Le Thi Toan', '1987-10-10', '0852369741');
    
-- PHIEUDKUNGTUYEN
INSERT PhieuDKUngTuyen (MaPTTDT, MaUV, NgayLapPhieu, TinhTrangXetDuyet, TinhTrangHoSo)
VALUES  
    (1, 1, '2024-02-25', 'Chua duyet', 'Dat'),
    (2, 2, '2024-02-25', 'Chua duyet', 'Khong dat'),
    (3, 3, '2024-02-25', 'Chua duyet', null),
    (1, 4, '2024-02-25', 'Chua duyet', 'Chua dat'),
    (1, 5, '2024-02-25', 'Chua duyet', 'Dat'),
    (4, 6, '2024-02-25', 'Chua duyet', null),
    (5, 7, '2024-02-25', 'Chua duyet', 'Dat'),
    (6, 8, '2024-02-25', 'Chua duyet', null),
    (7, 9, '2024-02-25', 'Chua duyet', 'Chua dat'),
    (2, 10, '2024-02-25', 'Chua duyet', 'Chua dat');
    
-- HOSOUNGVIEN
INSERT INTO HoSoUngVien (MaDKUT, NgayLapHoSo, TenHoSo, LoaiHoSo)
VALUES
    (1, '2024-02-27', 'Ho so 1', 'Loai 1'),
    (2, '2024-02-27', 'Ho so 2', 'Loai 2'),
    (3, '2024-02-27', 'Ho so 3', 'Loai 1'),
    (4, '2024-02-28', 'Ho so 4', 'Loai 2'),
    (5, '2024-03-01', 'Ho so 5', 'Loai 1'),
    (6, '2024-03-02', 'Ho so 6', 'Loai 2'),
    (7, '2024-03-03', 'Ho so 7', 'Loai 1'),
    (8, '2024-03-02', 'Ho so 8', 'Loai 2'),
    (9, '2024-03-01', 'Ho so 9', 'Loai 1'),
    (10, '2024-02-28', 'Ho so 10', 'Loai 2');
    
