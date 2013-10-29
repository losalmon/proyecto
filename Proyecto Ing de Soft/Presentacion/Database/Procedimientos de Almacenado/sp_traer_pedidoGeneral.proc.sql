CREATE PROCEDURE [dbo].[sp_traer_pedidoGeneral]
	@Idpedido bigint
as
	select * from Pedido