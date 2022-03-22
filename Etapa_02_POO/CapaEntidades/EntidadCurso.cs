using System;

namespace CapaEntidades
{
    public class EntidadCurso
    {
        //Atributos
        private int idCurso;
        private string nombreCurso;
        private int cantidadHoras;
        private int precioHora;
        private string estado;
        private bool existe;

        //Constructor con parámetros
        public EntidadCurso(int idCurso, string nombreCurso, int cantidadHoras, string estado, bool existe, int precioHora)
        {
            this.idCurso = idCurso;
            this.nombreCurso = nombreCurso;
            this.cantidadHoras = cantidadHoras;
            this.precioHora = precioHora;
            this.estado = estado;
            this.existe = existe;
        }
        //Constructor sin parámetros
        public EntidadCurso()
        {
            this.idCurso = 0;
            this.nombreCurso = string.Empty;
            this.cantidadHoras = 0;
            this.precioHora = 0;
            this.estado = string.Empty;
            this.existe = false;
        }

        //Métodos de acceso generados
        public int IdCurso { get => idCurso; set => idCurso = value; }
        public string NombreCurso { get => nombreCurso; set => nombreCurso = value; }
        public int CantidadHoras { get => cantidadHoras; set => cantidadHoras = value; }
        public string Estado { get => estado; set => estado = value; }
        public bool Existe { get => existe; set => existe = value; }
        public int PrecioHora { get => precioHora; set => precioHora = value; }

        //Métodos de acceso manuales
        //Geter
        public int getIdCurso() { return idCurso; }
        public string getNombreCurso() { return nombreCurso; }
        public int getCantidadHoras() { return cantidadHoras; }
        public int getPrecioHora() { return precioHora; }
        public string getEstado() { return estado; }
        public bool getExiste() { return existe; }
        //Setter
        public void setIdCurso(int idCurso) { this.idCurso = idCurso; }
        public void setNombreCurso(string nombreCurso) { this.nombreCurso = nombreCurso; }
        public void setCantidadHoras(int cantidadHoras) { this.cantidadHoras = cantidadHoras; }
        public void setPrecioHora(int precioHora) { this.precioHora = precioHora; }
        public void setEstado(string estado) { this.estado = estado; }
        public void setExiste(bool existe) { this.existe = existe; }


        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} - {4}", idCurso, nombreCurso, cantidadHoras, estado);
        }
    }//fin class EntidadCurso
}//fin namespace CapaEntidades
