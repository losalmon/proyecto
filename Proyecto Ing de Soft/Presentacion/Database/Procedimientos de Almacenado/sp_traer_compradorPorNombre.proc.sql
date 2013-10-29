CREATE PROCEDURE [dbo].[sp_traer_compradorPorNombre]
	@Nombre_comprador varchar(90)
AS
	select c.Idcomprador, c.Nombre_comprador, c.App_comp, c.Apm_comp, c2.Idcliente, c2.Nombre_cliente, c2.App, c2.Apm
	from Comprador c inner join Cliente c2
	on c.Idcliente = c2.Idcliente
	where c.Idcliente = c2.Idcliente 
		and(c.Nombre_comprador like '%' + @Nombre_comprador + '%'
			or c.Idcomprador like '%' + @Nombre_comprador + '%')