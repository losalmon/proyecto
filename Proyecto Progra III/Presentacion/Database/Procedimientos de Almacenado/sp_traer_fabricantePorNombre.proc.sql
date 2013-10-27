CREATE PROCEDURE [dbo].[sp_traer_fabricantePorNombre]
	@Nombre_fabricante varchar(90)
AS
	select * from Fabricante
	where Nombre_fabricante like '%' + @Nombre_fabricante + '%'
			or Idfabricante like '%' + @Nombre_fabricante + '%'