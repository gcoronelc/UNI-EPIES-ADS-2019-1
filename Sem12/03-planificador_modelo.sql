USE COLEGIO;
GO


CREATE TABLE dbo.TB_NIVEL
( 
	ID_NIVEL             integer  NOT NULL ,
	NOMBRE               varchar(100)  NULL ,
	CONSTRAINT XPKTB_NIVEL PRIMARY KEY (ID_NIVEL ASC)
)
go




EXEC sp_addextendedproperty
@name = N'MS_Description', @value = N'Identificador de nivel.',
@level0type = N'SCHEMA', @level0name = N'dbo',
@level1type = N'TABLE', @level1name = N'TB_NIVEL',
@level2type = N'COLUMN', @level2name = N'ID_NIVEL'
go




EXEC sp_addextendedproperty
@name = N'MS_Description', @value = N'Nombre del nivel.',
@level0type = N'SCHEMA', @level0name = N'dbo',
@level1type = N'TABLE', @level1name = N'TB_NIVEL',
@level2type = N'COLUMN', @level2name = N'NOMBRE'
go



CREATE TABLE dbo.TB_GRADO
( 
	ID_GRADO             integer  NOT NULL ,
	ID_NIVEL             integer  NOT NULL ,
	NOMBRE               varchar(100)  NULL ,
	CONSTRAINT XPKTB_GRADO PRIMARY KEY (ID_GRADO ASC),
	CONSTRAINT FK_GRADO_NIVEL FOREIGN KEY (ID_NIVEL) REFERENCES dbo.TB_NIVEL(ID_NIVEL)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)
go




EXEC sp_addextendedproperty
@name = N'MS_Description', @value = N'Identificador de nivel.',
@level0type = N'SCHEMA', @level0name = N'dbo',
@level1type = N'TABLE', @level1name = N'TB_GRADO',
@level2type = N'COLUMN', @level2name = N'ID_NIVEL'
go




EXEC sp_addextendedproperty
@name = N'MS_Description', @value = N'Identificador de grado',
@level0type = N'SCHEMA', @level0name = N'dbo',
@level1type = N'TABLE', @level1name = N'TB_GRADO',
@level2type = N'COLUMN', @level2name = N'ID_GRADO'
go




EXEC sp_addextendedproperty
@name = N'MS_Description', @value = N'Nombre del grado',
@level0type = N'SCHEMA', @level0name = N'dbo',
@level1type = N'TABLE', @level1name = N'TB_GRADO',
@level2type = N'COLUMN', @level2name = N'NOMBRE'
go



CREATE TABLE dbo.TB_PERIODO
( 
	ID_PERIODO           integer  NOT NULL ,
	INGRESO              numeric(10,2)  NULL ,
	PENSION              numeric(10,2)  NULL ,
	ESTADO               integer  NOT NULL ,
	CONSTRAINT XPKTB_PERIODO PRIMARY KEY (ID_PERIODO ASC)
)
go




EXEC sp_addextendedproperty
@name = N'MS_Description', @value = N'Identificador de periodo, corresponde al año academico, por ejemplo 2019, 2020, etc.',
@level0type = N'SCHEMA', @level0name = N'dbo',
@level1type = N'TABLE', @level1name = N'TB_PERIODO',
@level2type = N'COLUMN', @level2name = N'ID_PERIODO'
go




EXEC sp_addextendedproperty
@name = N'MS_Description', @value = N'Cuota de ingreso, igual para todos los niveles.',
@level0type = N'SCHEMA', @level0name = N'dbo',
@level1type = N'TABLE', @level1name = N'TB_PERIODO',
@level2type = N'COLUMN', @level2name = N'INGRESO'
go




EXEC sp_addextendedproperty
@name = N'MS_Description', @value = N'Pensión del estudiante, igual para todos los niveles.',
@level0type = N'SCHEMA', @level0name = N'dbo',
@level1type = N'TABLE', @level1name = N'TB_PERIODO',
@level2type = N'COLUMN', @level2name = N'PENSION'
go




EXEC sp_addextendedproperty
@name = N'MS_Description', @value = N'1: Planificación
2: Proceso
3: Cerrado',
@level0type = N'SCHEMA', @level0name = N'dbo',
@level1type = N'TABLE', @level1name = N'TB_PERIODO',
@level2type = N'COLUMN', @level2name = N'ESTADO'
go



CREATE TABLE dbo.TB_SECCION
( 
	ID_SECCION           integer IDENTITY ( 1,1 ) ,
	NOMBRE               varchar(100)  NULL ,
	ID_GRADO             integer  NOT NULL ,
	ID_PERIODO           integer  NOT NULL ,
	VACANTES             integer  NULL ,
	MATRICULADOS         integer  NULL ,
	CONSTRAINT XPKTB_SECCION PRIMARY KEY (ID_SECCION ASC),
	CONSTRAINT FK_SECCION_GRADO FOREIGN KEY (ID_GRADO) REFERENCES dbo.TB_GRADO(ID_GRADO)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
CONSTRAINT FK_SECCION_PERIODO FOREIGN KEY (ID_PERIODO) REFERENCES dbo.TB_PERIODO(ID_PERIODO)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)
go




EXEC sp_addextendedproperty
@name = N'MS_Description', @value = N'Identificador de grado',
@level0type = N'SCHEMA', @level0name = N'dbo',
@level1type = N'TABLE', @level1name = N'TB_SECCION',
@level2type = N'COLUMN', @level2name = N'ID_GRADO'
go




EXEC sp_addextendedproperty
@name = N'MS_Description', @value = N'Identificador de periodo, corresponde al año academico, por ejemplo 2019, 2020, etc.',
@level0type = N'SCHEMA', @level0name = N'dbo',
@level1type = N'TABLE', @level1name = N'TB_SECCION',
@level2type = N'COLUMN', @level2name = N'ID_PERIODO'
go




EXEC sp_addextendedproperty
@name = N'MS_Description', @value = N'Identificador de sección.',
@level0type = N'SCHEMA', @level0name = N'dbo',
@level1type = N'TABLE', @level1name = N'TB_SECCION',
@level2type = N'COLUMN', @level2name = N'ID_SECCION'
go




EXEC sp_addextendedproperty
@name = N'MS_Description', @value = N'Nombre del grado',
@level0type = N'SCHEMA', @level0name = N'dbo',
@level1type = N'TABLE', @level1name = N'TB_SECCION',
@level2type = N'COLUMN', @level2name = N'NOMBRE'
go


