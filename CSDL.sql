USE QLCSKH;
GO

-- 1. Xóa dữ liệu các bảng theo thứ tự: Bảng con trước, bảng cha sau
DELETE FROM HoaDon_ChiTiet;
DELETE FROM PhanCongChamSoc;
DELETE FROM HoaDon; 
DELETE FROM SanPham;
DELETE FROM NhanVien;
DELETE FROM KhachHang;

-- 2. Reset identity về 0
DBCC CHECKIDENT('HoaDon_ChiTiet', RESEED, 0);
DBCC CHECKIDENT('PhanCongChamSoc', RESEED, 0);
DBCC CHECKIDENT('HoaDon', RESEED, 0);
DBCC CHECKIDENT('SanPham', RESEED, 0);
DBCC CHECKIDENT('NhanVien', RESEED, 0);
DBCC CHECKIDENT('KhachHang', RESEED, 0);

-- ==========================================
-- 3. CHÈN DỮ LIỆU MẪU (50 DÒNG MỖI BẢNG)
-- ==========================================

-- BẢNG 1: NHÂN VIÊN (50 Dòng)
INSERT INTO NhanVien (HoVaTen, DienThoai, Email, TrangThai, TenDangNhap, MatKhau, QuyenHan) VALUES
(N'Trần Chốt Đơn', '0901000001', 'chotdon@congty.com', N'Đang làm việc', 'chotdon', '123456', 1),
(N'Nguyễn Kẻ Hủy Diệt KPI', '0901000002', 'huydietkpi@congty.com', N'Đang làm việc', 'huydiet', '123456', 0),
(N'Lê Thánh Sale', '0901000003', 'thanhsale@congty.com', N'Đang làm việc', 'thanhsale', '123456', 0),
(N'Phạm Chúa Tể Data', '0901000004', 'chuatedata@congty.com', N'Đang làm việc', 'chuatedata', '123456', 0),
(N'Đặng Thần Đồng Telesale', '0901000005', 'thandong@congty.com', N'Đang làm việc', 'thandong', '123456', 0),
(N'Vũ Cỗ Máy Bán Hàng', '0901000006', 'comay@congty.com', N'Đang làm việc', 'comay', '123456', 0),
(N'Hoàng Độc Cô Cầu Bại', '0901000007', 'docco@congty.com', N'Đang làm việc', 'docco', '123456', 0),
(N'Bùi Vua Cạp Data', '0901000008', 'vuacap@congty.com', N'Đang làm việc', 'vuacap', '123456', 0),
(N'Đỗ Bàn Tay Vàng', '0901000009', 'bantayvang@congty.com', N'Đang làm việc', 'bantayvang', '123456', 0),
(N'Hồ Ma Tốc Độ Gọi', '0901000010', 'matocdo@congty.com', N'Đang làm việc', 'matocdo', '123456', 0),
(N'Đoàn Sát Thủ Lạnh Lùng', '0901000011', 'satthu@congty.com', N'Đã nghỉ việc', 'satthu', '123456', 0),
(N'Ngô Bé Trực Page', '0901000012', 'trucpage@congty.com', N'Đang làm việc', 'trucpage', '123456', 0),
(N'Lý Nữ Hoàng Tư Vấn', '0901000013', 'nuhoang@congty.com', N'Đang làm việc', 'nuhoang', '123456', 0),
(N'Châu Đam Mê Gọi Điện', '0901000014', 'damme@congty.com', N'Đang làm việc', 'damme', '123456', 0),
(N'Thái Chăm Khách Như Người Yêu', '0901000015', 'chamkhach@congty.com', N'Đang làm việc', 'chamkhach', '123456', 0),
(N'Tô Vua Chốt Deal', '0901000016', 'chotdeal@congty.com', N'Đang làm việc', 'chotdeal', '123456', 0),
(N'Kiều Bà Hoàng Upsale', '0901000017', 'upsale@congty.com', N'Đang làm việc', 'upsale', '123456', 0),
(N'Tào Tháo Đuổi Số', '0901000018', 'duoiso@congty.com', N'Đang làm việc', 'duoiso', '123456', 0),
(N'Mạc Sầu Doanh Số', '0901000019', 'saudoanhso@congty.com', N'Đang làm việc', 'saudoanhso', '123456', 0),
(N'Đinh Công Đỉnh', '0901000020', 'congdinh@congty.com', N'Đã nghỉ việc', 'congdinh', '123456', 0),
-- Sinh ngẫu nhiên thêm 30 nhân viên nữa cho đủ 50
(N'Trần Văn A', '0901100001', 'nva1@congty.com', N'Đang làm việc', 'nva1', '123456', 0), (N'Nguyễn Thị B', '0901100002', 'ntb2@congty.com', N'Đang làm việc', 'ntb2', '123456', 0), (N'Lê Văn C', '0901100003', 'nvc3@congty.com', N'Đang làm việc', 'nvc3', '123456', 0),
(N'Phạm Thị D', '0901100004', 'ntd4@congty.com', N'Đang làm việc', 'ntd4', '123456', 0), (N'Hoàng Văn E', '0901100005', 'nve5@congty.com', N'Đang làm việc', 'nve5', '123456', 0), (N'Vũ Thị F', '0901100006', 'ntf6@congty.com', N'Đang làm việc', 'ntf6', '123456', 0),
(N'Đặng Văn G', '0901100007', 'nvg7@congty.com', N'Đang làm việc', 'nvg7', '123456', 0), (N'Bùi Thị H', '0901100008', 'nth8@congty.com', N'Đang làm việc', 'nth8', '123456', 0), (N'Đỗ Văn I', '0901100009', 'nvi9@congty.com', N'Đang làm việc', 'nvi9', '123456', 0),
(N'Hồ Thị K', '0901100010', 'ntk10@congty.com', N'Đã nghỉ việc', 'ntk10', '123456', 0), (N'Đoàn Văn L', '0901100011', 'nvl11@congty.com', N'Đang làm việc', 'nvl11', '123456', 0), (N'Ngô Thị M', '0901100012', 'ntm12@congty.com', N'Đang làm việc', 'ntm12', '123456', 0),
(N'Lý Văn N', '0901100013', 'nvn13@congty.com', N'Đang làm việc', 'nvn13', '123456', 0), (N'Châu Thị O', '0901100014', 'nto14@congty.com', N'Đang làm việc', 'nto14', '123456', 0), (N'Thái Văn P', '0901100015', 'nvp15@congty.com', N'Đang làm việc', 'nvp15', '123456', 0),
(N'Tô Thị Q', '0901100016', 'ntq16@congty.com', N'Đang làm việc', 'ntq16', '123456', 0), (N'Kiều Văn R', '0901100017', 'nvr17@congty.com', N'Đang làm việc', 'nvr17', '123456', 0), (N'Tào Thị S', '0901100018', 'nts18@congty.com', N'Đang làm việc', 'nts18', '123456', 0),
(N'Mạc Văn T', '0901100019', 'nvt19@congty.com', N'Đang làm việc', 'nvt19', '123456', 0), (N'Đinh Thị U', '0901100020', 'ntu20@congty.com', N'Đang làm việc', 'ntu20', '123456', 0), (N'Trần Văn V', '0901100021', 'nvv21@congty.com', N'Đang làm việc', 'nvv21', '123456', 0),
(N'Nguyễn Thị X', '0901100022', 'ntx22@congty.com', N'Đang làm việc', 'ntx22', '123456', 0), (N'Lê Văn Y', '0901100023', 'nvy23@congty.com', N'Đang làm việc', 'nvy23', '123456', 0), (N'Phạm Thị Z', '0901100024', 'ntz24@congty.com', N'Đang làm việc', 'ntz24', '123456', 0),
(N'Hoàng Văn W', '0901100025', 'nvw25@congty.com', N'Đang làm việc', 'nvw25', '123456', 0), (N'Vũ Thị AA', '0901100026', 'ntaa26@congty.com', N'Đang làm việc', 'ntaa26', '123456', 0), (N'Đặng Văn BB', '0901100027', 'nvbb27@congty.com', N'Đang làm việc', 'nvbb27', '123456', 0),
(N'Bùi Thị CC', '0901100028', 'ntcc28@congty.com', N'Đang làm việc', 'ntcc28', '123456', 0), (N'Đỗ Văn DD', '0901100029', 'nvdd29@congty.com', N'Đang làm việc', 'nvdd29', '123456', 0), (N'Hồ Thị EE', '0901100030', 'ntee30@congty.com', N'Đang làm việc', 'ntee30', '123456', 0);
GO

