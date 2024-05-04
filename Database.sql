-- CREATE DATABASE IF NOT EXISTS DoAnPTTK;
USE byurnw82eioyoixoulvr;

-- DROP TABLE HoSo;
-- DROP TABLE PhieuDangTuyen;
-- DROP TABLE DoanhNghiep;
-- DROP TABLE UngVien;
-- DROP TABLE NhanVien;
-- DROP TABLE PhieuDangKyThanhVienCuaUngVien;
-- DROP TABLE PhieuDKUngTuyen;
-- DROP TABLE PhieuDangKyThongTinThanhVien;
-- DROP TABLE PhieuDangKyQuangCao;
-- DROP TABLE HopDongTuyenDung;
-- DROP TABLE HoaDon;
-- DROP TABLE HoaDonTheoDot;
-- DROP TABLE HinhThucThanhToan;
-- DROP TABLE PhieuThongTinThanhToan;
-- DROP TABLE TieuChiDoanhNghiep;
-- DROP TABLE UuDai;
-- DROP TABLE DoanhNghiepTiemNang;
-- DROP TABLE HinhThucDangTuyen;	

CREATE TABLE HoSoUngVien (
    MaHoSo INT AUTO_INCREMENT PRIMARY KEY,
    MaDKUT INT,
    NgayLapHoSo date, 
    TenHoSo VARCHAR(255),
    LoaiHoSo VARCHAR(255)
);

CREATE TABLE PhieuDangTuyen (
    MaPTTDT INT AUTO_INCREMENT PRIMARY KEY,
    MaSoThue INT,
    ViTriUngTuyen NVARCHAR(100),
    SoLuongTuyen INT,
    MaTieuChi int,
    NgayDK DATE,
    TinTrangHopLe nvarchar(10)
);

CREATE TABLE DoanhNghiep (
    MaSoThue INT AUTO_INCREMENT PRIMARY KEY,
    TenCongTy nvarchar(50),
    DiaChi NVARCHAR(255),
    Email varchar(50)
);

CREATE TABLE UngVien (
    MaUV INT AUTO_INCREMENT PRIMARY KEY,
    HoTen nvarchar(50),
    NgaySinh date,
	SDT char(10)
);

CREATE TABLE NhanVien (
    MaNhanVien INT AUTO_INCREMENT PRIMARY KEY,
    HoTen nvarchar(50),
    passwordNV varchar(20),
    roleNV nvarchar(20)
);

CREATE TABLE PhieuDangKyThanhVienCuaUngVien (
    MaPhieuDK_UV INT AUTO_INCREMENT PRIMARY KEY,
    MaUV int,
    NgayLapPhieu date
);

CREATE TABLE PhieuDKUngTuyen (
    MaDKUT INT AUTO_INCREMENT PRIMARY KEY,
    MaPTTDT int,
    MaUV int,
    NgayLapPhieu date, 
    TinhTrangXetDuyet nvarchar(10),
    TinhTrangHoSo nvarchar(10)
);

-- drop TABLE PhieuDKUngTuyen;
-- ALTER TABLE HoSoUngVien DROP FOREIGN KEY FK_HoSoUngVien_PhieuDKUngTuyen;

CREATE TABLE PhieuDangKyThongTinThanhVien (
    MaPhieuDK INT AUTO_INCREMENT PRIMARY KEY,
    TenNguoiDaiDien nvarchar(50),
    NgayDK date,
    MaDN int
);

CREATE TABLE PhieuDangKyQuangCao (
    MaPDKQC INT AUTO_INCREMENT PRIMARY KEY,
    MaHTDT int,
    MaPTTDT int, 
    ThoiGianDangTuyen datetime,
    DonGiaQC int
);

CREATE TABLE HopDongTuyenDung (
    MaHDTD INT AUTO_INCREMENT PRIMARY KEY,
    MaDN int,
    NgayKyHopDong date, 
    NgayHetHanHopDong date    
);

