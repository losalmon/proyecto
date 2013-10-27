/*
Script de implementación para Database
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "Database"
:setvar DefaultDataPath ""
:setvar DefaultLogPath ""

GO
USE [master]

GO
:on error exit
GO
IF (DB_ID(N'$(DatabaseName)') IS NOT NULL
    AND DATABASEPROPERTYEX(N'$(DatabaseName)','Status') <> N'ONLINE')
BEGIN
    RAISERROR(N'El estado de la base de datos de destino, %s, no está establecido en ONLINE. Para implementarlo en esta base de datos, debe tener el estado ONLINE.', 16, 127,N'$(DatabaseName)') WITH NOWAIT
    RETURN
END

GO
IF (DB_ID(N'$(DatabaseName)') IS NOT NULL) 
BEGIN
    ALTER DATABASE [$(DatabaseName)]
    SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [$(DatabaseName)];
END

GO
PRINT N'Creando $(DatabaseName)...'
GO
CREATE DATABASE [$(DatabaseName)] COLLATE SQL_Latin1_General_CP1_CI_AS
GO
EXECUTE sp_dbcmptlevel [$(DatabaseName)], 100;


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ANSI_NULLS ON,
                ANSI_PADDING ON,
                ANSI_WARNINGS ON,
                ARITHABORT ON,
                CONCAT_NULL_YIELDS_NULL ON,
                NUMERIC_ROUNDABORT OFF,
                QUOTED_IDENTIFIER ON,
                ANSI_NULL_DEFAULT ON,
                CURSOR_DEFAULT LOCAL,
                RECOVERY FULL,
                CURSOR_CLOSE_ON_COMMIT OFF,
                AUTO_CREATE_STATISTICS ON,
                AUTO_SHRINK OFF,
                AUTO_UPDATE_STATISTICS ON,
                RECURSIVE_TRIGGERS OFF 
            WITH ROLLBACK IMMEDIATE;
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CLOSE OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ALLOW_SNAPSHOT_ISOLATION OFF;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET READ_COMMITTED_SNAPSHOT OFF;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_UPDATE_STATISTICS_ASYNC OFF,
                PAGE_VERIFY NONE,
                DATE_CORRELATION_OPTIMIZATION OFF,
                DISABLE_BROKER,
                PARAMETERIZATION SIMPLE,
                SUPPLEMENTAL_LOGGING OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET TRUSTWORTHY OFF,
        DB_CHAINING OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'No se puede modificar la configuración de la base de datos. Debe ser un administrador del sistema para poder aplicar esta configuración.';
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET HONOR_BROKER_PRIORITY OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'No se puede modificar la configuración de la base de datos. Debe ser un administrador del sistema para poder aplicar esta configuración.';
    END


GO
USE [$(DatabaseName)]

GO
IF fulltextserviceproperty(N'IsFulltextInstalled') = 1
    EXECUTE sp_fulltext_database 'enable';


GO
PRINT N'Creando [dbo].[sp_traer_clientePorNombre]...';


GO
CREATE PROCEDURE [dbo].[sp_traer_clientePorNombre]
	@Nombre_cliente varchar(90)
AS
	select c.Idcliente, c.Nombre_cliente, c.App, c.Apm
	from Cliente c
	where (c.Nombre_cliente like '%' + @Nombre_cliente + '%'
			or c.Idcliente like '%' + @Nombre_cliente + '%')
GO
PRINT N'Creando [dbo].[sp_traer_compradorPorNombre]...';


GO
CREATE PROCEDURE [dbo].[sp_traer_compradorPorNombre]
	@Nombre_comprador varchar(90)
AS
	select c.Idcomprador, c.Nombre_comprador, c.App_comp, c.Apm_comp, c2.Idcliente, c2.Nombre_cliente, c2.App, c2.Apm
	from Comprador c inner join Cliente c2
	on c.Idcliente = c2.Idcliente
	where c.Idcliente = c2.Idcliente 
		and(c.Nombre_comprador like '%' + @Nombre_comprador + '%'
			or c.Idcomprador like '%' + @Nombre_comprador + '%')
GO
PRINT N'Creando [dbo].[sp_traer_fabricanteGeneral]...';


GO
CREATE PROCEDURE [dbo].[sp_traer_fabricanteGeneral]
	@Idfabricante bigint
as
	select * from Fabricante
GO
PRINT N'Creando [dbo].[sp_traer_fabricantePorNombre]...';


GO
CREATE PROCEDURE [dbo].[sp_traer_fabricantePorNombre]
	@Nombre_fabricante varchar(90)
AS
	select * from Fabricante
	where Nombre_fabricante like '%' + @Nombre_fabricante + '%'
			or Idfabricante like '%' + @Nombre_fabricante + '%'
GO
PRINT N'Creando [dbo].[sp_traer_pedidoGeneral]...';


GO
CREATE PROCEDURE [dbo].[sp_traer_pedidoGeneral]
	@Idpedido bigint
as
	select * from Pedido
GO
PRINT N'Creando [dbo].[sp_traer_pedidoPorId]...';


GO
CREATE PROCEDURE [dbo].[sp_traer_pedidoPorId]
	@Idpedido bigint
as
	if(@Idpedido=0)
		select * from Pedido
	else
		select * from Pedido where Idpedido=@Idpedido
GO
PRINT N'Creando [dbo].[sp_traer_productoGeneral]...';


GO
CREATE PROCEDURE [dbo].[sp_traer_productoGeneral]
		@Idfabricante bigint
as
	if(@Idfabricante=0)
		select p.Idproducto, p.Tipo_producto, f.Nombre_fabricante, p.Caracteristicas, p.Precio, p.Stock
		from Producto p inner join Fabricante f
		on p.Idfabricante = f.Idfabricante
	else
		select p.Idproducto, p.Tipo_producto, f.Nombre_fabricante, p.Caracteristicas, p.Precio, p.Stock
		from Producto p inner join Fabricante f
		on p.Idfabricante = f.Idfabricante
		where p.Idfabricante=@Idfabricante
GO
PRINT N'Creando [dbo].[sp_traer_productoPorNombre]...';


GO
CREATE PROCEDURE [dbo].[sp_traer_productoPorNombre]
	@Nombre_producto varchar(90)
AS
	select p.Idproducto, p.Tipo_producto, f.Nombre_fabricante, p.Caracteristicas, p.Precio, p.Stock
	from Producto p, Fabricante f
	where p.Idfabricante = f.Idfabricante
		and (p.Tipo_producto like '%' + @Nombre_producto + '%'
			or f.Nombre_fabricante like '%' + @Nombre_producto + '%')
GO
PRINT N'Creando [dbo].[sp_traer_productoPorTipo]...';


GO
CREATE PROCEDURE [dbo].[sp_traer_productoPorTipo]
	@Idfabricante bigint
as
	if(@Idfabricante=0)
		select p.Idproducto, p.Tipo_producto, p.Precio, f.Nombre_fabricante
		from Producto p inner join Fabricante f
		on p.Idfabricante = f.Idfabricante
	else
		select p.Idproducto, p.Tipo_producto, p.Precio, f.Nombre_fabricante
		from Producto p inner join Fabricante f
		on p.Idfabricante = f.Idfabricante
		where p.Idfabricante=@Idfabricante
GO
-- Paso de refactorización para actualizar el servidor de destino con los registros de transacciones implementadas
CREATE TABLE  [dbo].[__RefactorLog] (OperationKey UNIQUEIDENTIFIER NOT NULL PRIMARY KEY)
GO
sp_addextendedproperty N'microsoft_database_tools_support', N'refactoring log', N'schema', N'dbo', N'table', N'__RefactorLog'
GO

GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        DECLARE @VarDecimalSupported AS BIT;
        SELECT @VarDecimalSupported = 0;
        IF ((ServerProperty(N'EngineEdition') = 3)
            AND (((@@microsoftversion / power(2, 24) = 9)
                  AND (@@microsoftversion & 0xffff >= 3024))
                 OR ((@@microsoftversion / power(2, 24) = 10)
                     AND (@@microsoftversion & 0xffff >= 1600))))
            SELECT @VarDecimalSupported = 1;
        IF (@VarDecimalSupported > 0)
            BEGIN
                EXECUTE sp_db_vardecimal_storage_format N'$(DatabaseName)', 'ON';
            END
    END


GO
ALTER DATABASE [$(DatabaseName)]
    SET MULTI_USER 
    WITH ROLLBACK IMMEDIATE;


GO
