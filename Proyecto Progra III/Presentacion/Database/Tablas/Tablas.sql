create database dbOrbitalPC_ProyectoPrograIII_Sept2012
use dbOrbitalPC_ProyectoPrograIII_Sept2012
exec sp_addtype codigo, 'bigint','not null'

create table Cliente(
	Idcliente codigo primary key,
	Nombre_cliente varchar(90) not null,
	App varchar(90) not null,
	Apm varchar(90) not null,
	Nit bigint not null,
	Telefono bigint not null,
)
create table Comprador(
	Idcomprador codigo primary key,
	Nombre_comprador varchar(90) not null,
	App_comp varchar(90) not null,
	Apm_comp varchar(90) not null,
	Nit_comp bigint not null,
	Telefono_comp bigint not null,
	Idcliente codigo references Cliente(Idcliente)
)
create table Fabricante(
	Idfabricante codigo primary key,
	Nombre_fabricante varchar(90) not null,
)
create table Producto(
	Idproducto codigo primary key,
	Tipo_producto varchar(90) not null,
	Caracteristicas varchar(90) not null,
	Precio bigint not null,
	Stock bigint not null,
	Idfabricante codigo references Fabricante(Idfabricante)
)
create table Pedido(
	Idpedido codigo primary key,
	Fecha_pedido varchar(90) not null,
	Idcliente codigo references Cliente(Idcliente),
	Idcomprador codigo references Comprador(Idcomprador)
)
create table Detalle_Pedido(
	Precio_compra bigint not null,
	Cantidad bigint not null,
	Idpedido codigo references Pedido(Idpedido),
	Idproducto codigo references Producto(Idproducto)
)
create table Cargo(
	Idcargo codigo primary key,
	Nombre_cargo varchar(90) not null,
)
create table Administrativo(
	Idadm codigo primary key,
	Nombre_adm varchar(90) not null,
	App_adm varchar(90) not null,
	Apm_adm varchar(90) not null,
	Usuario varchar(90) not null,
	Pasword varchar(90) not null,
	Idcargo codigo references Cargo(Idcargo)
)
create table Factura(
	Idfactura codigo primary key,
	Fecha_factura varchar(90) not null,
	Detalle_factura varchar(90) not null,
)
create table Nota_Venta(
	Idnota_venta codigo primary key,
	Fecha_nota varchar(90) not null,
	Detalle_nota varchar(90) not null,
)