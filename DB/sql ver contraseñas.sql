SELECT Usuario,
Cast(DecryptByPassPhrase('password', Contraseņa) As varchar(200)) As pass
FROM Usuario