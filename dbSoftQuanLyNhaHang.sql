USE [dbSoftQuanLyNhaHang]
GO
/****** Object:  UserDefinedFunction [dbo].[fcgetIdBan]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	-- select IdKhachHang=dbo.fcgetIdKhuVuc()
	
					/*-------- BANG BAN ---------*/

	
	Create function [dbo].[fcgetIdBan]()
		returns varchar(5)
		
		
		As
		Begin
			Declare @IdBan varchar(5)
			Declare @MaxIdBan varchar(5)
			Declare @Max float
			
			
			Select @MaxIdBan = MAX(IdBan) from Ban
			
			if exists (select IdBan from Ban)
						set @Max = CONVERT(float, SUBSTRING(@MaxIdBan,4,2)) + 1
			else
						set @Max=1	
			if (@Max < 10)
						set @IdBan='BAN' + '0' + Convert(varchar(1),@Max)
			else
						set @IdBan ='BAN' +  Convert(varchar(3),@Max)
			Return @IdBan
	End

GO
/****** Object:  UserDefinedFunction [dbo].[fcgetIdHoaDon]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	
	Create function [dbo].[fcgetIdHoaDon]()
		returns varchar(5)
		
		
		As
		Begin
			Declare @IdHoaDon varchar(5)
			Declare @MaxIdHoaDon varchar(5)
			Declare @Max float
			
			
			Select @MaxIdHoaDon = MAX(IdHoaDon) from HoaDon
			
			if exists (select IdHoaDon from HoaDon)
						set @Max = CONVERT(float, SUBSTRING(@MaxIdHoaDon,4,2)) + 1
			else
						set @Max=1	
			if (@Max < 10)
						set @IdHoaDon='MHD' + '0' + Convert(varchar(1),@Max)
			else
						set @IdHoaDon ='MHD' +  Convert(varchar(3),@Max)
			Return @IdHoaDon
	End
GO
/****** Object:  UserDefinedFunction [dbo].[fcgetIdKhachHang]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
		Create function [dbo].[fcgetIdKhachHang]()
		returns varchar(10)
		
		
		As
		Begin
			Declare @IdKhachHang varchar(10)
			Declare @MaxIdKhachHang varchar(10)
			Declare @Max float
			
			
			Select @MaxIdKhachHang = MAX(IdKhachHang) from KhachHang
			
			if exists (select IdKhachHang from KhachHang)
						set @Max = CONVERT(float, SUBSTRING(@MaxIdKhachHang,3,8)) + 1
			else
						set @Max=1	
			if (@Max < 10)
						set @IdKhachHang='KH' + '0000000' + Convert(varchar(1),@Max)
			else
			if (@Max < 100)
						set @IdKhachHang='KH' + '000000' + Convert(varchar(2),@Max)
			else
			if (@Max < 1000)
						set @IdKhachHang='KH' + '00000' + Convert(varchar(3),@Max)
			else
			if (@Max < 10000)
						set @IdKhachHang='KH' + '0000' + Convert(varchar(4),@Max)
			else
			if (@Max < 100000)
						set @IdKhachHang ='KH' + '000' + Convert(varchar(5),@Max)
			else
			if (@Max < 1000000)
						set @IdKhachHang  ='KH' + '00' + Convert(varchar(6),@Max)
			else	
			if (@Max < 10000000)
						set @IdKhachHang ='KH' + '0' + Convert(varchar(7),@Max)
			else
						set @IdKhachHang ='KH' +  Convert(varchar(8),@Max)
			Return @IdKhachHang
	End

GO
/****** Object:  UserDefinedFunction [dbo].[fcgetIdkhuVuc]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	-- select IdKhachHang=dbo.fcgetIdKhachHang()
	
	/*--------------- BANG KHU VUC ------------*/
	
	Create function [dbo].[fcgetIdkhuVuc]()
		returns varchar(5)
		
		
		As
		Begin
			Declare @IdKhuVuc varchar(5)
			Declare @MaxIdKhuVuc varchar(5)
			Declare @Max float
			
			
			Select @MaxIdKhuVuc = MAX(IdKhuVuc) from KhuVuc
			
			if exists (select IdKhuVuc from KhuVuc)
						set @Max = CONVERT(float, SUBSTRING(@MaxIdKhuVuc,3,3)) + 1
			else
						set @Max=1	
			if (@Max < 10)
						set @IdKhuVuc='KV' + '00' + Convert(varchar(1),@Max)
			else
			if (@Max < 100)
						set @IdKhuVuc='KV' + '0' + Convert(varchar(2),@Max)
			else
						set @IdKhuVuc ='KV' +  Convert(varchar(3),@Max)
			Return @IdKhuVuc
	End

GO
/****** Object:  UserDefinedFunction [dbo].[fcgetIdLoaiThucDon]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	-- select IdBan=dbo.fcgetIdBan()
	
			/*----- BANG LOAITHUCDON ----------*/
			
		Create function [dbo].[fcgetIdLoaiThucDon]()
		returns varchar(5)
		
		
		As
		Begin
			Declare @IdLoaiThucDon		varchar(5)
			Declare @MaxIdLoaiThucDon	varchar(5)
			Declare @Max float
			
			
			Select @MaxIdLoaiThucDon = MAX(IdLoaiThucDon) from LoaiThucDon
			
			if exists (select IdLoaiThucDon from LoaiThucDon)
						set @Max = CONVERT(float, SUBSTRING(@MaxIdLoaiThucDon,4,2)) + 1
			else
						set @Max=1	
			if (@Max < 10)
						set @IdLoaiThucDon='LTD' + '0' + Convert(varchar(1),@Max)
			else
						set @IdLoaiThucDon ='LTD' +  Convert(varchar(3),@Max)
			Return @IdLoaiThucDon
	End

