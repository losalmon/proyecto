CREATE PROCEDURE [dbo].[sp_traer_fabricanteGeneral]
	@Idfabricante bigint
as
	select * from Fabricante