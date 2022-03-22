using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;
namespace CapaAccesoDatos
{
    public class DAMatricula
    {

        private string _cadena_Conexion;
        private string _mensaje;

        //Constructor de la clase
        public DAMatricula(string cadena_Conexion)
        {
            _cadena_Conexion = cadena_Conexion;
            _mensaje = string.Empty;
        }

        public string Mensaje
        {
            get => _mensaje;
        }

      //******************************************************
      //Método para Insertar una matricula

        public int InsertarMatricula(EntidadMatricula matricula)
        {
            SqlConnection conexion = new SqlConnection(_cadena_Conexion);
            SqlCommand cmd = new SqlCommand();
            int id = 0; //variable guarda id generado en la BD y la función ExecuteEscalar() lo devuelve

            //Creamos la sentencia o consulta para obtener los datos de la base de datos
            string sentencia = "INSERT INTO Matriculas(ID_Estudiante, Nombre_Est, Primer_Apellido_Est, Segundo_Apellido_Est, Numero_Telefonico,Correo_Electronico_Est," +
                " Direccion_Exacta, Curso_Matriculado,Intensidad, Fecha_Inicio,Fecha_Final, Horas_Clase_Asin, Horas_Clase_Sin, Total_horas_Clases, Horas_Por_Dia ) " +
                "VALUES(@ID_ESTUDIANTE, @NOMBRE_EST, @PRIMER_APELLIDO, @SEGUNDO_APELLIDO, @NUMERO_TELEFONO, @CORREO, @DIRECCION, @CURSO_MATRICULADO, @INTENSIDAD, @FECHA_INICIO,@FECHA_FINAL," +
                " @HORA_SINCRONICA, @HORA_ASINCRONICA, @TOTAL_HORAS_CLASES, @HORAS_POR_DIA) SELECT @@IDENTITY";

            cmd.Connection = conexion;
            cmd.Parameters.AddWithValue("@ID_ESTUDIANTE", matricula.IdEstudiante);
            cmd.Parameters.AddWithValue("@NOMBRE_EST", matricula.Nombre_Estudiantes);
            cmd.Parameters.AddWithValue("@PRIMER_APELLIDO", matricula.Numero_Telefono);
            cmd.Parameters.AddWithValue("@SEGUNDO_APELLIDO", matricula.Segundo_Apellido);
            cmd.Parameters.AddWithValue("@NUMERO_TELEFONO", matricula.Numero_Telefono);
            cmd.Parameters.AddWithValue("@CORREO", matricula.Correo_Electronico);
            cmd.Parameters.AddWithValue("@DIRECCION", matricula.Direccion);
            cmd.Parameters.AddWithValue("@CURSO_MATRICULADO", matricula.Curso_Matriculado);
            cmd.Parameters.AddWithValue("@INTENSIDAD", matricula.Intensidad);
            cmd.Parameters.AddWithValue("@FECHA_INICIO", matricula.Fecha_Inicio);
            cmd.Parameters.AddWithValue("@FECHA_FINAL", matricula.Fecha_Final);
            cmd.Parameters.AddWithValue("@HORA_SINCRONICA", matricula.Horas_Clase_Sincronica);
            cmd.Parameters.AddWithValue("@HORA_ASINCRONICA", matricula.Horas_Clase_Asincronica);
            cmd.Parameters.AddWithValue("@TOTAL_HORAS_CLASES", matricula.Total_Horas_Clases);
            cmd.Parameters.AddWithValue("@HORAS_POR_DIA", matricula.Horas_Por_Dia);
            cmd.CommandText = sentencia;

            try
            {
                conexion.Open();
                id = Convert.ToInt32(cmd.ExecuteScalar());
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Dispose();
                cmd.Dispose();
            }
            return id;
        }//Fin InsertarMatricula
        //*****************************************************************