CREATE TABLE HoaDon (
    MaHoaDon INT AUTO_INCREMENT PRIMARY KEY,
    SoTien int,
    NgayThanhToan date,
    MaHTTT int,
    CoThanhToanTheoDot nvarchar(10),
    MaNV int, 
    MaPhieuTTTT int
);

drop table HoaDon;

CREATE TABLE HinhThucThanhToan (
    MaHTTT INT AUTO_INCREMENT PRIMARY KEY,
    TenHTTT varchar(50)
);

CREATE TABLE PhieuThongTinThanhToan (
    MaPhieuTTTT INT AUTO_INCREMENT PRIMARY KEY,
    TongSoTien int,
    TinhTrangThanhToan varchar(10),
    MaPTTDT int
);

CREATE TABLE TieuChiDoanhNghiep (
    MaTieuChi INT AUTO_INCREMENT PRIMARY KEY,
    SoNamKN int,
    BacHoc varchar(50),
    GPA int
);

CREATE TABLE UuDai (
    MaUuDai INT AUTO_INCREMENT PRIMARY KEY,
    MaDNTiemNang int,
    ThongTinUuDai varchar(255)
);

CREATE TABLE DoanhNghiepCanGiaHan (
    MaDN int PRIMARY KEY,
    CoLaDNTiemNang nvarchar(10),
    CoLaDNTiemNangLon nvarchar(10)
);

CREATE TABLE HinhThucDangTuyen (
    MaHTDT int PRIMARY KEY,
    TenHDTD varchar(255), 
    DonGia int
);


-- After all tables are created, add foreign key constraints
-- Adding foreign keys for table 'HoSoUngVien'
ALTER TABLE HoSoUngVien
ADD CONSTRAINT FK_HoSoUngVien_PhieuDKUngTuyen
FOREIGN KEY (MaDKUT) REFERENCES PhieuDKUngTuyen(MaDKUT);

-- Adding foreign keys for table 'PhieuDangKyThanhVienCuaUngVien'
ALTER TABLE PhieuDangKyThanhVienCuaUngVien
ADD CONSTRAINT FK_PhieuDK_UV_MaUngVien
FOREIGN KEY (MaUV) REFERENCES UngVien(MaUV);

-- Adding foreign keys for table 'PhieuDangKyThongTinThanhVien'
ALTER TABLE PhieuDangKyThongTinThanhVien
ADD CONSTRAINT FK_PhieuDKTTTV_DN
FOREIGN KEY (MaDN) REFERENCES DoanhNghiep(MaSoThue);

-- Adding foreign keys for table 'PhieuDKUngTuyen'
ALTER TABLE PhieuDKUngTuyen
ADD CONSTRAINT fk_PhieuDKUngTuyen_MaPTTDT
FOREIGN KEY (MaPTTDT) REFERENCES PhieuDangTuyen(MaPTTDT),
ADD CONSTRAINT fk_PhieuDKUngTuyen_MaUV
FOREIGN KEY (MaUV) REFERENCES UngVien(MaUV);

-- Adding foreign keys for table 'PhieuDangTuyen'
ALTER TABLE PhieuDangTuyen
ADD CONSTRAINT fk_PhieuDangTuyen_TieuChi
FOREIGN KEY (MaTieuChi) REFERENCES TieuChiDoanhNghiep(MaTieuChi);

-- Adding foreign keys for table 'PhieuDangKyQuangCao'
ALTER TABLE PhieuDangKyQuangCao
ADD CONSTRAINT fk_PhieuDangKyQuangCao_MaHTDT
FOREIGN KEY (MaHTDT) REFERENCES HinhThucDangTuyen(MaHTDT),
ADD CONSTRAINT fk_PhieuDangKyQuangCao_MaPTTDT
FOREIGN KEY (MaPTTDT) REFERENCES PhieuDangTuyen(MaPTTDT);

-- Adding foreign keys for table 'HopDongTuyenDung'
ALTER TABLE HopDongTuyenDung
ADD CONSTRAINT fk_HopDongTuyenDung_DoanhNghiep
FOREIGN KEY (MaDN) REFERENCES DoanhNghiep(MaSoThue);