-- BẢNG 2: KHÁCH HÀNG (50 Dòng)
INSERT INTO KhachHang (HoVaTen, DienThoai, DiaChi, NgaySinh, NhomKhachHang) VALUES
(N'Khách Đại Gia Ngầm', '0988000001', N'Biệt thự Thảo Điền, Quận 2, TP.HCM', '1980-01-01', N'VIP'),
(N'Khách Seen Không Rep', '0988000002', N'Hẻm cụt, Gò Vấp, TP.HCM', '1995-02-14', N'Khách thường'),
(N'Khách Hỏi Giá Không Mua', '0988000003', N'Khu phố mộng mơ, Đà Lạt', '1998-05-20', N'Tiềm năng'),
(N'Khách Chờ Lương Về', '0988000004', N'KCN Sóng Thần, Bình Dương', '1992-10-10', N'Tiềm năng'),
(N'Khách Bom Hàng Quốc Dân', '0988000005', N'Đảo hoang, không rõ địa chỉ', '2000-04-01', N'Danh sách đen'),
(N'Khách Thích Mặc Cả', '0988000006', N'Chợ Đồng Xuân, Hà Nội', '1975-08-08', N'Khách thường'),
(N'Khách Hỏi Vợ Đã', '0988000007', N'Khu dân cư sợ vợ, Cần Thơ', '1988-11-11', N'Tiềm năng'),
(N'Khách Đòi Freeship', '0988000008', N'Đỉnh núi Fansipan, Lào Cai', '1999-09-09', N'Khách thường'),
(N'Khách Chốt Không Cần Giá', '0988000009', N'Landmark 81, TP.HCM', '1985-12-25', N'VIP'),
(N'Khách Giận Dỗi', '0988000010', N'Bến Ninh Kiều, Cần Thơ', '1997-07-27', N'Danh sách đen'),
(N'Khách Xin Giảm 1K', '0988000011', N'Nhà trọ, Làng đại học', '2002-01-01', N'Khách thường'),
(N'Khách Đang Đi Nước Ngoài', '0988000012', N'Sân bay Tân Sơn Nhất', '1990-05-05', N'VIP'),
(N'Khách Hỏi Từ Năm Ngoái', '0988000013', N'Ngõ 13, Hà Nội', '1986-06-06', N'Tiềm năng'),
(N'Khách Mới Trúng Số', '0988000014', N'Đại lộ Bình Dương', '1978-08-08', N'VIP'),
(N'Khách Block Shop', '0988000015', N'Không xác định', '1995-09-09', N'Danh sách đen'),
(N'Nguyễn Khách 1', '0988100001', N'Quận 1, TP.HCM', '1990-01-01', N'Khách thường'), 
(N'Trần Khách 2', '0988100002', N'Quận 2, TP.HCM', '1991-02-02', N'Tiềm năng'), 
(N'Lê Khách 3', '0988100003', N'Quận 3, TP.HCM', '1992-03-03', N'VIP'),
(N'Phạm Khách 4', '0988100004', N'Quận 4, TP.HCM', '1993-04-04', N'Khách thường'), 
(N'Hoàng Khách 5', '0988100005', N'Quận 5, TP.HCM', '1994-05-05', N'Tiềm năng'), 
(N'Vũ Khách 6', '0988100006', N'Quận 6, TP.HCM', '1995-06-06', N'Danh sách đen'),
(N'Đặng Khách 7', '0988100007', N'Quận 7, TP.HCM', '1996-07-07', N'Khách thường'), 
(N'Bùi Khách 8', '0988100008', N'Quận 8, TP.HCM', '1997-08-08', N'Tiềm năng'), 
(N'Đỗ Khách 9', '0988100009', N'Quận 9, TP.HCM', '1998-09-09', N'VIP'),
(N'Hồ Khách 10', '0988100010', N'Quận 10, TP.HCM', '1999-10-10', N'Khách thường'), 
(N'Đoàn Khách 11', '0988100011', N'Quận 11, TP.HCM', '2000-11-11', N'Tiềm năng'), 
(N'Ngô Khách 12', '0988100012', N'Quận 12, TP.HCM', '2001-12-12', N'Khách thường'),
(N'Lý Khách 13', '0988100013', N'Tân Bình, TP.HCM', '1985-01-15', N'VIP'), 
(N'Châu Khách 14', '0988100014', N'Tân Phú, TP.HCM', '1986-02-16', N'Khách thường'), 
(N'Thái Khách 15', '0988100015', N'Bình Tân, TP.HCM', '1987-03-17', N'Tiềm năng'),
(N'Tô Khách 16', '0988100016', N'Bình Thạnh, TP.HCM', '1988-04-18', N'Khách thường'), 
(N'Kiều Khách 17', '0988100017', N'Gò Vấp, TP.HCM', '1989-05-19', N'Tiềm năng'), 
(N'Tào Khách 18', '0988100018', N'Phú Nhuận, TP.HCM', '1990-06-20', N'VIP'),
(N'Mạc Khách 19', '0988100019', N'Hoàn Kiếm, HN', '1991-07-21', N'Khách thường'), 
(N'Đinh Khách 20', '0988100020', N'Ba Đình, HN', '1992-08-22', N'Tiềm năng'), 
(N'Trần Khách 21', '0988100021', N'Đống Đa, HN', '1993-09-23', N'Khách thường'),
(N'Nguyễn Khách 22', '0988100022', N'Hai Bà Trưng, HN', '1994-10-24', N'Tiềm năng'), 
(N'Lê Khách 23', '0988100023', N'Tây Hồ, HN', '1995-11-25', N'VIP'), 
(N'Phạm Khách 24', '0988100024', N'Cầu Giấy, HN', '1996-12-26', N'Khách thường'),
(N'Hoàng Khách 25', '0988100025', N'Thanh Xuân, HN', '1997-01-27', N'Tiềm năng'), 
(N'Vũ Khách 26', '0988100026', N'Hà Đông, HN', '1998-02-28', N'Khách thường'), 
(N'Đặng Khách 27', '0988100027', N'Long Biên, HN', '1999-03-29', N'Danh sách đen'),
(N'Bùi Khách 28', '0988100028', N'Ninh Kiều, Cần Thơ', '2000-04-30', N'Tiềm năng'), 
(N'Đỗ Khách 29', '0988100029', N'Cái Răng, Cần Thơ', '1980-05-01', N'VIP'), 
(N'Hồ Khách 30', '0988100030', N'Hải Châu, Đà Nẵng', '1981-06-02', N'Khách thường'),
(N'Đoàn Khách 31', '0988100031', N'Sơn Trà, Đà Nẵng', '1982-07-03', N'Tiềm năng'), 
(N'Ngô Khách 32', '0988100032', N'Ngũ Hành Sơn, ĐN', '1983-08-04', N'Khách thường'), 
(N'Lý Khách 33', '0988100033', N'Liên Chiểu, ĐN', '1984-09-05', N'VIP'),
(N'Châu Khách 34', '0988100034', N'Thanh Khê, Đà Nẵng', '1985-10-06', N'Khách thường'), 
(N'Thái Khách 35', '0988100035', N'Cẩm Lệ, Đà Nẵng', '1986-11-07', N'Tiềm năng');
GO

