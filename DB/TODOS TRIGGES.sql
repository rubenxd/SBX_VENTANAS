CREATE TRIGGER [dbo].[tr_kardex_delete] on [dbo].[Kardex]
		AFTER DELETE
	AS
	BEGIN
	INSERT INTO Bit_kardex (Fecha,Accion,CodigoMovimiento,Item,Referencia,Nombre,Descripcion)
		SELECT
		SYSDATETIME(),'Eliminacion movimiento',d.Codigo,d.Item,d.Referencia,d.Nombre,d.Descripcion
		FROM deleted d		
	END

	go

	create TRIGGER [dbo].[tr_Producto_insert] on [dbo].[Producto]
	FOR INSERT
	AS
	BEGIN
	INSERT INTO Kardex (Item,Referencia,Nombre,Descripcion,IVA,UnidadMedida,Medida,Estado,Categoria,Marca,DNIproveedor,Proveedor,
	ModoVenta,Cantidad,Costo,PrecioVenta,CodigoBarras,SubCantidad,ValorSubcantidad,Sobres,ValorSobre,Usuario,FechaRegistro,
	Accion,movimiento,Ubicacion,Salida_para,Stock_minimo,Stock_maximo,UM,DescuentoProveedor,Nota)
	SELECT p.Item,p.Referencia,p.Nombre,P.Descripcion,p.IVA,um.Nombre,p.Medida,p.Estado,ct.Nombre,m.Nombre,pr.DNI,pr.Nombre,
	p.ModoVenta,p.Cantidad,p.Costo,p.PrecioVenta,p.CodigoBarras,p.SubCantidad,p.ValorSubcantidad,p.Sobres,p.ValorSobre,
	p.Usuario,SYSDATETIME(),'INSERT-INVENTARIO',p.movimiento,p.Ubicacion,p.Salida_para,p.Stock_minimo,p.Stock_maximo,
	CASE WHEN ModoVenta = 'Unidad' THEN
		'UND'
		ELSE
		CASE WHEN ModoVenta = 'Pesaje' THEN
		'Bulto'
		ELSE
		'Caja'
		END
	END, p.DescuentoProveedor,p.Nota
	FROM Producto p
	INNER JOIN UnidadMedida um ON um.Codigo = p.UnidadMedida
	INNER JOIN Categoria ct ON ct.Codigo = p.Categoria
	INNER JOIN Marca m ON m.Codigo = p.Marca
	INNER JOIN Proveedor pr ON pr.DNI = p.Proveedor
	WHERE p.FechaRegistro = (SELECT MAX(FechaRegistro) FROM Producto)
	END

	go

	create TRIGGER [dbo].[tr_Producto_update] on [dbo].[Producto]
	FOR UPDATE
	AS
	BEGIN
	INSERT INTO Kardex (Item,Referencia,Nombre,Descripcion,IVA,UnidadMedida,Medida,Estado,Categoria,Marca,DNIproveedor,Proveedor,
	ModoVenta,Cantidad,Costo,PrecioVenta,CodigoBarras,SubCantidad,ValorSubcantidad,Sobres,ValorSobre,Usuario,FechaRegistro
	,Accion,movimiento,Ubicacion,Salida_para,Stock_minimo,Stock_maximo,UM,DescuentoProveedor,Nota)
	SELECT p.Item,p.Referencia,p.Nombre,P.Descripcion,p.IVA,um.Nombre,p.Medida,p.Estado,ct.Nombre,m.Nombre,pr.DNI,pr.Nombre,
	p.ModoVenta,p.Cantidad,p.Costo,p.PrecioVenta,p.CodigoBarras,p.SubCantidad,p.ValorSubcantidad,p.Sobres,p.ValorSobre,
	p.Usuario,SYSDATETIME(),'UPDATE-INVENTARIO',p.movimiento,p.Ubicacion,p.Salida_para,p.Stock_minimo,p.Stock_maximo,
	CASE WHEN ModoVenta = 'Unidad' THEN
		'UND'
		ELSE
		CASE WHEN ModoVenta = 'Pesaje' THEN
		'Bulto'
		ELSE
		'Caja'
		END
	END
	,p.DescuentoProveedor,Nota
	FROM Producto p
	INNER JOIN UnidadMedida um ON um.Codigo = p.UnidadMedida
	INNER JOIN Categoria ct ON ct.Codigo = p.Categoria
	INNER JOIN Marca m ON m.Codigo = p.Marca
	INNER JOIN Proveedor pr ON pr.DNI = p.Proveedor
	WHERE p.FechaRegistro = (SELECT MAX(FechaRegistro) FROM Producto)
	END


	go

	create TRIGGER [dbo].[tr_reset_item] on [dbo].[Producto]
	after delete
	AS
	BEGIN
		DECLARE @max INT;  
	SELECT @max = ISNULL(max(Item),0) FROM Producto;  
	DBCC checkident(Producto,reseed,@max)
	END

	go

	create TRIGGER [dbo].[tr_Venta_insert] on [dbo].[Venta]
	FOR INSERT
	AS
	BEGIN
	INSERT INTO Kardex (CodigoVenta,Item,Referencia,Nombre,Descripcion,IVA,UnidadMedida,Medida,Estado,Categoria,Marca,DNIproveedor,Proveedor,
	ModoVenta,Cantidad,Costo,PrecioVenta,CodigoBarras,SubCantidad,ValorSubcantidad,Sobres,ValorSobre,Usuario,FechaRegistro,
	Accion,movimiento,Ubicacion,Salida_para,Stock_minimo,Stock_maximo,UM,DescuentoProveedor,Nota)
	SELECT v.Codigo,p.Item,p.Referencia,p.Nombre,p.Descripcion,v.IVA,um.Nombre,p.Medida,0,ct.Nombre,
	m.Nombre,pr.DNI,pr.Nombre,p.ModoVenta,v.Cantidad,v.Costo,v.PrecioVenta,p.CodigoBarras,
	p.SubCantidad,p.ValorSubcantidad,p.Sobres,p.ValorSobre,v.Usuario,SYSDATETIME(),'INSERT-VENTA','Salida -',
	p.Ubicacion,p.Salida_para,p.Stock_minimo,p.Stock_maximo,v.UM,v.DescuentoProveedor,'Venta'
	FROM Venta v
	INNER JOIN Producto p ON v.Producto = p.Item
	INNER JOIN UnidadMedida um ON um.Codigo = p.UnidadMedida
	INNER JOIN Categoria ct ON ct.Codigo = p.Categoria
	INNER JOIN Marca m ON m.Codigo = p.Marca
	INNER JOIN Proveedor pr ON pr.DNI = p.Proveedor
	WHERE v.Codigo = (SELECT MAX(Codigo) FROM Venta)
	END





