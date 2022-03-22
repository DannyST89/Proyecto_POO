using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using CapaEntidades;

namespace CapaAccesoDatos
{
    public class DAPagos
    {
        // Atributos que se utilizaran para distribuir la cadena de conexion entre las diferentes capas
        private string _cadenaConexion;
        private string _mensaje;

        //propiedad
        public string Mensaje
        {
            get => _mensaje;
        }

        public DAPagos(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //**********************************
        public int InsertarPago(EntidadPagos pagos)
        {
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand cmd = new SqlCommand();

            int id = 0;
            string sentencia = "INSERT INTO Pagos(ID_Matricula,ID_Estudiante,Monto_A_Pagar,Curso_Matriculado,Fecha_Pago,Estado_Pago)" +
                                "VALUES(@ID_MATRICULA,@ID_ESTUDIANTE, @MONTO_A_PAGAR,@CURSO_MATRICULADO,@FECHA_PAGO,@ESTADO_PAGO) SELECT @@IDENTITY";
            cmd.Connection = conexion;

            cmd.Parameters.AddWithValue("@ID_MATRICULA", pagos.IdMatricula);
            cmd.Parameters.AddWithValue("@ID_ESTUDIANTE", pagos.IdEstudiante);
            cmd.Parameters.AddWithValue("@MONTO_A_PAGAR", pagos.MontoAPagar);
            cmd.Parameters.AddWithValue("@CURSO_MATRICULADO", pagos.CursoMatriculado);
            cmd.Parameters.AddWithValue("@FECHA_PAGO", pagos.FechaPago);
            cmd.Parameters.AddWithValue("@ESTADO_PAGO", pagos.EstadoPago);
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
        }//Fin insertar un pago
        //***************************************
        //Método para listar un cliente
        public DataSet ListarMatricula(string condicion, string orden)
        {
            DataSet datos = new DataSet();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            String sentencia = "SELECT ID_Matricula, ID_Estudiante, Curso_Matriculado,Total_horas_Clases FROM Matriculas";

            if (!string.IsNullOrEmpty(condicion))
            {
                sentencia = string.Format("{0} where {1}", sentencia, condicion);
            }
            else
            {
                sentencia = string.Format("{0} order by {1}", sentencia, orden);
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
        }//Fin Listar Matriculas
        //***************************************
        public EntidadMatricula ObtenerMatricula(int id)
        {
            EntidadMatricula matricula = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand cmd = new SqlCommand();

            SqlDataReader dataReader;
            string sentencia = string.Format("SELECT ID_Matricula, ID_Estudiante, Curso_Matriculado,Total_horas_Clases FROM Matriculas WHERE ID_Matricula = {0}", id);

            cmd.Connection = conexion;
            cmd.CommandText = sentencia;
            try
            {
                conexion.Open();
                dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    matricula = new EntidadMatricula();
                    dataReader.Read();
                    matricula.IdMatricula = dataReader.GetInt32(0);
                    matricula.IdEstudiante = dataReader.GetInt32(1);
                    matricula.Curso_Matriculado = dataReader.GetString(2);
                    matricula.Total_Horas_Clases = dataReader.GetInt32(3);
                }
                conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return matricula;
        }
    }//Fin class DAPagos

}//namespace CapaAccesoDatos
