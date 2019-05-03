
Create database DISENO_PREFERENCIA;
go

Use DISENO_PREFERENCIA;
go


create table tb_encuestador
(
IdEncuestador  integer  primary key ,
	Usuario  varchar(50) NULL ,
	Clave  varchar(50)  NULL);
GO

create table tb_Encuesta
(NroEncuesta  integer  primary key  ,
	GeneroEncuestado  varchar(30)  NULL ,
	PreferenciaBebida  varchar(30)  NULL ,
	Condicion  varchar(30)  NULL ,
	IdEncuestador  integer,
	Distrito varchar(50),
	foreign key (IdEncuestador) references tb_encuestador(IdEncuestador) 
);