-- BẢNG 3: SẢN PHẨM (50 Dòng)
INSERT INTO SanPham (TenSanPham, DonGia, HinhAnh, SoLuong) VALUES
(N'Liệu trình trị mụn chuẩn Y khoa', 499000, 'LieuTrinhTriMun.jpg', 100),
(N'Chăm sóc da mặt chuyên sâu', 899000, 'ChamocDaMat.jpg', 50),
(N'Phục hồi da mỏng yếu, nổi mao mạch', 1200000, 'PhucHoiDaMong.jpg', 30),
(N'Tắm trắng phi thuyền hoàng gia', 2500000, 'TamTrang.jpg', 20),
(N'Triệt lông nách vĩnh viễn (Trọn gói)', 800000, 'TrietLong.jpg', 50),
(N'Triệt lông toàn thân VIP', 3500000, 'TrietLongVip.jpg', 15),
(N'Nâng cơ trẻ hóa da công nghệ Hifu', 5000000, 'NangCo.jpg', 10),
(N'Massage body đá nóng đả thông kinh lạc', 450000, 'MassageBody.jpg', 40),
(N'Phun mày tán bột tự nhiên', 1500000, 'PhunMay.jpg', 25),
(N'Khử thâm môi Collagen', 2000000, 'KhuTham.jpg', 30),
(N'Tiêm Filler cằm V-line', 4000000, 'Filler.jpg', 10),
(N'Tiêm Botox xóa nhăn đuôi mắt', 3500000, 'Botox.jpg', 12),
(N'Cấy chỉ Collagen trẻ hóa toàn mặt', 15000000, 'CayChi.jpg', 5),
(N'Trị nám Laser Toning', 1800000, 'LaserNam.jpg', 20),
(N'Xóa xăm công nghệ Picosure', 2500000, 'XoaXam.jpg', 15),
-- Sinh nhanh 35 mỹ phẩm bán lẻ
(N'Kem trị mụn Centella', 350000, 'KemMun.jpg', 200), (N'Serum HA cấp ẩm sâu', 450000, 'SerumHA.jpg', 150), (N'Kem chống nắng phổ rộng SPF 50', 500000, 'KCN.jpg', 300),
(N'Nước tẩy trang dịu nhẹ 500ml', 300000, 'TayTrang.jpg', 250), (N'Sữa rửa mặt tạo bọt tràm trà', 250000, 'SRM.jpg', 200), (N'Toner hoa hồng cân bằng pH', 320000, 'Toner.jpg', 180),
(N'Tẩy tế bào chết vật lý', 280000, 'TTBC.jpg', 120), (N'Mặt nạ đất sét giảm bã nhờn', 400000, 'MaskDatSet.jpg', 100), (N'Mặt nạ giấy dưỡng trắng (Hộp 10 miếng)', 250000, 'MaskGiay.jpg', 500),
(N'Kem dưỡng phục hồi B5', 600000, 'KemB5.jpg', 150), (N'Serum Vitamin C mờ thâm', 550000, 'SerumVitC.jpg', 140), (N'Retinol 0.5% chống lão hóa', 850000, 'Retinol.jpg', 80),
(N'Kem mắt trị quầng thâm', 700000, 'KemMat.jpg', 90), (N'Dầu gội bưởi kích mọc tóc', 250000, 'DauGoi.jpg', 300), (N'Dầu xả phục hồi tóc hư tổn', 260000, 'DauXa.jpg', 280),
(N'Sữa tắm hương nước hoa', 350000, 'SuaTam.jpg', 200), (N'Lotion dưỡng thể trắng da', 450000, 'Lotion.jpg', 150), (N'Kem trị thâm nách', 280000, 'KemThamNach.jpg', 100),
(N'Xịt khoáng làm dịu da', 220000, 'XitKhoang.jpg', 250), (N'Son dưỡng môi mỡ hươu', 150000, 'SonDuong.jpg', 400), (N'Son tint bóng Hàn Quốc đỏ đất', 350000, 'SonTint.jpg', 300),
(N'Kem nền che khuyết điểm', 550000, 'KemNen.jpg', 100), (N'Phấn phủ kiềm dầu', 450000, 'PhanPhu.jpg', 120), (N'Kẻ mắt nước lâu trôi', 180000, 'KeMat.jpg', 200),
(N'Mascara làm cong và dài mi', 220000, 'Mascara.jpg', 180), (N'Bảng phấn mắt 9 màu', 480000, 'PhanMat.jpg', 90), (N'Nước hoa hồng dạng xịt', 320000, 'NuocHoaHong.jpg', 150),
(N'Viên uống trắng da Glutathione', 950000, 'VienTrangDa.jpg', 50), (N'Viên uống cấp nước Hyaluronic', 750000, 'VienCapNuoc.jpg', 60), (N'Collagen dạng nước', 1200000, 'CollagenNuoc.jpg', 40),
(N'Trà giảm cân thảo mộc', 450000, 'TraGiamCan.jpg', 100), (N'Thạch xơ thải độc ruột', 550000, 'ThachXo.jpg', 80), (N'Máy rửa mặt sóng âm', 1500000, 'MayRuaMat.jpg', 30),
(N'Máy đẩy tinh chất Ion', 2000000, 'MayDayTinhChat.jpg', 25), (N'Thanh lăn massage mặt V-line', 350000, 'ThanhLan.jpg', 100);
GO

