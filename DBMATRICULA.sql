/* CREADO POR DANNY SOTO J.
   5 DE ENERO DEL 2022
*/

/*___________________________________________________________*/
/*-----------------------------------------------------------*/
/*                  IMPORTANTE                               */
/* Los procedimientos almacenados y los triggres están       */
/* ubicados en el script  procedimientos consultar           */
/* en la carpeta  raiz                                       */
/*-----------------------------------------------------------*/
/*___________________________________________________________*/
CREATE DATABASE DBMATRICULA
GO 

USE DBMATRICULA
GO

/*Creamos la tabla de profesores*/

Create table Profesores (
	ID_Profesor	int  identity(1,1) primary key not null,/* Aquí se ingresa el número de cédula*/
	Nombre_Profesor	varchar(10) not null,
	Primer_Apellido_Prof	varchar(10) not null,
	Segundo_Apellido_Prof	varchar(10) null,	
	Fecha_Nacimiento_Prof	datetime not null, /* < getdate() */
	Numero_Telefonico	varchar(15) not null,
	Correo_Electronico_Prof	varchar(30) null,
	Cuenta_Bancaria	varchar(20) not null,
	Direccion_Exacta	varchar(100) null,
	Curso_Certificado	varchar(15) default 'Inglés',
	Hora_Entrada	datetime not null,
	Hora_Salida	datetime not null,
	Estado	varchar(3) default 'ACT' not null,
	Borrado	int  default 0 not null
)

/*Crear todas las restricciones*/

/*Hora de entrada del profesor*/
Alter table Profesores
Add constraint CHK_Hora_Entrada check (Hora_Entrada >= '8:00:00');

/*Hora de salida del profesor*/
Alter table Profesores
Add constraint CHK_Hora_Salida check (Hora_Salida >= '22:00:00'); /*Se estará usando la hora militar, si es necesario se convertira en am pm cuando se muestra*/

/*Fecha de nacimiento menor a la fecha actual*/
Alter table Profesores
Add constraint CHK_Fecha_Nacimiento_Prof check (Fecha_Nacimiento_Prof < getdate());


/*Estado de los profesores*/
Alter table	Profesores
Add constraint	CHK_Estado check(Estado in ('ACT','INA') and Estado = upper(Estado))
/*Como se deben de borrar los datos del profesor*/
Alter table	Profesores
Add constraint	CHK_Borrado check(Borrado = 0 or Borrado = 1)
GO
/*******************************************************************************************/
/*Creamos la tabla de Estudiantes*/

Create table Estudiantes (
	ID_Estudiante	int identity(1,1) primary key not null,/* Aquí se ingresa el número de cédula*/
	Nombre_Est	varchar(15) not null,
	Primer_Apellido_Est	varchar(15) not null,
	Segundo_Apellido_Est	varchar(15) null,	
	Fecha_Nacimiento	datetime not null, /* < getdate() */
	Numero_Telefonico	varchar(15) not null,
	Correo_Electronico_Est	varchar(25) null,
	Direccion_Exacta	varchar(100) null,
	Estado_Est	varchar(3) default 'INA' not null,
	Borrado_Est	int null
)

/*Crear todas las restricciones de Estudiantes*/
/*Estado de los profesores*/
Alter table	Estudiantes
Add constraint	CHK_Estado_Ests check(Estado_Est in ('ACT','INA') and Estado_Est = upper(Estado_Est))

/*Fecha de nacimiento menor a la fecha actual*/
Alter table Estudiantes
Add constraint CHK_Fecha_Nacimiento check (Fecha_Nacimiento < getdate());

/*Como se deben de borrar los datos de los Estudiantes*/
Alter table	Estudiantes
Add constraint	CHK_Borrado_Est check(Borrado_Est = 0 or Borrado_Est = 1)
GO
/*Creámos la tabla de cursos*/

Create table Cursos(
	ID_Curso	int  identity primary key not null,
	Nombre_Curso varchar(25) default 'Inglés'not null,
	Cantidad_Horas	int not null,
	Precio_Hora int not null,
	Estado_Curso	varchar(3) default 'INA' not null
)

/*Crear todas las restricciones de la tabla cursos*/
/*Nombre de los cursos*/
--Alter table Cursos
--Add constraint CHK_Nombre_Curso check(Nombre_Curso in ('Inglés','Francés','Alemán','Mandarín'))
/*Estado de los cursos*/
Alter table	Cursos
Add constraint	CHK_Estado_Curso check(Estado_Curso in ('ACT','INA') and Estado_Curso = upper(Estado_Curso))
GO				

/*Creamos la tabla de Matriculas*/

Create table Matriculas (
	ID_Matricula	int identity primary key not null,
	ID_Estudiante int not null,
	Nombre_Est	varchar(10) not null,
	Primer_Apellido_Est	varchar(10) not null,
	Segundo_Apellido_Est	varchar(10) null,	
	Numero_Telefonico	varchar(15) not null,
	Correo_Electronico_Est	varchar(20) null,
	Direccion_Exacta	varchar(100) null,
	Curso_Matriculado	varchar(10) not null,
	Intensidad	varchar(10) default 'Medio' not null,
	Fecha_Inicio datetime not null,
	Fecha_Final	datetime not null, 
	Horas_Clase_Asin	int not null, /*Campo calculado 75%*/
	Horas_Clase_Sin	int not null,  /*Campo calculado 25%*/	
	Total_horas_Clases int not null,
	Horas_Por_Dia int not null
)
/*referencia de la tabla */
Alter table Matriculas
Add constraint FK_ID_Estudiante
Foreign key (ID_Estudiante) references Estudiantes(ID_Estudiante);


