using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class EntidadProfesor
    {
        //Atributos
        private int idProfesor;
        private string nombreProfesor;
        private string primerApellido;
        private string segundoApellido;
        private DateTime fechaNacimiento;
        private string numeroTelefono;
        private string correElectronico;
        private string cuentaBancaria;
        private string direccionExacta;
        private string cursoCertificado;
        private DateTime horaEntrada;
        private DateTime horaSalida;
        private string estado;
        private int Borrado;
        private bool existe;
        //Constructor con parámetros


        //Constructor sin parámetros
        public EntidadProfesor()
        {
            this.idProfesor = 0;
            this.nombreProfesor = string.Empty;
            this.primerApellido = string.Empty;
            this.segundoApellido = string.Empty;
            this.fechaNacimiento = DateTime.Today;
            this.numeroTelefono = string.Empty;
            this.correElectronico = string.Empty;
            this.cuentaBancaria = string.Empty;
            this.direccionExacta = string.Empty;
            this.cursoCertificado = string.Empty;
            this.horaEntrada = DateTime.Today;
            this.horaSalida = DateTime.Today;
            this.estado = string.Empty;
            this.Borrado = 0;
            this.existe = false;
        }

        public EntidadProfesor(int idProfesor, string nombreProfesor, string primerApellido, string segundoApellido, DateTime fechaNacimiento, string numeroTelefono,
            string correElectronico, string cuentaBancaria, string direccionExacta, string cursoCertificado, DateTime horaEntrada, DateTime horaSalida, string estado, int borrado, bool existe)
        {
            this.idProfesor = idProfesor;
            this.nombreProfesor = nombreProfesor;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
            this.fechaNacimiento = fechaNacimiento;
            this.numeroTelefono = numeroTelefono;
            this.correElectronico = correElectronico;
            this.cuentaBancaria = cuentaBancaria;
            this.direccionExacta = direccionExacta;
            this.cursoCertificado = cursoCertificado;
            this.horaEntrada = horaEntrada;
            this.horaSalida = horaSalida;
            this.estado = estado;
            this.Borrado = borrado;
            this.existe = existe;
        }

        //Se crean los métodos de acceso generados automáticamente por visual studio
        public int IdProfesor { get => idProfesor; set => idProfesor = value; }
        public string NombreProfesor { get => nombreProfesor; set => nombreProfesor = value; }
        public string PrimerApellido { get => primerApellido; set => primerApellido = value; }
        public string SegundoApellido { get => segundoApellido; set => segundoApellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string NumeroTelefono { get => numeroTelefono; set => numeroTelefono = value; }
        public string CorreoElectronico { get => correElectronico; set => correElectronico = value; }
        public string CuentaBancaria { get => cuentaBancaria; set => cuentaBancaria = value; }
        public string DireccionExacta { get => direccionExacta; set => direccionExacta = value; }
        public string CursoCertificado { get => cursoCertificado; set => cursoCertificado = value; }
        public DateTime HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
        public DateTime HoraSalida { get => horaSalida; set => horaSalida = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Borrado1 { get => Borrado; set => Borrado = value; }
        public bool Existe { get => existe; set => existe = value; }

        //Creamos los métodos de acceso manualmente
        //Getter
        public int getIdProfesor() { return idProfesor; }
        public string getNombreProfesor() { return nombreProfesor; }
        public string getPrimerApellido() { return primerApellido; }
        public string getSegundoApellido() { return segundoApellido; }
        public DateTime getFechaNacimiento() { return fechaNacimiento; }
        public string getNumeroTelefonor() { return numeroTelefono; }
        public string getCorreoElectronico() { return correElectronico; }
        public string getCuentaBancaria() { return cuentaBancaria; }
        public string getDireccionExacta() { return direccionExacta; }
        public string getCursoCertificado() { return cursoCertificado; }
        public DateTime getHoraEntrada() { return horaEntrada; }
        public DateTime getHoraSalida() { return horaSalida; }
        public string getEstado() { return estado; }
        public int getBorrado1() { return Borrado; }
        //Getter
        public void setIdProfesor(int idProfesor) { this.idProfesor = idProfesor; }
        public void setNombreProfesor(string nombreProfesor) { this.nombreProfesor = nombreProfesor; }
        public void setPrimerApellido(string primerApellido) { this.primerApellido = primerApellido; }
        public void setSegundoApellido(string segundoApellido) { this.segundoApellido = segundoApellido; }
        public void setFechaNacimiento(DateTime fechaNacimiento) { this.fechaNacimiento = fechaNacimiento; }
        public void setNumeroTelefonor(string numeroTelefono) { this.numeroTelefono = numeroTelefono; }
        public void setCorreoElectronico(string correoElectronico) { this.CorreoElectronico = correoElectronico; }
        public void setCuentaBancaria(string cuentaBancaria) { this.cuentaBancaria = cuentaBancaria; }
        public void setDireccionExacta(string direccionExacta) { this.direccionExacta = direccionExacta; }
        public void setCursoCertificado(string cursoCertificado) { this.cursoCertificado = cursoCertificado; }
        public void setHoraEntrada(DateTime horaEntrada) { this.horaEntrada = horaEntrada; }
        public void setHoraSalida(DateTime horaSalida) { this.horaSalida = horaSalida; }
        public void setEstado(string estado) { this.estado = estado; }
        public void setBorrado1(int borrado1) { this.Borrado1 = borrado1; }

        //sobre escribimos el metodo generado automáticamente
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} - {4} - {5} - {6} - {7} - {8} - {9} - {10} - {11} - {12}", idProfesor, nombreProfesor,
                                  primerApellido, segundoApellido, fechaNacimiento, numeroTelefono, cuentaBancaria, direccionExacta, cursoCertificado,
                                  horaEntrada, horaSalida, estado, Borrado);
        }
    }//fin  class EntidadProfesor
}//fin namespace CapaEntidades
