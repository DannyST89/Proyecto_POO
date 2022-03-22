using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CapaDatos;
using CapaEntidades;

namespace CapaLogica
{
    public class BLProfesor
    {
        //necesitamos llamar el método para insertar datos, este método fue creado en la capaAccesoDatos
        //recibimos un parametro profesor
        //**************************************************
        //PRIMERA PARTE
        //creamos los atributos 
        private string _cadenaConexion;
        private string _mensaje;


        // propiedades
        public string Mensaje
        {
            get => _mensaje;
        }

        //constructor de la clase
        public BLProfesor(string cadenaConexion)
        {
            this._cadenaConexion = cadenaConexion;
            this._mensaje = string.Empty;
        }

        // En este espacio llamamos el método creado en la Capa Acceso a Datos con el parámetro profesor que envia
        public int InsertarDatosBD(EntidadProfesor profesor)// recordemos que el parámetro enviado es de tipo EntidadProfesor aquí no cambia
        {
            int id_Profesor = 0;
            DAProfesor accesoDatos = new DAProfesor(_cadenaConexion); // instanciamos el objeto accesoDatos de tipo DAProfesor con el valor de la cadena de conexion
            try
            {
                id_Profesor = accesoDatos.InsertarDatosBD(profesor);// utilizamos el método de la capa de datos
            }
            catch (Exception)
            {

                throw;
            }
            return id_Profesor;
        }
        //**************************************************
        //SEGUNDA PARTE
        //llamamos el método ConsultarClientes creado en CapaAccesoDatos
        public DataSet ListarProfesores(string condicion, string orden)
        {
            DataSet datos;
            DAProfesor accesoDatos = new DAProfesor(_cadenaConexion);// OBTENEMOS LA CADENA DE CONEXION

            try
            {
                datos = accesoDatos.ListarProfesores(condicion, orden);// este consultar clientes es de la CapaAccesoDatos
            }
            catch (Exception)
            {

                throw;
            }
            return datos;
        }// Fin ConsultarClientes

        //LLamamos obtener cliente creado en la capa Acceso a Datos

        public EntidadProfesor ObtenerProfesor(int id)
        {
            EntidadProfesor profesor;

            DAProfesor accesoDatos = new DAProfesor(_cadenaConexion);
            try
            {
                profesor = accesoDatos.ObtenerProfesor(id);
            }
            catch (Exception)
            {

                throw;
            }

            return profesor;
        }// Fin ObtenerProfesor

        //****************************************
        //llamamos EliminarProfesor de DAProfesor

        public int EliminarProfesor(EntidadProfesor profesor)
        {
            int resultado;
            DAProfesor accesoDatos = new DAProfesor(_cadenaConexion);
            try
            {
                resultado = accesoDatos.EliminarProfesor(profesor);
                _mensaje = accesoDatos.Mensaje;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }//Fin EliminarProfesor
        //*************************************************************
        //llamamos el método actualizar Profesor de la capa de Acceso a datos
        public int ActualizarProfesor(EntidadProfesor profesor)
        {
            int affectedRow = 0;
            DAProfesor accesoDatos = new DAProfesor(_cadenaConexion);
            try
            {
                affectedRow = accesoDatos.ActualizarProfesor(profesor);
            }
            catch (Exception)
            {

                throw;
            }
            return affectedRow;
        }//Fin actualizar profesor
    }//fin class BLProfesor
}//fin namespace CapaLogica
