-- CREATE DATABASE IF NOT EXISTS DoAnPTTK;
USE byurnw82eioyoixoulvr;

SET foreign_key_checks = 0;
-- Drop tables only if they exist;
DROP TABLE IF EXISTS DoanhNghiep;
DROP TABLE IF EXISTS UngVien;
DROP TABLE IF EXISTS NhanVien;
DROP TABLE IF EXISTS PhieuDangKyThanhVienCuaUngVien;
DROP TABLE IF EXISTS PhieuDKUngTuyen;
DROP TABLE IF EXISTS PhieuDangKyThongTinThanhVien;
DROP TABLE IF EXISTS PhieuDangKyQuangCao;
DROP TABLE IF EXISTS HopDongTuyenDung;
DROP TABLE IF EXISTS HoaDon;
DROP TABLE IF EXISTS HoaDonTheoDot;
DROP TABLE IF EXISTS HinhThucThanhToan;
DROP TABLE IF EXISTS PhieuThongTinThanhToan;
DROP TABLE IF EXISTS TieuChiDoanhNghiep;
DROP TABLE IF EXISTS UuDai;
DROP TABLE IF EXISTS DoanhNghiepTiemNang;
DROP TABLE IF EXISTS DoanhNghiepCanGiaHan;
DROP TABLE IF EXISTS HinhThucDangTuyen;

CREATE TABLE HoSoUngVien (
    MaHoSo int AUTO_INCREMENT PRIMARY KEY,
    MaDKUT INT,
    NgayLapHoSo date, 
    TenHoSo VARCHAR(255),
    LoaiHoSo VARCHAR(255)
);

CREATE TABLE PhieuDangTuyen (
    MaPTTDT INT AUTO_INCREMENT PRIMARY KEY,
    MaSoThue varchar(13),
    ViTriUngTuyen NVARCHAR(100),
    SoLuongTuyen INT,
    MaTieuChi int,
    NgayDK DATE,
    ThoiGianDangTuyen int,
    TinhTrangHopLe nvarchar(15)
);

CREATE TABLE DoanhNghiep (
    MaSoThue varchar(13) PRIMARY KEY,
    TenCongTy nvarchar(50),
    DiaChi NVARCHAR(255),
    Email varchar(50),
    LaDNTN int,
    LaDNTNLon int
);
ALTER TABLE DoanhNghiep
MODIFY COLUMN TenCongTy NVARCHAR(50) NOT NULL,
MODIFY COLUMN DiaChi NVARCHAR(255) NOT NULL,
MODIFY COLUMN Email VARCHAR(50) NOT NULL;

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

ALTER TABLE NhanVien
MODIFY COLUMN HoTen NVARCHAR(50) NOT NULL,
MODIFY COLUMN passwordNV VARCHAR(20) NOT NULL,
MODIFY COLUMN roleNV NVARCHAR(20) NOT NULL;
ALTER TABLE NhanVien
ADD CONSTRAINT chk_roleNV_ValidValues CHECK (roleNV IN ('Giam Doc', 'Nhan Vien'));


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
    tinhTrangXuLy nvarchar(10),
    TinhTrangXetDuyet nvarchar(10),
    TinhTrangHoSo nvarchar(10)
);

-- drop TABLE PhieuDKUngTuyen;
-- ALTER TABLE HoSoUngVien DROP FOREIGN KEY FK_HoSoUngVien_PhieuDKUngTuyen;

CREATE TABLE PhieuDangKyThongTinThanhVien (
    MaPhieuDK INT AUTO_INCREMENT PRIMARY KEY,
    TenNguoiDaiDien nvarchar(50),
    NgayDK date,
    MaDN varchar(13)
);

CREATE TABLE PhieuDangKyQuangCao (
    MaPDKQC INT AUTO_INCREMENT PRIMARY KEY,
    MaHTDT int,
    MaPTTDT int, 
    ThoiGianDangTuyen datetime
);

