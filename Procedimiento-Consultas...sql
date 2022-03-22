USE DBMATRICULA
GO

/*Procedimiento Almacenado para eliminar un profesor*/
GO
CREATE OR ALTER PROCEDURE SP_ELIMINAR_PROFESOR 
												@ID_PROFESOR INT,
												@NOMBRE_PROFESOR VARCHAR(10),
												@PRIMER_APELLIDO VARCHAR(10),
												@SEGUNDO_APELLIDO VARCHAR(10),
												@FECHA_NACIMIENTO DATETIME,
												@NUMERO_TELEFONO VARCHAR(15),
												@CORREO VARCHAR(30),
												@CUENTA VARCHAR(20),
												@DIRECCION VARCHAR(100), 
												@CURSO_CERTIFICADO VARCHAR(15),
												@HORA_ENTRADA DATETIME, 
												@HORA_SALIDA DATETIME, 
												@ESTADO VARCHAR(3), 
												@BORRADO INT,
												@MSJ VARCHAR(50) OUT
AS
	BEGIN
		
		IF (NOT EXISTS (SELECT ID_Profesor FROM Profesores WHERE ID_Profesor = @ID_PROFESOR))
			BEGIN
				SET @MSJ = 'Profesor no se encuentra en la base de datos'
				RETURN 0
			END
		ELSE
			BEGIN				
				DELETE FROM Profesores WHERE ID_Profesor = @ID_PROFESOR
				SET @MSJ = 'Profesor Eliminado Correctamente'
				RETURN 1
		    END
	END 
	
GO
/*Creamos un trigger para que cuando se inserten un estudiante el estado se agrege inactivo*/
GO
CREATE OR ALTER TRIGGER TR_INA_ESTUDIANTES
ON Estudiantes FOR INSERT
AS
	UPDATE Estudiantes
	SET Estado_Est = 'INA'
	FROM inserted
	WHERE Estudiantes.ID_Estudiante = inserted.ID_Estudiante
GO
/*Creamos un trigger para que cuando se inserten un estudiante el borrado se agrege 0*/
GO
CREATE OR ALTER TRIGGER TR_ESTADO_ESTUDIANTES
ON Estudiantes FOR INSERT 
AS
	UPDATE Estudiantes
	SET Borrado_Est = 0
	FROM inserted
	WHERE Estudiantes.ID_Estudiante = inserted.ID_Estudiante
GO
/*Creamos un trigger para que cuando se MATRICULE un estudiante el estado cambie a ACT*/
GO
CREATE OR ALTER TRIGGER TR_ACT_MATRICULAS_ESTUDIANTE
ON Matriculas FOR INSERT
AS
	UPDATE Estudiantes
	SET Estado_Est = 'ACT'
	FROM inserted
	WHERE Estudiantes.ID_Estudiante = inserted.ID_Estudiante
GO
/*Creamos un trigger para que cuando se MATRICULE un estudiante el estado del curso cambie a ACT*/
GO
CREATE OR ALTER TRIGGER TR_ACT_MATRICULAS_ESTUDIANTE
ON Matriculas FOR INSERT
AS
	UPDATE Cursos
	SET Estado_Curso = 'ACT'
	FROM inserted
	WHERE Cursos.Nombre_Curso = inserted.Curso_Matriculado
GO
/*Creamos un trigger para que cuando se actualice un un curso el estado del curso sea INA */

CREATE OR ALTER TRIGGER TR_INA_ACTUALIZAR_CURSO
ON Cursos FOR INSERT
AS
	UPDATE Cursos
	SET Estado_Curso = 'INA'
	FROM inserted
	WHERE Cursos.Nombre_Curso = inserted.Estado_Curso
GO
/*CREAMOS EL TRIGGER PARA INSERTAR DATOS EN LA TABLA DE PAGOS , CUANDO SE HACE UNA MATRICULA*/

GO
CREATE OR ALTER TRIGGER TR_INA_ESTUDIANTES
ON Estudiantes FOR INSERT
AS
	UPDATE Estudiantes
	SET Estado_Est = 'INA'
	FROM inserted
	WHERE Estudiantes.ID_Estudiante = inserted.ID_Estudiante
GO