        //SEGUNDA PARTE
        //Creamos el método para acceder a la base de datos
        public DataSet ListaMatriculas(string condicion, string orden)
        {
            DataSet datos = new DataSet();
            SqlConnection conexion = new SqlConnection(_cadena_Conexion);
            SqlDataAdapter adapter;
            string sentencia = "SELECT ID_Matricula,ID_Estudiante, Nombre_Est, Primer_Apellido_Est, " +
                "Segundo_Apellido_Est, Numero_Telefonico,Correo_Electronico_Est, Direccion_Exacta," +
                " Curso_Matriculado, Intensidad,Fecha_Inicio,Fecha_Final,Horas_Clase_Asin," +
                "Horas_Clase_Sin, Total_horas_Clases, Horas_Por_Dia  FROM Matriculas";
            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = string.Format("{0} WHERE {1}", sentencia, condicion);
            }
            if (!string.IsNullOrEmpty(orden))
            {
                sentencia = string.Format("{0} ORDER BY {1}", sentencia, orden);
            }
            try
            {
                adapter = new SqlDataAdapter(sentencia, conexion);
                adapter.Fill(datos, "Matriculas");
            }
            catch (Exception)
            {

                throw;
            }
            return datos;
        }//Fin CargarDataSet
        //********************************************
        //TERCERA PARTE