-- Adding foreign keys for table 'HoaDon'
ALTER TABLE HoaDon
ADD CONSTRAINT fk_HoaDon_NhanVienLap
FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNhanVien),
ADD CONSTRAINT fk_HoaDon_PhieuThongTinDangtuyen
FOREIGN KEY (MaPhieuTTTT) REFERENCES PhieuThongTinThanhToan(MaPhieuTTTT),
ADD CONSTRAINT fk_HinhThucThanhToan
FOREIGN KEY (MaHTTT) REFERENCES HinhThucThanhToan(MaHTTT);

-- Adding foreign keys for table 'PhieuThongTinThanhToan'
ALTER TABLE PhieuThongTinThanhToan
ADD CONSTRAINT fk_PhieuThongTinThanhToan_PhieuDangTuyen
FOREIGN KEY (MaPTTDT) REFERENCES PhieuDangTuyen(MaPTTDT);

-- Adding foreign keys for table 'UuDai'
ALTER TABLE UuDai
ADD CONSTRAINT fk_UuDai_DoanhNghiepTiemNang
FOREIGN KEY (MaDNTiemNang) REFERENCES DoanhNghiepCanGiaHan(MaDN);

ALTER TABLE DoanhNghiepCanGiaHan
ADD CONSTRAINT fk_DoanhNghiepCanGiaHan_DoanhNghiep
FOREIGN KEY (MaDN) REFERENCES DoanhNghiep(MaSoThue);

INSERT INTO DoanhNghiep
VALUES ('VNG', '7 district, HCM', 'vng@gmail.com');
INSERT INTO DoanhNghiep
VALUES ('FPT', '9 district, HCM', 'fpt@gmail.com');
INSERT INTO DoanhNghiep
VALUES ('MGW', '9 district, HCM', 'mgw@gmail.com');
INSERT INTO DoanhNghiep
VALUES ('OPSWAT', '3 district, HCM', 'opswat@gmail.com');
INSERT INTO DoanhNghiep
VALUES ('ANDUIN', '2 district, HCM', 'anduin@gmail.com');
INSERT INTO DoanhNghiep
VALUES ('TECOVN', '3 district, HCM', 'tecovn@gmail.com');
INSERT INTO DoanhNghiep
VALUES ('BOSCH', 'TanBinh district, HCM', 'bosch@gmail.com');
INSERT INTO DoanhNghiep
VALUES ('ELCA', 'BinhThanh district, HCM', 'elcs@gmail.com');
INSERT INTO DoanhNghiep
VALUES ('KMS', 'TanBinh district, HCM', 'kms@gmail.com');
INSERT INTO DoanhNghiep
VALUES ('MGM', '7 district, HCM', 'mgm@gmail.com');
INSERT INTO DoanhNghiep
VALUES ('FOSSIL', '9 district, HCM', 'fossil@gmail.com');
INSERT INTO DoanhNghiep
VALUES ('AXON', '9 district, HCM', 'axon@gmail.com');
INSERT INTO DoanhNghiep
VALUES ('Hoa Phat', '3 district, HCM', 'hoaphat@gmail.com');
INSERT INTO DoanhNghiep
VALUES ('Viettin Bank', '2 district, HCM', 'viettinbank@gmail.com');
INSERT INTO DoanhNghiep
VALUES ('Vietcom Bank', '3 district, HCM', 'vietcombank@gmail.com');
INSERT INTO DoanhNghiep
VALUES ('MBB', 'TanBinh district, HCM', 'mbb@gmail.com');
INSERT INTO DoanhNghiep
VALUES ('BIDV', 'BinhThanh district, HCM', 'bidv@gmail.com');
INSERT INTO DoanhNghiep
VALUES ('OCB', 'TanBinh district, HCM', 'ocb@gmail.com');


