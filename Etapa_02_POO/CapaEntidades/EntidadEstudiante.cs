using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class EntidadEstudiante
    {
        //Atributos 
        private int id_Estudiante;
        private string nombre_Est;
        private string primerApellido;
        private string segundoApellido;
        private DateTime fechaNacimiento;
        private string numeroTelefono;
        private string correoElectronico;
        private string direccion;
        private string estado;
        private bool existe;


        //Constructores
        //con paráremtros
        public EntidadEstudiante(int id_Estudiante, string nombre_Est, string primerApellido, string segundoApellido,
            DateTime fechaNacimiento, string numeroTelefono, string correoElectronico, string direccion, string estado, bool existe)
        {
            this.id_Estudiante = id_Estudiante;
            this.nombre_Est = nombre_Est;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
            this.fechaNacimiento = fechaNacimiento;
            this.numeroTelefono = numeroTelefono;
            this.correoElectronico = correoElectronico;
            this.direccion = direccion;
            this.estado = estado;
            this.existe = existe;
        }
        //sin parametros
        public EntidadEstudiante()
        {
            this.id_Estudiante = 0;
            this.nombre_Est = string.Empty;
            this.primerApellido = string.Empty;
            this.segundoApellido = string.Empty;
            this.fechaNacimiento = DateTime.Today;
            this.numeroTelefono = string.Empty;
            this.correoElectronico = string.Empty;
            this.direccion = string.Empty;
            this.estado = string.Empty;
            this.existe = false;
        }
        //*******************************************************************************
        //Métodos de acceso
        public int Id_Estudiante { get => id_Estudiante; set => id_Estudiante = value; }
        public string Nombre_Est { get => nombre_Est; set => nombre_Est = value; }
        public string PrimerApellido { get => primerApellido; set => primerApellido = value; }
        public string SegundoApellido { get => segundoApellido; set => segundoApellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string NumeroTelefono { get => numeroTelefono; set => numeroTelefono = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Estado { get => estado; set => estado = value; }
        public bool Existe { get => existe; set => existe = value; }
        //*********************************************************************************
        //Método que se sobre escribe

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} - {4} - {5} - {6} - {7} - {8} - {9}", id_Estudiante, nombre_Est,
                                 primerApellido, segundoApellido, fechaNacimiento, numeroTelefono, correoElectronico, direccion, estado, existe);
        }
    }//fin class EntidadEstudiante
}//fin namespace CapaEntidades
