If(db_id(N'gestaoClientes') IS NULL)
CREATE DATABASE [gestaoClientes]
GO

USE [gestaoClientes]
GO

IF (OBJECT_ID('[cliente]') IS NOT NULL)
  DROP TABLE cliente
GO

IF (OBJECT_ID('[tipoCliente]') IS NOT NULL)
  DROP TABLE tipoCliente
GO
if not exists (select * from sysobjects where name='tipoCliente' and xtype='U')
Create table tipoCliente (id int identity(1,1) not null primary key,
							descricao varchar(100) not null)
GO

IF (OBJECT_ID('[situacaoCliente]') IS NOT NULL)
  DROP TABLE situacaoCliente
GO
if not exists (select * from sysobjects where name='situacaoCliente' and xtype='U')
Create table situacaoCliente (id int identity(1,1) not null primary key,
								descricao varchar(100) not null)
GO

if not exists (select * from sysobjects where name='cliente' and xtype='U')
Create table cliente (id int identity(1,1) not null primary key,
						nome varchar(100) not null,
						cpf nvarchar(20) not null unique,
						masculino bit,
						tipoClienteId int foreign key references ..tipoCliente(Id),
						situacaoClienteId int foreign key references ..situacaoCliente(Id)
						)
GO

IF (OBJECT_ID('[listTipoCliente]') IS NOT NULL)
  DROP PROCEDURE [listTipoCliente]
GO
Create Procedure [listTipoCliente]
AS
Select id,descricao FROM tipoCliente
GO

IF (OBJECT_ID('[listSituacaoCliente]') IS NOT NULL)
  DROP PROCEDURE [listSituacaoCliente]
GO
Create Procedure [listSituacaoCliente]
AS
Select id, descricao FROM situacaoCliente
GO

IF (OBJECT_ID('[listCliente]') IS NOT NULL)
  DROP PROCEDURE [listCliente]
GO
Create Procedure [listCliente]
AS
Select id, nome, cpf, masculino, tipoClienteId, situacaoClienteId
From cliente
GO

IF (OBJECT_ID('[getCliente]') IS NOT NULL)
  DROP PROCEDURE [getCliente]
GO
Create Procedure [getCliente] @id int
AS
Select id, nome, cpf, masculino, tipoClienteId, situacaoClienteId
From cliente Where id = @id
GO

IF (OBJECT_ID('[addCliente]') IS NOT NULL)
  DROP PROCEDURE [addCliente]
GO
Create Procedure [addCliente] @nome varchar(100), @cpf nvarchar(20), @masculino bit, @tipoClienteId int, @situacaoClienteId int
AS
Insert Into cliente Values (@nome, @cpf, @masculino, @tipoClienteId, @situacaoClienteId)
GO

IF (OBJECT_ID('[updateCliente]') IS NOT NULL)
  DROP PROCEDURE [updateCliente]
GO
Create Procedure [updateCliente] @id int, @nome varchar(100), @cpf nvarchar(20), @masculino bit, @tipoClienteId int, @situacaoClienteId int
AS
Update cliente Set nome = @nome, cpf = @cpf, masculino = @masculino, tipoClienteId = @tipoClienteId, situacaoClienteId = @situacaoClienteId
Where id = @id
GO

IF (OBJECT_ID('[deleteCliente]') IS NOT NULL)
  DROP PROCEDURE [deleteCliente]
GO
Create Procedure [deleteCliente] @id int
AS
Delete From cliente Where id = @id
GO

--DADOS DE EXEMPLO

IF(SELECT TOP 1 id from situacaoCliente) IS NULL
INSERT INTO situacaoCliente VALUES ('Adimplente'),('Inadimplente'),('Bloqueado')
GO

IF(SELECT TOP 1 id from tipoCliente) IS NULL
INSERT INTO tipoCliente VALUES ('VIP'),('Gold'),('Standard')
GO
