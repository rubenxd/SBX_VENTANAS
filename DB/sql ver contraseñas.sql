SELECT Usuario,
Cast(DecryptByPassPhrase('password', Contrase�a) As varchar(200)) As pass
FROM Usuario