GO
/****** Object:  UserDefinedFunction [dbo].[fcgetIdNhanVien]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
		Create function [dbo].[fcgetIdNhanVien]()
		returns varchar(10)
		
		
		As
		Begin
			Declare @IdNhanVien varchar(10)
			Declare @MaxIdNhanVien varchar(10)
			Declare @Max float
			
			
			Select @MaxIdNhanVien = MAX(IdNhanVien) from NhanVien
			
			if exists (select IdNhanVien from NhanVien)
						set @Max = CONVERT(float, SUBSTRING(@MaxIdNhanVien,3,8)) + 1
			else
						set @Max=1	
			if (@Max < 10)
						set @IdNhanVien='NV' + '0000000' + Convert(varchar(1),@Max)
			else
			if (@Max < 100)
						set @IdNhanVien='NV' + '000000' + Convert(varchar(2),@Max)
			else
			if (@Max < 1000)
						set @IdNhanVien='NV' + '00000' + Convert(varchar(3),@Max)
			else
			if (@Max < 10000)
						set @IdNhanVien='NV' + '0000' + Convert(varchar(4),@Max)
			else
			if (@Max < 100000)
						set @IdNhanVien ='NV' + '000' + Convert(varchar(5),@Max)
			else
			if (@Max < 1000000)
						set @IdNhanVien  ='NV' + '00' + Convert(varchar(6),@Max)
			else	
			if (@Max < 10000000)
						set @IdNhanVien ='NV' + '0' + Convert(varchar(7),@Max)
			else
						set @IdNhanVien ='NV' +  Convert(varchar(8),@Max)
			Return @IdNhanVien
	End

GO
/****** Object:  UserDefinedFunction [dbo].[fcgetIdThucDon]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	-- select IdLoaiThucDon=dbo.fcgetIdLoaiThucDon()
	
	
			/*----- BANG THUCDON ----------*/
			
		Create function [dbo].[fcgetIdThucDon]()
		returns varchar(5)
		
		
		As
		Begin
			Declare @IdThucDon		varchar(5)
			Declare @MaxIdThucDon	varchar(5)
			Declare @Max float
			
			
			Select @MaxIdThucDon = MAX(IdThucDon) from ThucDon
			
			if exists (select IdThucDon from ThucDon)
						set @Max = CONVERT(float, SUBSTRING(@MaxIdThucDon,3,3)) + 1
			else
						set @Max=1	
			if (@Max < 10)
						set @IdThucDon='TD' + '00' + Convert(varchar(1),@Max)
			else
			if (@Max < 100)
						set @IdThucDon='TD' + '0' + Convert(varchar(2),@Max)
			else
						set @IdThucDon ='TD' +  Convert(varchar(3),@Max)
			Return @IdThucDon
	End

