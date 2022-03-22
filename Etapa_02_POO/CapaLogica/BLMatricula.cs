using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CapaDatos;
using CapaEntidades;

namespace CapaLogica
{
   public class BLMatricula
    {
        //*********************************
        //PRIMERA PARTE
        //Atributos 
        private string _cadena_Conexion;
        private string _mensaje;

        //constructor
        public BLMatricula(string cadena_Conexion)
        {
            _cadena_Conexion = cadena_Conexion;
            _mensaje = string.Empty;
        }

        public string Mensaje
        {
            get => _mensaje;
        }
        //*******************************************
        //llamamos el método InsertarMatricula de la capaAccesoDatos
        public int InsertarMatricula(EntidadMatricula matricula)
        {
            int id = 0;
            DAMatricula accesoDatos = new DAMatricula(_cadena_Conexion);
            try
            {
                id = accesoDatos.InsertarMatricula(matricula);// Este insertar es de capaDatos
            }
            catch (Exception)
            {

                throw;
            }
            return id;
        }//Fin InsertarMatricula
        //**************************************************
        //SEGUNDA PARTE
        public DataSet ListarMatriculas(string condicion, string orden)
        {
            DataSet datos;
            DAMatricula accesoDatos = new DAMatricula(_cadena_Conexion);
            try
            {
                datos = accesoDatos.ListaMatriculas(condicion, orden);
            }
            catch (Exception)
            {

                throw;
            }
            return datos;
        } //Fin listarMatriculas
        //*******************************************
        //TERCERA PARTE

        public EntidadMatricula ObtenerMatricula(int id)
        {
            EntidadMatricula matricula;
            DAMatricula accesoDatos = new DAMatricula(_cadena_Conexion);
            try
            {
                matricula = accesoDatos.ObtenerMatricula(id);
            }
            catch (Exception)
            {

                throw;
            }
            return matricula;
        }//Fin ObtenerMatricula
         //***********************************************
         //CUARTA PARTE
         //Eliminar una matrícula
        public int EliminarMatricula(EntidadMatricula matricula)
        {
            int resultado;
            DAMatricula accesoDatos = new DAMatricula(_cadena_Conexion);
            try
            {
                resultado = accesoDatos.EliminarMatricula(matricula);
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }//Fin EliminarMatricula
         //***********************************************
         //QUINTA PARTE
         //Actualizar una matrícula
        public int ActualizarMatricula(EntidadMatricula matricula)
        {
            int affectedRow = 0;
            DAMatricula accesoDatos = new DAMatricula(_cadena_Conexion);
            try
            {
                affectedRow = accesoDatos.ActualizarMatricula(matricula);
            }
            catch (Exception)
            {

                throw;
            }
            return affectedRow;
        }//Fin ActualizarMatricula
        //************************************************
        //SEXTA PARTE
        public EntidadEstudiante ObtenerEstudiantes(int id)
        {
            EntidadEstudiante estudiante;
            DAEstudiante accesoDatos = new DAEstudiante(_cadena_Conexion);
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
    }//fin class BLMatricula
}//fin namespace CapaLogica
