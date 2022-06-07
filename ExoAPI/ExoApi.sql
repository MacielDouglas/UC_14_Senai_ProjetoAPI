CREATE DATABASE ExoApi
GO

USE ExoApi
GO

CREATE TABLE Projetos (
    Id INT PRIMARY KEY IDENTITY,
    Titulo VARCHAR(150) NOT NULL,
    StatusProjeto TINYINT,
	DataInicio DATE NOT NULL,
    Tecnologias VARCHAR (150) NOT NULL,
	Area VARCHAR (100) NOT NULL

)
GO

INSERT INTO Projetos (Titulo, StatusProjeto, DataInicio, Tecnologias, Area) 
VALUES ('Sherwin Williams app', 1, '2022/05/10', 'Android','Mobile')
GO

INSERT INTO Projetos (Titulo, StatusProjeto, DataInicio, Tecnologias, Area) 
VALUES ('Wahl Clipper Corp', 2, '2021/08/02', 'Web','Mobile')
GO

INSERT INTO Projetos (Titulo, StatusProjeto, DataInicio, Tecnologias, Area) 
VALUES ('GameMania', 0, '2022/06/02', 'Angular','WebSite')
GO

-- UPDATE Livros SET Titulo = 'Titulo A1' Where Id = 1;

 -- DELETE FROM Livros WHERE Id = 1;

SELECT Id, Titulo, StatusProjeto, DataInicio, Tecnologias, Area FROM Projetos
GO

CREATE TABLE Usuarios (
    Id INT PRIMARY KEY IDENTITY,
    Email VARCHAR(255) NOT NULL UNIQUE,
    Senha VARCHAR(120) NOT NULL
)
GO

INSERT INTO Usuarios VALUES ('email@sp.br', '1234')
GO

SELECT * FROM Usuarios WHERE email = 'email@sp.br' AND senha = '1234'
GO