using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class EntidadMatricula
    {
        //Atributos
        private int idMatricula;
        private int idEstudiante;
        private string nombre_Estudiantes;
        private string primer_Apellido;
        private string segundo_Apellido;
        private string numero_Telefono;
        private string correo_Electronico;
        private string direccion;
        private string curso_Matriculado;
        private string intensidad;
        private DateTime fecha_Inicio;
        private DateTime fecha_Final;
        private int horas_Clase_Sincronica;
        private int horas_Clase_Asincronica;
        private int total_Horas_Clases;
        private int horas_Por_Dia;
        private bool existe;


        //Constructor
        public EntidadMatricula(int idMatricula, int idEstudiante, string nombre_Estudiantes, string primer_Apellido, string segundo_Apellido,
            string numero_Telefono, string correo_Electronico, string direccion, string curso_Matriculado, string intensidad,
            DateTime fecha_Inicio, DateTime fecha_Final, int horas_Clase_Sincronica, int horas_Clase_Asincronica,
            int total_Horas_Clases, int horas_Por_Dia, bool existe)
        {
            this.idMatricula = idMatricula;
            this.idEstudiante = idEstudiante;
            this.nombre_Estudiantes = nombre_Estudiantes;
            this.primer_Apellido = primer_Apellido;
            this.segundo_Apellido = segundo_Apellido;
            this.numero_Telefono = numero_Telefono;
            this.correo_Electronico = correo_Electronico;
            this.direccion = direccion;
            this.curso_Matriculado = curso_Matriculado;
            this.intensidad = intensidad;
            this.fecha_Inicio = fecha_Inicio;
            this.fecha_Final = fecha_Final;
            this.horas_Clase_Sincronica = horas_Clase_Sincronica;
            this.horas_Clase_Asincronica = horas_Clase_Asincronica;
            this.total_Horas_Clases = total_Horas_Clases;
            this.horas_Por_Dia = horas_Por_Dia;
            this.existe = false;
        }//Fin Metodo con parametros
        public EntidadMatricula()
        {
            this.idMatricula = 0;
            this.idEstudiante = 0;
            this.nombre_Estudiantes = string.Empty;
            this.primer_Apellido = string.Empty;
            this.segundo_Apellido = string.Empty;
            this.numero_Telefono = string.Empty;
            this.correo_Electronico = string.Empty;
            this.direccion = string.Empty;
            this.curso_Matriculado = string.Empty;
            this.intensidad = string.Empty;
            this.fecha_Inicio = DateTime.Today;
            this.fecha_Final = DateTime.Today;
            this.horas_Clase_Sincronica = 0;
            this.horas_Clase_Asincronica = 0;
            this.total_Horas_Clases = 0;
            this.horas_Por_Dia = 0;
            this.existe = false;
        }//Fin Metodo sin parametros
        //***********************************************
        //Métodos de acceso
        public int IdMatricula { get => idMatricula; set => idMatricula = value; }
        public int IdEstudiante { get => idEstudiante; set => idEstudiante = value; }
        public string Nombre_Estudiantes { get => nombre_Estudiantes; set => nombre_Estudiantes = value; }
        public string Primer_Apellido { get => primer_Apellido; set => primer_Apellido = value; }
        public string Segundo_Apellido { get => segundo_Apellido; set => segundo_Apellido = value; }
        public string Numero_Telefono { get => numero_Telefono; set => numero_Telefono = value; }
        public string Correo_Electronico { get => correo_Electronico; set => correo_Electronico = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Curso_Matriculado { get => curso_Matriculado; set => curso_Matriculado = value; }
        public string Intensidad { get => intensidad; set => intensidad = value; }
        public DateTime Fecha_Inicio { get => fecha_Inicio; set => fecha_Inicio = value; }
        public DateTime Fecha_Final { get => fecha_Final; set => fecha_Final = value; }
        public int Horas_Clase_Sincronica { get => horas_Clase_Sincronica; set => horas_Clase_Sincronica = value; }
        public int Horas_Clase_Asincronica { get => horas_Clase_Asincronica; set => horas_Clase_Asincronica = value; }
        public int Total_Horas_Clases { get => total_Horas_Clases; set => total_Horas_Clases = value; }
        public int Horas_Por_Dia { get => horas_Por_Dia; set => horas_Por_Dia = value; }
        public bool Existe { get => existe; set => existe = value; }


        //***************************************************************************************************************
        //metodo sobre escribe
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} - {4} - {5} - {6} - {7} - {8} - {9} - {10} - {11} - {12} - {13} - {14} - {15} - {16}", idMatricula, idEstudiante,
                              nombre_Estudiantes, primer_Apellido, segundo_Apellido, numero_Telefono, correo_Electronico, direccion, curso_Matriculado, intensidad,
                                  fecha_Inicio, Fecha_Final, horas_Clase_Asincronica, Horas_Clase_Asincronica, Total_Horas_Clases, Horas_Por_Dia, existe);
        }
    }//fin class EntidadMatricula
}//fin namespace CapaEntidades
