
CREATE TABLE dbo.TB_ESTUDIANTE
( 
	ID_ESTUDIANTE        integer IDENTITY ( 1,1 ) ,
	DNI                  varchar(20)  NOT NULL ,
	PATERNO              varchar(50)  NOT NULL ,
	MATERNO              varchar(50)  NOT NULL ,
	NOMBRE               varchar(50)  NOT NULL ,
	TIPO_SANGRE          varchar(20)  NOT NULL ,
	ALERGIA              varchar(100)  NOT NULL ,
	CONSTRAINT XPKTB_ESTUDIANTE PRIMARY KEY (ID_ESTUDIANTE ASC)
)
go



CREATE TABLE dbo.TB_PERSONA
( 
	ID_PERSONA           integer IDENTITY ( 1,1 ) ,
	APELLIDOS            varchar(100)  NOT NULL ,
	NOMBRES              varchar(100)  NOT NULL ,
	DNI                  varchar(15)  NOT NULL ,
	CORREO               varchar(100)  NOT NULL ,
	CONSTRAINT XPKTB_PERSONA PRIMARY KEY (ID_PERSONA ASC)
)
go




EXEC sp_addextendedproperty
@name = N'MS_Description', @value = N'P: Padre   M: Madre',
@level0type = N'SCHEMA', @level0name = N'dbo',
@level1type = N'TABLE', @level1name = N'TB_PERSONA',
@level2type = N'COLUMN', @level2name = N'DNI'
go



CREATE TABLE dbo.TB_TIPO_RELACION
( 
	ID_TIPO              integer  NOT NULL ,
	NOMBRE               varchar(100)  NOT NULL ,
	CONSTRAINT XPKTB_TIPO_RELACION PRIMARY KEY (ID_TIPO ASC)
)
go



CREATE TABLE dbo.TB_RELACION
( 
	ID_RELACION          integer IDENTITY ( 1,1 ) ,
	ID_ESTUDIANTE        integer  NOT NULL ,
	ID_PERSONA           integer  NOT NULL ,
	ID_TIPO              integer  NOT NULL ,
	CONSTRAINT XPKTB_RELACION PRIMARY KEY (ID_RELACION ASC),
	CONSTRAINT XAK1TB_RELACION UNIQUE (ID_ESTUDIANTE  ASC,ID_PERSONA  ASC),
	CONSTRAINT FK_RELACION_ESTUDIANTE FOREIGN KEY (ID_ESTUDIANTE) REFERENCES dbo.TB_ESTUDIANTE(ID_ESTUDIANTE)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
CONSTRAINT FK_RELACION_PERSONA FOREIGN KEY (ID_PERSONA) REFERENCES dbo.TB_PERSONA(ID_PERSONA)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
CONSTRAINT FK_RELACION_TIPO_RELACION FOREIGN KEY (ID_TIPO) REFERENCES dbo.TB_TIPO_RELACION(ID_TIPO)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)
go



CREATE TABLE dbo.TB_MATRICULA
( 
	ID_MATRICULA         integer IDENTITY ( 1,1 ) ,
	ID_ESTUDIANTE        integer  NOT NULL ,
	ID_SECCION           integer  NOT NULL ,
	CONFIRMADA           integer  NOT NULL 
	CONSTRAINT DF_CERO_304281688
		 DEFAULT  0,
	ACTIVA               integer  NOT NULL 
	CONSTRAINT DF_CERO_1277445602
		 DEFAULT  0,
	OBSERVACION          varchar(500)  NULL ,
	CONSTRAINT XPKTB_MATRICULA PRIMARY KEY (ID_MATRICULA ASC),
	CONSTRAINT XAK1TB_MATRICULA UNIQUE (ID_ESTUDIANTE  ASC,ID_SECCION  ASC),
	CONSTRAINT FK_MATRICULA_ESTUDIANTE FOREIGN KEY (ID_ESTUDIANTE) REFERENCES dbo.TB_ESTUDIANTE(ID_ESTUDIANTE)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
CONSTRAINT FK_MATRICULA_SECCION FOREIGN KEY (ID_SECCION) REFERENCES dbo.TB_SECCION(ID_SECCION)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)
go




EXEC sp_addextendedproperty
@name = N'MS_Description', @value = N'Identificador de sección.',
@level0type = N'SCHEMA', @level0name = N'dbo',
@level1type = N'TABLE', @level1name = N'TB_MATRICULA',
@level2type = N'COLUMN', @level2name = N'ID_SECCION'
go




EXEC sp_addextendedproperty
@name = N'MS_Description', @value = N'Identificador de la matricula.',
@level0type = N'SCHEMA', @level0name = N'dbo',
@level1type = N'TABLE', @level1name = N'TB_MATRICULA',
@level2type = N'COLUMN', @level2name = N'ID_MATRICULA'
go




EXEC sp_addextendedproperty
@name = N'MS_Description', @value = N'Estado de la matricula. 0: Sin Confirmar, 1: Confirmada.',
@level0type = N'SCHEMA', @level0name = N'dbo',
@level1type = N'TABLE', @level1name = N'TB_MATRICULA',
@level2type = N'COLUMN', @level2name = N'CONFIRMADA'
go




EXEC sp_addextendedproperty
@name = N'MS_Description', @value = N'Indica si la matricula esta activa. 0: No activa, 1: Activa',
@level0type = N'SCHEMA', @level0name = N'dbo',
@level1type = N'TABLE', @level1name = N'TB_MATRICULA',
@level2type = N'COLUMN', @level2name = N'ACTIVA'
go




EXEC sp_addextendedproperty
@name = N'MS_Description', @value = N'Observaciones que anota el usuario que realiza o modifica la matricula.',
@level0type = N'SCHEMA', @level0name = N'dbo',
@level1type = N'TABLE', @level1name = N'TB_MATRICULA',
@level2type = N'COLUMN', @level2name = N'OBSERVACION'
go


