USE M_Peoples;
--DQL--
SELECT * FROM Funcionarios;
-- Exibe todos os funcionários
SELECT IdFuncionario, Nome, Sobrenome FROM Funcionarios;

-- Exibe o funcionário com ID = 1
SELECT IdFuncionario, Nome, Sobrenome FROM Funcionarios WHERE IdFuncionario = 1;

-- Exibe o funcionário que tenha o nome Catarina
SELECT IdFuncionario, Nome, Sobrenome FROM Funcionarios WHERE Nome = 'Catarina';

-- Exibe o nome completo dos funcionários
SELECT IdFuncionario, CONCAT (Nome,' ',Sobrenome) AS [Nome Completo], DataNascimento FROM Funcionarios;

-- Exibe todos os funcionários de forma ordenada
SELECT IdFuncionario, Nome, Sobrenome, DataNascimento FROM Funcionarios ORDER BY Nome DESC;

-- Exibe todos os tipos de usuário
SELECT IdTipoUsuario, TituloTipoUsuario FROM TipoUsuario

-- Exibe todos os usuários
SELECT U.IdUsuario, U.Email, U.IdTipoUsuario, TU.TituloTipoUsuario FROM Usuarios U
INNER JOIN TipoUsuario TU
ON U.IdTipoUsuario = TU.IdTipoUsuario

-- Busca um usuário através do E-mail e da Senha
SELECT U.IdUsuario, U.Email, U.IdTipoUsuario, TU.TituloTipoUsuario FROM Usuarios U
INNER JOIN TipoUsuario TU
ON U.IdTipoUsuario = TU.IdTipoUsuario
WHERE U.Email = 'adm@gmail.com' AND U.Senha = 'adm123'