-- BẢNG 4: HÓA ĐƠN (50 Dòng)
-- Sinh ngẫu nhiên Hóa Đơn với NhanVienID từ 1-50, KhachHangID từ 1-50
DECLARE @i INT = 1;
WHILE @i <= 50
BEGIN
    INSERT INTO HoaDon (NhanVienID, KhachHangID, NgayLap, GhiChuHoaDon)
    VALUES (
        CAST((RAND() * 49 + 1) AS INT), 
        CAST((RAND() * 49 + 1) AS INT), 
        DATEADD(day, -CAST((RAND() * 60) AS INT), GETDATE()), 
        CHOOSE(CAST((RAND() * 5 + 1) AS INT), N'Khách tự đặt trên Web', N'Chốt sale qua Zalo', N'Khách mua trực tiếp', N'Áp mã Freeship', N'Khách VIP quay lại')
    );
    SET @i = @i + 1;
END;
GO

-- BẢNG 5: PHÂN CÔNG CHĂM SÓC (50 Dòng)
-- Bản Fix dứt điểm 100% lỗi NULL do hàm CHOOSE

DECLARE @j INT = 1;
DECLARE @rdNhanVien INT, @rdKhachHang INT, @rdHinhThuc INT, @rdNoiDung INT, @rdKetQua INT, @rdNgayHen INT;

