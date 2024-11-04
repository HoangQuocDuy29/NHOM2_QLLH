USE [Nhom2]
GO
/****** Object:  Table [dbo].[Diem]    Script Date: 10/31/2024 11:43:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
