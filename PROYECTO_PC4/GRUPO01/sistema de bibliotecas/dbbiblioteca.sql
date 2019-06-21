drop database dbbiblioteca
/* CREAMOS LA BASE DE DATOS*/
CREATE DATABASE dbbiblioteca
go
/* SELECCIONAMOS LA BASE DE DATOS CREADA */
USE dbbiblioteca
/* CREAMOS LA TABLA BIBLIOTECARIO*/
go
CREATE TABLE bibliotecario(
CodBibliotecario int identity primary key,
Nombres varchar(50),
Apellidos varchar(50),
Direccion varchar(100),
Email varchar(60),
Telefono int,
Dni int,
Nro_Carnet varchar(6),
Clave varchar(50)
)
go
/*CREAMOS LA TABLA LECTOR*/
CREATE TABLE lector(
CodLector int primary key identity,
Nombres varchar(50),
Apellidos varchar(50),
Direccion varchar(100),
Email varchar(60),
Telefono int
)
go
/*CREAMOS TABLAS DE LOS DETALLES DE LOS LIBROS*/
CREATE TABLE autor(
CodAutor int primary key identity,
Autor varchar(100)
)
go
CREATE TABLE genero(
CodGenero int primary key identity,
Genero varchar(100)
)
go
CREATE TABLE editorial(
CodEditorial int primary key identity,
Editorial varchar(100)
)


/* CREAMOS LA TABLA LIBROS*/
go
CREATE TABLE libros(
CodLibro int primary key identity,
Titulo varchar(100),
CodAutor int foreign key references autor(CodAutor) on delete cascade on update cascade not null,
CodGenero int foreign key references genero(CodGenero) on delete cascade on update cascade not null,
CodEditorial int foreign key references editorial(Codeditorial) on delete cascade on update cascade not null,
Ubicacion varchar(50),
Cantidad int
)
go
/*CREAMOS EL STOCK DE LIBROS */
CREATE TABLE stocklibros(
CodStock int primary key identity,
CodLibro int foreign key references libros(CodLibro) on delete cascade on update cascade not null,
Disponibles int
)
go
/*CREAMOS LA TABLA PRESTAMO*/

CREATE TABLE prestamo(
CodPrestamo int primary key identity,
CodLector int foreign key references lector(CodLector) on delete cascade on update cascade not null,
CodLibro int foreign key references libros(CodLibro) on delete cascade on update cascade not null,
Fec_Entrega date,
Fec_Devolucion date,
Fec_Retorno date,
Estado varchar(50)
)

/*---------------------------CREAMOS UN PROCEDIMIENTO PARA GENERAR UN NUEVO CARNET-------------------------------*/
go
CREATE PROC NroCarnetBibliotecario
AS
BEGIN
	DECLARE @cantidad int
	DECLARE @numero int
	SET @cantidad =  (SELECT COUNT(*) FROM bibliotecario)

   if @cantidad = 0
		begin
		SET @numero = 1
		end	
   else
		begin
		DECLARE @antiguocarnet varchar(50)
		SET @antiguocarnet = SUBSTRING( (SELECT TOP 1 Nro_Carnet FROM bibliotecario ORDER BY Nro_Carnet DESC),2,5)
		SET @numero =  CONVERT(INT,@antiguocarnet) + 1;
		end

	DECLARE @nuevocarnet varchar(7)
	SET @nuevocarnet =('B' + right('000000' + convert(varchar(5),@numero),5))
	SELECT @nuevocarnet
 END

 go
 /*-------------------------------------PROCEDIMIENTOS ALMACENADOS PARA BIBLIOTECARIO----------------------------------*/

 CREATE PROC AccederBibliotecario
 @user varchar(50),
 @clave varchar(50)
 AS
 BEGIN
 SELECT * FROM bibliotecario WHERE Nro_Carnet = @user AND Clave = @clave
 END

 go

 /*CREAMOS UN PROCEDIMIENTO PARA MOSTRAR BIBLIOTECARIOS SEGUN FILTROS*/
 CREATE PROC MostrarBibliotecarios
 AS
 BEGIN
	SELECT CodBibliotecario, Nombres, Apellidos,Direccion,Email,Telefono,Dni,Nro_Carnet FROM bibliotecario
 END
