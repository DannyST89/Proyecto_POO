using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CapaEntidades;
using CapaDatos;

namespace CapaLogica
{
    public class BLEstudiante
    {
        //****************************************************
        //PRIMERA PARTE
        //Atributos 
        private string _cadenaConexion;
        private string _mensaje;

        public BLEstudiante(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public string Mensaje
        {
            get => _mensaje;
        }

        //****************************************************
        //Obtenemos el método de insertar estudiante creado en capaDatos
        public int InsertarEstudiante(EntidadEstudiante estudiante)
        {
            int id = 0;
            DAEstudiante accesoDatos = new DAEstudiante(_cadenaConexion);
            try
            {
                id = accesoDatos.InsertarEstudiante(estudiante);
            }
            catch (Exception)
            {

                throw;
            }
            return id;
        }//Fin InsertarEstudiante

        //**************************************************
        //SEGUNDA PARTE

        public DataSet ListarEstudiantes(string condicion, string orden)
        {
            DataSet datos;
            DAEstudiante accesoDatos = new DAEstudiante(_cadenaConexion);
            try
            {
                datos = accesoDatos.ListarEstudiantes(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }
            return datos;
        }// Fin ListarEstudiantes
         //****************************************************
         //TERCERA PARTE
        public EntidadEstudiante ObtenerEstudiantes(int id)
        {
            EntidadEstudiante estudiante;
            DAEstudiante accesoDatos = new DAEstudiante(_cadenaConexion);
            try
            {
                estudiante = accesoDatos.ObtenerEstudiante(id);
            }
            catch (Exception)
            {

                throw;
            }
            return estudiante;
        }//fin ObtenerEstudiantes

        //CUARTA PARTE
        //Eliminar una Estudiane
        public int EliminarEstudiante(EntidadEstudiante estudiante)
        {
            int affectedRow;
            DAEstudiante accesoDatos = new DAEstudiante(_cadenaConexion);
            try
            {
                affectedRow = accesoDatos.EliminarEstudiante(estudiante);
            }
            catch (Exception)
            {

                throw;
            }
            return affectedRow;
        }//Fin EliminarEstudiante
         //**********************************************************************
         //QUINTA PARTE
         //Actualizar un Estudiante
        public int ActualizarEstudiante(EntidadEstudiante estudiante)
        {
            int affectedRow = 0;
            DAEstudiante accesoDatos = new DAEstudiante(_cadenaConexion);
            try
            {
                affectedRow = accesoDatos.ActualizarEstudiante(estudiante);
            }
            catch (Exception)
            {

                throw;
            }
            return affectedRow;
        }// Fin ActualizarEstudiante
         //***********************************************
         //SEXTA PARTE
         //llamando listar estudiante de la capa acceso datos
        public DataSet ListarEstudiante(string condicion, string orden)
        {
            DataSet datos;
            DAEstudiante accesoDatos = new DAEstudiante(_cadenaConexion);
            try
            {
                datos = accesoDatos.ListarEstudiante(condicion, orden);
            }
            catch (Exception)
            {
                throw;
            }
            return datos;
        }// Fin ListarEstudiante
    }//fin class BLEstudiante
}//fin namespace CapaLogica
