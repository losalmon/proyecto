CREATE PROCEDURE [dbo].[sp_traer_clientePorNombre]
	@Nombre_cliente varchar(90)
AS
	select c.Idcliente, c.Nombre_cliente, c.App, c.Apm
	from Cliente c
	where (c.Nombre_cliente like '%' + @Nombre_cliente + '%'
			or c.Idcliente like '%' + @Nombre_cliente + '%')