CREATE TABLE HopDongTuyenDung (
    MaHDTD INT AUTO_INCREMENT PRIMARY KEY,
    MaDN varchar(13),
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

select * from HoaDon;

CREATE TABLE HinhThucThanhToan (
    MaHTTT INT AUTO_INCREMENT PRIMARY KEY,
    TenHTTT varchar(50)
);
ALTER TABLE HinhThucThanhToan
MODIFY COLUMN TenHTTT VARCHAR(50) NOT NULL;

CREATE TABLE PhieuThongTinThanhToan (
    MaPhieuTTTT INT AUTO_INCREMENT PRIMARY KEY,
    TongSoTien int,
    TinhTrangThanhToan varchar(10),
    MaPTTDT int
);

ALTER TABLE PhieuThongTinThanhToan
MODIFY COLUMN TongSoTien INT NOT NULL,
MODIFY COLUMN TinhTrangThanhToan VARCHAR(10) NOT NULL;
ALTER TABLE PhieuThongTinThanhToan
ADD CONSTRAINT chk_TinhTrangThanhToan_ValidValues CHECK (TinhTrangThanhToan IN ('Chua thanh toan', 'Da thanh toan'));


CREATE TABLE TieuChiDoanhNghiep (
    MaTieuChi INT AUTO_INCREMENT PRIMARY KEY,
    SoNamKN int,
    BacHoc varchar(50),
    GPA int
);

ALTER TABLE TieuChiDoanhNghiep
MODIFY COLUMN SoNamKN INT NOT NULL,
MODIFY COLUMN BacHoc VARCHAR(50) NOT NULL,
MODIFY COLUMN GPA INT NOT NULL;
ALTER TABLE TieuChiDoanhNghiep
ADD CONSTRAINT chk_SoNamKN_NonNegative CHECK (SoNamKN >= 0),
ADD CONSTRAINT chk_GPA_NonNegative CHECK (GPA >= 0);

CREATE TABLE UuDai (
    MaUuDai INT AUTO_INCREMENT PRIMARY KEY,
    ThongTinUuDai varchar(255)
);
ALTER TABLE UuDai
MODIFY COLUMN ThongTinUuDai VARCHAR(255) NOT NULL;

CREATE TABLE DoanhNghiepCanGiaHan (
    MaDN varchar(13) primary key,
    CoLaDNTiemNang nvarchar(10),
    CoLaDNTiemNangLon nvarchar(10),
    MaUuDai int
);

CREATE TABLE HinhThucDangTuyen (	
    MaHTDT int AUTO_INCREMENT PRIMARY KEY,
    TenHTDT varchar(255), 
    DonGia int
);
ALTER TABLE HinhThucDangTuyen
MODIFY COLUMN TenHTDT VARCHAR(255) NOT NULL,
MODIFY COLUMN DonGia INT NOT NULL;
ALTER TABLE HinhThucDangTuyen
ADD CONSTRAINT chk_DonGia_NonNegative CHECK (DonGia >= 0);

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
ALTER TABLE PhieuDangTuyen
ADD CONSTRAINT fk_PhieuDangTuyen_MaSoThue
FOREIGN KEY (MaSoThue) REFERENCES DoanhNghiep(MaSoThue);

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

ALTER TABLE DoanhNghiepCanGiaHan
ADD CONSTRAINT fk_DoanhNghiepCanGiaHan_DoanhNghiep
FOREIGN KEY (MaDN) REFERENCES DoanhNghiep(MaSoThue);

-- Adding foreign keys for table 'UuDai'
ALTER TABLE DoanhNghiepCanGiaHan
ADD CONSTRAINT fk_DoanhNghiepCanGiaHan_UuDai
FOREIGN KEY (MaUuDai) REFERENCES UuDai(MaUuDai);

-- RBTV
ALTER TABLE PhieuDangTuyen
MODIFY COLUMN MaSoThue varchar(13) NOT NULL,
MODIFY COLUMN ViTriUngTuyen NVARCHAR(100) NOT NULL,
MODIFY COLUMN SoLuongTuyen INT NOT NULL,
MODIFY COLUMN MaTieuChi INT NOT NULL;
-- MODIFY COLUMN NgayDK DATE NOT NULL;

ALTER TABLE PhieuDangTuyen
ADD CONSTRAINT chk_SoLuongTuyen CHECK (SoLuongTuyen > 0),
ADD CONSTRAINT chk_ThoiGianDangTuyen CHECK (ThoiGianDangTuyen > 0),
ADD CONSTRAINT chk_TinhTrangHopLe CHECK (TinhTrangHopLe IN ('Da het han', 'Hop le', 'Khong hop le') OR TinhTrangHopLe IS NULL);

-- INSERT INTO PhieuDangTuyen(MaSoThue, ViTriUngTuyen, SoLuongTuyen, MaTieuChi, NgayDK, ThoiGianDangTuyen, TinhTrangHopLe)
-- VALUES
--     (123456789, 'Backend engineer', 10, 1, '2024-02-23', 10, null);

ALTER TABLE UngVien
MODIFY COLUMN HoTen NVARCHAR(50) NOT NULL,
MODIFY COLUMN NgaySinh DATE NOT NULL,
MODIFY COLUMN SDT CHAR(10) NOT NULL;

ALTER TABLE UngVien
ADD CONSTRAINT chk_SDT_LenghAndNumeric CHECK (LENGTH(SDT) = 10 AND SDT REGEXP '^[0-9]+$');

ALTER TABLE PhieuDKUngTuyen
MODIFY COLUMN MaPTTDT INT NOT NULL,
MODIFY COLUMN MaUV INT NOT NULL,
MODIFY COLUMN NgayLapPhieu DATE NOT NULL;

ALTER TABLE PhieuDKUngTuyen
ADD CONSTRAINT chk_TinhTrangXuLy_ValidValues CHECK (tinhTrangXuLy IN ('Da xu ly') OR tinhTrangXuLy IS NULL),
ADD CONSTRAINT chk_TinhTrangXetDuyet_ValidValues CHECK (TinhTrangXetDuyet IN ('Da duyet') OR TinhTrangXetDuyet IS NULL),
ADD CONSTRAINT chk_TinhTrangHoSo_ValidValues CHECK (TinhTrangHoSo IN ('dat', 'khong dat') OR TinhTrangHoSo IS NULL);






-- INSERT INTO DoanhNghiep
-- VALUES ('VNG', '7 district, HCM', 'vng@gmail.com');
-- INSERT INTO DoanhNghiep
-- VALUES ('FPT', '9 district, HCM', 'fpt@gmail.com');
-- INSERT INTO DoanhNghiep
-- VALUES ('MGW', '9 district, HCM', 'mgw@gmail.com');
-- INSERT INTO DoanhNghiep
-- VALUES ('OPSWAT', '3 district, HCM', 'opswat@gmail.com');
-- INSERT INTO DoanhNghiep
-- VALUES ('ANDUIN', '2 district, HCM', 'anduin@gmail.com');
-- INSERT INTO DoanhNghiep
-- VALUES ('TECOVN', '3 district, HCM', 'tecovn@gmail.com');
-- INSERT INTO DoanhNghiep
-- VALUES ('BOSCH', 'TanBinh district, HCM', 'bosch@gmail.com');
-- INSERT INTO DoanhNghiep
-- VALUES ('ELCA', 'BinhThanh district, HCM', 'elcs@gmail.com');
-- INSERT INTO DoanhNghiep
-- VALUES ('KMS', 'TanBinh district, HCM', 'kms@gmail.com');
-- INSERT INTO DoanhNghiep
-- VALUES ('MGM', '7 district, HCM', 'mgm@gmail.com');
-- INSERT INTO DoanhNghiep
-- VALUES ('FOSSIL', '9 district, HCM', 'fossil@gmail.com');
-- INSERT INTO DoanhNghiep
-- VALUES ('AXON', '9 district, HCM', 'axon@gmail.com');
-- INSERT INTO DoanhNghiep
-- VALUES ('Hoa Phat', '3 district, HCM', 'hoaphat@gmail.com');
-- INSERT INTO DoanhNghiep
-- VALUES ('Viettin Bank', '2 district, HCM', 'viettinbank@gmail.com');
-- INSERT INTO DoanhNghiep
-- VALUES ('Vietcom Bank', '3 district, HCM', 'vietcombank@gmail.com');
-- INSERT INTO DoanhNghiep
-- VALUES ('MBB', 'TanBinh district, HCM', 'mbb@gmail.com');
-- INSERT INTO DoanhNghiep
-- VALUES ('BIDV', 'BinhThanh district, HCM', 'bidv@gmail.com');
-- INSERT INTO DoanhNghiep
-- VALUES ('OCB', 'TanBinh district, HCM', 'ocb@gmail.com');


-- INSERT INTO HinhThucThanhToan
-- Values ('Tien mat');
-- INSERT INTO HinhThucThanhToan
-- Values ('The');
-- INSERT INTO HinhThucThanhToan
-- Values ('Momo');

-- INSERT INTO NhanVien
-- Values ('Phong', '123', 'Nhan vien');
-- INSERT INTO NhanVien
-- Values ('Tri', '123', 'Nhan vien');
-- INSERT INTO NhanVien
-- Values ('Thao', '123', 'Nhan vien');
-- INSERT INTO NhanVien
-- Values ('Thanh', '123', 'Nhan vien');
-- INSERT INTO NhanVien
-- Values ('Hoang', '123', 'Nhan vien');
-- INSERT INTO NhanVien
-- Values ('Hung', '123', 'Nhan vien');
-- INSERT INTO NhanVien
-- Values ('Hoa', '123', 'Nhan vien');
-- INSERT INTO NhanVien
-- Values ('Hieu', '123', 'Nhan vien');
-- INSERT INTO NhanVien
-- Values ('Duy', '123', 'Nhan vien');
-- INSERT INTO NhanVien
-- Values ('Nhi', '123', 'Nhan vien');
-- INSERT INTO NhanVien
-- Values ('Trung', '123', 'Nhan vien');
-- INSERT INTO NhanVien
-- Values ('Tuan', '123', 'Nhan vien');
-- INSERT INTO NhanVien
-- Values ('Tien', '123', 'Ban giam doc');
-- INSERT INTO NhanVien
-- Values ('Dat', '123', 'Ban giam doc');
-- INSERT INTO NhanVien
-- Values ('Dung', '123', 'Ban giam doc');

-- INSERT INTO NhanVien
-- Values ('Phong', '123', 'Nhan vien');
-- INSERT INTO NhanVien
-- Values ('Tri', '123', 'Nhan vien');
-- INSERT INTO NhanVien
-- Values ('Thao', '123', 'Nhan vien');
-- INSERT INTO NhanVien
-- Values ('Thanh', '123', 'Nhan vien');
-- INSERT INTO NhanVien
-- Values ('Hoang', '123', 'Nhan vien');
-- INSERT INTO NhanVien
-- Values ('Hung', '123', 'Nhan vien');
-- INSERT INTO NhanVien
-- Values ('Hoa', '123', 'Nhan vien');
-- INSERT INTO NhanVien
-- Values ('Hieu', '123', 'Nhan vien');
-- INSERT INTO NhanVien
-- Values ('Duy', '123', 'Nhan vien');
-- INSERT INTO NhanVien
-- Values ('Nhi', '123', 'Nhan vien');
-- INSERT INTO NhanVien
-- Values ('Trung', '123', 'Nhan vien');
-- INSERT INTO NhanVien
-- Values ('Tuan', '123', 'Nhan vien');
-- INSERT INTO NhanVien
-- Values ('Tien', '123', 'Ban giam doc');
-- INSERT INTO NhanVien
-- Values ('Dat', '123', 'Ban giam doc');
-- INSERT INTO NhanVien
-- Values ('Dung', '123', 'Ban giam doc');

-- INSERT INTO UngVien
-- Values ('Phong', '05-04-2003', '0585041111');
-- INSERT INTO UngVien
-- Values ('Tri', '05-04-2001', '0585041111');
-- INSERT INTO UngVien
-- Values ('Thao', '05-04-2000', '0585041111');
-- INSERT INTO UngVien
-- Values ('Thanh', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Hoang', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Hung', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Hoa', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Hieu', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Duy', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Nhi', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Trung', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Tuan', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Phong', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Tri', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Thao', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Thanh', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Hoang', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Hung', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Hoa', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Hieu', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Phong', '05-04-2003', '0585041111');
-- INSERT INTO UngVien
-- Values ('Tri', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Thao', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Thanh', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Hoang', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Hung', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Hoa', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Hieu', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Duy', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Nhi', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Trung', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Tuan', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Phong', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Tri', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Thao', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Thanh', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Hoang', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Hung', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Hoa', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Thao', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Yen', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('An', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Duc', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Hien', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Phong', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Tri', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Thao', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Thanh', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Hoang', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Hung', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Hoa', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Thao', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Yen', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('An', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Duc', '05-04-1998', '0585041111');
-- INSERT INTO UngVien
-- Values ('Hien', '05-04-1998', '0585041111');


