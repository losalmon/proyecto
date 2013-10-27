CREATE PROCEDURE [dbo].[sp_traer_productoPorNombre]
	@Nombre_producto varchar(90)
AS
	select p.Idproducto, p.Tipo_producto, f.Nombre_fabricante, p.Caracteristicas, p.Precio, p.Stock
	from Producto p, Fabricante f
	where p.Idfabricante = f.Idfabricante
		and (p.Tipo_producto like '%' + @Nombre_producto + '%'
			or f.Nombre_fabricante like '%' + @Nombre_producto + '%')