--SELECT ID_Matricula, Nombre_Est, Primer_Apellido_Est, Segundo_Apellido_Est, Numero_Telefonico,Correo_Electronico_Est, Direccion_Exacta, Curso_Matriculado FROM Matriculas
--Intensidad, Fecha_Inicio,Fecha_Final, Horas_Clase_Asin, Horas_Clase_Sin
--INSERT INTO Matriculas(Nombre_Est, Primer_Apellido_Est, Segundo_Apellido_Est, Numero_Telefonico,Correo_Electronico_Est, Direccion_Exacta, Curso_Matriculado, 
--Intensidad, Fecha_Inicio,Fecha_Final, Horas_Clase_Asin, Horas_Clase_Sin ) VALUES(@NOMBRE_EST,@PRIMER_APELLIDO,@SEGUNDO_APELLIDO,@NUMERO_TELEFONO,@CORREO,@DIRECCION,@CURSO_MATRICULADO,@INTENSIDAD,@FECHA_INICIO,
--@FECHA_FINAL,@HORA_SINCRONICA,@HORA_ASINCRONICA) SELECT @@IDENTITY;

/*Se crean las restricciones de Matriculas*/
Alter table Matriculas
Add constraint CHK_Intensidad Check (Intensidad in ('Bajo','Medio','Alto','Intensivo'))
GO
/*Creamos la tabla detalles de matriculas*/

Create table Detalles_Matriculas (
	ID_Matricula	varchar(10) not null,
	ID_Estudiante	varchar(10) not null,
	ID_Curso	varchar(10) not null,
	Fecha_Creacion	date not null	
)



/*Se crean las restricciones de Matriculas*/
Alter table Detalles_Matriculas
Add constraint CHK_Fecha_Creacion check (Fecha_Creacion >= getdate());
GO


/*Creamos la tabla para las clases sincrónicas*/

Create table Clases_Sincrónicas(
	ID_Clase int primary key not null,
	Fecha_Clase date not null,
	Hora_Clase time not null,
	Profesor_Asignado varchar(50) not null
)
GO
/*Creamos la tabla para los pagos*/

Create table Pagos (
	ID_Matricula int not null, /*Cuando se crea una matricula se registra el monto a pagar en la tabla pagos*/
	ID_Estudiante int not null,
	Monto_A_Pagar	decimal not null,
	Curso_Matriculado varchar(10) not null,
	Fecha_Pago datetime not null,
	Estado_Pago	varchar(10) default 'Pendiente' not null
)
GO
Alter table Pagos
Add constraint FK_ID_Matricula_Pagos
Foreign key (ID_Matricula) references Matriculas(ID_Matricula);
Alter table Pagos
Add constraint FK_ID_Estudiante_Pagos
Foreign key (ID_Estudiante) references Estudiantes(ID_Estudiante);

/* Se crean las restricciones de pagos*/

/*El estado del pago debe ser pendiente o cancelado default pendinete, cambia a cancelado cuando se realiza el pago*/

Alter table Pagos
Add constraint CHK_Estado_Pago	Check( Estado_Pago = 'Pendiente' or Estado_Pago = 'Cancelado')
GO
/*INSERTAMOS LOS CURSOS DEL INSTITUTO*/
GO
INSERT INTO Cursos(Nombre_Curso,Cantidad_Horas,Precio_Hora)
		VALUES('Inglés 01',80,2000),
			  ('Inglés 02',80,2000),
			  ('Inglés 03',80,2000),
			  ('Inglés 04',80,2000),
			  ('Inglés 05',80,2000),
			  ('Inglés 06',80,2000),
			  ('Inglés 07',80,2000),
			  ('Inglés 08',80,2000),
			  ('Inglés 09',80,2000),
			  ('Inglés 10',80,2000),
			  ('Inglés 11',80,2000),
			  ('Inglés 12',80,2000),

			  /*France´s*/
			  ('Francés 01',100,2000),
			  ('Francés 02',100,2000),
			  ('Francés 03',100,2000),
			  ('Francés 04',100,2000),
			  /*Alemán*/
			  ('Alemán 01',94,2000),
			  ('Alemán 02',94,2000),
			  ('Alemán 03',94,2000),
			  ('Alemán 04',94,2000),
			  ('Alemán 05',94,2000),
			  ('Alemán 06',94,2000),
			  ('Alemán 07',94,2000),
			  ('Alemán 08',94,2000),
			  ('Alemán 09',94,2000),
			  ('Alemán 10',94,2000),
			  /*Mandarín*/
			  ('Mandarín 01',120,2000),
			  ('Mandarín 02',120,2000),
			  ('Mandarín 03',120,2000),
			  ('Mandarín 04',120,2000),
			  ('Mandarín 05',120,2000),
			  ('Mandarín 06',120,2000),
			  ('Mandarín 07',120,2000),
			  ('Mandarín 08',120,2000),
			  ('Mandarín 09',120,2000),
			  ('Mandarín 10',120,2000),
			  ('Mandarín 11',120,2000),
			  ('Mandarín 12',120,2000),
			  ('Mandarín 13',120,2000),
			  ('Mandarín 14',120,2000)
GO







		

		