USE M_Peoples;

----DML---

INSERT INTO Funcionarios (Nome,Sobrenome,DataNascimento)
VALUES ('Catarina', 'Strada','02/03/2000'),
		('Tadeu','Vitelli','01/07/1995');


INSERT INTO TipoUsuario (TituloTipoUsuario)
VALUES ('Administrador'),
	   ('Comum');

	

INSERT INTO Usuarios(Email,Senha,IdTipoUsuario)
VALUES 	('catarina@email.com','catarina',2),
		('tadeu@email.com','tadeu',2);

		DELETE TipoUsuario WHERE IdTipoUsuario = 4;

		SELECT * FROM TipoUsuario;
		SELECT * FROM Usuarios;
		SELECT * FROM Funcionarios;

		UPDATE Funcionarios SET IdUsuario = 4  WHERE IdFuncionario = 2;