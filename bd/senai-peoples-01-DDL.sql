CREATE DATABASE M_Peoples;

USE M_Peoples;

----- DDL---------

CREATE TABLE Funcionarios(
IdFuncionario INT PRIMARY KEY IDENTITY,
Nome    VARCHAR(255)  NOT NULL,
Sobrenome  VARCHAR(255) NOT NULL,
DataNascimento  DATE
);

CREATE TABLE TipoUsuario(
IdTipoUsuario  INT PRIMARY KEY IDENTITY,
TituloTipoUsuario  VARCHAR(100)
);

CREATE TABLE Usuarios (
IdUsuario	INT PRIMARY KEY IDENTITY,
Email		VARCHAR (255) NOT NULL UNIQUE,
Senha		VARCHAR (255) NOT NULL,
IdTipoUsuario  INT FOREIGN KEY REFERENCES TipoUsuario(IdTipoUsuario)
);

--Adicionar coluna a uma tabela 

ALTER TABLE Funcionarios
ADD DataNascimento DATE

----------------------------
ALTER TABLE Funcionarios
ADD IdUsuario INT