GO
/****** Object:  Table [dbo].[Ban]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ban](
	[IdBan] [varchar](5) NOT NULL,
	[TenKhuVuc] [nvarchar](100) NULL,
	[TenBan] [nvarchar](100) NULL,
	[DienGiai] [nvarchar](100) NULL,
	[TrangThai] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [Unique_Ban] UNIQUE NONCLUSTERED 
(
	[TenBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[TenBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DangNhap]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DangNhap](
	[IdDangNhap] [varchar](100) NOT NULL,
	[MatKhau] [nvarchar](200) NULL,
	[TrangThai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GoiMon]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GoiMon](
	[IdBan] [varchar](5) NULL,
	[IdThucDon] [varchar](5) NULL,
	[TenThucDon] [nvarchar](100) NULL,
	[DonGiaTon] [decimal](18, 0) NULL,
	[SoLuong] [int] NULL,
	[ThoiGian] [datetime] NULL,
	[ThanhTien] [decimal](18, 0) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDon](
	[IdHoaDon] [varchar](10) NOT NULL,
	[IdNhanVien] [varchar](10) NULL,
	[IdBan] [varchar](5) NULL,
	[NgayLap] [datetime] NULL,
	[DienGiai] [nvarchar](100) NULL,
	[SoTien] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[IdKhachHang] [varchar](10) NOT NULL,
	[TenKhachHang] [nvarchar](100) NULL,
	[DienThoai] [varchar](15) NULL,
	[Email] [varchar](100) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[GioiTinh] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhuVuc]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhuVuc](
	[IdKhuVuc] [varchar](5) NOT NULL,
	[TenKhuVuc] [nvarchar](100) NULL,
	[DienGiai] [nvarchar](100) NULL,
	[TrangThai] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdKhuVuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [Unique_KhuVuc] UNIQUE NONCLUSTERED 
(
	[TenKhuVuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[TenKhuVuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiThucDon]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiThucDon](
	[IdLoaiThucDon] [varchar](5) NOT NULL,
	[TenLoaiThucDon] [nvarchar](100) NULL,
	[DienGiai] [nvarchar](100) NULL,
	[TrangThai] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdLoaiThucDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[TenLoaiThucDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NguyenLieuThucDon]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NguyenLieuThucDon](
	[IdNguyenLieuThucDon] [varchar](5) NULL,
	[IdThucDon] [varchar](5) NULL,
	[SoLuong] [float] NULL,
	[DienGiai] [nvarchar](100) NULL,
	[TrangThai] [nvarchar](30) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[IdNhanVien] [varchar](10) NOT NULL,
	[HoLot] [nvarchar](100) NULL,
	[Ten] [nvarchar](100) NULL,
	[Ngaysinh] [datetime] NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[DienThoai] [varchar](15) NULL,
	[Email] [varchar](100) NULL,
	[DiaChi] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhanQuyen](
	[IdTaiKhoan] [varchar](10) NOT NULL,
	[MatKhau] [varchar](200) NULL,
	[IdNhanVien] [varchar](10) NULL,
 CONSTRAINT [KhoaChinh_PhanQuyen] PRIMARY KEY CLUSTERED 
(
	[IdTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThucDon]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThucDon](
	[IdThucDon] [varchar](5) NOT NULL,
	[TenLoaiThucDon] [nvarchar](100) NULL,
	[TenThucDon] [nvarchar](100) NULL,
	[DonViTinh] [nvarchar](10) NULL,
	[SoLuongTon] [float] NULL,
	[DonGiaTon] [float] NULL,
	[TonToiThieu] [float] NULL,
	[TrangThai] [nvarchar](30) NULL,
	[HinhAnh] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdThucDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[TenThucDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Ban]  WITH CHECK ADD FOREIGN KEY([TenKhuVuc])
REFERENCES [dbo].[KhuVuc] ([TenKhuVuc])
GO
ALTER TABLE [dbo].[GoiMon]  WITH CHECK ADD FOREIGN KEY([IdBan])
REFERENCES [dbo].[Ban] ([IdBan])
GO
ALTER TABLE [dbo].[GoiMon]  WITH CHECK ADD FOREIGN KEY([IdThucDon])
REFERENCES [dbo].[ThucDon] ([IdThucDon])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([IdBan])
REFERENCES [dbo].[Ban] ([IdBan])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([IdNhanVien])
REFERENCES [dbo].[NhanVien] ([IdNhanVien])
GO
ALTER TABLE [dbo].[NguyenLieuThucDon]  WITH CHECK ADD FOREIGN KEY([IdThucDon])
REFERENCES [dbo].[ThucDon] ([IdThucDon])
GO
ALTER TABLE [dbo].[PhanQuyen]  WITH CHECK ADD FOREIGN KEY([IdNhanVien])
REFERENCES [dbo].[NhanVien] ([IdNhanVien])
GO
ALTER TABLE [dbo].[ThucDon]  WITH CHECK ADD FOREIGN KEY([TenLoaiThucDon])
REFERENCES [dbo].[LoaiThucDon] ([TenLoaiThucDon])
GO
/****** Object:  StoredProcedure [dbo].[spCheckDangNhap]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*------------------ Kiem tra DangNhap -----------------------*/
create procedure [dbo].[spCheckDangNhap]
(
		@IdDangNhap		varchar(100),
		@MatKhau		nvarchar(200)
)
	as
	Begin
				select	* from DangNhap dn
				where		dn.idDangNhap= @IdDangNhap
				and			dn.MatKhau=@MatKhau				
	End

GO
/****** Object:  StoredProcedure [dbo].[spCheckDangNhapMoi]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spCheckDangNhapMoi]
(
		@IdDangNhap		varchar(100),
		@MatKhau		nvarchar(200)
)
	as
	Begin
				select	count(*) from DangNhap dn
				where		dn.idDangNhap= @IdDangNhap
				and			dn.MatKhau=@MatKhau				
	End
GO
/****** Object:  StoredProcedure [dbo].[spDeleteBan]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- drop procedure spUpdateBan
/*-------------------- Delete Ban -------------------*/
create procedure [dbo].[spDeleteBan]
(
	@IdBan		varchar(5)
)
as
begin
	delete Ban where IdBan = @IdBan
end

GO
/****** Object:  StoredProcedure [dbo].[spDeleteDangNhapByIdDangNhap]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spDeleteDangNhapByIdDangNhap]
(
		 @IdDangNhap	varchar(100)							
)
as
Begin
		 delete from DangNhap 
		 where IdDangNhap =@IdDangNhap
End
/*----------- Tim kiem thong tin theo IdDangNhap ----------*/

GO
/****** Object:  StoredProcedure [dbo].[spDeleteGoiMon]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- drop procedure spUpdateGoiMon
/*-------------------- Delete GoiMon -------------------*/
create procedure [dbo].[spDeleteGoiMon]
(
	@IdBan				varchar (5)
)
as
begin
	Delete GoiMon where IdBan = @IdBan
end

GO
/****** Object:  StoredProcedure [dbo].[spDeleteKhachHang]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*-------------------- Delete KhachHang -------------------*/
CREATE procedure [dbo].[spDeleteKhachHang]
(
	@IdKhachHang		varchar(10)
)
as
begin
	delete Khachhang where IdKhachHang = @IdKhachHang
end

GO
/****** Object:  StoredProcedure [dbo].[spDeleteKhuVuc]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- drop procedure spUpdateKhuVuc
/*-------------------- Delete KhuVuc -------------------*/
create procedure [dbo].[spDeleteKhuVuc]
(
	@IdKhuVuc		varchar(5)
)
as
begin
	delete KhuVuc where IdKhuVuc = @IdKhuVuc
end
-- drop procedure spDeleteKhuVuc

GO
/****** Object:  StoredProcedure [dbo].[spDeleteLoaiThucDon]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- drop procedure spUpdateLoaiThucDon
/*-------------------- Delete LoaiThucDon -------------------*/
create procedure [dbo].[spDeleteLoaiThucDon]
(
	@IdLoaiThucDon			varchar (5)
)
as
begin
	delete LoaiThucDon where IdLoaiThucDon = @IdLoaiThucDon
end

