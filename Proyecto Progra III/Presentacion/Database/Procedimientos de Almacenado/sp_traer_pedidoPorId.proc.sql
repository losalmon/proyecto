CREATE PROCEDURE [dbo].[sp_traer_pedidoPorId]
	@Idpedido bigint
as
	if(@Idpedido=0)
		select * from Pedido
	else
		select * from Pedido where Idpedido=@Idpedido