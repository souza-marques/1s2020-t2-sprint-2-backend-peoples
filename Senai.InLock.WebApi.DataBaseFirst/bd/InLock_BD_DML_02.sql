USE InLock_Games_Manha;

    INSERT INTO TipoUsuario(Titulo)
    VALUES ('administrador'),
		   ('cliente')

    INSERT INTO Usuarios(Email, Senha, IdTipoUsuario)
	VALUES   ('admin@admin.com','admin',1),
			('cliente@cliente.com','cliente',2)	

	INSERT INTO Estudios (NomeEstudio)
	VALUES	(' Blizzard'),
			('Rockstar Studios'),
			('Square Enix')

	INSERT INTO Jogos(Nome,Descricao,DataLancamento,Valor,IdEstudio) 
	VALUES	(' Diablo 3',' � um jogo que cont�m bastante a��o e � viciante, seja voc� um novato ou um f�','15/05/2012',' 99',1),
			(' Red Dead Redemption II',' jogo eletr�nico de a��o-aventura western',' 26/10/2018',' 120',2)


		
			SELECT * FROM TipoUsuario;
			SELECT * FROM Usuarios;
			SELECT * FROM Estudios;
			SELECT * FROM Jogos;