INSERT INTO HinhThucThanhToan
Values ('Tien mat');
INSERT INTO HinhThucThanhToan
Values ('The');
INSERT INTO HinhThucThanhToan
Values ('Momo');

INSERT INTO NhanVien
Values ('Phong', '123', 'Nhan vien');
INSERT INTO NhanVien
Values ('Tri', '123', 'Nhan vien');
INSERT INTO NhanVien
Values ('Thao', '123', 'Nhan vien');
INSERT INTO NhanVien
Values ('Thanh', '123', 'Nhan vien');
INSERT INTO NhanVien
Values ('Hoang', '123', 'Nhan vien');
INSERT INTO NhanVien
Values ('Hung', '123', 'Nhan vien');
INSERT INTO NhanVien
Values ('Hoa', '123', 'Nhan vien');
INSERT INTO NhanVien
Values ('Hieu', '123', 'Nhan vien');
INSERT INTO NhanVien
Values ('Duy', '123', 'Nhan vien');
INSERT INTO NhanVien
Values ('Nhi', '123', 'Nhan vien');
INSERT INTO NhanVien
Values ('Trung', '123', 'Nhan vien');
INSERT INTO NhanVien
Values ('Tuan', '123', 'Nhan vien');
INSERT INTO NhanVien
Values ('Tien', '123', 'Ban giam doc');
INSERT INTO NhanVien
Values ('Dat', '123', 'Ban giam doc');
INSERT INTO NhanVien
Values ('Dung', '123', 'Ban giam doc');

INSERT INTO NhanVien
Values ('Phong', '123', 'Nhan vien');
INSERT INTO NhanVien
Values ('Tri', '123', 'Nhan vien');
INSERT INTO NhanVien
Values ('Thao', '123', 'Nhan vien');
INSERT INTO NhanVien
Values ('Thanh', '123', 'Nhan vien');
INSERT INTO NhanVien
Values ('Hoang', '123', 'Nhan vien');
INSERT INTO NhanVien
Values ('Hung', '123', 'Nhan vien');
INSERT INTO NhanVien
Values ('Hoa', '123', 'Nhan vien');
INSERT INTO NhanVien
Values ('Hieu', '123', 'Nhan vien');
INSERT INTO NhanVien
Values ('Duy', '123', 'Nhan vien');
INSERT INTO NhanVien
Values ('Nhi', '123', 'Nhan vien');
INSERT INTO NhanVien
Values ('Trung', '123', 'Nhan vien');
INSERT INTO NhanVien
Values ('Tuan', '123', 'Nhan vien');
INSERT INTO NhanVien
Values ('Tien', '123', 'Ban giam doc');
INSERT INTO NhanVien
Values ('Dat', '123', 'Ban giam doc');
INSERT INTO NhanVien
Values ('Dung', '123', 'Ban giam doc');

INSERT INTO UngVien
Values ('Phong', '05-04-2003', '0585041111');
INSERT INTO UngVien
Values ('Tri', '05-04-2001', '0585041111');
INSERT INTO UngVien
Values ('Thao', '05-04-2000', '0585041111');
INSERT INTO UngVien
Values ('Thanh', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Hoang', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Hung', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Hoa', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Hieu', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Duy', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Nhi', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Trung', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Tuan', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Phong', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Tri', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Thao', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Thanh', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Hoang', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Hung', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Hoa', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Hieu', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Phong', '05-04-2003', '0585041111');
INSERT INTO UngVien
Values ('Tri', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Thao', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Thanh', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Hoang', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Hung', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Hoa', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Hieu', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Duy', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Nhi', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Trung', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Tuan', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Phong', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Tri', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Thao', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Thanh', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Hoang', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Hung', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Hoa', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Thao', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Yen', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('An', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Duc', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Hien', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Phong', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Tri', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Thao', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Thanh', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Hoang', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Hung', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Hoa', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Thao', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Yen', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('An', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Duc', '05-04-1998', '0585041111');
INSERT INTO UngVien
Values ('Hien', '05-04-1998', '0585041111');


