




-- Tipo de Relación

insert into dbo.tb_tipo_relacion( id_tipo, nombre )
values( 1,'PADRE' );

insert into dbo.tb_tipo_relacion( id_tipo, nombre )
values( 2,'MADRE' );

insert into dbo.tb_tipo_relacion( id_tipo, nombre )
values( 3,'ABUELO' );

insert into dbo.tb_tipo_relacion( id_tipo, nombre )
values( 4,'ABUELA' );


-- Estudiantes
SET IDENTITY_INSERT dbo.tb_estudiante ON;  
GO 

insert into dbo.tb_estudiante(id_estudiante, dni, paterno, materno, nombre, tipo_sangre, alergia)
values( 1, '12345678', 'POMA', 'QUISPE', 'VICTOR', 'RH O+', 'NINGUNA');

insert into dbo.tb_estudiante(id_estudiante, dni, paterno, materno, nombre, tipo_sangre, alergia)
values( 2, '87654321', 'CASABONA', 'LOPEZ', 'MIGUEL', 'RH O-', 'CITRICO');

insert into dbo.tb_estudiante(id_estudiante, dni, paterno, materno, nombre, tipo_sangre, alergia)
values( 3, '89764532', 'CACERES', 'PIMENTEL', 'MERCEDES', 'RH A-', 'NINGUNA');

insert into dbo.tb_estudiante(id_estudiante, dni, paterno, materno, nombre, tipo_sangre, alergia)
values( 4, '54679876', 'VALERO', 'VALVERDE', 'RUBEN', 'RH A+', 'NINGUNA');

insert into dbo.tb_estudiante(id_estudiante, dni, paterno, materno, nombre, tipo_sangre, alergia)
values( 5, '89435678', 'CARRION', 'PADILLA', 'SHEYLA', 'RH O-', 'NINGUNA');

SET IDENTITY_INSERT dbo.tb_estudiante OFF;  
GO 

