CREATE PROCEDURE [dbo].[sp_traer_clientePorNombre]
	@Nombre_cliente varchar(90)
AS
	select c.Idcliente, c.Nombre_cliente, c.App, c.Apm
	from Cliente c
	where (c.Nombre_cliente like '%' + @Nombre_cliente + '%'
			or c.Idcliente like '%' + @Nombre_cliente + '%')

go
CREATE PROCEDURE [dbo].[sp_traer_compradorPorNombre]
	@Nombre_comprador varchar(90)
AS
	select c.Idcomprador, c.Nombre_comprador, c.App_comp, c.Apm_comp, c2.Idcliente, c2.Nombre_cliente, c2.App, c2.Apm
	from Comprador c inner join Cliente c2
	on c.Idcliente = c2.Idcliente
	where c.Idcliente = c2.Idcliente 
		and(c.Nombre_comprador like '%' + @Nombre_comprador + '%'
			or c.Idcomprador like '%' + @Nombre_comprador + '%')

go
CREATE PROCEDURE [dbo].[sp_traer_fabricanteGeneral]
	@Idfabricante bigint
as
	select * from Fabricante

go
CREATE PROCEDURE [dbo].[sp_traer_fabricantePorNombre]
	@Nombre_fabricante varchar(90)
AS
	select * from Fabricante
	where Nombre_fabricante like '%' + @Nombre_fabricante + '%'
			or Idfabricante like '%' + @Nombre_fabricante + '%'

go
CREATE PROCEDURE [dbo].[sp_traer_pedidoGeneral]
	@Idpedido bigint
as
	select * from Pedido

go
CREATE PROCEDURE [dbo].[sp_traer_pedidoPorId]
	@Idpedido bigint
as
	if(@Idpedido=0)
		select * from Pedido
	else
		select * from Pedido where Idpedido=@Idpedido

go
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

go
CREATE PROCEDURE [dbo].[sp_traer_productoPorNombre]
	@Nombre_producto varchar(90)
AS
	select p.Idproducto, p.Tipo_producto, f.Nombre_fabricante, p.Caracteristicas, p.Precio, p.Stock
	from Producto p, Fabricante f
	where p.Idfabricante = f.Idfabricante
		and (p.Tipo_producto like '%' + @Nombre_producto + '%'
			or f.Nombre_fabricante like '%' + @Nombre_producto + '%')

go
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