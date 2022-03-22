using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CapaInterfaz
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }
        //Abrimos el formulario para administrar profesor
        private void TSMadmimistrarProfesor_Click(object sender, EventArgs e)
        {
            // creamos un objeto de tipo FrmAdminProfesor para abrir ese formulario en el menú principal
            Form openAdminProfesor = new FrmAdminProfesor();
            agregarFormulario(openAdminProfesor);// llamo el método que agrega el formulario en el panel principal
            openAdminProfesor.Dock = DockStyle.Fill; // rellena del panel principal
            openAdminProfesor.Show();
        }
        
        //llamado del formulario Administrar cursos
        private void AdministrarCursostoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form abrirAdminCursos = new FrmAdminCurso();
            agregarFormulario(abrirAdminCursos);// llamo el método que agrega el formulario en el panel principal
            abrirAdminCursos.Dock = DockStyle.Fill;
            abrirAdminCursos.Show();
        }
        //método para agregar un formulario al panel principal del menu principal
        public void agregarFormulario(Form formulario)
        {
            if (this.panelMenuPrincipal.Controls.Count > 0) // si en el panel hay algo abierto se cierra
            {
                this.panelMenuPrincipal.Controls.RemoveAt(0);
            }
            formulario.TopLevel = false; // esto hace que el formulario no se salga del formulario menú
            this.panelMenuPrincipal.Controls.Add(formulario); // lo agrega como un control en el panel
            formulario.Show();
        }
        //abrimos el formulario de matricula en el formulario principal
        private void crearMatrículaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form openAdminMatricula = new FrmCrearMatricula();
            agregarFormulario(openAdminMatricula);// llamo el método que agrega el formulario en el panel principal
            openAdminMatricula.Dock = DockStyle.Fill; // rellena del panel principal
            openAdminMatricula.Show();
        }

        private void administrarEstudinatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form openAdminEstudiante = new FrmEstudiante();
            agregarFormulario(openAdminEstudiante);// llamo el método que agrega el formulario en el panel principal
            openAdminEstudiante.Dock = DockStyle.Fill; // rellena del panel principal
            openAdminEstudiante.Show();
        }

        private void panelMenuPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }//Fin FrmMenuPrincipal
    
}//fin namespace