go
 /*CREAMOS UN PROCEDIMIENTO PARA AGREGAR BIBLIOTECARIO*/
 CREATE PROC AgregarBibliotecario
 @nombres varchar(50),
 @apellidos varchar(50),
 @direccion varchar(100),
 @email varchar(60),
 @telefono int,
 @dni int,
 @nro_carnet varchar(6),
 @contrasena varchar(50)
 AS
 BEGIN
 INSERT INTO bibliotecario VALUES (@nombres,@apellidos,@direccion,@email,@telefono,@dni,@nro_carnet,@contrasena)
 END

 /*CREAMOS UN PROCEDIMIENTO PARA MODIFICAR BIBLIOTECARIO*/
 go
 CREATE PROC ModificarBibliotecario
 @codbibliotecario int,
 @nombres varchar(50),
 @apellidos varchar(50),
 @direccion varchar(100),
 @email varchar(60),
 @telefono int,
 @dni int
 AS
 BEGIN
 UPDATE bibliotecario SET Nombres = @nombres, Apellidos = @apellidos, Direccion = @direccion, Email= @email, Telefono = @telefono, Dni = @dni
 WHERE CodBibliotecario = @codbibliotecario
 END
 go
  /*CREAMOS UN PROCEDIMIENTO PARA ELIMINAR BIBLIOTECARIO*/
  CREATE PROC EliminarBibliotecario
  @codbibliotecario int
  AS
  BEGIN
  DELETE FROM bibliotecario WHERE CodBibliotecario = @codbibliotecario
  END
  go
  /*---------------------------------------------PROCEDIMIENTOS PARA LECTOR---------------------------------------------*/
  
 /*CREAMOS UN PROCEDIMIENTO PARA MOSTRAR LECTORES SEGUN FILTROS*/
 /*PROCEDIMIENTO PARA VERIFICAR LECTORES*/
 CREATE PROC VerificarLector
 @codlector int
 AS
 BEGIN
	select * from prestamo where Fec_Devolucion < GETDATE() and Estado = 'Pendiente' and CodLector = @codlector
 END

 go

 CREATE PROC MostrarLectores
 AS
 BEGIN

	SELECT CodLector, Nombres, Apellidos,Direccion,Email,Telefono FROM lector order by CodLector desc
 END

  go
 /*CREAMOS UN PROCEDIMIENTO PARA AGREGAR LECTOR*/
 CREATE PROC AgregarLector
 @nombres varchar(50),
 @apellidos varchar(50),
 @direccion varchar(100),
 @email varchar(60),
 @telefono int
 AS
 BEGIN
 INSERT INTO lector VALUES (@nombres,@apellidos,@direccion,@email,@telefono)
 END

 /*CREAMOS UN PROCEDIMIENTO PARA MODIFICAR LECTOR*/
 go
 CREATE PROC ModificarLector
 @codlector int,
 @nombres varchar(50),
 @apellidos varchar(50),
 @direccion varchar(100),
 @email varchar(60),
 @telefono int
 AS
 BEGIN
 UPDATE lector SET Nombres = @nombres, Apellidos = @apellidos, Direccion = @direccion, Email= @email, Telefono = @telefono
 WHERE Codlector = @codlector
 END
 go
  /*CREAMOS UN PROCEDIMIENTO PARA ELIMINAR LECTOR*/
  CREATE PROC EliminarLector
  @codlector int
  AS
  BEGIN
  DELETE FROM lector WHERE CodLector = @codlector
  END





   /*----------------------------------------PROCEDIMIENTOS PARA AUTOR--------------------------------------------*/

