using System;
using System.Data;
using CapaEntidades;
using CapaDatos;

namespace CapaLogica
{
    public class BLCurso
    {
        private string _cadenaConexion;
        private string _mensaje;

        public BLCurso(string cadenaConexion)
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
        //llamado insertar cursos de la capa de datos
        public int InsertarCursos(EntidadCurso curso)
        {
            int id_Curso = 0;
            DACurso accesoDatos = new DACurso(_cadenaConexion);

            try
            {
                id_Curso = accesoDatos.InsertarCursos(curso);
            }
            catch (Exception)
            {

                throw;
            }
            return id_Curso;
        }
        //llamamos el método de la Capa de acceso a datos MostrarCursosEnDataGridView
        public DataSet MostrarCursosEnDataGridView(string condicion, string orden)//con los mismos parámetros
        {
            DataSet datos;
            DACurso accesoDatos = new DACurso(_cadenaConexion);
            try
            { // guardamos los datos recibidos en la base de datos en la variable datos
                datos = accesoDatos.MostrarCursosEnDataGridView(condicion, orden);
            }
            catch (Exception)
            {
                throw;
            }
            return datos;
        }//Fin MostrarCursosEnDataGridView
        //*************************************************
        //llamamos EliminarCurso creado en la capa de datos
        public int EliminarCurso(EntidadCurso curso)
        {
            int resultado;
            DACurso accesoDatos = new DACurso(_cadenaConexion);
            try
            {
                resultado = accesoDatos.EliminarCurso(curso);
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }//Fin EliminarCurso
        //************************************************
        public EntidadCurso ObtenerCurso(int id)
        {
            EntidadCurso curso;

            DACurso accesoDatos = new DACurso(_cadenaConexion);
            try
            {
                curso = accesoDatos.ObtenerCurso(id);
            }
            catch (Exception)
            {

                throw;
            }

            return curso;
        }// Fin ObtenerCurso
        //***********************************
        //llamamas el método actualizar curso en la capa datos
        public int ActualizarCurso(EntidadCurso curso)
        {
            int affectedRow = 0;
            DACurso accesoDatos = new DACurso(_cadenaConexion);
            try
            {
                affectedRow = accesoDatos.ActualizarCurso(curso);
            }
            catch (Exception)
            {

                throw;
            }
            return affectedRow;
        }//Fin actualizar curso
         //llamando listar curso de la capa acceso datos
        public DataSet ListarCursos(string condicion, string orden)
        {
            DataSet datos;
            DACurso accesoDatos = new DACurso(_cadenaConexion);
            try
            {
                datos = accesoDatos.ListarCursos(condicion, orden);
            }
            catch (Exception)
            {
                throw;
            }
            return datos;
        }// Fin Listarcurso
    }//fin class BLCurso
}//fin namespace CapaLogica
