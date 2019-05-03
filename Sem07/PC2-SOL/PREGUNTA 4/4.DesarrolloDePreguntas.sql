
use DISENO_PREFERENCIA;
GO

SELECT COUNT(1) FROM dbo.tb_Encuesta;
GO

/*  PREGUNTA 1
Cual es la bebida que mas se consume en Lima?*/

select PreferenciaBebida,  count(PreferenciaBebida) as [Cantidad de Bebidas]  from dbo.tb_Encuesta
group by PreferenciaBebida 
order by 2 desc;
GO


/*¿PREGUNTA 2
Cuál es la bebida gaseosa que más consumen los hombres y cuál es la que más consumen las mujeres? */

select PreferenciaBebida,count(PreferenciaBebida) as [Cantidad de Bebidas]from dbo.tb_Encuesta
where GeneroEncuestado = 'M'
group by PreferenciaBebida 
order by 2 desc;
GO

select PreferenciaBebida,count(PreferenciaBebida) as [Cantidad de Bebidas]from dbo.tb_Encuesta
where GeneroEncuestado = 'F'
group by PreferenciaBebida 
order by 2 desc;
GO

select GeneroEncuestado, PreferenciaBebida,count(PreferenciaBebida) as [Cantidad de Bebidas]
from dbo.tb_Encuesta
group by GeneroEncuestado, PreferenciaBebida 
order by 1, 3 desc;
GO





select GeneroEncuestado,count(PreferenciaBebida) from dbo.tb_Encuesta
group by GeneroEncuestado;
GO


/* PREGUNTA 3
¿Cuál es la bebida gaseosa que más consumen los adolescentes, jóvenes y adultos? */

select PreferenciaBebida,count(PreferenciaBebida) as [Cantidad de Bebidas]from dbo.tb_Encuesta
where Condicion = 'Adolesente'
group by PreferenciaBebida
order by 2 desc;
GO

select PreferenciaBebida,count(PreferenciaBebida) as [Cantidad de Bebidas]from dbo.tb_Encuesta
where Condicion = 'Joven'
group by PreferenciaBebida
order by 2 desc;
GO


select PreferenciaBebida,count(PreferenciaBebida) as [Cantidad de Bebidas]from dbo.tb_Encuesta
where Condicion = 'Adulto'
group by PreferenciaBebida
order by 2 desc;
GO


/* PREGUNTA 4
 ¿Cuál es la bebida gaseosa que más consumen los hombres y las mujeres por distrito?  */

select distrito, count(PreferenciaBebida) as [Cantidad de Bebidas] from dbo.tb_Encuesta
where GeneroEncuestado = 'M'
group by Distrito
order by 2 desc;
GO

select distrito,count(PreferenciaBebida) as [Cantidad de Bebidas]from dbo.tb_Encuesta
where GeneroEncuestado = 'F'
group by distrito
order by 2 desc;
GO

