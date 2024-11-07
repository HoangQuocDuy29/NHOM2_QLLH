
CREATE TABLE [dbo].[Diem](
	[ma_diem] [int] IDENTITY(1,1) NOT NULL,
	[ma_sinh_vien] [int] NULL,
	[ma_mon_hoc] [int] NULL,
	[loai_diem] [nvarchar](50) NULL,
	[ty_le_phan_tram] [decimal](5, 2) NULL,
	[diem_so] [decimal](5, 2) NULL,
	[lan_thi] [int] NULL,
	[so_buoi_nghi] [int] NULL,
	[da_xoa] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_diem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GhiDanh]    Script Date: 10/31/2024 11:43:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GhiDanh](
	[ma_ghi_danh] [int] IDENTITY(1,1) NOT NULL,
	[ma_sinh_vien] [int] NULL,
	[ma_lop_hoc] [int] NULL,
	[so_buoi_nghi] [int] NULL,
	[da_xoa] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_ghi_danh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LopHoc]    Script Date: 10/31/2024 11:43:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LopHoc](
	[ma_lop_hoc] [int] IDENTITY(1,1) NOT NULL,
	[ma_mon_hoc] [int] NULL,
	[ten_lop] [nvarchar](100) NOT NULL,
	[so_sinh_vien] [int] NULL,
	[da_xoa] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_lop_hoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 10/31/2024 11:43:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[ma_mon_hoc] [int] IDENTITY(1,1) NOT NULL,
	[ten_mon_hoc] [nvarchar](100) NOT NULL,
	[so_tin_chi] [int] NOT NULL,
	[phan_loai] [nvarchar](20) NULL,
	[tong_so_buoi_hoc] [int] NULL,
	[diem_thi_toi_thieu] [decimal](5, 2) NULL,
	[diem_qua_mon] [decimal](5, 2) NULL,
	[da_xoa] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_mon_hoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 10/31/2024 11:43:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 10/31/2024 11:43:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[ma_sinh_vien] [int] IDENTITY(1,1) NOT NULL,
	[ho_ten] [nvarchar](100) NOT NULL,
	[email] [nvarchar](100) NULL,
	[so_dien_thoai] [nvarchar](20) NULL,
	[chuyen_nganh] [nvarchar](100) NULL,
	[gioi_tinh] [nvarchar](10) NULL,
	[ngay_sinh] [date] NULL,
	[dia_chi] [nvarchar](255) NULL,
	[khoa_hoc] [nvarchar](20) NULL,
	[so_can_cuoc] [nvarchar](20) NULL,
	[da_xoa] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ma_sinh_vien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Diem] ADD  DEFAULT ((0)) FOR [diem_so]
GO
ALTER TABLE [dbo].[Diem] ADD  DEFAULT ((1)) FOR [lan_thi]
GO
ALTER TABLE [dbo].[Diem] ADD  DEFAULT ((0)) FOR [so_buoi_nghi]
GO
ALTER TABLE [dbo].[Diem] ADD  DEFAULT ((0)) FOR [da_xoa]
GO
ALTER TABLE [dbo].[GhiDanh] ADD  DEFAULT ((0)) FOR [so_buoi_nghi]
GO
ALTER TABLE [dbo].[GhiDanh] ADD  DEFAULT ((0)) FOR [da_xoa]
GO
ALTER TABLE [dbo].[LopHoc] ADD  DEFAULT ((0)) FOR [so_sinh_vien]
GO
ALTER TABLE [dbo].[LopHoc] ADD  DEFAULT ((0)) FOR [da_xoa]
GO
ALTER TABLE [dbo].[MonHoc] ADD  DEFAULT ((0)) FOR [da_xoa]
GO
ALTER TABLE [dbo].[SinhVien] ADD  DEFAULT ((0)) FOR [da_xoa]
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD FOREIGN KEY([ma_mon_hoc])
REFERENCES [dbo].[MonHoc] ([ma_mon_hoc])
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD FOREIGN KEY([ma_sinh_vien])
REFERENCES [dbo].[SinhVien] ([ma_sinh_vien])
GO
ALTER TABLE [dbo].[GhiDanh]  WITH CHECK ADD FOREIGN KEY([ma_lop_hoc])
REFERENCES [dbo].[LopHoc] ([ma_lop_hoc])
GO
ALTER TABLE [dbo].[GhiDanh]  WITH CHECK ADD FOREIGN KEY([ma_sinh_vien])
REFERENCES [dbo].[SinhVien] ([ma_sinh_vien])
GO
ALTER TABLE [dbo].[LopHoc]  WITH CHECK ADD FOREIGN KEY([ma_mon_hoc])
REFERENCES [dbo].[MonHoc] ([ma_mon_hoc])
GO
-- Thêm dữ liệu vào bảng MonHoc
INSERT INTO [dbo].[MonHoc] (ten_mon_hoc, so_tin_chi, phan_loai, tong_so_buoi_hoc, diem_thi_toi_thieu, diem_qua_mon, da_xoa)
VALUES 
('Toán Cao Cấp', 3, 'Bắt buộc', 45, 5.0, 4.0, 0),
('Lý Thuyết Đồ Thị', 2, 'Tự chọn', 30, 4.0, 3.5, 0);

-- Thêm dữ liệu vào bảng SinhVien
INSERT INTO [dbo].[SinhVien] (ho_ten, email, so_dien_thoai, chuyen_nganh, gioi_tinh, ngay_sinh, dia_chi, khoa_hoc, so_can_cuoc, da_xoa)
VALUES 
('Nguyen Van A', 'nguyenvana@example.com', '0123456789', 'Công nghệ thông tin', 'Nam', '2000-01-01', '123 Đường ABC', 'Khoa 2018', '123456789012', 0),
('Tran Thi B', 'tranthib@example.com', '0987654321', 'Kinh tế', 'Nữ', '2001-02-02', '456 Đường XYZ', 'Khoa 2019', '987654321098', 0);

-- Thêm dữ liệu vào bảng LopHoc
INSERT INTO [dbo].[LopHoc] (ma_mon_hoc, ten_lop, so_sinh_vien, da_xoa)
VALUES 
(1, 'Lớp Toán Cao Cấp A', 30, 0),
(2, 'Lớp Lý Thuyết Đồ Thị B', 25, 0);

-- Thêm dữ liệu vào bảng GhiDanh
INSERT INTO [dbo].[GhiDanh] (ma_sinh_vien, ma_lop_hoc, so_buoi_nghi, da_xoa)
VALUES 
(1, 1, 2, 0),
(2, 2, 0, 0);

-- Thêm dữ liệu vào bảng Diem
INSERT INTO [dbo].[Diem] (ma_sinh_vien, ma_mon_hoc, loai_diem, ty_le_phan_tram, diem_so, lan_thi, so_buoi_nghi, da_xoa)
VALUES 
(1, 1, 'Giữa kỳ', 30.00, 8.5, 1, 1, 0),
(2, 2, 'Cuối kỳ', 70.00, 7.0, 1, 0, 0);

-- Thêm dữ liệu vào bảng NguoiDung
INSERT INTO [dbo].[NguoiDung] (UserName, Password)
VALUES 
('admin', '123456'),
('user1', '123');
