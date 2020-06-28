CREATE PROC  [dbo].[sp_consultar_sucursal]
		@v_buscar VARCHAR(300),
		@v_tipo_busqueda AS VARCHAR(20)
		AS
		IF(@v_tipo_busqueda = 'Contiene')
		BEGIN
		SELECT * FROM sucursal WHERE ( Nombre LIKE @v_buscar+'%') AND Nombre != 'N/A'
		END
		ELSE
		IF(@v_tipo_busqueda = 'validacion')
		BEGIN
		SELECT * FROM sucursal WHERE Nombre = @v_buscar 
		END
		ELSE
		BEGIN
		IF(@v_tipo_busqueda ='validacion_celular')
		BEGIN
		SELECT * FROM sucursal WHERE Celular = @v_buscar 
		END
		ELSE
		BEGIN
		SELECT * FROM sucursal WHERE ( Nombre = @v_buscar) AND Nombre != 'N/A'
		END
		END