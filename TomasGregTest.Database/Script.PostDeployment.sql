IF NOT EXISTS(SELECT 1 FROM dbo.Usuarios)
BEGIN
	INSERT INTO Usuarios (Nome, Email, Senha, Ativo) VALUES ('Elias Zanotti', 'eliaszanotti@gmail.com', 'Mudar@123', 1);
END