CREATE proc sp_consultar_factura
@Factura VARCHAR(100)
AS
SELECT * FROM (
SELECT 
 CONCAT(v.NombreDocumento,'-',v.ConsecutivoDocumento) Factura
 ,DAY(Fecha) Dia
 ,MONTH(Fecha) Mes
 ,YEAR(Fecha) Año
 ,v.ConsecutivoDocumento NumFac
 ,ISNULL(c.Nombre ,'Publico') NomRazon
 ,ISNULL(c.DNI,0) DNI
 ,ISNULL(c.Direccion,'') Direccion
 ,CONCAT(c.Telefono,' - ',c.Celular) Telefonos
FROM Venta v
INNER JOIN Producto p ON p.Item = v.Producto
LEFT JOIN Cliente c ON c.Codigo = v.Cliente
LEFT JOIN Sucursal s ON s.Codigo = v.Sucursal
INNER JOIN Usuario us ON us.Codigo = v.Usuario
) F
WHERE F.Factura = @Factura
