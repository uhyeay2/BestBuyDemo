﻿CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY Identity(1, 1),
	[Guid] UNIQUEIDENTIFIER UNIQUE NOT NULL DEFAULT NEWID(),
	[Name] NVARCHAR(90) NOT NULL,
	[Price] MONEY NOT NULL,
	[CategoryId] INT NOT NULL FOREIGN KEY REFERENCES Category(Id),
	[OnSale] TINYINT NOT NULL DEFAULT 0,
	[StockLevel] INT NOT NULL DEFAULT 0,
)
