using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CapaEntidades;
using CapaDatos;

namespace CapaLogica
{
    public class BLPagos
    {
        private string _cadenaConexion;
        private string _mensaje;

        public BLPagos(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //propiedad
        public string Mensaje
        {
            get => _mensaje;
        }

        //*****************************************
        //llamado insertar pagos de la capa de datos
        public int InsertarPago(EntidadPagos pago)
        {
            int id_Pago = 0;
            DAPagos accesoDatos = new DAPagos(_cadenaConexion);

            try
            {
                id_Pago = accesoDatos.InsertarPago(pago);
            }
            catch (Exception)
            {

                throw;
            }
            return id_Pago;
        }
        //******************************
        public DataSet ListarMatricula(string condicion, string orden)
        {
            DataSet datos;
            DAMatricula accesoDatos = new DAMatricula(_cadenaConexion);
            try
            {
                datos = accesoDatos.ListaMatriculas(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }
            return datos;
        }

        //***************************
        public EntidadMatricula ObtenerMatricula(int id)
        {
            EntidadMatricula matricula;
            DAMatricula accesoDatos = new DAMatricula(_cadenaConexion);
            try
            {
                matricula = accesoDatos.ObtenerMatricula(id);
            }
            catch (Exception)
            {

                throw;
            }
            return matricula;
        }

    }//fin     class BLPagos
}//fin namespace CapaLogica
