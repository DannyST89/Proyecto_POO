using System;
using System.Data.SqlClient;
using System.Data;
using CapaEntidades;

namespace CapaDatos
{
    public class DACurso
    {
        // Atributos que se utilizaran para distribuir la cadena de conexion entre las diferentes capas
        private string _cadenaConexion;
        private string _mensaje;

        public DACurso(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //propiedad
        public string Mensaje
        {
            get => _mensaje;
        }

        //***************************************************************
        //Insertar cursos
        public int InsertarCursos(EntidadCurso curso)
        {
            // Creamos un objeto que recibira la cadena de conexion para la base de datos
            //objeto de tipo sqlConnection
            SqlConnection conexion = new SqlConnection(_cadenaConexion);// hacemos la instancia y recibimos el parametro con el valor de conexion
                                                                        // con la siguiente instancia creamos un objeto de tipo SqlCommand para usar comando de SQL
            SqlCommand cmd = new SqlCommand();
            //Esta variable guarda el id ingresado en la BD y la funcion EXecuteScalar() lo devuelve
            int id = 0;

            string sentencia = "INSERT INTO Cursos(Nombre_Curso, Cantidad_Horas,Precio_Hora) VALUES(@NOMBRE_CURSO, @CANTIDAD_HORAS," +
                               "@PRECIO_HORAS) SELECT @@IDENTITY";

            cmd.Connection = conexion;
            //Necesitamos específicar las variables que van en la sentencia SQL
            cmd.Parameters.AddWithValue("@NOMBRE_CURSO", curso.getNombreCurso());
            cmd.Parameters.AddWithValue("@CANTIDAD_HORAS", curso.getCantidadHoras());
            cmd.Parameters.AddWithValue("@PRECIO_HORAS", curso.getPrecioHora());

            cmd.CommandText = sentencia;

            //Ejecutamos la consulta

            try
            {
                conexion.Open();//abrimos la conexion
                id = Convert.ToInt32(cmd.ExecuteScalar());// traemos el identity de la tabla cursos
                conexion.Close(); //cerramos la conexion
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Dispose();//se lebera la memoria
                cmd.Dispose();//libera la memoria del objeto
            }
            return id;
        }//Fin InsertarCursos
        //***********************************************

        //Procedemos a utilizar el dataSet que nos permitirá ver los cursos disponibles en el dataGridView
        public DataSet MostrarCursosEnDataGridView(string condicion, string orden)
        {
            DataSet datos = new DataSet(); // dataset trae la informacion en una tabla del sql
            SqlConnection conexion = new SqlConnection(_cadenaConexion);//optenemos la conexion;
            //SqlDataAdapter adapter;

            string sentencia = "SELECT ID_Curso,Nombre_Curso,Cantidad_Horas,Precio_Hora,Estado_Curso  FROM Cursos";

            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = string.Format("{0} where {1}", sentencia, condicion);
            }
            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = string.Format("{0} order by {1}", sentencia, orden);
            }

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sentencia, conexion);
                adapter.Fill(datos, "Cursos");
            }
            catch (Exception)
            {

                throw;
            }
            return datos;
        }//Fin MostrarCursosEnDataGridView

        //***********************************************
        //Eliminar los cursos en la base de datos
        public int EliminarCurso(EntidadCurso curso)
        {
            int afectado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            string sentencia = "DELETE FROM CURSOS";
            sentencia = string.Format("{0} WHERE ID_Curso = {1}", sentencia, curso.IdCurso);
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
        }//Fin EliminarCurso
         //*********************************************************************
         //Creamos el método obtener curso para mostrar en el formulario

        public EntidadCurso ObtenerCurso(int id)
        {
            EntidadCurso curso = new EntidadCurso();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand cmd = new SqlCommand();

            SqlDataReader dataReader;// se llena con un execute
            string sentencia = string.Format("SELECT ID_Curso, Nombre_Curso, Cantidad_Horas,Precio_Hora, Estado_Curso FROM Cursos WHERE ID_Curso = {0}", id);

            cmd.Connection = conexion;
            cmd.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    curso.IdCurso = dataReader.GetInt32(0);
                    curso.NombreCurso = dataReader.GetString(1);
                    curso.CantidadHoras = dataReader.GetInt32(2);
                    curso.PrecioHora = dataReader.GetInt32(3);
                    curso.Estado = dataReader.GetString(4);
                    curso.Existe = true;
                }
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return curso;
        }//Fin Obtener Profesor
        //**************************************************
        //Actualizar curso
        public int ActualizarCurso(EntidadCurso curso)
        {
            int affectedRow = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            String sentencia = "UPDATE Cursos SET Nombre_Curso = @NOMBRE_CURSO, " +
                "Cantidad_Horas = @CANTIDAD_HORAS,Precio_Hora = @PRECIO_HORAS WHERE ID_Curso = @ID_CURSO";
            cmd.CommandText = sentencia;
            cmd.Connection = conexion;
            cmd.Parameters.AddWithValue("@ID_CURSO", curso.IdCurso);
            cmd.Parameters.AddWithValue("@NOMBRE_CURSO", curso.NombreCurso);
            cmd.Parameters.AddWithValue("@CANTIDAD_HORAS", curso.CantidadHoras);
            cmd.Parameters.AddWithValue("@PRECIO_HORAS", curso.PrecioHora);
          

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
        public DataSet ListarCursos(string condicion, string orden)
        {
            DataSet datos = new DataSet();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "SELECT ID_Curso, Nombre_Curso, Cantidad_Horas, Precio_Hora, Estado_Curso FROM Cursos";
            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = string.Format("{0} WHERE {1}", sentencia, condicion);
            }
            if (!string.IsNullOrEmpty(orden))
            {
                sentencia = string.Format("{0} order by {1}");
            }
            try
            {
                adapter = new SqlDataAdapter(sentencia, conexion);
                adapter.Fill(datos, "Cursos");
            }
            catch (Exception)
            {

                throw;
            }
            return datos;
        }// Fin ListarEstudiantes
    }//Fin class DACurso
}//Fin namespace CapaDatos