GO
/****** Object:  StoredProcedure [dbo].[spDeleteNhanVien]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*--------------- Delete NhanVien ---------------------*/
create procedure [dbo].[spDeleteNhanVien]
(
	@idNhanVien varchar (10)
)
as
Begin
	delete from NhanVien where IdNhanVien=@idNhanVien
End

GO
/****** Object:  StoredProcedure [dbo].[spDeletePhanQuyen]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- drop procedure spUpdatePhanQuyen
/*-------------------- Delete PHANQUYEN -------------------*/
create procedure [dbo].[spDeletePhanQuyen]
(
	@IdTaiKhoan			varchar (10)
)
as
begin
	Delete PhanQuyen where IdTaiKhoan = @IdTaiKhoan	 
end

GO
/****** Object:  StoredProcedure [dbo].[spDeleteThucDon]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----   drop proc spUpdateThucDon
/*-------------------- Delete ThucDon -------------------*/
create procedure [dbo].[spDeleteThucDon]
(
	@IdThucDon		varchar (5)
)
as
begin
	delete ThucDon where IdThucDon = @IdThucDon
end

GO
/****** Object:  StoredProcedure [dbo].[spgetBan]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

						/*----------- BANG BAN --------------*/
						
/*--------- Hien thi thong tin Ban ----------------*/
create procedure [dbo].[spgetBan]
as
Begin
	select IdBan,TenBan,TenKhuVuc,DienGiai,TrangThai from Ban
End

GO
/****** Object:  StoredProcedure [dbo].[spgetBanByIdBan]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--drop  procedure spgetBan
/*----------- Hien thi thong tin Ban bang IdBan --------------*/
create procedure [dbo].[spgetBanByIdBan]
(
	@IdBan	varchar (5)
)
as
begin
	select * from Ban where IdBan = @IdBan
end

GO
/****** Object:  StoredProcedure [dbo].[spgetDangNhap]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spgetDangNhap]
as
Begin
		 select IdDangNhap, MatKhau, TrangThai
		 from DangNhap		 
End

GO
/****** Object:  StoredProcedure [dbo].[spgetDangNhapByIdDangNhap]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spgetDangNhapByIdDangNhap]
(
		 @IdDangNhap	varchar(100)							
)
as
Begin
		 select IdDangNhap, MatKhau, TrangThai
		 from DangNhap
		 where IdDangNhap =@IdDangNhap
End

GO
/****** Object:  StoredProcedure [dbo].[spgetDanhSachBan_ChuaGoiMon]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- drop proc spgetDanhSachBan_GoiMon

/*-------------------- get DanhSachBan_ChuaGoiMon -------------------*/
create procedure [dbo].[spgetDanhSachBan_ChuaGoiMon]
as
begin
	select  distinct IdBan as 'Id Bàn',TenBan as 'Tên Bàn',TenKhuVuc as 'Tên Khu Vực',DienGiai as 'Diễn Giải'
	from Ban where IdBan not in (select IdBan from GoiMon)
	ORDER BY IdBan,TenBan,TenKhuVuc,DienGiai
end
-- drop proc spgetDanhSachBan_ChuaGoiMon


GO
/****** Object:  StoredProcedure [dbo].[spgetDanhSachBan_GoiMon]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*-------------------- get DanhSachBan_GoiMon -------------------*/
create procedure [dbo].[spgetDanhSachBan_GoiMon]
as
begin
	select  DISTINCT b.IdBan as 'Id Bàn' , TenBan as 'Tên Bàn',  TenKhuVuc as 'Tên Khu Vực',DienGiai as 'Diễn Giải'
	from Ban b,GoiMon gm
	where b.IdBan = gm.IdBan
	ORDER BY b.IdBan
end

GO
/****** Object:  StoredProcedure [dbo].[spgetDonGiaByTenThucDon]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*-------------------- get DonGiaTon tu TenThucDon -------------------*/
create procedure [dbo].[spgetDonGiaByTenThucDon]
(
	@TenThucDon			nvarchar(100)
)
as
begin
	select DonGiaTon as 'Đơn giá' from ThucDon where TenThucDon=@TenThucDon
end
							/*--- BANG KHU VUC ---*/

GO
/****** Object:  StoredProcedure [dbo].[spgetGoiMon]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
						/*----- BANG GOIMON-----*/

/*--------- Hien thi thong tin GoiMon ----------------*/
create procedure [dbo].[spgetGoiMon]
as
Begin
	select IdBan,TenThucDon,DonGiaTon,SoLuong,ThoiGian,(SoLuong*DonGiaTon)as ThanhTien
	from GoiMon
	ORDER BY IdBan
End

GO
/****** Object:  StoredProcedure [dbo].[spgetGoiMonByIdBan]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- drop procedure spgetGoiMon
/*----------- Hien thi thong tin GoiMon bang IdBan --------------*/
create procedure [dbo].[spgetGoiMonByIdBan]
(
	@IdBan	varchar (5)
)
as
begin
	select  IdBan as 'Id Bàn', TenThucDon as 'Tên Thực Đơn',DonGiaTon as 'Đơn Giá',SoLuong as 'Số Lượng ',ThoiGian as 'Thời Gian',(SoLuong*DonGiaTon)as 'Thành Tiền'
	from GoiMon where IdBan = @IdBan
end

GO
/****** Object:  StoredProcedure [dbo].[spgetKhachHang]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--drop  procedure spSearchNVByTenNV

						/*-- BANG KHACH HANG -- */
						
