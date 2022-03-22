using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class EntidadPagos
    {
        //Atributos
        private int idMatricula;
        private int idEstudiante;
        private decimal montoAPagar;
        private string cursoMatriculado;
        private DateTime fechaPago;
        private string estadoPago;

        public EntidadPagos(int idMatricula, int idEstudiante, decimal montoAPagar, string cursoMatriculado, DateTime fechaPago, string estadoPago)
        {
            this.idMatricula = idMatricula;
            this.idEstudiante = idEstudiante;
            this.montoAPagar = montoAPagar;
            this.cursoMatriculado = cursoMatriculado;
            this.fechaPago = fechaPago;
            this.estadoPago = estadoPago;
        }

        public EntidadPagos()
        {
            this.idMatricula = 0;
            this.idEstudiante = 0;
            this.montoAPagar = 0;
            this.cursoMatriculado = string.Empty;
            this.fechaPago = DateTime.Today;
            this.estadoPago = string.Empty;
        }

        public int IdMatricula { get => idMatricula; set => idMatricula = value; }
        public int IdEstudiante { get => idEstudiante; set => idEstudiante = value; }
        public decimal MontoAPagar { get => montoAPagar; set => montoAPagar = value; }
        public string CursoMatriculado { get => cursoMatriculado; set => cursoMatriculado = value; }
        public DateTime FechaPago { get => fechaPago; set => fechaPago = value; }
        public string EstadoPago { get => estadoPago; set => estadoPago = value; }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} - {4} - {5}", idMatricula, idEstudiante,
                                  montoAPagar, cursoMatriculado, fechaPago, estadoPago);
        }

    }//fin class EntidadPagos
}//fin namespace CapaEntidades
