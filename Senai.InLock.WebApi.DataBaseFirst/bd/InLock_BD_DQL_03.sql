USE InLock_Games_Manha;

-- Listar todos os usu�rios
SELECT * FROM Usuarios;
-- Listar todos os est�dios
SELECT * FROM Estudios;
-- Listar todos os jogos
SELECT * FROM Jogos;
-- Listar todos os jogos e seus respectivos est�dios
SELECT Nome, NomeEstudio FROM Jogos INNER JOIN Estudios ON Jogos.IdEstudio = Estudios.IdEstudio;
-- Buscar e trazer na lista todos os est�dios, mesmo que eles n�o contenham nenhum jogo de refer�ncia


-- Busca um usu�rio atrav�s do E-mail e da Senha
SELECT U.IdUsuario, U.Email, U.IdTipoUsuario, TU.Titulo FROM Usuarios U
INNER JOIN TipoUsuario TU
ON U.IdTipoUsuario = TU.IdTipoUsuario
WHERE U.Email = 'admin@admin.com' AND U.Senha = 'admin'

-- Buscar um jogo atrav�s do  IdJogo;
SELECT Nome, Descricao, DataLancamento, Valor FROM Jogos
WHERE IdJogo = 1;

-- Buscar um est�dio atrav�s do seu  Id
SELECT NomeEstudio FROM Estudios
WHERE IdEstudio = 2;

----- Buscar e trazer na lista todos os est�dios, mesmo que eles n�o contenham nenhum jogo de refer�ncia; 
SELECT * FROM Estudios LEFT OUTER JOIN Jogos ON Estudios.IdEstudio = Jogos.IdJogo 

