USE [DB_SBX]
GO
/****** Object:  Trigger [dbo].[tr_reset_item]    Script Date: 25/04/2020 12:36:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	ALTER TRIGGER [dbo].[tr_reset_item] on [dbo].[Producto]
	after delete
	AS
	BEGIN
		DECLARE @max INT;  
	SELECT @max = ISNULL(max(Item),0) FROM Producto;  
	DBCC checkident(Producto,reseed,@max)
	END
