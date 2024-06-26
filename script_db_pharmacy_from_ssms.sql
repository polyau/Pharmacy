USE [master]
GO
/****** Object:  Database [Pharmacy]    Script Date: 20.03.2024 21:43:35 ******/
CREATE DATABASE [Pharmacy]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Pharmacy', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Pharmacy.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Pharmacy_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Pharmacy_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Pharmacy] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Pharmacy].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Pharmacy] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Pharmacy] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Pharmacy] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Pharmacy] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Pharmacy] SET ARITHABORT OFF 
GO
ALTER DATABASE [Pharmacy] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Pharmacy] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Pharmacy] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Pharmacy] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Pharmacy] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Pharmacy] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Pharmacy] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Pharmacy] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Pharmacy] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Pharmacy] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Pharmacy] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Pharmacy] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Pharmacy] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Pharmacy] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Pharmacy] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Pharmacy] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Pharmacy] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Pharmacy] SET RECOVERY FULL 
GO
ALTER DATABASE [Pharmacy] SET  MULTI_USER 
GO
ALTER DATABASE [Pharmacy] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Pharmacy] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Pharmacy] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Pharmacy] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Pharmacy] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Pharmacy] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Pharmacy', N'ON'
GO
ALTER DATABASE [Pharmacy] SET QUERY_STORE = ON
GO
ALTER DATABASE [Pharmacy] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Pharmacy]
GO
/****** Object:  Schema [Pharmacy]    Script Date: 20.03.2024 21:43:36 ******/
CREATE SCHEMA [Pharmacy]
GO
/****** Object:  UserDefinedFunction [dbo].[checkBarcode]    Script Date: 20.03.2024 21:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[checkBarcode] (@barcode CHAR(13))
RETURNS INT 
AS
BEGIN
	DECLARE @res int

    SELECT @res = COUNT(*) FROM Product
    WHERE Barcode = @barcode

    RETURN @res
END
GO
/****** Object:  UserDefinedFunction [dbo].[checkStock]    Script Date: 20.03.2024 21:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[checkStock] (@barcode CHAR(13))
RETURNS INT 
AS
BEGIN
	DECLARE @res int
	SELECT @res = InStock FROM Product WHERE Barcode = @barcode
	RETURN @res
END
GO
/****** Object:  UserDefinedFunction [dbo].[getProductInfo]    Script Date: 20.03.2024 21:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[getProductInfo] (@barcode CHAR(13))
RETURNS VARCHAR(205)
AS
BEGIN
    DECLARE @productInfo VARCHAR(205)

    SELECT @productInfo = CONCAT(Brand, ' ', NameProduct, ' ', Price, ' руб')
    FROM Product WHERE Barcode = @barcode

    RETURN @productInfo
END
GO
/****** Object:  Table [dbo].[Product]    Script Date: 20.03.2024 21:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Barcode] [char](13) NOT NULL,
	[СodeСategory] [tinyint] NOT NULL,
	[Brand] [varchar](30) NOT NULL,
	[NameProduct] [varchar](170) NOT NULL,
	[Price] [money] NOT NULL,
	[MinReserve] [smallint] NULL,
	[InStock] [smallint] NOT NULL,
 CONSTRAINT [PK__Product__2E46E6993A275C83] PRIMARY KEY CLUSTERED 
(
	[Barcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DeleteProduct]    Script Date: 20.03.2024 21:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeleteProduct](
	[Ndelete] [smallint] NOT NULL,
	[Barcode] [char](13) NOT NULL,
	[Quantity] [smallint] NOT NULL,
	[DateDelete] [date] NOT NULL,
	[WhyDelete] [varchar](60) NOT NULL,
 CONSTRAINT [PK__DeletePr__3B69A4676ACF032A] PRIMARY KEY CLUSTERED 
(
	[Ndelete] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[deleteProductForWF]    Script Date: 20.03.2024 21:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[deleteProductForWF] AS
SELECT dbo.DeleteProduct.Ndelete, dbo.DeleteProduct.Barcode, dbo.Product.Brand, dbo.Product.NameProduct, dbo.DeleteProduct.Quantity, dbo.DeleteProduct.DateDelete, dbo.DeleteProduct.WhyDelete
FROM     dbo.DeleteProduct INNER JOIN
                  dbo.Product ON dbo.DeleteProduct.Barcode = dbo.Product.Barcode
GO
/****** Object:  Table [dbo].[StructSell]    Script Date: 20.03.2024 21:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StructSell](
	[Nrec] [smallint] NOT NULL,
	[Barcode] [char](13) NOT NULL,
	[Quantity] [smallint] NOT NULL,
	[TotalCost] [money] NOT NULL,
 CONSTRAINT [PK__StructSe__F907C6067A3047E4] PRIMARY KEY CLUSTERED 
(
	[Nrec] ASC,
	[Barcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sotr]    Script Date: 20.03.2024 21:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sotr](
	[idSotr] [smallint] NOT NULL,
	[Fio] [varchar](60) NOT NULL,
	[Position] [varchar](40) NOT NULL,
	[Email] [varchar](50) NULL,
	[PhoneNum] [varchar](15) NULL,
 CONSTRAINT [PK__Sotr__6B50870129114B18] PRIMARY KEY CLUSTERED 
(
	[idSotr] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__Sotr__DF8F1A02AA0C7BC7] UNIQUE NONCLUSTERED 
(
	[PhoneNum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sell]    Script Date: 20.03.2024 21:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sell](
	[Nreceipt] [smallint] NOT NULL,
	[id_sotr] [smallint] NOT NULL,
	[DateSell] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Nreceipt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[viewSell]    Script Date: 20.03.2024 21:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[viewSell] AS
SELECT dbo.Sell.Nreceipt, dbo.Sotr.Fio, dbo.Sell.DateSell, dbo.StructSell.Barcode, dbo.Product.Brand, dbo.Product.NameProduct, dbo.StructSell.Quantity, dbo.StructSell.TotalCost
FROM     dbo.Sotr INNER JOIN
                  dbo.Sell ON dbo.Sotr.idSotr = dbo.Sell.id_sotr INNER JOIN
                  dbo.StructSell ON dbo.Sell.Nreceipt = dbo.StructSell.Nrec INNER JOIN
                  dbo.Product ON dbo.StructSell.Barcode = dbo.Product.Barcode
GO
/****** Object:  Table [dbo].[Purchase]    Script Date: 20.03.2024 21:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purchase](
	[OrderCode] [int] NOT NULL,
	[СodePurv] [smallint] NOT NULL,
	[id_sotr] [smallint] NOT NULL,
	[DateExe] [date] NOT NULL,
	[DelivPrice] [money] NULL,
 CONSTRAINT [PK__Purchase__999B5228D9E92744] PRIMARY KEY CLUSTERED 
(
	[OrderCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StructPurchase]    Script Date: 20.03.2024 21:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StructPurchase](
	[OrderCode] [int] NOT NULL,
	[Barcode] [char](13) NOT NULL,
	[ValidFor] [date] NULL,
	[UnitPrice] [money] NOT NULL,
	[QuantityOrd] [smallint] NOT NULL,
	[QuantityReceiv] [smallint] NULL,
 CONSTRAINT [PK__StructPu__1B7F3C4156356479] PRIMARY KEY CLUSTERED 
(
	[OrderCode] ASC,
	[Barcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Purveyor]    Script Date: 20.03.2024 21:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purveyor](
	[СodePurveyor] [smallint] NOT NULL,
	[NamePurveyor] [varchar](20) NOT NULL,
	[ContactPerson] [varchar](50) NOT NULL,
	[Country] [varchar](30) NOT NULL,
	[Sity] [varchar](30) NOT NULL,
	[Address] [varchar](100) NOT NULL,
	[PhoneNum] [varchar](20) NOT NULL,
	[TermsPay] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[СodePurveyor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[viewPurchase]    Script Date: 20.03.2024 21:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[viewPurchase] AS
SELECT dbo.Purchase.OrderCode, dbo.Purveyor.NamePurveyor, dbo.Sotr.Fio, dbo.Purchase.DateExe, dbo.Purchase.DelivPrice, dbo.StructPurchase.Barcode, dbo.Product.Brand, dbo.Product.NameProduct, dbo.StructPurchase.UnitPrice, 
                  dbo.StructPurchase.QuantityOrd
FROM     dbo.Purveyor INNER JOIN
                  dbo.Purchase ON dbo.Purveyor.СodePurveyor = dbo.Purchase.СodePurv INNER JOIN
                  dbo.Sotr ON dbo.Purchase.id_sotr = dbo.Sotr.idSotr INNER JOIN
                  dbo.StructPurchase ON dbo.Purchase.OrderCode = dbo.StructPurchase.OrderCode INNER JOIN
                  dbo.Product ON dbo.StructPurchase.Barcode = dbo.Product.Barcode
GO
/****** Object:  UserDefinedFunction [dbo].[getPurveyor]    Script Date: 20.03.2024 21:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[getPurveyor]()
RETURNS TABLE 
AS
RETURN 
(
	SELECT NamePurveyor FROM Purveyor
)
GO
/****** Object:  Table [dbo].[Analog]    Script Date: 20.03.2024 21:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Analog](
	[Barcode] [char](13) NOT NULL,
	[BarcodeAnalog] [char](13) NOT NULL,
 CONSTRAINT [PK__Analog__1BA38494F005FA64] PRIMARY KEY CLUSTERED 
(
	[Barcode] ASC,
	[BarcodeAnalog] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[findAnalogs]    Script Date: 20.03.2024 21:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[findAnalogs] (@Barcode CHAR(13))
RETURNS TABLE
AS
RETURN
(
    SELECT Product.Barcode AS Штрихкод, Brand AS Бренд, NameProduct AS Название, Price AS Цена, InStock AS 'В наличии'
    FROM Product
    INNER JOIN Analog ON Product.Barcode = Analog.BarcodeAnalog
    WHERE Analog.Barcode = @Barcode
)
GO
/****** Object:  Table [dbo].[Medicament]    Script Date: 20.03.2024 21:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicament](
	[СodeMedicament] [smallint] NOT NULL,
	[Barcode] [char](13) NOT NULL,
	[PharmGroup] [varchar](50) NOT NULL,
	[Exp] [varchar](20) NOT NULL,
	[Notes] [varchar](150) NULL,
	[Effect] [varchar](50) NULL,
	[ActiveSubstance] [varchar](70) NOT NULL,
	[ReleaseForm] [varchar](80) NOT NULL,
	[Dosage] [varchar](50) NULL,
	[Quantity] [tinyint] NULL,
	[Volume] [varchar](15) NULL,
	[Composition] [varchar](400) NOT NULL,
	[Country] [varchar](30) NULL,
	[Manufactur] [varchar](70) NOT NULL,
 CONSTRAINT [PK__Medicame__AD17978209DE7BCC] PRIMARY KEY CLUSTERED 
(
	[СodeMedicament] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[seeDescriptionOfMedicament]    Script Date: 20.03.2024 21:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[seeDescriptionOfMedicament] (@barcode CHAR(13))
RETURNS TABLE 
AS
RETURN 
(
	SELECT PharmGroup AS 'Фарм.группа', 
		   Exp AS 'Срок годности', 
		   Notes AS Примечания, 
		   Effect AS Эффект, 
		   ActiveSubstance AS 'Действующее вещество', 
		   ReleaseForm AS 'Форма выпуска', 
		   Dosage AS Дозировка, 
		   Quantity AS Количество, 
		   Volume AS Объем, 
		   Composition AS Состав, 
		   Country AS Страна, 
		   Manufactur AS Производитель
	FROM Medicament WHERE Barcode = @barcode
)
GO
/****** Object:  Table [dbo].[Category]    Script Date: 20.03.2024 21:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[СodeСategory] [tinyint] NOT NULL,
	[NameCategory] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[СodeСategory] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[tableProduct]    Script Date: 20.03.2024 21:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[tableProduct] 
AS
SELECT dbo.Product.Barcode, dbo.Category.NameCategory, dbo.Product.Brand, dbo.Product.NameProduct, dbo.Product.Price, dbo.Product.MinReserve, dbo.Product.InStock
FROM     dbo.Category INNER JOIN
                  dbo.Product ON dbo.Category.СodeСategory = dbo.Product.СodeСategory
GO
ALTER TABLE [dbo].[DeleteProduct] ADD  CONSTRAINT [DF_DeleteProduct_Quantity]  DEFAULT ((1)) FOR [Quantity]
GO
ALTER TABLE [dbo].[DeleteProduct] ADD  CONSTRAINT [DF_DeleteProduct_DateDelete]  DEFAULT (getdate()) FOR [DateDelete]
GO
ALTER TABLE [dbo].[DeleteProduct] ADD  CONSTRAINT [DF__DeletePro__WhyDe__4BAC3F29]  DEFAULT ('Истекает срок годности') FOR [WhyDelete]
GO
ALTER TABLE [dbo].[Medicament] ADD  CONSTRAINT [DF__Medicament__Exp__0DAF0CB0]  DEFAULT ('Более 12 месяцев') FOR [Exp]
GO
ALTER TABLE [dbo].[Medicament] ADD  CONSTRAINT [DF_Medicament_Notes]  DEFAULT ('Беречь от детей') FOR [Notes]
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_InStock]  DEFAULT ((0)) FOR [InStock]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF_Purchase_DateExe]  DEFAULT (getdate()) FOR [DateExe]
GO
ALTER TABLE [dbo].[Purchase] ADD  CONSTRAINT [DF__Purchase__DelivP__4D94879B]  DEFAULT ('0') FOR [DelivPrice]
GO
ALTER TABLE [dbo].[Purveyor] ADD  DEFAULT ('Россия') FOR [Country]
GO
ALTER TABLE [dbo].[Sell] ADD  CONSTRAINT [DF_Sell_DateSell]  DEFAULT (getdate()) FOR [DateSell]
GO
ALTER TABLE [dbo].[StructPurchase] ADD  CONSTRAINT [DF_StructPurchase_QuantityOrd]  DEFAULT ((0)) FOR [QuantityOrd]
GO
ALTER TABLE [dbo].[StructPurchase] ADD  CONSTRAINT [DF_StructPurchase_QuantityReceiv]  DEFAULT ((0)) FOR [QuantityReceiv]
GO
ALTER TABLE [dbo].[StructSell] ADD  CONSTRAINT [DF__StructSel__Quant__4F7CD00D]  DEFAULT ('1') FOR [Quantity]
GO
ALTER TABLE [dbo].[Analog]  WITH CHECK ADD  CONSTRAINT [FK__Analog__id_Prod__5070F446] FOREIGN KEY([Barcode])
REFERENCES [dbo].[Product] ([Barcode])
GO
ALTER TABLE [dbo].[Analog] CHECK CONSTRAINT [FK__Analog__id_Prod__5070F446]
GO
ALTER TABLE [dbo].[Analog]  WITH CHECK ADD  CONSTRAINT [FK__Analog__id_ProdA__5165187F] FOREIGN KEY([BarcodeAnalog])
REFERENCES [dbo].[Product] ([Barcode])
GO
ALTER TABLE [dbo].[Analog] CHECK CONSTRAINT [FK__Analog__id_ProdA__5165187F]
GO
ALTER TABLE [dbo].[DeleteProduct]  WITH CHECK ADD  CONSTRAINT [FK_DeleteProduct_Product] FOREIGN KEY([Barcode])
REFERENCES [dbo].[Product] ([Barcode])
GO
ALTER TABLE [dbo].[DeleteProduct] CHECK CONSTRAINT [FK_DeleteProduct_Product]
GO
ALTER TABLE [dbo].[Medicament]  WITH CHECK ADD  CONSTRAINT [FK_Medicament_Product] FOREIGN KEY([Barcode])
REFERENCES [dbo].[Product] ([Barcode])
GO
ALTER TABLE [dbo].[Medicament] CHECK CONSTRAINT [FK_Medicament_Product]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([СodeСategory])
REFERENCES [dbo].[Category] ([СodeСategory])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category]
GO
ALTER TABLE [dbo].[Purchase]  WITH CHECK ADD  CONSTRAINT [FK__Purchase__id_Sot__571DF1D5] FOREIGN KEY([id_sotr])
REFERENCES [dbo].[Sotr] ([idSotr])
GO
ALTER TABLE [dbo].[Purchase] CHECK CONSTRAINT [FK__Purchase__id_Sot__571DF1D5]
GO
ALTER TABLE [dbo].[Purchase]  WITH CHECK ADD  CONSTRAINT [FK__Purchase__СodePu__5812160E] FOREIGN KEY([СodePurv])
REFERENCES [dbo].[Purveyor] ([СodePurveyor])
GO
ALTER TABLE [dbo].[Purchase] CHECK CONSTRAINT [FK__Purchase__СodePu__5812160E]
GO
ALTER TABLE [dbo].[Sell]  WITH CHECK ADD  CONSTRAINT [FK__Sell__id_Sotr__59063A47] FOREIGN KEY([id_sotr])
REFERENCES [dbo].[Sotr] ([idSotr])
GO
ALTER TABLE [dbo].[Sell] CHECK CONSTRAINT [FK__Sell__id_Sotr__59063A47]
GO
ALTER TABLE [dbo].[StructPurchase]  WITH CHECK ADD  CONSTRAINT [FK__StructPur__id_Pr__59FA5E80] FOREIGN KEY([Barcode])
REFERENCES [dbo].[Product] ([Barcode])
GO
ALTER TABLE [dbo].[StructPurchase] CHECK CONSTRAINT [FK__StructPur__id_Pr__59FA5E80]
GO
ALTER TABLE [dbo].[StructPurchase]  WITH CHECK ADD  CONSTRAINT [FK__StructPur__Order__5AEE82B9] FOREIGN KEY([OrderCode])
REFERENCES [dbo].[Purchase] ([OrderCode])
GO
ALTER TABLE [dbo].[StructPurchase] CHECK CONSTRAINT [FK__StructPur__Order__5AEE82B9]
GO
ALTER TABLE [dbo].[StructSell]  WITH CHECK ADD  CONSTRAINT [FK__StructSel__id_Pr__5BE2A6F2] FOREIGN KEY([Barcode])
REFERENCES [dbo].[Product] ([Barcode])
GO
ALTER TABLE [dbo].[StructSell] CHECK CONSTRAINT [FK__StructSel__id_Pr__5BE2A6F2]
GO
ALTER TABLE [dbo].[StructSell]  WITH CHECK ADD  CONSTRAINT [FK__StructSell__Nrec__5CD6CB2B] FOREIGN KEY([Nrec])
REFERENCES [dbo].[Sell] ([Nreceipt])
GO
ALTER TABLE [dbo].[StructSell] CHECK CONSTRAINT [FK__StructSell__Nrec__5CD6CB2B]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [CK__Product__InStock__5DCAEF64] CHECK  (([InStock]>=(0)))
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [CK__Product__InStock__5DCAEF64]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [CK__Product__Price__5EBF139D] CHECK  (([Price]>=(0)))
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [CK__Product__Price__5EBF139D]
GO
ALTER TABLE [dbo].[Purchase]  WITH CHECK ADD  CONSTRAINT [CK__Purchase__DelivP__5FB337D6] CHECK  (([DelivPrice]>=(0)))
GO
ALTER TABLE [dbo].[Purchase] CHECK CONSTRAINT [CK__Purchase__DelivP__5FB337D6]
GO
ALTER TABLE [dbo].[StructPurchase]  WITH CHECK ADD  CONSTRAINT [CK__StructPur__Quant__60A75C0F] CHECK  (([QuantityOrd]>=(0)))
GO
ALTER TABLE [dbo].[StructPurchase] CHECK CONSTRAINT [CK__StructPur__Quant__60A75C0F]
GO
ALTER TABLE [dbo].[StructPurchase]  WITH CHECK ADD  CONSTRAINT [CK__StructPur__Quant__619B8048] CHECK  (([QuantityReceiv]>=(0)))
GO
ALTER TABLE [dbo].[StructPurchase] CHECK CONSTRAINT [CK__StructPur__Quant__619B8048]
GO
ALTER TABLE [dbo].[StructPurchase]  WITH CHECK ADD  CONSTRAINT [CK__StructPur__UnitP__628FA481] CHECK  (([UnitPrice]>=(0)))
GO
ALTER TABLE [dbo].[StructPurchase] CHECK CONSTRAINT [CK__StructPur__UnitP__628FA481]
GO
ALTER TABLE [dbo].[StructSell]  WITH CHECK ADD  CONSTRAINT [CK__StructSel__Quant__6383C8BA] CHECK  (([Quantity]>(0)))
GO
ALTER TABLE [dbo].[StructSell] CHECK CONSTRAINT [CK__StructSel__Quant__6383C8BA]
GO
/****** Object:  StoredProcedure [dbo].[addMedicament]    Script Date: 20.03.2024 21:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[addMedicament]
(
    @barcode CHAR(13),
    @pharmGroup varchar(50),
    @exp VARCHAR(20),
    @notes VARCHAR(150),
    @effect VARCHAR(50),
    @activeSubstance VARCHAR(70),
    @releaseForm VARCHAR(80),
	@dosage VARCHAR(50),
	@quantity TINYINT,
	@volume VARCHAR(15),
	@composition VARCHAR(400),
	@country VARCHAR(30),
	@manufactur VARCHAR(70)
)
AS
BEGIN
	DECLARE @codeMedicament SMALLINT
	SELECT @codeMedicament = (MAX(СodeMedicament) + 1) FROM Medicament

    INSERT INTO Medicament (СodeMedicament, Barcode, PharmGroup, Exp, Notes, Effect, ActiveSubstance, ReleaseForm, Dosage, Quantity, Volume, Composition, Country, Manufactur)
    VALUES (@codeMedicament, @barcode, @pharmGroup, @exp, @notes, @effect, @activeSubstance, @releaseForm, @dosage, @quantity, @volume, @composition, @country, @manufactur)
END
GO
/****** Object:  StoredProcedure [dbo].[addNewProduct]    Script Date: 20.03.2024 21:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[addNewProduct]
(
    @barcode CHAR(13),
    @nameCategory VARCHAR(30),
    @brand VARCHAR(30),
    @nameProduct VARCHAR(170),
    @price MONEY,
    @minReserve SMALLINT,
    @inStock SMALLINT
)
AS
BEGIN
	DECLARE @codeСategory TINYINT
	SELECT @codeСategory = СodeСategory FROM Category WHERE @nameCategory = NameCategory 

    INSERT INTO Product (Barcode, СodeСategory, Brand, NameProduct, Price, MinReserve, InStock)
    VALUES (@barcode, @codeСategory, @brand, @nameProduct, @price, @minReserve, @inStock)
END
GO
/****** Object:  StoredProcedure [dbo].[addNewSotr]    Script Date: 20.03.2024 21:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[addNewSotr]
(
    @fio VARCHAR(60),
    @position VARCHAR(40),
    @email VARCHAR(50),
    @phoneNum VARCHAR(15)
)
AS
BEGIN
	 DECLARE @maxIdSotr SMALLINT;
  -- Получаем максимальное значение idSotr из таблицы Sotr
	SELECT @maxIdSotr = MAX(idSotr) FROM Sotr;

    INSERT INTO Sotr (idSotr, Fio, Position, Email, PhoneNum)
    VALUES (@maxIdSotr + 1, @fio, @position, @email, @phoneNum)
END
GO
/****** Object:  StoredProcedure [dbo].[addPurchase]    Script Date: 20.03.2024 21:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[addPurchase]
	@barcode CHAR(13), 
	@quantity SMALLINT,
	@purveyor varchar(20),
	@sotr VARCHAR(60)
AS
BEGIN
	--по имени поставщика вытягивается его код и вносится в таблицу поставок
	DECLARE @codePurveyor smallint
	SELECT @codePurveyor = СodePurveyor FROM Purveyor WHERE @purveyor = NamePurveyor

	-- есть ли в таблице Purveyor такой поставщик
	IF NOT EXISTS(SELECT NamePurveyor FROM Purveyor WHERE @purveyor = NamePurveyor)
	BEGIN
		RAISERROR ('NamePurveyor does not exist in Purveyor table', 16, 1);
		RETURN;
	END

	--по имени сотрудника вытягивается его код и вносится в таблицу поставок
	DECLARE @idSotr smallint
	SELECT @idSotr = idSotr FROM Sotr WHERE @sotr = Fio

	DECLARE @price MONEY
	SELECT @price = Price FROM Product WHERE Barcode = @barcode

	DECLARE @total MONEY
	SET @total = @price * @quantity 

	DECLARE @n_ord SMALLINT
	SELECT @n_ord = (MAX(OrderCode) + 1) FROM StructPurchase

	IF NOT EXISTS (SELECT * FROM Purchase WHERE OrderCode = @n_ord)
	BEGIN
		INSERT INTO Purchase(OrderCode, СodePurv, id_sotr, DateExe, DelivPrice) 
					 VALUES (@n_ord, @codePurveyor, @idSotr, GETDATE(), @total)
	END

	INSERT INTO StructPurchase(OrderCode, Barcode, ValidFor, UnitPrice, QuantityOrd) 
					   VALUES (@n_ord,   @barcode, NULL,     @price,    @quantity)

	UPDATE Product SET InStock = (InStock + @quantity) WHERE Barcode = @barcode
END
GO
/****** Object:  StoredProcedure [dbo].[addPurveyor]    Script Date: 20.03.2024 21:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[addPurveyor]
	@namePurveyor varchar(20),
	@contactPerson varchar(50),
	@country varchar(30),
	@sity varchar(30),
	@address varchar(100),
	@phoneNum varchar(20),
	@termsPay varchar(100)
AS
BEGIN
	DECLARE @codePurv smallint
	SELECT @codePurv = (MAX(СodePurveyor) + 1) FROM Purveyor

	INSERT INTO Purveyor(СodePurveyor, NamePurveyor, ContactPerson, Country, Sity, Address, PhoneNum, TermsPay) 
	VALUES (@codePurv, @namePurveyor, @contactPerson, @country, @sity, @address, @phoneNum, @termsPay)
END

GO
/****** Object:  StoredProcedure [dbo].[addStructSell]    Script Date: 20.03.2024 21:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[addStructSell]
	@barcode CHAR(13), 
	@quantity SMALLINT,
	@sotr VARCHAR(60)
AS
BEGIN
	BEGIN
		IF (SELECT InStock FROM Product WHERE Barcode = @barcode) > 0
		BEGIN
			IF (SELECT InStock FROM Product WHERE Barcode = @barcode) >= @quantity
			BEGIN
				DECLARE @idSotr smallint
				SELECT @idSotr = idSotr FROM Sotr WHERE @sotr = Fio
				
				DECLARE @price MONEY
				SELECT @price = Price FROM Product

				DECLARE @total MONEY
				SET @total = @price * @quantity 

				DECLARE @n_receipt SMALLINT
				SELECT @n_receipt = (MAX(Nrec) + 1) FROM StructSell

				IF NOT EXISTS (SELECT * FROM Sell WHERE Nreceipt = @n_receipt)
				BEGIN
					INSERT INTO Sell (Nreceipt, id_sotr, DateSell) VALUES (@n_receipt, @idSotr, GETDATE())
				END

				INSERT INTO StructSell(Nrec, Barcode, Quantity, TotalCost) 
				VALUES (@n_receipt, @barcode, @quantity, @total)

				

				
			END
			ELSE BEGIN
				PRINT 'Товара недостаточно'
			END
			UPDATE Product SET InStock = (InStock - @quantity) WHERE Barcode = @barcode
		END
		ELSE BEGIN
			PRINT 'Товара нет в наличии'
		END
	END
END
GO
/****** Object:  StoredProcedure [dbo].[authenticationUser]    Script Date: 20.03.2024 21:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[authenticationUser]
	@fio VARCHAR(60), 
	@phoneNum VARCHAR(15), 
	@a INT OUTPUT
AS
BEGIN
	SET @a = 0

	declare @position VARCHAR(40)
	SET @position = (SELECT Position FROM Sotr WHERE @fio = Fio AND @phoneNum = PhoneNum)

	IF @position = 'Провизор' OR @position = 'Фармацевт'
	SET @a = 1

	IF @position = 'Менеджер'
	SET @a = 2

	IF @position = 'Директор'
	SET @a = 3
END
GO
/****** Object:  StoredProcedure [dbo].[getInStock]    Script Date: 20.03.2024 21:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getInStock]
    @Barcode CHAR(13),
    @InStock INT OUTPUT
AS
BEGIN
    SET @InStock = (SELECT InStock FROM Product WHERE Barcode = @Barcode)
END
GO
/****** Object:  StoredProcedure [dbo].[retireSotr]    Script Date: 20.03.2024 21:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[retireSotr]
    @idSotr SMALLINT
AS
BEGIN
	UPDATE Sotr
    SET Position = 'Уволен ' + Position
    WHERE idSotr = @idSotr;
END
GO
/****** Object:  StoredProcedure [dbo].[writeOffProduct]    Script Date: 20.03.2024 21:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[writeOffProduct]
	@Barcode char(13),
    @Quantity smallint,
	@WhyDelete varchar(60)
AS
BEGIN
    DECLARE @Ndelete smallint
--	DECLARE @OrderCode int
    DECLARE @DateDelete date
	DECLARE @InStock smallint

    -- Получение следующего значения Ndelete
    SELECT @Ndelete = (MAX(Ndelete) + 1) FROM DeleteProduct

	SELECT @InStock = InStock FROM Product
    WHERE Barcode = @Barcode;

    -- Получение текущей даты
    SET @DateDelete = GETDATE()


	IF @Quantity <= @InStock
	BEGIN
		-- Вставка данных в таблицу DeleteProduct
		INSERT INTO DeleteProduct (Ndelete, Barcode, Quantity, DateDelete, WhyDelete)
		VALUES (@Ndelete, @Barcode, @Quantity, @DateDelete, @WhyDelete)
		
		-- Уменьшение количества товара в таблице Product
		UPDATE Product
		SET InStock = InStock - @Quantity
		WHERE Barcode = @Barcode
	END
	ELSE
	BEGIN
		PRINT 'Такое количество товара отсутсвует на складе'
	END
END
GO
USE [master]
GO
ALTER DATABASE [Pharmacy] SET  READ_WRITE 
GO
