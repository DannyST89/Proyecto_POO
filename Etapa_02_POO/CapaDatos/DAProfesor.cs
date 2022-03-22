using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using CapaEntidades;

namespace CapaDatos
{
    public class DAProfesor
    {
        //************************************
        //PRIMERA PARTE
        // Se crean dos atributos, el primero es la cadena de conexion y el segundo el mensaje que mostraremos al usuario
        //Encapsulamos los atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades

        public string Mensaje
        {
            get => _mensaje;
        }

        //Creamos el constructor de la clase
        public DAProfesor(string cadenaConexion)
        {
            this._cadenaConexion = cadenaConexion;
            this._mensaje = string.Empty;
        }

        // Se crea el método para insertar datos en la base de datos
        public int InsertarDatosBD(EntidadProfesor profesor)
        {
            // Creamos un objeto que recibira la cadena de conexion para la base de datos
            //objeto de tipo sqlConnection
            SqlConnection conexion = new SqlConnection(_cadenaConexion);// hacemos la instancia y recibimos el parametro con el valor de conexion
            // con la siguiente instancia creamos un objeto de tipo SqlCommand para usar comando de SQL
            SqlCommand comando = new SqlCommand();
            //Esta variable guarda el id ingresado en la BD y la funcion EXecuteScalar() lo devuelve
            int id = 0;

            string sentencia = "INSERT INTO Profesores(Nombre_Profesor, Primer_Apellido_Prof, Segundo_Apellido_Prof," +
                               "Fecha_Nacimiento_Prof, Numero_Telefonico, Correo_Electronico_Prof, Cuenta_Bancaria, Direccion_Exacta," +
                               "Curso_Certificado, Hora_Entrada,Hora_Salida) VALUES(@NOMBRE, @PRIMER_APELLIDO," +
                               "@SEGUNDO_APELLIDO, @FECHA_NACIMIENTO, @TELEFONO, @CORREO, @CUENTA, @DIRECCION, @CURSO_CERTIFICADO, @HORA_ENTRADA," +
                               "@HORA_SALIDA) SELECT @@IDENTITY";
            //tenemos la conexion en el objeto conexion
            //tenemos que pasarla al objeto comando que tiene como atributo connection 
            comando.Connection = conexion;
            //Necesitamos específicar las variables que van en la sentencia SQL
            comando.Parameters.AddWithValue("@NOMBRE", profesor.getNombreProfesor());
            comando.Parameters.AddWithValue("@PRIMER_APELLIDO", profesor.getPrimerApellido());
            comando.Parameters.AddWithValue("@SEGUNDO_APELLIDO", profesor.getSegundoApellido());
            comando.Parameters.AddWithValue("@FECHA_NACIMIENTO", profesor.getFechaNacimiento());
            comando.Parameters.AddWithValue("@TELEFONO", profesor.getNumeroTelefonor());
            comando.Parameters.AddWithValue("@CORREO", profesor.getCorreoElectronico());
            comando.Parameters.AddWithValue("@CUENTA", profesor.getCuentaBancaria());
            comando.Parameters.AddWithValue("@DIRECCION", profesor.getDireccionExacta());
            comando.Parameters.AddWithValue("@CURSO_CERTIFICADO", profesor.getCursoCertificado());
            comando.Parameters.AddWithValue("@HORA_ENTRADA", profesor.getHoraEntrada());
            comando.Parameters.AddWithValue("@HORA_SALIDA", profesor.getHoraSalida());

            comando.CommandText = sentencia;

            //Ejecutamos la consulta

            try
            {
                conexion.Open();//abrimos la conexion
                id = Convert.ToInt32(comando.ExecuteScalar());// traemos el identity de la tabla profesores
                conexion.Close(); //cerramos la conexion
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Dispose();//se lebera la memoria
                comando.Dispose();//libera la memoria del objeto
            }
            return id;
        }//Fin InsertarDatosBD

        //****************************************************
        //SEGUNDA PARTE
        //Creamos el método para acceder a la base de datos y mostrar los datos de la tabla profesores en el DataGridView

