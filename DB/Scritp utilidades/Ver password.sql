DECLARE
@PassEncritado VARCHAR(300),
@PassDecifrado VARCHAR(300)

SET @PassEncritado = (SELECT Contrasena FROM Usuario WHERE NombreUsuario = 'Admin')
SET	@PassDecifrado = DECRYPTBYPASSPHRASE('password', @PassEncritado)

SELECT @PassDecifrado