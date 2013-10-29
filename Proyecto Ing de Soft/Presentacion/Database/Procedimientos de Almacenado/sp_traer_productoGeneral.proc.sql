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