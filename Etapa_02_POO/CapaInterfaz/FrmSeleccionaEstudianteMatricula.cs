using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaLogica;

namespace CapaInterfaz
{
    public partial class FrmSeleccionaEstudianteMatricula: Form
    {
        //Creamos EventHandler para enviar datos a el formulario de matricula
        public event EventHandler Aceptar;
        //Variable global
        int vgn_Id_Estudiante;
        public FrmSeleccionaEstudianteMatricula()
        {
            InitializeComponent();
        }

        private void FrmSeleccionaEstudianteMatricula_Load(object sender, EventArgs e)
        {           
            try
            {
                CargarListaDataSet();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//Fin FrmSeleccionaEstudianteMatricula_Load
        //Cargamos los estudiantes
        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLEstudiante logica = new BLEstudiante(Configuracion.getConnectionString);
            DataSet dsEstudiantes;
            try
            {
                dsEstudiantes = logica.ListarEstudiante(condicion,orden);
                grdMuestraEstudiantes.DataSource = dsEstudiantes;
                grdMuestraEstudiantes.DataMember = dsEstudiantes.Tables["Estudiantes"].TableName;
            }
            catch (Exception)
            {
                throw;
            }
        }// Fin  CargarListaDataSet

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }
        //*******************************************
        //Buscar estudainte
        //**********************************
        //Método seleccionar
        private void Seleccionar()
        {
            try
            {
                if (grdMuestraEstudiantes.SelectedRows.Count > 0)
                {
                    vgn_Id_Estudiante = (int)grdMuestraEstudiantes.SelectedRows[0].Cells[0].Value;
                    Aceptar(vgn_Id_Estudiante, null);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdMuestraEstudiantes_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Aceptar(-1, null);
            Close();
        }

        private void btnBuscarEstudiante_Click(object sender, EventArgs e)
        {
            string condicion = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(txtIdEstudiante.Text))
                {
                    condicion = string.Format("Nombre like '%{0}%'", txtIdEstudiante.Text).Trim();
                }
                else
                {
                    MessageBox.Show("Debe escribir el nombre a buscar", "Atención",
                       MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtIdEstudiante.Focus();
                }
                CargarListaDataSet();
                txtIdEstudiante.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }//Fin FrmSeleccionaEstudianteMatricula: Form
}//namespace CapaInterfaz
