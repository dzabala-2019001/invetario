--
-- CREACION DE DB Y EL GO FINALIZA LA INSTRUCCION 
CREATE DATABASE PREUBA1
GO

-- USO DE LA DB
USE PREUBA1

-- IDENTITY LOS DATOS LOS MANDA AUTOMATICAMENTE 

CREATE TABLE producto(
	idproducto int  IDENTITY(1, 1) PRIMARY KEY,
	nombreEquipo varchar(80),
	modelo varchar(80),
	cantidad int
)

-- inserta un nuevo dato
INSERT INTO producto (nombreEquipo, modelo, cantidad)
	values('Monitor Dell', 'E2020H', 8)


-- muestra los datos de la tabla
select * from producto

-- eliminar cierto dato con el id 

delete from producto where idproducto= '5'


-- AL AGREGAR UN MISMO PRODUCTO QUE YA EXISTE ACTUALIZA EL STOCK(CANTIDAD)
DECLARE @nombreEquipo varchar(80) = 'Monitor';
DECLARE @modelo varchar(80) = 'E2020H';
DECLARE @cantidad int = 10;

IF @cantidad < 0
BEGIN
    PRINT 'La cantidad no puede ser un número negativo.';
END
ELSE
BEGIN
    IF EXISTS (SELECT 1 FROM producto WHERE nombreEquipo = @nombreEquipo AND modelo = @modelo)
    BEGIN
        UPDATE producto
        SET cantidad = cantidad + @cantidad
        WHERE nombreEquipo = @nombreEquipo AND modelo = @modelo;
    END
    ELSE
    BEGIN
        INSERT INTO producto (nombreEquipo, modelo, cantidad)
        VALUES (@nombreEquipo, @modelo, @cantidad);
    END
END



-- RESTA EL STOCK AL MOMENTO QUE SALGA UN PRODUCTO
DECLARE @nombreEquipo varchar(80) = 'Monitor Dell';
DECLARE @modelo varchar(80) = 'E2020H';
DECLARE @cantidad int = 22;

IF EXISTS (SELECT 1 FROM producto WHERE nombreEquipo = @nombreEquipo AND modelo = @modelo)
BEGIN
    DECLARE @stockActual int;

    SELECT @stockActual = cantidad 
    FROM producto 
    WHERE nombreEquipo = @nombreEquipo AND modelo = @modelo;

    IF @stockActual >= @cantidad
    BEGIN
        UPDATE producto
        SET cantidad = cantidad - @cantidad
        WHERE nombreEquipo = @nombreEquipo AND modelo = @modelo;
    END
    ELSE
    BEGIN
        PRINT 'No se puede restar más cantidad de la que hay en stock.';
    END
END
ELSE
BEGIN
    PRINT 'El producto no existe en la base de datos';
END


-- eliminar un producto pero si aun tiene stock no permitir 
