USE [FLIGHT]
GO
/****** Object:  User [usrPruebas]    Script Date: 2021/11/21 5:46:03 p. m. ******/
CREATE USER [usrPruebas] FOR LOGIN [usrPruebas] WITH DEFAULT_SCHEMA=[dbo]
GO
sys.sp_addrolemember @rolename = N'db_owner', @membername = N'usrPruebas'
GO
/****** Object:  Table [dbo].[IATAC]    Script Date: 2021/11/21 5:46:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IATAC](
	[Code] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](100) NULL,
 CONSTRAINT [PK_IATAC] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservation]    Script Date: 2021/11/21 5:46:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DepartureStation] [nvarchar](50) NULL,
	[ArrivalStation] [nvarchar](50) NULL,
	[DepartureDate] [datetime] NULL,
	[Transport] [nvarchar](50) NULL,
	[Price] [numeric](18, 2) NULL,
	[Currency] [nvarchar](50) NULL,
	[Number] [nvarchar](50) NULL,
 CONSTRAINT [PK_Reservation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[IATAC] ([Code], [Name]) VALUES (N'BOG', N'BOGOTA')
INSERT [dbo].[IATAC] ([Code], [Name]) VALUES (N'CTG', N'CARTAGENA')
INSERT [dbo].[IATAC] ([Code], [Name]) VALUES (N'MDE', N'MEDELLIN')
INSERT [dbo].[IATAC] ([Code], [Name]) VALUES (N'PEI', N'PEREIRA')
GO
ALTER TABLE [dbo].[Reservation]  WITH CHECK ADD  CONSTRAINT [FK_Reservation_IATAC] FOREIGN KEY([DepartureStation])
REFERENCES [dbo].[IATAC] ([Code])
GO
ALTER TABLE [dbo].[Reservation] CHECK CONSTRAINT [FK_Reservation_IATAC]
GO
ALTER TABLE [dbo].[Reservation]  WITH CHECK ADD  CONSTRAINT [FK_Reservation_IATAC1] FOREIGN KEY([DepartureStation])
REFERENCES [dbo].[IATAC] ([Code])
GO
ALTER TABLE [dbo].[Reservation] CHECK CONSTRAINT [FK_Reservation_IATAC1]
GO
/****** Object:  StoredProcedure [dbo].[sp_GetIATA]    Script Date: 2021/11/21 5:46:03 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author		: Carlos Giraldo
-- Create date	: 2021-11-21
-- Description	: Allow to consult the IATA Table
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetIATA]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	SET NOCOUNT ON;

	SELECT  Code, Name
	FROM IATAC
END
GO
