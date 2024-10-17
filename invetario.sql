
create database invetario

use invetario

create table producto(
	idproducto int primary key identity (1,1),
	nombreProducto varchar(80),
	modelo varchar(80),
	cantidad int
--fechaIngreso DATETIME DEFAULT GETDATE()
)


delete	from producto where idproducto= 11
select * from producto


