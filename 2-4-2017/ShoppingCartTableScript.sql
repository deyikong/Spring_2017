USE [ShoppingCart]
GO

/****** Object:  Table [dbo].[Address]    Script Date: 2/4/2017 4:42:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Address](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](25) NULL,
	[Address1] [varchar](100) NOT NULL,
	[Address2] [varchar](100) NULL,
	[City] [varchar](25) NOT NULL,
	[State] [char](2) NOT NULL,
	[ZipCode] [varchar](10) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CustomerId] [int] NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[Customer]    Script Date: 2/4/2017 4:42:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](25) NOT NULL,
	[LastName] [varchar](25) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[UserName] [varchar](25) NOT NULL,
	[Password] [varchar](25) NOT NULL,
	[Phone] [varchar](25) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[MyShoppingCart]    Script Date: 2/4/2017 4:42:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MyShoppingCart](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[GrandTotal] [decimal](18, 0) NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_MyShoppingCart] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[MyShoppingCartProduct]    Script Date: 2/4/2017 4:42:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MyShoppingCartProduct](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MyShoppingCartId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Quantity] [decimal](18, 0) NULL,
	[UnitPrice] [money] NULL,
	[SubTotal] [decimal](18, 0) NULL,
 CONSTRAINT [PK_MyShoppingCartProduct] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[Product]    Script Date: 2/4/2017 4:42:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Product](
	[Id] [int] NOT NULL,
	[Name] [varchar](50) NULL,
	[Description] [varchar](200) NULL,
	[UnitPrice] [money] NULL,
	[UnitOfMeasure] [varchar](25) NULL,
	[IsActive] [bit] NULL,
	[Picture] [varchar](100) NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [varchar](50) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Address] ADD  CONSTRAINT [DF_Address_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO

ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Customer_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO

ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Customer_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO

ALTER TABLE [dbo].[MyShoppingCart] ADD  CONSTRAINT [DF_MyShoppingCart_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO

ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO

ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [DF_Product_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO

ALTER TABLE [dbo].[Address]  WITH CHECK ADD  CONSTRAINT [FK_Address_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO

ALTER TABLE [dbo].[Address] CHECK CONSTRAINT [FK_Address_Customer]
GO

ALTER TABLE [dbo].[MyShoppingCart]  WITH CHECK ADD  CONSTRAINT [FK_MyShoppingCart_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO

ALTER TABLE [dbo].[MyShoppingCart] CHECK CONSTRAINT [FK_MyShoppingCart_Customer]
GO

ALTER TABLE [dbo].[MyShoppingCartProduct]  WITH CHECK ADD  CONSTRAINT [FK_MyShoppingCartProduct_MyShoppingCart] FOREIGN KEY([MyShoppingCartId])
REFERENCES [dbo].[MyShoppingCart] ([Id])
GO

ALTER TABLE [dbo].[MyShoppingCartProduct] CHECK CONSTRAINT [FK_MyShoppingCartProduct_MyShoppingCart]
GO

ALTER TABLE [dbo].[MyShoppingCartProduct]  WITH CHECK ADD  CONSTRAINT [FK_MyShoppingCartProduct_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
GO

ALTER TABLE [dbo].[MyShoppingCartProduct] CHECK CONSTRAINT [FK_MyShoppingCartProduct_Product]
GO

