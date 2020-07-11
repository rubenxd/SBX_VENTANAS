ALTER PROC  [dbo].[SP_BUSCAR_VENTAS]
@TipoBusq AS VARCHAR(20),
@FechaInicio AS DATE,
@FechaFin AS DATE,
@Busqueda AS VARCHAR(MAX)
AS
IF(@Busqueda = '')
BEGIN
SELECT 
 v.Codigo
,V.Fecha
,CONCAT(v.NombreDocumento,'-',v.ConsecutivoDocumento) Factura
,p.Item
,p.Nombre
,p.Referencia
,p.CodigoBarras
,p.ModoVenta
,v.UM
,v.Cantidad
,v.Costo 
,v.PrecioVenta
,v.descuento
,v.PrecioVenta * v.descuento ValorDescuento
,v.Tdebito
,v.NumBaucherDebito
,v.Tcredito
,v.NumBaucherCredito
,v.Total
,v.Efectivo
,v.Cambio
,CONCAT(c.DNI,'-',c.Nombre) Cliente
,CONCAT(s.Codigo,'-',s.Nombre) Sucursal
,ISNULL(v.Domicilio,'') Domicilio
,CONCAT(us.Codigo,'-',us.NombreUsuario) Usuario
FROM Venta v
INNER JOIN Producto p ON p.Item = v.Producto
LEFT JOIN Cliente c ON c.Codigo = v.Cliente
LEFT JOIN Sucursal s ON s.Codigo = v.Sucursal
INNER JOIN Usuario us ON us.Codigo = v.Usuario
WHERE  CONVERT(date,v.Fecha) BETWEEN @FechaInicio AND @FechaFin
END
ELSE
BEGIN
IF(@TipoBusq = 'Contiene')
BEGIN
SELECT 
 v.Codigo
,V.Fecha
,CONCAT(v.NombreDocumento,'-',v.ConsecutivoDocumento) Factura
,p.Item
,p.Nombre
,p.Referencia
,p.CodigoBarras
,p.ModoVenta
,v.UM
,v.Cantidad
,v.Costo 
,v.PrecioVenta
,v.descuento
,v.PrecioVenta * v.descuento ValorDescuento
,v.Tdebito
,v.NumBaucherDebito
,v.Tcredito
,v.NumBaucherCredito
,v.Total
,v.Efectivo
,v.Cambio
,CONCAT(c.DNI,'-',c.Nombre) Cliente
,CONCAT(s.Codigo,'-',s.Nombre) Sucursal
,ISNULL(v.Domicilio,'') Domicilio
,CONCAT(us.Codigo,'-',us.NombreUsuario) Usuario
FROM Venta v
INNER JOIN Producto p ON p.Item = v.Producto
LEFT JOIN Cliente c ON c.Codigo = v.Cliente
LEFT JOIN Sucursal s ON s.Codigo = v.Sucursal
INNER JOIN Usuario us ON us.Codigo = v.Usuario
WHERE (CONCAT(v.NombreDocumento,'-',v.ConsecutivoDocumento) LIKE @Busqueda+'%' 
OR 
Item LIKE CASE WHEN ISNUMERIC(@Busqueda) = 1 THEN @Busqueda ELSE 0 END )
AND CONVERT(date,v.Fecha) BETWEEN @FechaInicio AND @FechaFin
END
ELSE
BEGIN
SELECT 
 v.Codigo
,V.Fecha
,CONCAT(v.NombreDocumento,'-',v.ConsecutivoDocumento) Factura
,p.Item
,p.Nombre
,p.Referencia
,p.CodigoBarras
,p.ModoVenta
,v.UM
,v.Cantidad
,v.Costo 
,v.PrecioVenta
,v.descuento
,v.PrecioVenta * v.descuento ValorDescuento
,v.Tdebito
,v.NumBaucherDebito
,v.Tcredito
,v.NumBaucherCredito
,v.Total
,v.Efectivo
,v.Cambio
,CONCAT(c.DNI,'-',c.Nombre) Cliente
,CONCAT(s.Codigo,'-',s.Nombre) Sucursal
,ISNULL(v.Domicilio,'') Domicilio
,CONCAT(us.Codigo,'-',us.NombreUsuario) Usuario
FROM Venta v
INNER JOIN Producto p ON p.Item = v.Producto
LEFT JOIN Cliente c ON c.Codigo = v.Cliente
LEFT JOIN Sucursal s ON s.Codigo = v.Sucursal
INNER JOIN Usuario us ON us.Codigo = v.Usuario
WHERE (CONCAT(v.NombreDocumento,'-',v.ConsecutivoDocumento) = @Busqueda
OR 
Item = CASE WHEN ISNUMERIC(@Busqueda) = 1 THEN @Busqueda ELSE 0 END)
AND CONVERT(date,v.Fecha) BETWEEN @FechaInicio AND @FechaFin
END
END