/*--------- Hien thi thong tin KhachHang ----------------*/
CREATE procedure [dbo].[spgetKhachHang]
as
Begin
	select IdKhachHang, TenKhachHang,  DienThoai, Email,DiaChi,GioiTinh
	from Khachhang
End
GO
/****** Object:  StoredProcedure [dbo].[spgetKhachHangByIdKhachHang]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*----------- Hien thi thong tin KhachHang bang IdKhachHang --------------*/
CREATE procedure [dbo].[spgetKhachHangByIdKhachHang]
(
	@IdKhachHang		varchar (10)
)
as
begin
	select * from Khachhang where IdKhachHang = @IdKhachHang
end

GO
/****** Object:  StoredProcedure [dbo].[spgetKhuVuc]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
							
/*--------- Hien thi thong tin KhuVuc ----------------*/
create procedure [dbo].[spgetKhuVuc]
as
Begin
	select * from KhuVuc
End

GO
/****** Object:  StoredProcedure [dbo].[spgetKhuVucByIdKhuVuc]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*----------- Hien thi thong tin KhuVuc bang IdKhuVuc --------------*/
create proc [dbo].[spgetKhuVucByIdKhuVuc]
(
	@IdKhuVuc		varchar (5)
)
as
begin
	select * from KhuVuc where IdKhuVuc = @IdKhuVuc
end

GO
/****** Object:  StoredProcedure [dbo].[spgetLoaiThucDon]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

						/*----------- BANG LOAITHUCDON --------------*/
						
/*--------- Hien thi thong tin LoaiThucDon ----------------*/
create procedure [dbo].[spgetLoaiThucDon]
as
Begin
	select * from LoaiThucDon
End

GO
/****** Object:  StoredProcedure [dbo].[spgetLoaiThucDonByIdLoaiThucDon]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*----------- Hien thi thong tin LoaiThucDon bang IdLoaiThucDon --------------*/
create procedure [dbo].[spgetLoaiThucDonByIdLoaiThucDon]
(
	@IdLoaiThucDon			varchar (5)
)
as
begin
	select * from LoaiThucDon where IdLoaiThucDon = @IdLoaiThucDon
end

GO
/****** Object:  StoredProcedure [dbo].[spgetNhanVien]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
						/*-- BANG NHAN VIEN  -- */
						
/*------------- Hien thi thong tin NhanVien -------------------*/
create procedure [dbo].[spgetNhanVien]
as
Begin
	select *from NhanVien
	--IdNhanVien as 'Id Nhân Viên ',HoLot + + Ten as ' Họ Tên ',Ngaysinh as 'Ngày Sinh',GioiTinh as 'Giới Tính',DienThoai as 'Điện Thoại',Email,DiaChi as 'Địa chỉ' 
End

GO
/****** Object:  StoredProcedure [dbo].[spgetNhanVienByIdNhanVien]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- drop procedure spgetNhanVien
/*----------- Hien thi thong tin NhanVien bang IdNhanVien --------------*/
create procedure [dbo].[spgetNhanVienByIdNhanVien]
(
	@IdNhanVien varchar(10)
)
as
Begin
	select * from NhanVien where IdNhanVien =@IdNhanVien
End


GO
/****** Object:  StoredProcedure [dbo].[spgetPhanQuyen]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- drop trigger  trigger_Valid_insertUpdateGoiMon


						/*----- BANG PHANQUYEN-----*/

/*--------- Hien thi thong tin PHANQUYEN ----------------*/
create procedure [dbo].[spgetPhanQuyen]
as
Begin
	select pq.IdTaiKhoan as 'Id Tài Khoản',MatKhau as 'Mật Khẩu',nv.IdNhanVien as 'Id Nhân Viên',HoLot + + Ten as 'Họ Tên'
	from PhanQuyen pq,NhanVien nv
	where pq.IdNhanVien = nv.IdNhanVien
End

GO
/****** Object:  StoredProcedure [dbo].[spgetPhanQuyenByIdTaiKhoan]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- drop procedure spgetPhanQuyen
/*----------- Hien thi thong tin spgetPhanQuyenByIdTaiKhoan --------------*/
create procedure [dbo].[spgetPhanQuyenByIdTaiKhoan]
(
	@IdTaiKhoan	varchar (10)
)
as
begin
	select pq.IdTaiKhoan,MatKhau,nv.IdNhanVien,HoLot + + Ten as 'Họ Tên'
	from PhanQuyen pq,NhanVien nv
	where IdTaiKhoan = @IdTaiKhoan
end

GO
/****** Object:  StoredProcedure [dbo].[spgetTenBan]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*-------------------- get TenBan  -------------------*/
create procedure [dbo].[spgetTenBan]
as
begin
	select TenBan from Ban
end

GO
/****** Object:  StoredProcedure [dbo].[spgetTenKhuVuc]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- drop procedure spDeleteBan
/* ----------------------- Get TenKhuVuc ------------------- */
create procedure [dbo].[spgetTenKhuVuc]
as
begin
	select TenKhuVuc from KhuVuc
end

GO
/****** Object:  StoredProcedure [dbo].[spgetTenLoaiThucDon]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/* ----------------------- Get TenLoaiThucDon ----------------*/
create procedure [dbo].[spgetTenLoaiThucDon]
as
begin
	select TenLoaiThucDon from LoaiThucDon
end

GO
/****** Object:  StoredProcedure [dbo].[spgetTenThucDon]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*-------------------- get TenThucDon -------------------*/
create procedure [dbo].[spgetTenThucDon]
as
begin
	select TenThucDon from ThucDon
end

