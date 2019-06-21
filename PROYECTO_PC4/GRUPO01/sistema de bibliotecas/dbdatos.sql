
/*INSERTAMOS DATOS EN LA TABLA BIBLIOTECARIO*/
use dbbiblioteca
INSERT INTO bibliotecario VALUES ('Jose','Chambi','Av. Milagros','Jchambi08@gmail.com','963003456','87898526','B00001','admin1')
go


Insert into editorial values('Navarrete')
Insert into editorial values('Sierra')
Insert into editorial values('Random House')
Insert into editorial values('Alfaguara')
Insert into editorial values('Letras Hispanicas')
Insert into editorial values('Fondo de Cultura Económica')
Insert into editorial values('Debols!llo')
Insert into editorial values('Talleres de la penitencia de lima')

go
insert into autor values('Cesar Vallejo')
insert into autor values('CIRE')
insert into autor values('Gabriel García Márquez')
insert into autor values('Mario Vargas LLosa')
insert into autor values('Augusto Roa Bastos')
insert into autor values('Carlos Fuentes')
insert into autor values('Laura Esquivel')
select * from libros
go

insert into genero values('Magical Realism, Novela')
insert into genero values('Poema')
insert into genero values('Ficción Histórica')
insert into genero values('Ficción')
insert into genero values('Tragedia')
insert into genero values('Lírico')

go

insert into libros values ('Los perros y la ciudad',4,1,1,'Seccion L',100)
insert into libros values ('Cien Años de Soledad',4,1,4,'Seccion C',80)
insert into libros values ('La Fiesta del Chivo',4,4,5,'Seccion L',90)
insert into libros values ('Yo el Sumpremo',6,4,6,'Seccion Y',95)
insert into libros values ('La Guerra del Fin del Mundo',5,5,5,'Seccion L',75)
insert into libros values ('La Muerte de Artemio Cruz',6,1,7,'Seccion L',96)
insert into libros values ('Como Agua para Chocolate',7,6,7,'Seccion C',84)
insert into libros values ('Los Heraldos Negros',1,6,8,'Seccion L',56)


go
insert into lector values ('Yamile','Pinto','Av. Locura','yamile@hotmail.com',963852741)
insert into lector values ('Fiorela','Escovar','Av. Las Series','Fiorela4Ever@gmail.com',987951482)
insert into lector values ('Leonela','Muñoz','Av. Las Estrellas','leo28@gmail.com',988741159)
insert into lector values ('Andres','Tabur','Av. Las Bermudas','Andew@hotmail.com',963852741)
insert into lector values ('Rosina','Paredes','Av. Los Postes','rosy@outlook.com',915468357)
insert into lector values ('Nicole','Hurtado','Av. Los pimientos','Nico@hotmail.com',900396305)
insert into lector values ('Pamela','Taipe','Av. Buena Vista','taipe@gmail.com',904005987)

go

insert into prestamo values(2,50,'2017-04-20','2017-05-12',null,'Pendiente')
insert into prestamo values(1,50,'2017-05-20','2017-05-25',null,'Pendiente')
insert into prestamo values(3,55,'2017-05-17','2017-05-25',null,'Pendiente')
insert into prestamo values(4,54,'2017-05-21','2017-06-20',null,'Pendiente')
