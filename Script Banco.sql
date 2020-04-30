CREATE DATABASE Teste;
USE Teste;

CREATE TABLE SEXO(
SexoId INT IDENTITY(1,1),
Descricao VARCHAR(15),
CONSTRAINT PK_SexoId PRIMARY KEY (SexoId)
)


CREATE TABLE USUARIO(
UsuarioId INT IDENTITY(1,1),
Nome VARCHAR(200),
DataNascimento Date,
Email VARCHAR(100),
Senha VARCHAR(30),
Ativo BIT,
SexoId INT,
CONSTRAINT PK_UsuarioId PRIMARY KEY (UsuarioId),
CONSTRAINT FK_SexoId FOREIGN KEY (SexoID) REFERENCES Sexo (SexoId)
)


INSERT INTO SEXO VALUES('Feminino');
INSERT INTO SEXO VALUES('Masculino');

INSERT INTO USUARIO(Nome,DataNascimento,Email,Senha,Ativo,SexoId) VALUES('Daniel','1994-05-25','daniel.pin@outlook.com','123',1,1);
INSERT INTO USUARIO(Nome,DataNascimento,Email,Senha,Ativo,SexoId) VALUES('Amanda','1992-03-04','to.silence@hotmail.com','@1234',1,2);