GO
/****** Object:  StoredProcedure [dbo].[spgetThucDon]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--   drop proc spgetTenLoaiThucDon
-- drop procedure spgetTenLoaiThucDonByIdThucDon


							/*-- BANG THUC DON -- */
							
/*--------- Hien thi thong tin ThucDon ----------------*/
CREATE procedure [dbo].[spgetThucDon]
as
Begin
	select IdThucDon,TenLoaiThucDon,TenThucDon,DonViTinh,SoLuongTon,DonGiaTon,TrangThai,HinhAnh	
	from ThucDon
End
GO
/****** Object:  StoredProcedure [dbo].[spgetThucDonByIdThucDon]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- drop proc spgetThucDonNotTTT
/*----------- Hien thi thong tin ThucDon bang IdThucDon --------------*/
CREATE procedure [dbo].[spgetThucDonByIdThucDon]
(
	@IdThucDon		varchar (5)
)
as
begin
	select IdThucDon,TenLoaiThucDon,TenThucDon,DonViTinh,SoLuongTon,DonGiaTon,TrangThai,HinhAnh from ThucDon where IdThucDon = @IdThucDon
end

GO
/****** Object:  StoredProcedure [dbo].[spgetThucDonNotTTT]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- drop proc spgetThucDon

/*--------- Hien thi thong tin ThucDon NOT TonToiThieu ----------------*/
CREATE procedure [dbo].[spgetThucDonNotTTT]
as
Begin
	select IdThucDon,TenLoaiThucDon,TenThucDon,DonViTinh,SoLuongTon,DonGiaTon,TrangThai,HinhAnh
	from ThucDon
End

GO
/****** Object:  StoredProcedure [dbo].[spgetTien_BanGoiMon]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spgetTien_BanGoiMon]
(
@IdBan VARCHAR(50)
)
as
begin
	select sum(gm.DonGiaTon*gm.SoLuong)
from GoiMon gm
where gm.IdBan = @IdBan;
end
GO
/****** Object:  StoredProcedure [dbo].[spInsertBan]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- drop proc spgetBanByIdBan
/*---------------- Insert Ban -------------------*/
create procedure [dbo].[spInsertBan]
( 
		@IdBan			varchar (5) ,
		@TenKhuVuc		nvarchar(100) ,
		@TenBan			nvarchar(100),
		@DienGiai		nvarchar(100),
		@TrangThai		nvarchar(30)
)
as
Begin
	insert into Ban(IdBan,TenKhuVuc, TenBan, DienGiai, TrangThai)
	values(@IdBan,@TenKhuVuc,@TenBan,@DienGiai,@TrangThai)
End

GO
/****** Object:  StoredProcedure [dbo].[spInsertDangNhap]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--  drop procedure spInsertDangNhap

					/*-- BANG DANG NHAP -- */
					
/*-------------- Insert DangNhap -------------------------*/
create procedure [dbo].[spInsertDangNhap]
(
			@IdDangNhap			varchar(100),
			@MatKhau			varchar(200),
			@TrangThai			bit
)
as
Begin
		insert into DangNhap(IdDangNhap, MatKhau, TrangThai)
		values(@IdDangNhap, @MatKhau, @TrangThai)
End
-- Gọi lại thủ tục:
/*
execute spInsertDangNhap				@IdDangNhap='anh1' ,
										@MatKhau ='123',
										@TrangThai= 1

*/

/*------------- Doi mat khau DangNhap ----------------*/

GO
/****** Object:  StoredProcedure [dbo].[spInsertGoiMon]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- drop proc spgetGoiMonByIdBan
/*---------------- Insert GoiMon -------------------*/
create procedure [dbo].[spInsertGoiMon]
( 
		@IdBan				varchar (5),
		@TenThucDon			nvarchar(100),
		@DonGiaTon			decimal ,
		@SoLuong			int,
		@ThoiGian			datetime,
		@ThanhTien			decimal
)
as
Begin
	insert into GoiMon(IdBan,TenThucDon, DonGiaTon, SoLuong, ThoiGian,ThanhTien)
	values(@IdBan,@TenThucDon, @DonGiaTon, @SoLuong, @ThoiGian,@ThanhTien )
End

GO
/****** Object:  StoredProcedure [dbo].[spInsertHoaDon]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spInsertHoaDon]
( 
		@IdHoaDon			varchar(15) ,
		@IdBan		nvarchar(100),
		@NgayLap			datetime,
		@SoTien			decimal(10)
		
)
as
Begin
	insert into HoaDon(IdHoaDon,IdBan,NgayLap,SoTien)
	values(@IdHoaDon,@IdBan,@NgayLap,@SoTien)
End
GO
/****** Object:  StoredProcedure [dbo].[spInsertKhachHang]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*---------------- Insert KhachHang -------------------*/
CREATE procedure [dbo].[spInsertKhachHang]
( 
		@IdKhachHang			varchar(10),
		@TenKhachHang			nvarchar(100),
		@DienThoai				varchar(15),
		@Email					varchar(100),
		@DiaChi					nvarchar(100),
		@GioiTinh					nvarchar(15)
		
)
as
Begin
	insert into KhachHang(IdKhachHang, TenKhachHang, DienThoai, Email, DiaChi,GioiTinh)
	values(@IdKhachHang, @TenKhachHang, @DienThoai, @Email, @DiaChi,@GioiTinh)
End

