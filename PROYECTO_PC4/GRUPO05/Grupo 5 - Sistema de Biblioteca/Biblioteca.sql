CREATE DATABASE SISTBIBLIOTECA
USE SISTBIBLIOTECA

CREATE TABLE AUTORSB(
	IDautor			 int,
	AutorNombre		 char(200),
	PRIMARY KEY(IDautor)
)	

CREATE TABLE TEMASB(
	IDtema			 int,
	Tema			 char(200),
	PRIMARY KEY(IDtema)
)

CREATE TABLE LIBROSSB(
	IDlibros		 int,
	Titulo			 char(200),
	IDautor			 int,
	IDTema			 int,
	Categoria		 char(200),
	N_ejemplares	 int,
	Estante			 int,
	Casillero		 int,
	Observaciones	 char(200),
	PRIMARY KEY(IDlibros),
FOREIGN KEY (IDautor) REFERENCES AUTORSB(IDautor),
FOREIGN KEY (IDtema) REFERENCES TEMASB(IDtema)
)	

CREATE TABLE PRESTAMISTASB(
	NumDocPrestamista	 int,
	PrestamistaNombre	 char(200),
	Usuario				 char(200),
	Contrase�a			 int,
	PRIMARY KEY(NumDocPrestamista)
)	

CREATE TABLE USUARIOSB(
	NumDocUsuario		 int,
	UsuarioNombre		 char(200),
	FechaIngreso		 char(200),
	Direccion			 char(200),
	Celular				 int,
	Correo				 char(200),
	PRIMARY KEY(NumDocUsuario),
)

CREATE TABLE PRESTAMOSB(
	IDprestamos			int,
	NumDocPrestamista	int,
	NumDocUsuario		int,	
	IDlibros			int,
	FechaInicio			date,
	FechaFin			date,
	N_ejemplares		int,
	ObsInicio			char(200),	
	ObsFin				char(200),
	PRIMARY KEY(IDprestamos),
FOREIGN KEY (IDlibros) REFERENCES LIBROSSB(IDlibros),
FOREIGN KEY (NumDocPrestamista) REFERENCES PRESTAMISTASB(NumDocPrestamista),
FOREIGN KEY (NumDocUsuario) REFERENCES USUARIOSB(NumDocUsuario)
)

CREATE TABLE SANCIONSB(
	IDsancion				int,
	NumDocUsuario			int,
	SancionInicio			date,
	SancionFin				date,
	PRIMARY KEY(IDsancion),
FOREIGN KEY (NumDocUsuario) REFERENCES USUARIOSB(NumDocUsuario)
)

CREATE TABLE PRESTAMOESTUDIO(
	IDprestamo				int,
	NumDocUsuario			int,
	NumDocPrestamista		int,
	PRIMARY KEY(IDprestamo),
FOREIGN KEY (NumDocPrestamista) REFERENCES PRESTAMISTASB(NumDocPrestamista),
FOREIGN KEY (NumDocUsuario) REFERENCES USUARIOSB(NumDocUsuario)
)


INSERT INTO AUTORSB (IDautor,AutorNombre)
VALUES 
	(10, 'Jos� Aranda'),
	(11, 'Francisco Javier P�rez Gonz�lez'),
	(12, 'N�stor Daniel B�cari'),
	(13, 'Mar�a Cristina Vacchino'),
	(14, 'Graciela Recabarren'),
	(15, 'Miguel Barreda Rochera'),
	(16, 'Elsie Hern�ndez S'),
	(17, 'Marta Susana Bonacina'),
	(18, 'Walter Mora F.'),
	(19, 'Fernando Revilla Jim�nez')


INSERT INTO TEMASB (IDtema,Tema)
VALUES 
	(100, 'an�lisis matem�tico b�sico'),
	(101, 'Axiomas en R'),
	(102, 'funciones, derivadas, continuidad'),
	(103, 'l�mite y continuidad'),
	(104, 'aplicaciones de la derivada y diferencial'),
	(105, 'integraci�n en una variable'),
	(106, 'aplicaciones de las integrales definidas'),
	(107, 'integrales y sus aplicaciones'),
	(108, 'ecuaciones diferenciales'),
	(109, 'c�lculo multivariable')


INSERT INTO LIBROSSB (IDlibros,Titulo,IDautor,IDtema,Categoria,N_ejemplares,Estante,Casillero,Observaciones)
VALUES

	(1000, 'C�lculo diferencial e integral de funciones de una variable',10,100,'Libros p�stumos',5,1,1,'any'),
	(1001, 'C�lculo diferencial',11,101,'C�dices',3,4,3,'any'),
	(1002, 'C�lculo integral para funciones a valores reales y vectoriales',12,102,'Libros ficticios',4,2,2,'any'),
	(1003, 'An�lisis Matem�tico I',13,103,'Diarios personales',5,2,3,'any'),
	(1004, 'Fundamentos matem�ticos de la ingenier�a II: C�lculo diferencial e integral',14,104,'Libros electr�nicos',3,3,3,'any'),
	(1005, 'C�lculo diferencial e integral con aplicaciones, de Elsie Hern�ndez Saborio',15,105,'Libros inacabados',4,4,4,'any'),
	(1006, 'C�lculo diferencial e integral',16,106,'Incunables',5,5,5,'any'),
	(1007, 'C�lculo en varias variables',17,107,'Libros de entrevistas',4,6,6,'any'),
	(1008, 'Problemas resueltos de an�lisis matem�tico',18,108,'Libros de texto',3,7,7,'any'),
	(1009, 'Apuntes de c�lculo diferencial e integral de funciones de varias variables',19,109,'Libros ilustrados',4,8,8,'any')




