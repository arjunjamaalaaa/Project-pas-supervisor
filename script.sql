USE [db_multiUser]
GO
/****** Object:  Table [dbo].[tbl_supervisi]    Script Date: 07/02/2022 16:20:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_supervisi]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_supervisi]
GO
/****** Object:  Table [dbo].[tbl_jadwal]    Script Date: 07/02/2022 16:20:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_jadwal]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_jadwal]
GO
/****** Object:  Table [dbo].[tbl_dokumen]    Script Date: 07/02/2022 16:20:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_dokumen]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_dokumen]
GO
/****** Object:  Table [dbo].[table_teachers]    Script Date: 07/02/2022 16:20:26 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[table_teachers]') AND type in (N'U'))
DROP TABLE [dbo].[table_teachers]
GO
/****** Object:  Table [dbo].[table_teachers]    Script Date: 07/02/2022 16:20:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[table_teachers](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[nip] [bigint] NOT NULL,
	[nama] [varchar](50) NOT NULL,
	[alamat] [varchar](max) NULL,
	[email] [varchar](50) NOT NULL,
	[jabatan1] [varchar](50) NULL,
	[jabatan2] [varchar](50) NULL,
	[supervisor] [varchar](5) NULL,
	[password] [varchar](50) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_dokumen]    Script Date: 07/02/2022 16:20:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_dokumen](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nip] [varchar](50) NOT NULL,
	[mapel] [varchar](50) NOT NULL,
	[rpp] [varchar](max) NOT NULL,
	[embed] [varchar](100) NOT NULL,
	[catatan] [varchar](max) NULL,
	[status] [varchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_jadwal]    Script Date: 07/02/2022 16:20:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_jadwal](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[tanggal] [varchar](50) NOT NULL,
	[jam] [varchar](50) NOT NULL,
	[nip] [varchar](50) NOT NULL,
	[id_supervisor] [varchar](50) NOT NULL,
	[ruangan] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_supervisi]    Script Date: 07/02/2022 16:20:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_supervisi](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nip] [varchar](50) NULL,
	[id_supervisor] [varchar](50) NULL,
	[id_jadwal] [varchar](50) NULL,
	[id_dokumen] [varchar](50) NULL,
	[catatan] [varchar](max) NULL,
	[status] [varchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[table_teachers] ON 

INSERT [dbo].[table_teachers] ([id], [nip], [nama], [alamat], [email], [jabatan1], [jabatan2], [supervisor], [password]) VALUES (3, 111, N'arjun', N'cikeas', N'arjun@gmail.com', N'guru/laboran', N'kurikulum', N'yes', N'111')
INSERT [dbo].[table_teachers] ([id], [nip], [nama], [alamat], [email], [jabatan1], [jabatan2], [supervisor], [password]) VALUES (7, 123, N'jamaala', N'jakarta', N'jamal@gmail.com', N'guru/laboran', N'', N'', N'123')
INSERT [dbo].[table_teachers] ([id], [nip], [nama], [alamat], [email], [jabatan1], [jabatan2], [supervisor], [password]) VALUES (8, 520, N'yayat', N'bandung', N'yayat@gmail.com', N'', N'kepala sekolah', N'', N'520')
INSERT [dbo].[table_teachers] ([id], [nip], [nama], [alamat], [email], [jabatan1], [jabatan2], [supervisor], [password]) VALUES (6, 114, N'kolot', N'bandung', N'koo@gmail.com', N'guru/laboran', N'kurikulum', N'yes', N'114')
SET IDENTITY_INSERT [dbo].[table_teachers] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_dokumen] ON 

INSERT [dbo].[tbl_dokumen] ([id], [nip], [mapel], [rpp], [embed], [catatan], [status]) VALUES (4, N'123', N'Sunda', N'C:\Users\Arjun\Downloads\Cara-Insert-Update-Delete-file-PDF-dengan-vb.net.pdf', N'https://www.tokopedia.com/search?st=product&q=custom%20patch%20varsity&srp_component_id=02.01.00.00', N'test 1', N'lulus')
SET IDENTITY_INSERT [dbo].[tbl_dokumen] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_jadwal] ON 

INSERT [dbo].[tbl_jadwal] ([id], [tanggal], [jam], [nip], [id_supervisor], [ruangan]) VALUES (2, N'15/46/2022', N'08:00-09:00', N'123', N'6', N'Tefa Hotel')
SET IDENTITY_INSERT [dbo].[tbl_jadwal] OFF
GO
