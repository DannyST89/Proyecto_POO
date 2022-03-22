using System;
using System.Data.SqlClient;
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
    public partial class FrmAdminCurso : Form
    {
        EntidadCurso cursoRegistrado;

        public FrmAdminCurso()
        {
            InitializeComponent();
        }
        //Creamos una instancia para obtener los datos del formulario
        private EntidadCurso GenerarEntidad()
        {
            EntidadCurso curso = new EntidadCurso(); // instanciamos objeto de tipo entidadProfesor

            if (!string.IsNullOrEmpty(txtCodigoCurso.Text))
            {
                curso = cursoRegistrado;
            }
            else
            {
                curso = new EntidadCurso();
            }
            curso.setNombreCurso(txtNombreCurso.Text);
            curso.setCantidadHoras(Convert.ToInt32(txtCantidadHoras.Text));
            curso.setPrecioHora(Convert.ToInt32(txtPrecioHora.Text));
            curso.setExiste(false);
            return curso;

        }//Fin GenerarCliente

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BLCurso logica = new BLCurso(Configuracion.getConnectionString);
            EntidadCurso curso;

            int resultado;

            try
            {
                if (!string.IsNullOrEmpty(txtNombreCurso.Text) &&
                    !string.IsNullOrEmpty(txtCantidadHoras.Text) &&
                    !string.IsNullOrEmpty(txtPrecioHora.Text))
                {
                    curso = GenerarEntidad();
                    resultado = logica.InsertarCursos(curso);
                    LimpiarFormulario();
                    CargarDatosDataSet();
                    MessageBox.Show("Curso agregado correctamente", "Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor ingrese los datos correspondientes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }//Fin btnGuardar

        //Creamos un método para limpiar los datos del formulario
        private void LimpiarFormulario()
        {
            txtNombreCurso.Text = string.Empty;
            txtCodigoCurso.Text = string.Empty;
            txtCantidadHoras.Text = string.Empty;
            txtPrecioHora.Text = string.Empty;
            //cmbEstado.Text = string.Empty;
        }//Fin LimpiarFormulario

        //***************************************************************
        //Aquí es donde cargamos todos los datos obtenido mediante el dataset y los mostramos en el dataGridView
        private void CargarDatosDataSet(string condicion = "", string orden = "")
        {
            BLCurso logica = new BLCurso(Configuracion.getConnectionString);
            DataSet DatosCursos;

            try
            {
                DatosCursos = logica.MostrarCursosEnDataGridView(condicion, orden);
                gdrAdminCursos.DataSource = DatosCursos;
                gdrAdminCursos.DataMember = DatosCursos.Tables["Cursos"].TableName; //este es el nombre de la tabla que creamos con el dataset
            }
            catch (Exception)
            {

                MessageBox.Show("No se ha cargado la información", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//Fin MostrarCursosEnDataGridView

        private void FrmAdminCurso_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatosDataSet();                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//Fin FrmAdminCurso_Load

        private void gdrAdminCursos_Click(object sender, EventArgs e)
        {
            int id = 0;
            try
            {//obtenemos el id de la lista del datagridview
                id = (int)gdrAdminCursos.SelectedRows[0].Cells[0].Value;
                CargarCurso(id);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }// fin gdrAdminCursos_Click
        //*********************************************
        //Eliminamos cursos
        private void btnEliminarCurso_Click(object sender, EventArgs e)
        {
            EntidadCurso curso;
            int resultado;
            BLCurso logica = new BLCurso(Configuracion.getConnectionString);
            try
            {
                if (!string.IsNullOrEmpty(txtCodigoCurso.Text))
                {
                    curso = logica.ObtenerCurso(int.Parse(txtCodigoCurso.Text));
                    if (curso != null)
                    {
                        resultado = logica.EliminarCurso(curso);
                        MessageBox.Show("El curso se ha eliminado","Aviso",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarFormulario();
                        CargarDatosDataSet();
                    }
                    else
                    {
                        MessageBox.Show("El curso no esta registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LimpiarFormulario();
                        CargarDatosDataSet();
                    }
                }
                else
                {
                    MessageBox.Show("Debe selecionar un curso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//Fin btnEliminarCurso_Click
         //recibimos el metodo Obtener curso
        private void CargarCurso(int id)
        {
            EntidadCurso curso = new EntidadCurso();
            BLCurso traerCurso = new BLCurso(Configuracion.getConnectionString);

            try
            {
               curso = traerCurso.ObtenerCurso(id);
                if  (curso != null)
                {
                    txtCodigoCurso.Text = curso.IdCurso.ToString();
                    txtNombreCurso.Text = curso.NombreCurso;
                    txtCantidadHoras.Text = curso.CantidadHoras.ToString();
                    txtPrecioHora.Text = curso.PrecioHora.ToString();


                    //Se asigna la entidad profesor local a la variable global
                    cursoRegistrado = curso;
                }
                else
                {
                    MessageBox.Show("El curso no está registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            BLCurso logica = new BLCurso(Configuracion.getConnectionString);
            EntidadCurso curso;
            int resultado;
            try
            {
                if (!string.IsNullOrEmpty(txtNombreCurso.Text) &&
                    !string.IsNullOrEmpty(txtCantidadHoras.Text) &&
                    !string.IsNullOrEmpty(txtPrecioHora.Text))
                {
                    curso = GenerarEntidad();
                    if (!curso.Existe)
                    {
                        resultado = logica.ActualizarCurso(curso);
                    }
                    else
                    {
                        resultado = logica.InsertarCursos(curso);
                    }
                    if (resultado > 0)
                    {
                        LimpiarFormulario();
                        CargarDatosDataSet();
                        MessageBox.Show("El dato se ha actualizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se ha realizado la actualización", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Debe completar todos los datos del registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }//Fin FrmAdminCurso
}//Fin namespace
