using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaEntidades;
using CapaLogica;

namespace CapaInterfaz
{
    public partial class FrmPagos : Form
    {
        EntidadPagos pagoRegistrado;
        FrmBuscarMatricula formularioBuscar;
        public FrmPagos()
        {
            InitializeComponent();
        }

        private void FrmPagos_Load(object sender, EventArgs e)
        {
            try
            {
                CargarListaDataSet();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //***********************************************************
        private EntidadPagos GenerarEntidad()
        {
            EntidadPagos pagos = new EntidadPagos(); // instanciamos objeto de tipo entidadProfesor

            if (!string.IsNullOrEmpty(txtIdMatricula.Text))
            {
                pagos = pagoRegistrado;
            }
            else
            {
                pagos = new EntidadPagos();
            }
            pagos. IdMatricula = (Convert.ToInt32(txtIdMatricula.Text));
            pagos.IdEstudiante = (Convert.ToInt32(txtCodigoEstudiante.Text));
            pagos.MontoAPagar = (Convert.ToDecimal(txtMontoPagar.Text));
            pagos.CursoMatriculado = txtCursoMatriculado.Text;
            pagos.FechaPago = Convert.ToDateTime(dtpFechaPagos.Text);
            pagos.EstadoPago = txtEstadoPago.Text;
            return pagos;

        }//Fin GenerarCliente

        private void btnHacerPago_Click(object sender, EventArgs e)
        {
            BLPagos logica = new BLPagos(Configuracion.getConnectionString);
            EntidadPagos pagos;
            int resultado;
            try
            {
                if (!string.IsNullOrEmpty(txtCursoMatriculado.Text) &&
                    !string.IsNullOrEmpty(txtCodigoEstudiante.Text) &&
                    !string.IsNullOrEmpty(txtCursoMatriculado.Text) &&
                    !string.IsNullOrEmpty(txtEstadoPago.Text) &&
                    !string.IsNullOrEmpty(dtpFechaPagos.Text) &&
                    !string.IsNullOrEmpty(txtMontoPagar.Text))
                {
                    pagos = GenerarEntidad();
                    resultado = logica.InsertarPago(pagos);
                    LimpiarFormulario();
                    MessageBox.Show("El pago se ha realizado con exito","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ingrese el monto a pagar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//Fin insertar un pago
        //*************************************************************
        //Creamos el método para limpiar el formulario
        private void LimpiarFormulario()
        {
            txtCursoMatriculado.Text = string.Empty;
            txtCodigoEstudiante.Text = string.Empty;
            txtCursoMatriculado.Text = string.Empty;
            txtEstadoPago.Text = string.Empty;
            txtMontoPagar.Text = string.Empty;
            txtPagoIngresado.Text = string.Empty;
        }
        //*******************************************
        //CArgar lista data set
     

        private void btnBuscarMatricula_Click(object sender, EventArgs e)
        {
            formularioBuscar= new FrmBuscarMatricula();
            formularioBuscar.Aceptar += new EventHandler(Aceptar);
            formularioBuscar.ShowDialog();
        }
        //**********************************
        private void Aceptar(object id, EventArgs e)
        {
            try
            {
                int idMatricula = (int)id;
                if (idMatricula != -1)
                {
                    CargarMatricula(idMatricula);
                }
                else
                {
                    LimpiarFormulario();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //********************************************
        private void CargarMatricula(int id)
        {
            EntidadMatricula matricula = new EntidadMatricula();
            BLMatricula traerMatricula = new BLMatricula(Configuracion.getConnectionString);
            try
            {
                matricula = traerMatricula.ObtenerMatricula(id);
                if (matricula != null)
                {
                    txtIdMatricula.Text = matricula.IdMatricula.ToString();
                    txtCodigoEstudiante.Text = matricula.IdEstudiante.ToString();
                    txtCursoMatriculado.Text = matricula.Curso_Matriculado;
                    txtHorasCurso.Text = matricula.Total_Horas_Clases.ToString();
                }
                else
                {
                    MessageBox.Show("Matrícula sin registros", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //*********************************************
        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLMatricula logica = new BLMatricula(Configuracion.getConnectionString);
            DataSet datosMatricula;

            try
            {
                datosMatricula = logica.ListarMatriculas(condicion, orden);


            }
            catch (Exception)
            {

                throw;
            }
        }
    }// Fin Clase principal
}//Fin namespace
