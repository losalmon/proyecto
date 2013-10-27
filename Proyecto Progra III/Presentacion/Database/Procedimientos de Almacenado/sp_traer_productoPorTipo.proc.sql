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