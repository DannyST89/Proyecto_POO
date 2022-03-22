using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using CapaEntidades;

namespace CapaDatos
{
    public class DAEstudiante
    {
        //****************************************************
        //PRIMERA PARTE

        //Atributos 
        private string _cadenaConexion; // variable que utlizamos para conectarnos en toda la clase
        private string _mensaje;

        public DAEstudiante(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public string Mensaje
        {
            get => _mensaje;
        }

        //******************************************
        //Creamos el método InsertarEstudiante
        public int InsertarEstudiante(EntidadEstudiante estudiante)
        {
            //Preparamos las conexiones
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand cmd = new SqlCommand();// instanciamos cmd para utilizar comandos SQL
            int id = 0; // llave primaria identity recuperado con ExecuteScalar()
            string sentencia = "INSERT INTO Estudiantes (Nombre_Est, Primer_Apellido_Est, Segundo_Apellido_Est, Fecha_Nacimiento, Numero_Telefonico, Correo_Electronico_Est," +
                               "Direccion_Exacta) VALUES(@NOMBRE_EST, @PRIMER_APELLIDO, @SEGUNDO_APELLIDO, @FECHA_NACIMIENTO, @NUMERO_TELEFONO," +
                               "@CORREO_ELECTRONICO, @DIRECCION) SELECT @@IDENTITY; "; //Creamos la variable que nos ayudara a insertar datos en la base de datos


            //Anteriormente instanciamos cmd, ahora necesitamos agregarle la conexion para insertar los datos
            cmd.Connection = conexion;

            //variables que van en la sentencia
            cmd.Parameters.AddWithValue("@NOMBRE_EST", estudiante.Nombre_Est);
            cmd.Parameters.AddWithValue("@PRIMER_APELLIDO", estudiante.PrimerApellido);
            cmd.Parameters.AddWithValue("@SEGUNDO_APELLIDO", estudiante.SegundoApellido);
            cmd.Parameters.AddWithValue("@FECHA_NACIMIENTO", estudiante.FechaNacimiento);
            cmd.Parameters.AddWithValue("@NUMERO_TELEFONO", estudiante.NumeroTelefono);
            cmd.Parameters.AddWithValue("@CORREO_ELECTRONICO", estudiante.CorreoElectronico);
            cmd.Parameters.AddWithValue("@DIRECCION", estudiante.Direccion);

            //Teniendo los parametros y la conexionen cmd, ahora agregamos la sentencia
            cmd.CommandText = sentencia;

            //Insertamos los datos
            try
            {
                conexion.Open();
                id = Convert.ToInt32(cmd.ExecuteNonQuery());
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
        }//Fin InsertarEstudiante

        //****************************************************
        //SEGUNDA PARTE
        //Hacemos todos los preparativos para mostrar en el DataGridView los datos de los estudiantes

        public DataSet ListarEstudiantes(string condicion, string orden)
        {
            DataSet datos = new DataSet();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "SELECT ID_Estudiante, Nombre_Est, Primer_Apellido_Est, Segundo_Apellido_Est," +
                " Fecha_Nacimiento, Numero_Telefonico, Correo_Electronico_Est, Direccion_Exacta, Estado_Est, Borrado_Est FROM Estudiantes";
            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = string.Format("{0} WHERE {1}", sentencia, condicion);
            }
            if (!string.IsNullOrEmpty(orden))
            {
                sentencia = string.Format("{0} orden {1}");
            }
            try
            {
                adapter = new SqlDataAdapter(sentencia, conexion);
                adapter.Fill(datos, "Estudiantes");
            }
            catch (Exception)
            {

                throw;
            }
            return datos;
        }// Fin ListarEstudiantes
        //****************************************************
        //TERCERA PARTE
        //En esta parte creamos el método para seleccionar un estudiante en dataGridView y cargarlo en los txtbox
        public EntidadEstudiante ObtenerEstudiante(int id)
        {
            EntidadEstudiante estudiante = new EntidadEstudiante();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
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
                    estudiante.Nombre_Est = dataReader.GetString(1);
                    estudiante.PrimerApellido = dataReader.GetString(2);
                    estudiante.SegundoApellido = dataReader.GetString(3);
                    estudiante.FechaNacimiento = dataReader.GetDateTime(4);
                    estudiante.NumeroTelefono = dataReader.GetString(5);
                    estudiante.CorreoElectronico = dataReader.GetString(6);
                    estudiante.Direccion = dataReader.GetString(7);
                    estudiante.Estado = dataReader.GetString(8);
                    estudiante.Existe = true;
                }
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return estudiante;
        }//Fin ObtenerEstudiante
        //***********************************************
        //CUARTA PARTE
        //Eliminar un estudainte
        public int EliminarEstudiante(EntidadEstudiante estudiante)
        {
            int affectedRow = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            string sentencia = "DELETE FROM Estudiantes";
            sentencia = string.Format("{0} WHERE ID_Estudiante = {1}", sentencia, estudiante.Id_Estudiante);
            cmd.CommandText = sentencia;
            cmd.Connection = conexion;
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
        }// Fin EliminarEstudiante
         //**********************************************************************
         //QUINTA PARTE
         //Actualizar un Estudiante

        public int ActualizarEstudiante(EntidadEstudiante estudiante)
        {
            int affectedRow = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand cmd = new SqlCommand();

            string sentencia = "UPDATE Estudiantes SET Nombre_Est = @NOMBRE_EST, Primer_Apellido_Est = @PRIMER_APELLIDO,Segundo_Apellido_Est = @SEGUNDO_APELLIDO," +
                "Fecha_Nacimiento = @FECHA_NACIMIENTO,Numero_Telefonico = @NUMERO_TELEFONO,Correo_Electronico_Est = @CORREO_ELECTRONICO,Direccion_Exacta = @DIRECCION WHERE ID_Estudiante = @ID_ESTUDIANTE";

            cmd.CommandText = sentencia;
            cmd.Connection = conexion;
            cmd.Parameters.AddWithValue("@ID_ESTUDIANTE", estudiante.Id_Estudiante);
            cmd.Parameters.AddWithValue("@NOMBRE_EST", estudiante.Nombre_Est);
            cmd.Parameters.AddWithValue("@PRIMER_APELLIDO", estudiante.PrimerApellido);
            cmd.Parameters.AddWithValue("@SEGUNDO_APELLIDO", estudiante.SegundoApellido);
            cmd.Parameters.AddWithValue("@FECHA_NACIMIENTO", estudiante.FechaNacimiento);
            cmd.Parameters.AddWithValue("@NUMERO_TELEFONO", estudiante.NumeroTelefono);
            cmd.Parameters.AddWithValue("@CORREO_ELECTRONICO", estudiante.CorreoElectronico);
            cmd.Parameters.AddWithValue("@DIRECCION", estudiante.Direccion);
            

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
        }//Fin ActualizarEstudiante
         //***********************************************
         //SEXTA PARTE
         ////Buscamos un estudiante en un formulario externo y así agregarlo a la matricula para matricularlo

        public DataSet ListarEstudiante(string condicion, string orden)
        {
            DataSet datos = new DataSet();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "SELECT ID_Estudiante, Nombre_Est, Primer_Apellido_Est, Segundo_Apellido_Est, Numero_Telefonico," +
                " Correo_Electronico_Est, Direccion_Exacta FROM Estudiantes";
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
                adapter.Fill(datos, "Estudiantes");
            }
            catch (Exception)
            {

                throw;
            }
            return datos;
        }//Fin ListarEstudiante
    }//Fin  class DAEstudiante
}//Fin namespace CapaDatos