go
 /*CREAMOS UN PROCEDIMIENTO PARA AUTORES SEGUN FILTROS*/
 CREATE PROC MostrarAutor
 AS
 BEGIN

	SELECT CodAutor as Codigo, Autor FROM autor ORDER BY CodAutor desc
 END

  go
 /*CREAMOS UN PROCEDIMIENTO PARA AGREGAR AUTOR*/
 CREATE PROC AgregarAutor
 @autor varchar(50)
 AS
 BEGIN
 INSERT INTO autor VALUES (@autor)
 END

 /*CREAMOS UN PROCEDIMIENTO PARA MODIFICAR AUTOR*/
 go
 CREATE PROC ModificarAutor
 @codautor int,
 @autor varchar(50)
 AS
 BEGIN
 UPDATE autor SET Autor = @autor
 WHERE CodAutor = @codautor
 END
 go
  /*CREAMOS UN PROCEDIMIENTO PARA ELIMINAR AUTOR*/
  CREATE PROC EliminarAutor
  @codautor int
  AS
  BEGIN
  DELETE FROM autor WHERE CodAutor = @codautor
  END


  go
  
   /*-------------------------------------PROCEDIMIENTOS PARA GENERO---------------------------------------------*/
  
  
 /*CREAMOS UN PROCEDIMIENTO PARA GENEROS SEGUN FILTROS*/
 CREATE PROC MostrarGenero
 AS
 BEGIN

	SELECT CodGenero as Codigo, Genero FROM genero order by CodGenero desc
 END

  go
 /*CREAMOS UN PROCEDIMIENTO PARA AGREGAR GENERO*/
 CREATE PROC AgregarGenero
 @genero varchar(50)
 AS
 BEGIN
 INSERT INTO genero VALUES (@genero)
 END
 go
 /*CREAMOS UN PROCEDIMIENTO PARA MODIFICAR GENERO*/
 
 CREATE PROC ModificarGenero
 @codgenero int,
 @genero varchar(50)
 AS
 BEGIN
 UPDATE genero SET Genero = @genero
 WHERE CodGenero = @codgenero
 END
 go
  /*CREAMOS UN PROCEDIMIENTO PARA ELIMINAR GENERO*/
  CREATE PROC EliminarGenero
  @codgenero int
  AS
  BEGIN
  DELETE FROM genero WHERE CodGenero = @codgenero
  END



  go
  
   /*--------------------------------------------PROCEDIMIENTOS PARA EDITORIAL----------------------------------------------*/

 /*CREAMOS UN PROCEDIMIENTO PARA EDITORIAL SEGUN FILTROS*/
 CREATE PROC MostrarEditorial
 AS
 BEGIN
	SELECT CodEditorial as Codigo, Editorial FROM editorial ORDER BY CodEditorial DESC
 END

  go
 /*CREAMOS UN PROCEDIMIENTO PARA AGREGAR Editorial*/
 CREATE PROC AgregarEditorial
 @editorial varchar(50)
 AS
 BEGIN
 INSERT INTO editorial VALUES (@editorial)
 END
 go
 /*CREAMOS UN PROCEDIMIENTO PARA MODIFICAR EDITORIAL*/
 
 CREATE PROC ModificarEditorial
 @codeditorial int,
 @editorial varchar(50)
 AS
 BEGIN
 UPDATE editorial SET Editorial = @editorial
 WHERE CodEditorial = @codeditorial
 END
 go
  /*CREAMOS UN PROCEDIMIENTO PARA ELIMINAR EDITORIAL*/
  CREATE PROC EliminarEditorial
  @codeditorial int
  AS
  BEGIN
  DELETE FROM editorial WHERE CodEditorial = @codeditorial
  END

  go
  
  /*--------------------------------------------PROCEDIMIENTOS PARA LIBROS------------------------------------------------------*/
  
 /*CREAMOS UN PROCEDIMIENTO PARA MOSTRAR LIBROS SEGUN FILTROS*/


 CREATE PROC MostrarLibros
 AS
 BEGIN
	SELECT LI.CodLibro, LI.Titulo,AU.CodAutor, AU.Autor, GE.CodGenero, GE.Genero, ED.CodEditorial, ED.Editorial, LI.Ubicacion, LI.Cantidad
	FROM libros LI
	INNER JOIN autor AU ON AU.CodAutor = LI.CodAutor
	INNER JOIN genero GE ON GE.CodGenero = LI.CodGenero
	INNER JOIN editorial ED ON ED.CodEditorial = LI.CodEditorial
	order by LI.CodLibro DESC
 END
 go
 /*-----------------------PROCEDIMIENTO ALMACENADO PARA LOS REPORTES DE LOS LIBROS---------------------------------*/
 
 CREATE PROC ReporteLibros
 @busqueda varchar(100)
 AS
 BEGIN
	SELECT LI.CodLibro, LI.Titulo,AU.Autor, GE.Genero, ED.Editorial, LI.Ubicacion, LI.Cantidad
	FROM libros LI
	INNER JOIN autor AU ON AU.CodAutor = LI.CodAutor
	INNER JOIN genero GE ON GE.CodGenero = LI.CodGenero
	INNER JOIN editorial ED ON ED.CodEditorial = LI.CodEditorial
	WHERE LI.Titulo like @busqueda +'%' OR
	AU.Autor like @busqueda +'%' OR
	GE.Genero LIKE @busqueda +'%' OR
	ED.Editorial LIKE @busqueda +'%'
 END
 



 go
 
  /*CREAMOS UN PROCEDIMIENTO PARA MOSTRAR STOCK DE LIBROS SEGUN FILTROS*/
 CREATE PROC MostrarLibrosStock
 as
 begin
	SELECT LI.CodLibro AS Codigo, LI.Titulo, AU.Autor, SL.Disponibles FROM stocklibros SL
	INNER JOIN libros LI on LI.CodLibro = SL.CodLibro
	INNER JOIN autor AU ON AU.CodAutor = LI.CodAutor
	order by LI.CodLibro DESC
 end
 GO
 /*CREAMOS UN PROCEDIMIENTO PARA VERIFICAR STOCK DEL LIBRO*/
 CREATE PROC VerificarLibro
 @codlibro INT
 as
 begin
	select Disponibles from stocklibros where Codlibro = @codlibro
 end

 GO

 /*CREAMOS UN PROCEDIMIENTO PARA VERIFICAR LA CANTIDAD DISPONIBLE*/
 CREATE PROC VerificarCantidadLibro
 @codlibro INT
 as
 begin
	select * from prestamo where Codlibro = @codlibro and Estado = 'Pendiente'
 end


  go
 /*CREAMOS UN PROCEDIMIENTO PARA AGREGAR LIBRO*/
 CREATE PROC AgregarLibro
 @titulo varchar(50),
 @codautor int,
 @codgenero int,
 @codeditorial int,
 @ubicacion varchar(50),
 @cantidad int
 AS
 BEGIN
 INSERT INTO libros VALUES (@titulo,@codautor,@codgenero,@codeditorial,@ubicacion,@cantidad)
 END

 go
 /*CREAMOS UN PROCEDIMIENTO PARA MODIFICAR LIBRO*/

 CREATE PROC ModificarLibro
 @codlibro int,
 @titulo varchar(50),
 @codautor int,
 @codgenero int,
 @codeditorial int,
 @ubicacion varchar(50),
 @cantidad int
 AS
 BEGIN
 UPDATE libros SET Titulo = @titulo, CodAutor = @codautor, CodGenero = @codgenero, CodEditorial = @codeditorial, Ubicacion = @ubicacion, Cantidad = @cantidad
 WHERE Codlibro = @codlibro
 END

 go
  /*CREAMOS UN PROCEDIMIENTO PARA ELIMINAR LIBRO*/
  CREATE PROC EliminarLibro
  @codlibro int
  AS
  BEGIN
  DELETE FROM libros WHERE CodLibro = @codlibro
  END

  go
 
 /*-------------------------------------------PROCEDIMIENTOS PARA PRESTAMO----------------------------------------------*/
 
 /*CREAMOS UN PROCEDIMIENTO PARA MOSTRAR PRESTAMOS SEGUN FILTROS*/
 CREATE PROC MostrarPrestamo
 AS
 BEGIN
	SELECT PR.CodPrestamo AS 'Nro Registro',(LE.Nombres + ' ' + LE.Apellidos) AS Lector , LI.Titulo , PR.Fec_Entrega, PR.Fec_Devolucion, PR.Fec_Retorno, PR.Estado FROM prestamo PR
	INNER JOIN lector LE on LE.CodLector = PR.CodLector
	INNER JOIN libros LI on LI.CodLibro = PR.CodLibro
	WHERE PR.Estado = 'Pendiente'
	order by PR.CodPrestamo desc
 END
 go
 /*......................CREAMOS LA VISTA PARA EL REPORTE......................*/

 CREATE PROC ReportePrestamos
 @busqueda varchar(100)
 AS
 BEGIN
 	SELECT PR.CodPrestamo,(LE.Nombres + ' ' + LE.Apellidos) AS Lector , LI.Titulo , PR.Fec_Entrega, PR.Fec_Devolucion, PR.Estado FROM prestamo PR
	INNER JOIN lector LE on LE.CodLector = PR.CodLector
	INNER JOIN libros LI on LI.CodLibro = PR.CodLibro
	WHERE PR.Estado = 'Pendiente' and
	(LI.Titulo like @busqueda + '%' OR LE.Nombres like @busqueda +'%' OR LE.Apellidos like @busqueda +'%')
 END
 


 go
  /*CREAMOS UN PROCEDIMIENTO PARA MOSTRAR PRESTAMOS DEVUELTOS SEGUN FILTROS*/
 CREATE PROC MostrarPrestamoDevueltos
 AS
 BEGIN
	SELECT PR.CodPrestamo AS 'Nro Registro',(LE.Nombres + ' ' + LE.Apellidos) AS Lector , LI.Titulo , PR.Fec_Entrega, PR.Fec_Devolucion, PR.Fec_Retorno, PR.Estado FROM prestamo PR
	INNER JOIN lector LE on LE.CodLector = PR.CodLector
	INNER JOIN libros LI on LI.CodLibro = PR.CodLibro
	WHERE PR.Estado = 'Retornado'
	order by PR.CodPrestamo desc
 END
 go

 /*CREAMOS UN PROCEDIMIENTO PARA VERIFICAR PRESTAMOS POR LECTOR*/
 CREATE PROC MostrarPrestamoDeudaLecor
 @codlector int
 AS
 BEGIN
	select (LE.Nombres + ' ' + LE.Apellidos) as Lector, LI.Titulo, PR.Fec_Entrega, Fec_Devolucion, PR.Estado from prestamo PR
	inner join lector LE on LE.CodLector = PR.CodLector
	inner join libros LI on LI.CodLibro = PR.CodLibro
	where Fec_Devolucion < GETDATE() and PR.Estado = 'Pendiente' and PR.CodLector = @codlector
 END

 GO
 /*CREAMOS UN PROCEDIMIENTO PARA AGREGAR PRESTAMO*/
 CREATE PROC AgregarPrestamo
 @codlector int,
 @codlibro int,
 @fec_devolucion date
 AS
 BEGIN
 declare @fe date
 set @fe = getdate()
 INSERT INTO prestamo VALUES (@codlector,@codlibro,@fe,@fec_devolucion,null,'Pendiente')
 END
 
 go
 /*CREAMOS UN PROCEDIMIENTO PARA MODIFICAR PRESTAMO*/
 
 CREATE PROC ModificarPrestamoRetorno
 @codprestamo int
 AS
 BEGIN
 declare @fe date
 set @fe = getdate()
 UPDATE prestamo SET Fec_Retorno = @fe, Estado = 'Retornado'
 WHERE CodPrestamo = @codprestamo
 END
 GO