INSERT INTO PRESTAMISTASB (NumDocPrestamista,PrestamistaNombre,Usuario,Contrase�a)
VALUES

	(71751989, 'Miliana Quispe Bejar','Milianita',1234),
	(77589626, 'Michelle Marin Padilla','Michilover',2345),
	(78956412, 'Reynaldo Caceres','ElFlaco',3456),
	(78956325, 'Jhonatan Napan','Nikoni',4567),
	(78596325, 'Sebastian Angeles','Angelito',5678),
	(78594125, 'Andres Pulido','Andi',6789),
	(36952684, 'Lenin de la Cruz','Delacruz',7891),
	(78956824, 'Francisco Yupanqui','Franz',8912),
	(56982314, 'Angel Ponce','Ponce',9123),
	(56489723, 'Junior Espinosa','Espina',9182)


INSERT INTO USUARIOSB (NumDocUsuario,UsuarioNombre,FechaIngreso,Direccion,Celular,Correo)
VALUES

	(98562312, 'Jhosephine Alvares','15-03-2015','Los Jazmines 140',955862356,'josy@gmail.com'),
	(95126347, 'Carmen Cuadros','15-04-2015','Los Duraznos 140',944862356,'camu@gmail.com'),
	(98562471, 'Nataly Cotrina','19-03-2015','Los Manantialas 14',955232356,'nati@gmail.com'),
	(96325412, 'Nicole Taboada','21-05-2014','Manzanos 10',955862390,'nic@gmail.com'),
	(91235487, 'Duberly Mamani','10-01-2013','Do�a Laura 140',911162356,'dud@gmail.com'),
	(65231478, 'Josue Poma','15-06-2015','Do�a Juana 23',922262356,'josue@gmail.com'),
	(63258741, 'Linnar Paredes','23-04-2015','Las Paltas 100',933362356,'linnar@gmail.com'),
	(98541723, 'Andree Culquicondor','01-09-2013','Las Mandarinas 10',944462356,'andre@gmail.com'),
	(36524871, 'Omar Ramos','30-03-2014','Do�a Maria 140',988862356,'omar@gmail.com'),
	(98521475, 'Anderson Laos','15-09-2014','28 de julio 25',999962356,'laos@gmail.com')


INSERT INTO PRESTAMOSB (IDprestamos,NumDocPrestamista,NumDocUsuario,IDlibros,FechaInicio,FechaFin,N_ejemplares,ObsInicio,ObsFin)
VALUES

	(1231,71751989,98562312,1000,'15-01-2018','20-01-2018',5,'any','any'),
	(1232,77589626,95126347,1001,'16-02-2018','21-02-2018',3,'any','Tapa rota'),
	(1233,78956412,98562471,1002,'17-03-2018','22-03-2018',4,'any','any'),
	(1234,78956325,96325412,1003,'18-04-2018','23-04-2018',5,'any','any'),
	(1235,78596325,91235487,1004,'19-05-2018','24-05-2018',3,'any','hojas dobladas'),
	(1236,78594125,65231478,1005,'20-06-2018','25-06-2018',4,'any','any'),
	(1237,36952684,63258741,1006,'21-07-2018','26-07-2018',5,'any','any'),
	(1238,78956824,98541723,1007,'22-08-2018','27-08-2018',4,'any','any'),
	(1239,56982314,36524871,1008,'23-09-2018','28-09-2018',3,'any','any'),
	(1210,56489723,98521475,1009,'24-10-2018','29-10-2018',4,'any','any')

	INSERT INTO SANCIONSB(IDsancion	,NumDocUsuario,SancionInicio,SancionFin)
values 
    (1111,98562312,'',''),
	(1112,95126347,'22-02-2018','22-03-2018'),
	(1113,98562471,'',''),
	(1114,96325412,'',''),
	(1115,91235487,'25-05-2018','24-06-2018'),
	(1116,65231478,'',''),
	(1117,63258741,'',''),
	(1118,98541723,'',''),
	(1119,36524871,'',''),
	(1120,98521475,'','')
	
	INSERT INTO PRESTAMOESTUDIO( IDprestamo ,NumDocUsuario ,NumDocPrestamista)
values
	(2221,98562312,71751989),
	(2222,95126347,77589626),
	(2223,98562471,78956412),
	(2224,96325412,78956325),
	(2225,91235487,78596325),
	(2226,65231478,78594125),
	(2227,63258741,36952684),
	(2228,98541723,78956824),
	(2229,36524871,56982314),
	(2230,98521475,56489723)