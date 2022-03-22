using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using CapaEntidades;
using CapaLogica;

namespace CapaInterfaz
{
    public partial class FrmAdminProfesor : Form
    {

        //Creamos un evento EventHandler para enviar valores

        //creamos la variable global para actualizar cliente

        EntidadProfesor clienteRegistrado;

        public FrmAdminProfesor()
        {
            InitializeComponent();
            AutoCompletado();
            CargarCmbCursoCertificado();

        }
        //***********************************************************
        //PRIMERA PARTE
        //para insertar profesor
        //para obtener los datos del formulario 
        //Generar entidad para crear la información
        private EntidadProfesor GenerarEntidad()
        {
            EntidadProfesor profesor = new EntidadProfesor(); // instanciamos objeto de tipo entidadProfesor

            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                profesor = clienteRegistrado;
            }

            profesor.setNombreProfesor(txtNombre.Text);
            profesor.setPrimerApellido(txtPrimerApellido.Text);
            profesor.setSegundoApellido(txtSegundoApellido.Text);
            //Utilizamos el formato dateTime para optener la fecha 
            profesor.setFechaNacimiento(Convert.ToDateTime(dtpFechaNacimiento.Value.Date.ToString("dd-MM-yyyy")));
            profesor.setNumeroTelefonor(txtTelefono.Text);
            profesor.setCorreoElectronico(txtCorreo.Text);
            profesor.setCuentaBancaria(txtCuentaBancaria.Text);
            profesor.setDireccionExacta(txtDireccion.Text);
            profesor.setCursoCertificado(cmbCursoCertificado.Text);
            //por medio del datetimepicker obtenemos la hora precisa
            profesor.setHoraEntrada(Convert.ToDateTime(dtpHoraEntrada.Value.ToString()));
            profesor.setHoraSalida(Convert.ToDateTime(dtpHoraSalida.Value.ToString()));
            profesor.setEstado(cmbElegirEstadoProf.Text);
            profesor.setBorrado1(Convert.ToInt32(cmbBorradoProf.Text));