/*EL PRESTAMO NO SE ELIMINARÁ DE LOS REGISTROS*/

/*------------------------------------------------CREACION DE TRIGGERS-----------------------------------------------*/
/*AHORA CREAREMOS UN TRIGGER PARA ALMACENAR AUTOMATICAMENTE
//EN LA TABLA stocklibros CADA VEZ QUE SE ALMACENE UN LIBRO
*/


go 

CREATE TRIGGER AgregarStockNuevo ON libros
AFTER INSERT 
AS
BEGIN
DECLARE @codlibro int
set @codlibro = (SELECT TOP 1 CodLibro FROM libros ORDER BY CodLibro DESC)

DECLARE @cantidad int
set @cantidad = (SELECT Cantidad from libros where CodLibro = @codlibro)
INSERT INTO stocklibros VALUES (@codlibro, @cantidad)
END

go

/*AHORA CREAMO UN TRIGGER PARA DISMINUIR EL STOCK DE LIBROS
CADA VEZ QUE OCURRA UN PRESTAMO
*/


CREATE TRIGGER DisminuirStocklibro ON prestamo
AFTER INSERT 
AS
BEGIN
DECLARE @codlibro int
set @codlibro = (SELECT Codlibro from inserted)
UPDATE stocklibros SET Disponibles = (Disponibles - 1) WHERE CodLibro = @codlibro
END


go


/*AHORA CREAMOS UN TRIGGER PARA AUMENTAR EL STOCK DE LIBROS
CADA VEZ QUE OCURRA QUE SE DEVUELVA UN PRESTAMO*/


CREATE TRIGGER AumentarStocklibro ON prestamo
AFTER UPDATE 
AS
BEGIN
Declare @codlibro int
set @codlibro = (select codlibro from inserted)
UPDATE stocklibros SET Disponibles = (Disponibles + 1) WHERE CodLibro = @codlibro
END


