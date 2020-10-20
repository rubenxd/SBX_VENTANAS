---------DATOS INICIALES-----------------------------------------------------------------------------------------------------------------------------------
INSERT INTO Empresa VALUES('0','N/A','N/A','N/A','0','0','','','','',null,0,10000,'N/A',100,'F')
GO
INSERT INTO Estado VALUES('Activo'),('Inactivo')
GO
INSERT INTO Categoria VALUES('N/A'),('Celulares'),('Computadores'),('Televisores'),('Videojuegos')
GO
INSERT INTO Marca VALUES('N/A'),('Xiaomi'),('Samsung'),('Sony'),('HP')
GO
INSERT INTO UnidadMedida VALUES('N/A'),('KG'),('LB'),('LT'),('G')
GO
INSERT INTO Ubicacion VALUES('N/A')
GO
INSERT INTO SalidaPara VALUES('N/A'),('Venta')
GO
INSERT INTO Proveedor VALUES('0','N/A','N/A','N/A','0','0','N/A','N/A')
GO
INSERT INTO Cliente VALUES('0','N/A','N/A','N/A','0','0','N/A','N/A')
GO
INSERT INTO Mensajero VALUES('0','N/A','N/A','N/A','0','0','N/A')
GO
INSERT INTO Rol VALUES(1,'Administrador','Control total')
GO
INSERT INTO Modulo VALUES
(1,'VENTA',''),
(2,'PRODUCTO',''),
(3,'INVENTARIO',''),
(4,'CLIENTE',''),
(5,'PROVEEDOR',''),
(6,'EMPRESA',''),
(7,'DOMICILIO',''),
(8,'SEPARADO',''),
(9,'CAJA',''),
(10,'GASTOS',''),
(11,'REPORTES',''),
(12,'AJUSTES','')
GO
INSERT INTO Permiso VALUES
(1,'separado',''),
(2,'domicilio',''),
(3,'descuento',''),
(4,'quitar_todo',''),
(5,'quitar_uno',''),
(6,'consultas',''),
(7,'agregar_producto',''),
(8,'agregar_cliente',''),
(9,'exportar_excel',''),
(10,'editar',''),
(11,'eliminar',''),
(12,'guardar',''),
(13,'limpiar',''),
(14,'caracteristicas',''),
(15,'agregar_proveedor',''),
(16,'agregar_mensajero',''),
(17,'pagos',''),
(18,'historial',''),
(19,'VENDER',''),
(20,'PRODUCTO',''),
(21,'INVENTARIO',''),
(22,'CLIENTE',''),
(23,'PROVEEDOR',''),
(24,'EMPRESA',''),
(25,'DOMICILIO',''),
(26,'CAJA',''),
(27,'REPORTES',''),
(28,'GASTOS',''),
(29,'AJUSTES',''),
(30,'NomGasto',''),
(31,'AgregaGasto','')
GO
INSERT INTO Modulo_permiso VALUES
(1,1),
(1,2),
(1,3),
(1,4),
(1,5),
(1,6),
(1,7),
(1,8),
(1,19),

(2,9),
(2,10),
(2,11),
(2,20),

(3,12),
(3,6),
(3,14),
(3,13),
(3,15),
(3,21),

(4,12),
(4,13),
(4,10),
(4,11),
(4,9),
(4,22),

(5,12),
(5,10),
(5,11),
(5,9),
(5,23),
(5,13),

(6,12),
(6,13),
(6,24),

(7,9),
(7,11),
(7,12),
(7,16),
(7,25),

(8,9),
(8,11),
(8,17),
(8,18),

(9,9),
(9,26),
(9,10),
(9,11),

(10,9),
(10,11),
(10,28),
(10,30),
(10,31),

(11,27),
(12,29)
GO
INSERT INTO Rol_Modulo_Permiso VALUES
(1,	1),
(1	,2),
(1	,3),
(1	,4),
(1	,5),
(1	,6),
(1	,7),
(1	,8),
(1	,9),
(1	,10),
(1	,11),
(1	,12),
(1	,13),
(1	,14),
(1	,15),
(1	,16),
(1	,17),
(1	,18),
(1	,19),
(1	,20),
(1	,21),
(1	,22),
(1	,23),
(1	,24),
(1	,25),
(1	,26),
(1	,27),
(1	,28),
(1	,29),
(1	,30),
(1	,31),
(1	,32),
(1	,33),
(1	,34),
(1	,35),
(1	,36),
(1	,37),
(1	,38),
(1	,39),
(1	,40),
(1	,41),
(1	,42),
(1	,43),
(1	,44),
(1	,45),
(1	,46),
(1	,47),
(1	,48),
(1	,49),
(1	,50),
(1	,51),
(1	,52),
(1,	53),
(1	,54)
GO
INSERT INTO Usuario VALUES
('1','Admin','','','','',null,'Admin',ENCRYPTBYPASSPHRASE('password','admin'),'Activo',1)
GO
  insert into Parametros values('NO','NO')
