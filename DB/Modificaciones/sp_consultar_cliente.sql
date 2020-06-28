ALTER PROC  [dbo].[sp_consultar_cliente]
		@v_buscar VARCHAR(300),
		@v_tipo_busqueda AS VARCHAR(20)
		AS
		IF(@v_tipo_busqueda = 'Contiene')
		BEGIN
		SELECT c.*,s.Codigo cods, s.Nombre NombreS,s.Celular CelularS,s.Ciudad CiudadS,
		s.Direccion DireccionS,s.Email EmailS,s.SitioWeb SitioWebS,s.Telefono TelefonoS 
		FROM Cliente c 
		LEFT JOIN Sucursal s ON s.Cliente = c.Codigo
		WHERE (DNI LIKE @v_buscar+'%' OR c.Nombre LIKE @v_buscar+'%') AND c.Nombre != 'N/A'		
		END
		ELSE
		IF(@v_tipo_busqueda = 'validacion')
		BEGIN
		SELECT c.*,s.Codigo cods, s.Nombre NombreS,s.Celular CelularS,s.Ciudad CiudadS,
		s.Direccion DireccionS,s.Email EmailS,s.SitioWeb SitioWebS,s.Telefono TelefonoS 
		FROM Cliente c 
		LEFT JOIN Sucursal s ON s.Cliente = c.Codigo
	    WHERE c.DNI = @v_buscar 
		END
		ELSE
		BEGIN
		IF(@v_tipo_busqueda ='validacion_celular')
		BEGIN
		SELECT c.*,s.Codigo cods, s.Nombre NombreS,s.Celular CelularS,s.Ciudad CiudadS,
		s.Direccion DireccionS,s.Email EmailS,s.SitioWeb SitioWebS,s.Telefono TelefonoS 
		FROM Cliente c 
		LEFT JOIN Sucursal s ON s.Cliente = c.Codigo
		WHERE c.Celular = @v_buscar 
		END
		ELSE
		BEGIN
		SELECT  c.*,s.Codigo cods, s.Nombre NombreS,s.Celular CelularS,s.Ciudad CiudadS,s.Direccion DireccionS,s.Email EmailS,s.SitioWeb SitioWebS,s.Telefono TelefonoS FROM Cliente c
		LEFT JOIN Sucursal s ON s.Cliente = c.Codigo
		WHERE (DNI = @v_buscar OR c.Nombre = @v_buscar) AND c.Nombre != 'N/A'
		END
		END