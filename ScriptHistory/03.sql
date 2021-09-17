Begin Try
    SET NOCOUNT ON
    Set XACT_ABORT ON
Begin Tran
exec Check_db_Version 3

	USE [WowCarry]

	ALTER TABLE [dbo].[__ProductPrice] DROP CONSTRAINT [FK_ProductPrice_Product]

	/****** Object:  Table [dbo].[ProductPrice]    Script Date: 16.09.2021 17:48:00 ******/
	SET ANSI_NULLS ON

	SET QUOTED_IDENTIFIER ON

	CREATE TABLE [dbo].[ProductPrice](
		[ProductPriceId] [uniqueidentifier] NOT NULL,
		[ProductId] [uniqueidentifier] NOT NULL,
		[UsPrice] [decimal](18, 1) NULL,
		[UsSale] [decimal](18, 0) NULL,
		[EuPrice] [decimal](18, 1) NULL,
		[EuSale] [decimal](18, 0) NULL,
	PRIMARY KEY CLUSTERED 
	(
		[ProductPriceId] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
	) ON [PRIMARY]

	ALTER TABLE [dbo].[ProductPrice]  WITH CHECK ADD  CONSTRAINT [FK_ProductPrice_Product] FOREIGN KEY([ProductId])
	REFERENCES [dbo].[Product] ([ProductId])
	ON UPDATE CASCADE
	ON DELETE CASCADE

	ALTER TABLE [dbo].[ProductPrice] CHECK CONSTRAINT [FK_ProductPrice_Product]
	--select * from [ProductPrice]
	--select * from [__ProductPrice] where Region = 'Europe'

	insert into [dbo].[ProductPrice] ([ProductPriceId],[ProductId],[UsPrice],[UsSale])
	select [ProductPriceId],[ProductId],[Price],[ProductSale] from [__ProductPrice] where Region = 'US&Oceania'

	Update [dbo].[ProductPrice] 
	set	[EuPrice] =  [Price],
		[EuSale] = [ProductSale] 
	--select *
	from [ProductPrice] main
	join [__ProductPrice] temp on main.ProductId = temp.ProductId
	where Region = 'Europe' 

	/****** Object:  Table [dbo].[ProductPrice]    Script Date: 16.09.2021 17:48:00 ******/
	IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[__ProductPrice]') AND type in (N'U'))
	DROP TABLE [dbo].[__ProductPrice]


exec Update_db_Version 3
Commit Tran
End Try
Begin Catch
   RollBack Tran
   Select ERROR_MESSAGE() as Msg, ERROR_NUMBER() as Num
End Catch