GO
/****** Object:  StoredProcedure [dbo].[spInsertKhuVuc]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- drop proc spgetKhuVucByIdKhuVuc
/*---------------- Insert KhuVuc -------------------*/
create procedure [dbo].[spInsertKhuVuc]
( 
		@IdKhuVuc			varchar (5),
		@TenKhuVuc			nvarchar(100),
		@DienGiai			nvarchar(100),
		@TrangThai			nvarchar(30)
)
as
Begin
	insert into KhuVuc(IdKhuVuc, TenKhuVuc, DienGiai, TrangThai)
	values(@IdKhuVuc, @TenKhuVuc, @DienGiai, @TrangThai)
End

GO
/****** Object:  StoredProcedure [dbo].[spInsertLoaiThucDon]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- drop proc spgetLoaiThucDonByIdLoaiThucDon
/*---------------- Insert LoaiThucDon -------------------*/
create procedure [dbo].[spInsertLoaiThucDon]
( 
		@IdLoaiThucDon			varchar (5),
		@TenLoaiThucDon			nvarchar(100),
		@DienGiai				nvarchar(100),
		@TrangThai				nvarchar(30)
)
as
Begin
	insert into LoaiThucDon(IdLoaiThucDon,TenLoaiThucDon,DienGiai,TrangThai)
	values(@IdLoaiThucDon,@TenLoaiThucDon,@DienGiai,@TrangThai)
End

GO
/****** Object:  StoredProcedure [dbo].[spInsertNhanVien]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*-------------- Insert NhanVien -----------------------------*/
create procedure [dbo].[spInsertNhanVien]
( 
		@IdNhanVien			varchar(10),
		@HoLot				nvarchar(100),
		@Ten				nvarchar(100),
		@Ngaysinh			datetime,
		@GioiTinh			nvarchar(10),
		@DienThoai			varchar(15),
		@Email				varchar(100),
		@DiaChi				nvarchar(100)  
)
as
Begin
	insert into NhanVien(IdNhanVien, HoLot, Ten, Ngaysinh, GioiTinh, DienThoai,Email,DiaChi)
	values(@IdNhanVien, @HoLot, @Ten, @Ngaysinh, @GioiTinh, @DienThoai,@Email,@DiaChi)
End

GO
/****** Object:  StoredProcedure [dbo].[spInsertPhanQuyen]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 --drop proc spgetPhanQuyenByIdTaiKhoan
/*---------------- Insert PHANQUYEN -------------------*/
create procedure [dbo].[spInsertPhanQuyen]
( 
		@IdTaiKhoan			varchar (10),
		@MatKhau				varchar(200),
		@IdNhanVien			varchar(10)
)
as
Begin
	insert into PhanQuyen
	values(@IdTaiKhoan,@MatKhau,@IdNhanVien )
End

GO
/****** Object:  StoredProcedure [dbo].[spInsertThucDon]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*---------------- Insert ThucDon -------------------*/
CREATE procedure [dbo].[spInsertThucDon]
( 
		@IdThucDon			varchar(5) ,
		@TenLoaiThucDon		nvarchar(100),
		@TenThucDon			nvarchar(100),
		@DonViTinh			nvarchar(10),
		@SoLuongTon			float,
		@DonGiaTon			float,
	    @TrangThai			nvarchar(30),
		@HinhAnh            image
)
as
Begin
	insert into ThucDon(IdThucDon,TenLoaiThucDon,TenThucDon,DonViTinh,SoLuongTon,DonGiaTon,TrangThai,HinhAnh)
	values(@IdThucDon,@TenLoaiThucDon,@TenThucDon,@DonViTinh,@SoLuongTon,@DonGiaTon,@TrangThai,@HinhAnh)
End
GO
/****** Object:  StoredProcedure [dbo].[spSearchNVByIdNV]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*--------------TIM KIEM NHAN VIEN THEO IDNHANVIEN -----------*/
create procedure [dbo].[spSearchNVByIdNV]
(
	@IdNhanVien varchar (10)
)
as
Begin
	select *from NhanVien where IdNhanVien like  '%'+@IdNhanVien+'%'
End 

GO
/****** Object:  StoredProcedure [dbo].[spSearchNVByTenNV]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--drop  procedure spSearchNVByIdNV

/*--------------TIM KIEM NHAN VIEN THEO TEN -----------*/
create procedure [dbo].[spSearchNVByTenNV]
(
	@Ten			nvarchar(100)
)
as
Begin
	select *from NhanVien where Ten like  N'%'+@Ten+'%'
End 

GO
/****** Object:  StoredProcedure [dbo].[spSearchThucDonByTenLoaiThucDon]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spSearchThucDonByTenLoaiThucDon]

as
Begin
	select  DISTINCT b.TenLoaiThucDon 
	from ThucDon b,LoaiThucDon gm
	where b.TenLoaiThucDon = gm.TenLoaiThucDon 
	--ORDER BY b.TenLoaiThucDon 
	group BY b.TenLoaiThucDon 
	
End 
GO
/****** Object:  StoredProcedure [dbo].[spUpdateBan]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- DROP PROCEDURE spInsertBan
/*---------------- Update Ban -----------------*/
create procedure [dbo].[spUpdateBan]
(
		@IdBan			varchar (5) ,
		@TenKhuVuc		nvarchar(100) ,
		@TenBan			nvarchar(100),
		@DienGiai		nvarchar(100),
		@TrangThai		nvarchar(30)
)
as
Begin
	update Ban set		
						
						TenKhuVuc = @TenKhuVuc,
						TenBan=@TenBan,
						DienGiai=@DienGiai,
						TrangThai=@TrangThai						 
		where IdBan=@IdBan
End

GO
/****** Object:  StoredProcedure [dbo].[spUpdateDangNhap_MatKhau]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spUpdateDangNhap_MatKhau]
(
			@IdDangNhap	varchar(100),
			@MatKhau		    varchar(250)				
)
as
Begin
		   update DangNhap set MatKhau=@MatKhau
		   where IdDangNhap = @IdDangNhap
End

/*---------------- Xoa DangNhap -------------------------*/