            return profesor;
        }//Fin GenerarCliente

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            BLProfesor logica = new BLProfesor(Configuracion.getConnectionString);
            EntidadProfesor profesor;
            int resultado;
            try
            {
                if (!string.IsNullOrEmpty(txtNombre.Text) &&
                    !string.IsNullOrEmpty(txtPrimerApellido.Text) &&
                    !string.IsNullOrEmpty(txtSegundoApellido.Text) &&
                    !string.IsNullOrEmpty(dtpFechaNacimiento.Text) &&
                    !string.IsNullOrEmpty(txtTelefono.Text) &&
                    !string.IsNullOrEmpty(txtCorreo.Text) &&
                    !string.IsNullOrEmpty(txtCuentaBancaria.Text) &&
                    !string.IsNullOrEmpty(txtDireccion.Text) &&
                    !string.IsNullOrEmpty(cmbCursoCertificado.Text) &&
                    !string.IsNullOrEmpty(dtpHoraEntrada.Text) &&
                    !string.IsNullOrEmpty(dtpHoraSalida.Text) &&
                    !string.IsNullOrEmpty(cmbElegirEstadoProf.Text) &&
                    !string.IsNullOrEmpty(cmbBorradoProf.Text))
                {
                    profesor = GenerarEntidad();

                    resultado = logica.InsertarDatosBD(profesor);
                    LimpiarFormulario();
                    CargarListaDataSet();
                    MessageBox.Show("El dato se ha registrado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }//Fin botón guardar

        // creamos el botón para limpiar el formulario adminDatosProfesores
        public void LimpiarFormulario()
        {
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtPrimerApellido.Text = string.Empty;
            txtSegundoApellido.Text = string.Empty;
            dtpFechaNacimiento.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtCuentaBancaria.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            //cmbElegirCursoCertificado.Text = string.Empty;
            dtpHoraEntrada.Text = string.Empty;
            dtpHoraSalida.Text = string.Empty;
            //cmbElegirEstadoProf.Text = string.Empty;
            //cmbBorradoProf.Text = string.Empty;
            txtNombre.Focus();

        }

        //Creamos el método para cargar los datos que tiene el dataset en el dataGridView

        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLProfesor logica = new BLProfesor(Configuracion.getConnectionString);

            DataSet DatosProfesores;

            try
            {
                DatosProfesores = logica.ListarProfesores(condicion, orden);
                grdListaMuestraProfesores.DataSource = DatosProfesores;
                grdListaMuestraProfesores.DataMember = DatosProfesores.Tables["Profesores"].TableName;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Carga del formulario para administrar datos del profesor
        private void FrmAdminProfesor_Load(object sender, EventArgs e)
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
        //Botón para buscar cliente
        //****************************************************
        //TERCERA PARTE
        private void btnBuscarProfesor_Click(object sender, EventArgs e)
        {
            string condicion = string.Empty;

            try
            {
                if (!string.IsNullOrEmpty(txtBuscarCliente.Text))
                {
                    condicion = string.Format("Nombre_Profesor like '%{0}%'", txtBuscarCliente.Text).Trim();//trim se usa para quitar espacios                    
                }
                else
                {
                    MessageBox.Show("Ingrese un nombre para buscar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBuscarCliente.Focus();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CargarListaDataSet(condicion);
            txtBuscarCliente.Focus();
        }//Fin btnBuscar

        //Seleccionar cliente en el DataGridView
        private void grdListaMuestraProfesores_Click(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                //recuperamos el id 
                id = (int)grdListaMuestraProfesores.SelectedRows[0].Cells[0].Value;
                CargarProfesor(id);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//Fin grdListaMuestraProfesores_Click

        //recibimos el método obtenerProfesor
        private void CargarProfesor(int id)
        {
            EntidadProfesor profesor = new EntidadProfesor();
            BLProfesor traerProfesor = new BLProfesor(Configuracion.getConnectionString);

            try
            {
                profesor = traerProfesor.ObtenerProfesor(id);
                if (profesor != null)
                {
                    txtCodigo.Text = profesor.IdProfesor.ToString();
                    txtNombre.Text = profesor.NombreProfesor;
                    txtPrimerApellido.Text = profesor.PrimerApellido;
                    txtSegundoApellido.Text = profesor.SegundoApellido;
                    txtTelefono.Text = profesor.NumeroTelefono;
                    txtCorreo.Text = profesor.CorreoElectronico;
                    txtCuentaBancaria.Text = profesor.CuentaBancaria;
                    txtDireccion.Text = profesor.DireccionExacta;

                    //Se asigna la entidad profesor local a la variable global
                    clienteRegistrado = profesor;
                }
                else
                {
                    MessageBox.Show("El profesor no está registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //*****************************************************
        // creamos el código para eliminar un profesor
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EntidadProfesor profesor;
            int resultado;
            BLProfesor logica = new BLProfesor(Configuracion.getConnectionString);
            try
            {
                if (!string.IsNullOrEmpty(txtCodigo.Text))
                {
                    //verificamos si el profesor existe
                    profesor = logica.ObtenerProfesor(int.Parse(txtCodigo.Text));
                    if (profesor != null)
                    {
                        resultado = logica.EliminarProfesor(profesor);
                        MessageBox.Show(logica.Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarFormulario();
                        CargarListaDataSet();
                    }
                    else
                    {
                        MessageBox.Show("El profesor no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un profesor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//Fin btnEliminar_Click

        //No borrar este método
        private void grdListaMuestraProfesores_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            BLProfesor logica = new BLProfesor(Configuracion.getConnectionString);
            EntidadProfesor profesor;
            int resultado;
            try
            {
                if (!string.IsNullOrEmpty(txtNombre.Text) &&
                    !string.IsNullOrEmpty(txtPrimerApellido.Text) &&
                    !string.IsNullOrEmpty(txtSegundoApellido.Text) &&
                    !string.IsNullOrEmpty(dtpFechaNacimiento.Text) &&
                    !string.IsNullOrEmpty(txtTelefono.Text) &&
                    !string.IsNullOrEmpty(txtCorreo.Text) &&
                    !string.IsNullOrEmpty(txtCuentaBancaria.Text) &&
                    !string.IsNullOrEmpty(txtDireccion.Text) &&
                    !string.IsNullOrEmpty(cmbCursoCertificado.Text) &&
                    !string.IsNullOrEmpty(dtpHoraEntrada.Text) &&
                    !string.IsNullOrEmpty(dtpHoraSalida.Text) &&
                    !string.IsNullOrEmpty(cmbElegirEstadoProf.Text) &&
                    !string.IsNullOrEmpty(cmbBorradoProf.Text))
                {
                    profesor = GenerarEntidad();

                    resultado = logica.ActualizarProfesor(profesor);
                    LimpiarFormulario();
                    CargarListaDataSet();
                    MessageBox.Show("El dato se ha actualizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        //Con este método hacemos un auto completado cuando buscamos un profesor
        private void AutoCompletado()
        {
            SqlConnection conexion = new SqlConnection(Configuracion.getConnectionString);
            DataTable datos = new DataTable();
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Nombre_Profesor FROM Profesores", conexion);
            adapter.Fill(datos);

            for (int i = 0; i < datos.Rows.Count; i++)
            {
                lista.Add(datos.Rows[i]["Nombre_Profesor"].ToString());
            }
            txtBuscarCliente.AutoCompleteCustomSource = lista;
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {

        }

        //Cargar los datos del combobox curso matriculado llamando los datos de la tabla Cursos
        public void CargarCmbCursoCertificado()
        {
            SqlConnection conexion = new SqlConnection(Configuracion.getConnectionString);
            SqlCommand cmd = new SqlCommand();
            DataTable table = new DataTable();
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Cursos"; // pasamos el resultado de la consulta a cmd

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);// hacemos una instancia con el valor cmd
            adapter.Fill(table);//llenamos el objeto table
           
            //llamamos al combo box
            cmbCursoCertificado.DataSource = table; // pasamos el valor de table a cmbcursoMatriculado
            cmbCursoCertificado.DisplayMember = "Cursos";
            cmbCursoCertificado.ValueMember = "Nombre_Curso";

        }// fin class FrmAdminProfesor : Form

    }// fin namespace
}