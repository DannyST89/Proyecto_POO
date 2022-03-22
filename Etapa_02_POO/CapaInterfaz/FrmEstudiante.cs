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
    public partial class FrmEstudiante : Form
    {
        EntidadEstudiante estudianteRegistrado;
        public FrmEstudiante()
        {
            InitializeComponent();
        }

        private void FrmEstudiante_Load(object sender, EventArgs e)
        {
            CargarListaDataSet();
        }
        //***********************************************************
        //PRIMERA PARTE
        //para insertar estudiante
        private EntidadEstudiante GenerarEntidad()
        {
            EntidadEstudiante estudiante = new EntidadEstudiante();

            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                estudiante = estudianteRegistrado; // ****** Indispensable para poder actualizar un estudiante ******
            }
            estudiante.Nombre_Est = txtNombreEstudiante.Text;
            estudiante.PrimerApellido = txtPrimerApellido.Text;
            estudiante.SegundoApellido = txtSegundoApellido.Text;
            estudiante.FechaNacimiento = (Convert.ToDateTime(dtpFechaNacimiento.Value.Date.ToString("dd-MM-yyyy")));
            estudiante.NumeroTelefono = txtTelefono.Text;
            estudiante.CorreoElectronico = txtCorreo.Text;
            estudiante.Direccion = txtDireccion.Text;
            //estudiante.Estado = cmbElegirEstado.Text;

            return estudiante;

        }
        //**********************************
        //Botón para guardar estudiante

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BLEstudiante logica = new BLEstudiante(Configuracion.getConnectionString);
            EntidadEstudiante estudiante;
            int resultado;
            try
            {
                if (!string.IsNullOrEmpty(txtNombreEstudiante.Text) &&
                    !string.IsNullOrEmpty(txtPrimerApellido.Text) &&
                    !string.IsNullOrEmpty(txtSegundoApellido.Text) &&
                    !string.IsNullOrEmpty(dtpFechaNacimiento.Text) &&
                    !string.IsNullOrEmpty(txtTelefono.Text) &&
                    !string.IsNullOrEmpty(txtCorreo.Text) &&
                    !string.IsNullOrEmpty(txtDireccion.Text))
                    //!string.IsNullOrEmpty(cmbElegirEstado.Text))
                {
                    estudiante = GenerarEntidad();
                    resultado = logica.InsertarEstudiante(estudiante);
                    CargarListaDataSet();
                    LimpiarFormulario();
                    MessageBox.Show("El estudiante se ha registrado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Debe completar todos los datos del registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //***********************************************************
        //SEGUNDA PARTE
        //Lista cargamos la lista dataset
        private void CargarListaDataSet(string condicion = "", string orden = "") // tenemos que llamar la funcion en Load del formulario
            //Tambien lo llamamos en el butón guardar, para que refresque cada vez que se inserta un estudiante
        {
            BLEstudiante logica = new BLEstudiante(Configuracion.getConnectionString);
            DataSet datosProfesores;
            try
            {
                datosProfesores = logica.ListarEstudiantes(condicion, orden);
                grdListaMuestraEstudiantes.DataSource = datosProfesores;
                grdListaMuestraEstudiantes.DataMember = datosProfesores.Tables["Estudiantes"].TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }// Fin CargarListaDataSet
         //****************************************************
         //TERCERA PARTE
         //Recibimos el método obtenerestudiante
         private void ObtenerEstudiante(int id)
        {
            EntidadEstudiante estudiante = new EntidadEstudiante();
            BLEstudiante traerEstudiante = new BLEstudiante(Configuracion.getConnectionString);
            try
            {
                estudiante = traerEstudiante.ObtenerEstudiantes(id);
                if (estudiante != null)
                {
                    txtCodigo.Text = estudiante.Id_Estudiante.ToString();
                    txtNombreEstudiante.Text = estudiante.Nombre_Est;
                    txtPrimerApellido.Text = estudiante.PrimerApellido;
                    txtSegundoApellido.Text = estudiante.SegundoApellido;
                    dtpFechaNacimiento.Text = estudiante.FechaNacimiento.ToString();
                    txtTelefono.Text = estudiante.NumeroTelefono;
                    txtCorreo.Text = estudiante.CorreoElectronico;
                    txtDireccion.Text = estudiante.Direccion;
                    //cmbElegirEstado.Text = estudiante.Estado;

                    //Variable global inicializada
                    estudianteRegistrado = estudiante;
                }
                else
                {
                    MessageBox.Show("El estudiante no está registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //llamamos a obtener estudiante
        private void grdListaMuestraEstudiantes_Click(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                //recuperamos el id 
                id = (int)grdListaMuestraEstudiantes.SelectedRows[0].Cells[0].Value;
                ObtenerEstudiante(id);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//Fin grdListaMuestraEstudiantes_Click
        //Necesitamos limpiar el formulario cada vez que se agrega un dato o se modifica
        public void LimpiarFormulario()
        {
            txtCodigo.Text = string.Empty;
            txtNombreEstudiante.Text = string.Empty;
            txtPrimerApellido.Text = string.Empty;
            txtSegundoApellido.Text = string.Empty;
            dtpFechaNacimiento.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            //cmbElegirCursoCertificado.Text = string.Empty;
            txtNombreEstudiante.Focus();

        }
        //***********************************************************
        //CUARTA PARTE
        //Botón para eliminar estudiante
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EntidadEstudiante estudiante;
            int affectedRow;
            BLEstudiante logica = new BLEstudiante(Configuracion.getConnectionString);
            try
            {
                estudiante = logica.ObtenerEstudiantes(int.Parse(txtCodigo.Text));
                if (!string.IsNullOrEmpty(txtCodigo.Text))
                {
                    if (estudiante != null)
                    {                        
                        affectedRow = logica.EliminarEstudiante(estudiante);
                        MessageBox.Show("Estudiante eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarFormulario();
                        CargarListaDataSet();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error al eliminar el estudiante", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarFormulario();
                        CargarListaDataSet();
                    }
                   
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }
        //**********************************************************************
        //QUINTA PARTE
        //Actualizar un Estudiante
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            BLEstudiante logica = new BLEstudiante(Configuracion.getConnectionString);
            EntidadEstudiante estudiante;

            int affectedRow;

            try
            {
                if (!string.IsNullOrEmpty(txtNombreEstudiante.Text) &&
                    !string.IsNullOrEmpty(txtPrimerApellido.Text) &&
                    !string.IsNullOrEmpty(txtSegundoApellido.Text) &&
                    !string.IsNullOrEmpty(dtpFechaNacimiento.Text) &&
                    !string.IsNullOrEmpty(txtTelefono.Text) &&
                    !string.IsNullOrEmpty(txtCorreo.Text) &&
                    !string.IsNullOrEmpty(txtDireccion.Text))
                    //!string.IsNullOrEmpty(cmbElegirEstado.Text))
                {
                    estudiante = GenerarEntidad();
                    affectedRow = logica.ActualizarEstudiante(estudiante);
                    LimpiarFormulario();
                    CargarListaDataSet();
                    MessageBox.Show("Actualizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Complete los datos del registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }//Fin class FrmEstudiante : Form
}//Fin namespace CapaInterfaz