        public EntidadMatricula ObtenerMatricula(int id)
        {
            EntidadMatricula matricula = new EntidadMatricula();
            SqlConnection conexion = new SqlConnection(_cadena_Conexion);
            SqlCommand cmd = new SqlCommand();

            SqlDataReader dataReader;
            string sentencia = string.Format("SELECT ID_Matricula,ID_Estudiante, Nombre_Est, Primer_Apellido_Est, " +
                "Segundo_Apellido_Est, Numero_Telefonico,Correo_Electronico_Est, Direccion_Exacta," +
                "Curso_Matriculado, Intensidad,Fecha_Inicio,Fecha_Final,Horas_Clase_Asin," +
                "Horas_Clase_Sin,Total_horas_Clases, Horas_Por_Dia  FROM Matriculas WHERE ID_Matricula = {0}", id);

            cmd.Connection = conexion;
            cmd.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    matricula.IdMatricula = dataReader.GetInt32(0);
                    matricula.IdEstudiante = dataReader.GetInt32(1);
                    matricula.Nombre_Estudiantes = dataReader.GetString(2);
                    matricula.Primer_Apellido = dataReader.GetString(3);
                    matricula.Segundo_Apellido = dataReader.GetString(4);
                    matricula.Numero_Telefono = dataReader.GetString(5);
                    matricula.Correo_Electronico = dataReader.GetString(6);
                    matricula.Direccion = dataReader.GetString(7);
                    matricula.Curso_Matriculado = dataReader.GetString(8);                   
                    matricula.Intensidad = dataReader.GetString(9);                   
                    matricula.Fecha_Inicio = dataReader.GetDateTime(10);                   
                    matricula.Fecha_Final = dataReader.GetDateTime(11);                   
                    matricula.Horas_Clase_Asincronica = dataReader.GetInt32(12);
                    matricula.Horas_Clase_Sincronica = dataReader.GetInt32(13);
                    matricula.Total_Horas_Clases = dataReader.GetInt32(14);
                    matricula.Horas_Por_Dia = dataReader.GetInt32(15);
                }
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return matricula;
        }//Fin btenerMatricula
        //***********************************************
        //CUARTA PARTE
        //Eliminar una matrícula
        public int EliminarMatricula(EntidadMatricula matricula)
        {
            int afectado = -1;
            SqlConnection conexion = new SqlConnection(_cadena_Conexion);
            SqlCommand cmd = new SqlCommand();
            string sentencia = "DELETE FROM Matriculas";
            sentencia = string.Format("{0} WHERE ID_Matricula = {1}", sentencia, matricula.IdMatricula);
            cmd.CommandText = sentencia;
            cmd.Connection = conexion;
            try
            {
                conexion.Open();
                afectado = cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Dispose();
                cmd.Dispose();
            }
            return afectado;
        }//Fin EliminarMatricula
         //***********************************************
         //QUINTA PARTE
         //Actualizar una matrícula
         public int ActualizarMatricula(EntidadMatricula matricula)
        {
            int affectedRow = -1;
            
            SqlConnection conexion = new SqlConnection(_cadena_Conexion);
            SqlCommand cmd = new SqlCommand();
            string sentencia = "UPDATE Matriculas SET Nombre_Est =@NOMBRE_EST, Primer_Apellido_Est = @PRIMER_APELLIDO," +
                " Segundo_Apellido_Est = @SEGUNDO_APELLIDO, Numero_Telefonico = @NUMERO_TELEFONO," +
                "Correo_Electronico_Est = @CORREO, Direccion_Exacta =  @DIRECCION, Curso_Matriculado = @CURSO_MATRICULADO," +
                "Intensidad = @INTENSIDAD, Fecha_Inicio = @FECHA_INICIO,Fecha_Final = @FECHA_FINAL, Horas_Clase_Asin = @HORA_ASINCRONICA," +
                "Horas_Clase_Sin = @HORA_SINCRONICA, Total_horas_Clases = @TOTAL_HORAS_CLASES,Horas_Por_Dia =  @HORAS_POR_DIA WHERE ID_Matricula = @ID_MATRICULA";
            cmd.CommandText = sentencia;
            cmd.Connection = conexion;
            cmd.Parameters.AddWithValue("@ID_MATRICULA", matricula.IdMatricula);
            cmd.Parameters.AddWithValue("@NOMBRE_EST", matricula.Nombre_Estudiantes);
            cmd.Parameters.AddWithValue("@PRIMER_APELLIDO", matricula.Primer_Apellido);
            cmd.Parameters.AddWithValue("@SEGUNDO_APELLIDO", matricula.Segundo_Apellido);
            cmd.Parameters.AddWithValue("@NUMERO_TELEFONO", matricula.Numero_Telefono);
            cmd.Parameters.AddWithValue("@CORREO", matricula.Correo_Electronico);
            cmd.Parameters.AddWithValue("@DIRECCION", matricula.Direccion);
            cmd.Parameters.AddWithValue("@CURSO_MATRICULADO", matricula.Curso_Matriculado);
            cmd.Parameters.AddWithValue("@INTENSIDAD", matricula.Intensidad);
            cmd.Parameters.AddWithValue("@FECHA_INICIO", matricula.Fecha_Inicio);
            cmd.Parameters.AddWithValue("@FECHA_FINAL", matricula.Fecha_Final);
            cmd.Parameters.AddWithValue("@HORA_ASINCRONICA", matricula.Horas_Clase_Asincronica);
            cmd.Parameters.AddWithValue("@HORA_SINCRONICA", matricula.Horas_Clase_Sincronica);
            cmd.Parameters.AddWithValue("@TOTAL_HORAS_CLASES", matricula.Total_Horas_Clases);
            cmd.Parameters.AddWithValue("@HORAS_POR_DIA", matricula.Horas_Por_Dia);
            try
            {
                conexion.Open();
                affectedRow = cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Dispose();
                cmd.Dispose();
            }
            return affectedRow;
        }
        //********************************************
        //SEXTA PARTE
        //Obtener un estudiante en el formulario de llamado
        public EntidadEstudiante ObtenerEstudiante(int id)
        {
            EntidadEstudiante estudiante = new EntidadEstudiante();
            SqlConnection conexion = new SqlConnection(_cadena_Conexion);
            SqlCommand cmd = new SqlCommand();

            SqlDataReader dataReader;
            string sentencia = string.Format("SELECT ID_Estudiante, Nombre_Est, Primer_Apellido_Est, Segundo_Apellido_Est," + // hacemos la consulta y le pasamos el id
                "Fecha_Nacimiento, Numero_Telefonico, Correo_Electronico_Est, Direccion_Exacta, Estado_Est, Borrado_Est FROM Estudiantes WHERE ID_Estudiante  = {0}", id);

            cmd.Connection = conexion;
            cmd.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    estudiante.Id_Estudiante = dataReader.GetInt32(0);
                    estudiante.Nombre_Est = dataReader.GetString(2);
                    estudiante.PrimerApellido = dataReader.GetString(3);
                    estudiante.SegundoApellido = dataReader.GetString(4);
                    estudiante.FechaNacimiento = dataReader.GetDateTime(5);
                    estudiante.NumeroTelefono = dataReader.GetString(6);
                    estudiante.CorreoElectronico = dataReader.GetString(7);
                    estudiante.Direccion = dataReader.GetString(8);
                    estudiante.Estado = dataReader.GetString(9);
                }
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return estudiante;
        }//Fin ObtenerEstudiante
    }//class DAMatricula
}//namespace CapaAccesoDatos