WHILE @j <= 50
BEGIN
    -- CHỐT SỐ NGẪU NHIÊN TRƯỚC VÀO BIẾN ĐỂ SQL KHÔNG TÍNH LẠI
    SET @rdNhanVien = ABS(CHECKSUM(NEWID())) % 50 + 1;
    SET @rdKhachHang = ABS(CHECKSUM(NEWID())) % 50 + 1;
    SET @rdHinhThuc = ABS(CHECKSUM(NEWID())) % 4 + 1;
    SET @rdNoiDung = ABS(CHECKSUM(NEWID())) % 3 + 1;
    SET @rdKetQua = ABS(CHECKSUM(NEWID())) % 4 + 1;
    SET @rdNgayHen = ABS(CHECKSUM(NEWID())) % 2; -- Cho ra 0 hoặc 1

    INSERT INTO PhanCongChamSoc (NhanVienID, KhachHangID, NgayChamSoc, HinhThuc, NoiDung, KetQua, NgayHenLai)
    VALUES (
        @rdNhanVien, 
        @rdKhachHang, 
        DATEADD(day, -(ABS(CHECKSUM(NEWID())) % 30), GETDATE()), 
        
        -- Dùng biến đã chốt số để chọn, tuyệt đối không ra NULL nữa
        CHOOSE(@rdHinhThuc, N'Gọi điện', N'Nhắn tin Zalo', N'Gặp trực tiếp', N'Email'), 
        CHOOSE(@rdNoiDung, N'Chăm sóc định kỳ', N'Hỏi thăm sau liệu trình', N'Gửi chương trình khuyến mãi'), 
        CHOOSE(@rdKetQua, N'Chốt thành công', N'Khách đang suy nghĩ', N'Thuê bao/Không nghe', N'Từ chối khéo'), 
        
        -- Nếu @rdNgayHen = 0 thì có ngày hẹn, ngược lại là NULL
        IIF(@rdNgayHen = 0, DATEADD(day, (ABS(CHECKSUM(NEWID())) % 15) + 1, GETDATE()), NULL)
    );
    
    SET @j = @j + 1;
END;
GO

-- BẢNG 6: HÓA ĐƠN CHI TIẾT (50 Dòng)
-- Random chi tiết cho 50 hóa đơn vừa tạo ở trên
DECLARE @k INT = 1;
WHILE @k <= 50
BEGIN
    INSERT INTO HoaDon_ChiTiet (HoaDonID, SanPhamID, SoLuongBan, DonGiaBan)
    VALUES (
        @k, -- HoaDonID từ 1 đến 50
        CAST((RAND() * 49 + 1) AS INT), -- Random SanPhamID từ 1 đến 50
        CAST((RAND() * 5 + 1) AS INT), -- Số lượng từ 1 đến 5
        -- Lấy đại giá 500k làm mẫu
        500000 
    );
    SET @k = @k + 1;
END;
GO