GO
/****** Object:  StoredProcedure [dbo].[spUpdateGoiMon]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- DROP PROCEDURE spInsertGoiMon
/*---------------- Update GoiMon -----------------*/
create procedure [dbo].[spUpdateGoiMon]
(		
		@IdBan				varchar (5),
		@TenThucDon			nvarchar(100),
		@DonGiaTon			decimal ,
		@SoLuong			int,
		@ThoiGian			datetime,
		@ThanhTien			decimal
)
as
Begin
	update GoiMon set	
						TenThucDon = @TenThucDon,
						DonGiaTon=@DonGiaTon,
						SoLuong=@SoLuong,
						ThoiGian=@ThoiGian,
						ThanhTien=@ThanhTien
	where IdBan = @IdBan			 
End

GO
/****** Object:  StoredProcedure [dbo].[spUpdateKhachHang]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spUpdateKhachHang]
(
		@IdKhachHang			varchar(10),
		@TenKhachHang			nvarchar(100),
		@DienThoai				varchar(15),
		@Email					varchar(100),
		@DiaChi					nvarchar(100),
		@GioiTinh nvarchar(15)
)
as
Begin
	update Khachhang set 
						TenKhachHang = @TenKhachHang,
						DienThoai =@DienThoai,
						Email	=@Email,
						DiaChi	=@DiaChi,
						GioiTinh=@GioiTinh
											 
		where IdKhachHang =@IdKhachHang
End
GO
/****** Object:  StoredProcedure [dbo].[spUpdateKhuVuc]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- DROP PROCEDURE spInsertKhuVuc
/*---------------- Update KhuVuc -----------------*/
create procedure [dbo].[spUpdateKhuVuc]
(
		@IdKhuVuc			varchar (5) ,
		@TenKhuVuc			nvarchar(100),
		@DienGiai			nvarchar(100),
		@TrangThai			nvarchar(30)
)
as
Begin
	update KhuVuc set 
						TenKhuVuc=@TenKhuVuc,
						DienGiai=@DienGiai,
						TrangThai=@TrangThai						 
		where IdKhuVuc =@IdKhuVuc
End

GO
/****** Object:  StoredProcedure [dbo].[spUpdateLoaiThucDon]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- DROP PROCEDURE spInsertLoaiThucDon
/*---------------- Update LoaiThucDon -----------------*/
create procedure [dbo].[spUpdateLoaiThucDon]
(
		@IdLoaiThucDon			varchar (5),
		@TenLoaiThucDon			nvarchar(100),
		@DienGiai				nvarchar(100),
		@TrangThai				nvarchar(30)
)
as
Begin
	update LoaiThucDon set 
						TenLoaiThucDon=@TenLoaiThucDon,
						DienGiai=@DienGiai,
						TrangThai=@TrangThai						 
		where IdLoaiThucDon =@IdLoaiThucDon
End

GO
/****** Object:  StoredProcedure [dbo].[spUpdateNhanVien]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*------------------- Update NhanVien -----------------------*/
create procedure [dbo].[spUpdateNhanVien]
(
		@IdNhanVien			varchar(10),
		@HoLot				nvarchar(100),
		@Ten				nvarchar(100),
		@Ngaysinh			datetime,
		@GioiTinh			nvarchar(10),
		@DienThoai			varchar(15),
		@Email				varchar(100),
		@DiaChi				nvarchar(100)  	 
)
as
Begin
	update NhanVien set 
						HoLot = @HoLot,
						Ten =@Ten,
						Ngaysinh =@Ngaysinh,
						GioiTinh =@GioiTinh,
						DienThoai =@DienThoai,
						Email	=@Email,
						DiaChi	=@DiaChi
											 
		where IdNhanVien =@IdNhanVien
End

GO
/****** Object:  StoredProcedure [dbo].[spUpdatePhanQuyen]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- DROP PROCEDURE spInsertPhanQuyen
/*---------------- Update PHANQUYEN -----------------*/
create procedure [dbo].[spUpdatePhanQuyen]
(		
		@IdTaiKhoan			varchar (10),
		@MatKhau			varchar(200),
		@IdNhanVien			varchar(10)
)
as
Begin
	update PhanQuyen set	
						MatKhau = @MatKhau,
						IdNhanVien=@IdNhanVien
	where IdTaiKhoan = @IdTaiKhoan	 
End

GO
/****** Object:  StoredProcedure [dbo].[spUpdateThucDon]    Script Date: 6/8/2021 2:23:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- DROP PROCEDURE spgetThucDon
/*---------------- Update ThucDon -----------------*/
CREATE procedure [dbo].[spUpdateThucDon]
(
		@IdThucDon			varchar(5) ,
		@TenLoaiThucDon		nvarchar(100),
		@TenThucDon			nvarchar(100),
		@DonViTinh			nvarchar(10),
		@SoLuongTon			float,
		@DonGiaTon			float,
		
		@TrangThai			nvarchar(30),
		@HinhAnh image
)
as
Begin
	update ThucDon set 
						TenLoaiThucDon=@TenLoaiThucDon,
						TenThucDon=@TenThucDon,
						DonViTinh=@DonViTinh,
						SoLuongTon=@SoLuongTon,
						DonGiaTon=@DonGiaTon,
						
						TrangThai=@TrangThai,
						HinhAnh=@HinhAnh
											 
		where IdThucDon =@IdThucDon
End

GO
