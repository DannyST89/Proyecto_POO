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
    public partial class FrmBuscarMatricula : Form
    {
        public event EventHandler Aceptar;
        int vgn_id_matricula;
        public FrmBuscarMatricula()
        {
            InitializeComponent();
        }

        private void FrmBuscarMatricula_Load(object sender, EventArgs e)
        {
            try
            {
                CargarListaDataSet();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLMatricula logica = new BLMatricula(Configuracion.getConnectionString);
            DataSet datosMatricula;

            try
            {
                datosMatricula = logica.ListarMatriculas(condicion, orden);
                grdListarMatriculas.DataSource = datosMatricula;
                grdListarMatriculas.DataMember = datosMatricula.Tables["Matriculas"].TableName;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnBuscarMatricula_Click(object sender, EventArgs e)
        {
            string condicion = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(txtBuscarMatricula.Text))
                {
                    condicion = string.Format("Matricula like '%{0}%'", txtBuscarMatricula.Text).Trim();
                }
                else
                {
                    MessageBox.Show("Ingrese la matrícula", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBuscarMatricula.Focus();
                }
                CargarListaDataSet();
                txtBuscarMatricula.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //************************************
        private void Seleccionar() {
            {
                if (grdListarMatriculas.SelectedRows.Count > 0)
                {
                    vgn_id_matricula = (int)grdListarMatriculas.SelectedRows[0].Cells[0].Value;
                    Aceptar(vgn_id_matricula, null);
                    Close();
                }
            } }

        private void grdListarMatriculas_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Aceptar(-1, null);
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }
    }//Fin man class
}//Fin namespace