        public DataSet ListarProfesores(string condicion, string orden)
        {
            //creamos un objeto de tipo dataset para guardar la consulta de de la base de datos
            DataSet datos = new DataSet();
            //llamamos la conexion y al mismo timpo pasamos el valor al objeto que se esta creando
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            //variable tipo SqlAdapter
            SqlDataAdapter adapter;//se inicializa
            string sentencia = "SELECT ID_Profesor, Nombre_Profesor, Primer_Apellido_Prof, Segundo_Apellido_Prof, Fecha_Nacimiento_Prof," +
                " Numero_Telefonico, Correo_Electronico_Prof, Cuenta_Bancaria,Direccion_Exacta, Curso_Certificado, Hora_Entrada, Hora_Salida, Estado, Borrado  FROM Profesores";
            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = string.Format("{0}  WHERE  {1} ", sentencia, condicion);
            }
            if (!string.IsNullOrEmpty(orden))
            {
                sentencia = string.Format("{0}  orden {1} ", sentencia, orden);
            }
            try
            {
                adapter = new SqlDataAdapter(sentencia, conexion);//se instancia
                adapter.Fill(datos, "Profesores");
            }
            catch (Exception)
            {

                throw;
            }

            return datos;

        }//Fin ConsultarClientes

        //*********************************************************************
        //TERCERA PARTE
        //Creamos el método obtener profesor para mostrar en el formulario
        public EntidadProfesor ObtenerProfesor(int id)
        {
            EntidadProfesor profesor = new EntidadProfesor();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand cmd = new SqlCommand();

            SqlDataReader dataReader;// se llena con un execute
            string sentencia = string.Format("SELECT ID_Profesor, Nombre_Profesor, Primer_Apellido_Prof,  Segundo_Apellido_Prof, Fecha_Nacimiento_Prof," +
                " Numero_Telefonico, Correo_Electronico_Prof, Cuenta_Bancaria,Direccion_Exacta, Curso_Certificado, Hora_Entrada, Hora_Salida   FROM Profesores WHERE ID_Profesor = {0}", id);

            cmd.Connection = conexion;
            cmd.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    profesor.IdProfesor = dataReader.GetInt32(0);
                    profesor.NombreProfesor = dataReader.GetString(1);
                    profesor.PrimerApellido = dataReader.GetString(2);
                    profesor.SegundoApellido = dataReader.GetString(3);
                    profesor.FechaNacimiento = dataReader.GetDateTime(4);
                    profesor.NumeroTelefono = dataReader.GetString(5);
                    profesor.CorreoElectronico = dataReader.GetString(6);
                    profesor.CuentaBancaria = dataReader.GetString(7);
                    profesor.DireccionExacta = dataReader.GetString(8);
                    profesor.CursoCertificado = dataReader.GetString(9);
                    profesor.HoraEntrada = dataReader.GetDateTime(10);
                    profesor.HoraSalida = dataReader.GetDateTime(11);
                  
                    profesor.Existe = true;
                }
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return profesor;
        }//Fin Obtener Profesor
         //*********************************************************************
         //Eliminar un profesor con un procedimiento almacenado

        public int EliminarProfesor(EntidadProfesor profesor)
        {
            int resultado = -1;

            //nos conectamos a la base de datos
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_ELIMINAR_PROFESOR";//Nombre del procedimiento almacenado
            //específicamos el tipo de comando
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexion;

            //Este es el parametro que recibe el procedimiento para saber que dato eliminar

            //ES NECESARIO AGREGAR AQUÍ TODOS LOS DATOS, EN CASO CONTRARIO GENERA UN ERROR.
            cmd.Parameters.AddWithValue("@ID_PROFESOR", profesor.IdProfesor);
            cmd.Parameters.AddWithValue("@NOMBRE_PROFESOR", profesor.NombreProfesor);
            cmd.Parameters.AddWithValue("@PRIMER_APELLIDO", profesor.PrimerApellido);
            cmd.Parameters.AddWithValue("@SEGUNDO_APELLIDO", profesor.SegundoApellido);
            cmd.Parameters.AddWithValue("@FECHA_NACIMIENTO", profesor.FechaNacimiento);
            cmd.Parameters.AddWithValue("@NUMERO_TELEFONO", profesor.NumeroTelefono);
            cmd.Parameters.AddWithValue("@CORREO", profesor.CorreoElectronico);
            cmd.Parameters.AddWithValue("@CUENTA", profesor.CuentaBancaria);
            cmd.Parameters.AddWithValue("@DIRECCION", profesor.DireccionExacta);
            cmd.Parameters.AddWithValue("@CURSO_CERTIFICADO", profesor.CursoCertificado);
            cmd.Parameters.AddWithValue("@HORA_ENTRADA", profesor.HoraEntrada);
            cmd.Parameters.AddWithValue("@HORA_SALIDA", profesor.HoraSalida);
            cmd.Parameters.AddWithValue("@ESTADO", profesor.Estado);
            cmd.Parameters.AddWithValue("@BORRADO", profesor.Borrado1);


            cmd.Parameters.Add("@MSJ", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;// mensaje del procedimiento
            //otro parametro para obtener el retorno del procedimiento 
            cmd.Parameters.Add("@retorno", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;

            try
            {
                conexion.Open();
                cmd.ExecuteNonQuery();//ejecutamos el SP
                resultado = Convert.ToInt32(cmd.Parameters["@retorno"].Value);//obtiene la variable
                _mensaje = cmd.Parameters["@MSJ"].Value.ToString();
                conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }//Fin EliminarProfesor
        //***********************************************************
        //Creamos el método para actualizar un profesor

        public int ActualizarProfesor(EntidadProfesor profesor)
        {
            int affectedRow = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion); //realizamos la conexion
            SqlCommand cmd = new SqlCommand();
            //agregamos la consulta de la base de datos
            string sentencia = "UPDATE Profesores SET Nombre_Profesor = @NOMBRE_PROFESOR, Primer_Apellido_Prof = @PRIMER_APELLIDO," +
                "Segundo_Apellido_Prof = @SEGUNDO_APELLIDO, Fecha_Nacimiento_Prof = @FECHA_NACIMIENTO, Numero_Telefonico = @NUMERO_TELEFONO," +
                " Correo_Electronico_Prof = @CORREO, Cuenta_Bancaria = @CUENTA, Direccion_Exacta = @DIRECCION," +
                " Curso_Certificado = @CURSO_CERTIFICADO, Hora_Entrada = @HORA_ENTRADA, Hora_Salida = @HORA_SALIDA WHERE ID_Profesor = @ID_PROFESOR ";
            cmd.CommandText = sentencia;
            cmd.Connection = conexion;
            cmd.Parameters.AddWithValue("@ID_PROFESOR", profesor.IdProfesor);
            cmd.Parameters.AddWithValue("@NOMBRE_PROFESOR", profesor.NombreProfesor);
            cmd.Parameters.AddWithValue("@PRIMER_APELLIDO", profesor.PrimerApellido);
            cmd.Parameters.AddWithValue("@SEGUNDO_APELLIDO", profesor.SegundoApellido);
            cmd.Parameters.AddWithValue("@FECHA_NACIMIENTO", profesor.FechaNacimiento);
            cmd.Parameters.AddWithValue("@NUMERO_TELEFONO", profesor.NumeroTelefono);
            cmd.Parameters.AddWithValue("@CORREO", profesor.CorreoElectronico);
            cmd.Parameters.AddWithValue("@CUENTA", profesor.CuentaBancaria);
            cmd.Parameters.AddWithValue("@DIRECCION", profesor.DireccionExacta);
            cmd.Parameters.AddWithValue("@CURSO_CERTIFICADO", profesor.CursoCertificado);
            cmd.Parameters.AddWithValue("@HORA_ENTRADA", profesor.HoraEntrada);
            cmd.Parameters.AddWithValue("@HORA_SALIDA", profesor.HoraSalida);
           

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
        }//Fin Actualizar profesor

        //*************************************************

    }//Fin class DAProfesor
}//fin namespace capadatos
