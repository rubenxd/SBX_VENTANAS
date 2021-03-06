USE [DB_SBX]
GO
/****** Object:  Trigger [dbo].[tr_kardex_delete]    Script Date: 25/04/2020 12:34:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	ALTER TRIGGER [dbo].[tr_kardex_delete] on [dbo].[Kardex]
		AFTER DELETE
	AS
	BEGIN
	INSERT INTO Bit_kardex (Fecha,Accion,CodigoMovimiento,Item,Referencia,Nombre,Descripcion)
		SELECT
		SYSDATETIME(),'Eliminacion movimiento',d.Codigo,d.Item,d.Referencia,d.Nombre,d.Descripcion
		FROM deleted d		
	END
