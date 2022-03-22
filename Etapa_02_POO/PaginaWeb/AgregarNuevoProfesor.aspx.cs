using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;
using CapaLogica;

namespace PaginaWeb
{
    public partial class AgregarNuevoProfesor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            EntidadProfesor profesor;
            BLProfesor logica = new BLProfesor(Configuration.getConnectionString);
            int id;
            try
            {
                if (!Page.IsPostBack)
                {
                    //txtHoraEntrada.Text = System.DateTime.Now.ToString("hh:mm:ss tt");
                    //txtHoraSalida.Text = System.DateTime.Now.ToString("hh:mm:ss tt");
                    //Cuando se carga la página, se llena el dropdownlist con los cursos
                    llenarDropDown();
                    if (Session["ID_Profesor"] != null)//cuando se da clic en actualizar se redirecciona a esta página 
                        //si la session trae el id se lo pasamos a la variable id
                    {
                        id = int.Parse(Session["ID_Profesor"].ToString());//
                        profesor = logica.ObtenerProfesor(id);//con el id de session obtenemos los datos del estudiante
                        //si el id traido es verdadero se cargan los datos en sus respectivos texboxes
                        if (profesor.Existe)
                        {
                            txtId.Text = profesor.IdProfesor.ToString();
                            txtNombreProfesor.Text = profesor.NombreProfesor;
                            txtPrimerApellido.Text = profesor.PrimerApellido;
                            txtSegundoApellido.Text = profesor.SegundoApellido;
                            txtFechaNacimiento.Text = profesor.FechaNacimiento.ToString();
                            txtTelefono.Text = profesor.NumeroTelefono;
                            txtCorreo.Text = profesor.CorreoElectronico;
                            txtCuentaBancaria.Text = profesor.CuentaBancaria;
                            txtDireccion.Text = profesor.DireccionExacta;
                            ddElegirCursoCertificado.Text = profesor.CursoCertificado;
                            txtHoraEntrada.Text = profesor.HoraEntrada.ToString();
                            txtHoraSalida.Text = profesor.HoraSalida.ToString();
                            
                            //cuando se actualiza un dato los campos del id se muestran
                            txtId.Visible = true;
                            lblId.Visible = true;
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "swal('Error','No se han cargado los datos','warning');", true);
                        }
                    }
                    else
                    {
                        LimpiarFormulario();
                        txtId.Text = "-1";
                        txtId.Visible = false;
                        lblId.Visible = false;
                    }
                }
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "swal('Error','Ha ocurrido un error');", true);

                Response.Redirect("Profesores.aspx");
            }
        }

        //Guardamos el nuevo profesor o actualizamos uno existe
        //para eso debemos verificar si el profesor que nos trae la entidad existe o no
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            EntidadProfesor profesor;
            BLProfesor logica = new BLProfesor(Configuration.getConnectionString);
            int resultado = 0;
            try
            {
                profesor = GenerarEntidadProfesor();
                //si el cliente ya existe se modifica
                if (profesor.Existe)
                {
                    resultado = logica.ActualizarProfesor(profesor);
                }
                //si no existe
                else
                {
                    //si no existe se inserta
                    if (!string.IsNullOrEmpty(txtNombreProfesor.Text))
                    {
                        resultado = logica.InsertarDatosBD(profesor);
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "swal('Excelente','El estudiante se ha ingresado correctamente','success');", true);

                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "swal('Aviso','Debe completar todos los datos','warning');", true);
                        resultado = -1;
                    }
                }
                if (resultado > 0) // si resultado es mayor a cero, quiere decir que se ha actualizado correctamente
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "swal('Excelente','Actualizado correctamente', 'success');", true);
                    Response.Redirect("Profesores.aspx");
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "swal('Error','Los sentimos, al parecer ha ocurrido un error', 'warning');", true);
                }
            }
            catch (Exception)
            {
                //throw;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "swal('Error','Lo sentimos, se ha generado un problema no controlado', 'warning');", true);
            }
        }

        //Creamos la entidad profesor
        private EntidadProfesor GenerarEntidadProfesor()
        {
            EntidadProfesor profesor = new EntidadProfesor();

            // Si hay algo en la variable de sesión
            if (Session["ID_Profesor"] != null)
            {
                profesor.IdProfesor = int.Parse(Session["ID_Profesor"].ToString());
                profesor.Existe = true;
            }
            // Si no hay nada en la variable de sesión, es un estudiante nuevo
            else
            {
                profesor.IdProfesor = -1;
                profesor.Existe = false;
            }
            //txtHoraEntrada.Text = System.DateTime.Now.ToString("hh:mm:ss tt");
            //txtHoraSalida.Text = System.DateTime.Now.ToString("hh:mm:ss tt");
            // los demás datos siempre se toman de los cuadros de texto:
            profesor.NombreProfesor = txtNombreProfesor.Text;
            profesor.PrimerApellido = txtPrimerApellido.Text;
            profesor.SegundoApellido = txtSegundoApellido.Text;
            profesor.FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
            profesor.NumeroTelefono = txtTelefono.Text;
            profesor.CorreoElectronico = txtCorreo.Text;
            profesor.CuentaBancaria = txtCuentaBancaria.Text;
            profesor.DireccionExacta = txtDireccion.Text;
            profesor.CursoCertificado = ddElegirCursoCertificado.Text;
            profesor.HoraEntrada = (Convert.ToDateTime(txtHoraEntrada.Text.ToString()));
            profesor.HoraSalida = (Convert.ToDateTime(txtHoraSalida.Text.ToString()));

            return profesor;
        }//GenerarEntidadProfesores
        //cancelamos y regresamos a la página profesores
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profesores.aspx");
        }
        //Limpiamos los formularios 
        private void LimpiarFormulario()
        {
            txtId.Text = "";
            txtNombreProfesor.Text = "";
            txtPrimerApellido.Text = "";
            txtFechaNacimiento.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtCuentaBancaria.Text = "";
            txtDireccion.Text = "";
            ddElegirCursoCertificado.Text = "";
            txtHoraEntrada.Text = "";
            txtHoraSalida.Text = "";
        }
        //*******************************************
        //Creamos un método para obtener los cursos en los que un profesor se puede certificar
        public DataSet CargarCmbCursoMatriculado(string sentenciaSql)
         {
            SqlConnection conexion = new SqlConnection(Configuration.getConnectionString);
            conexion.Open();
            SqlCommand cmd = new SqlCommand(sentenciaSql, conexion);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet datos = new DataSet();
            adapter.Fill(datos);
            conexion.Close();
            return datos;

        }
        //llenamos el dropdownlist con los cursos del instituto
        private void llenarDropDown()
        {
            ddElegirCursoCertificado.DataSource = CargarCmbCursoMatriculado("SELECT * FROM Cursos");
            ddElegirCursoCertificado.DataTextField = "Nombre_Curso";
            //ddElegirCursoCertificado.DataValueField = "ID_Curso";
            //ddCursoMatriculado.DataTextField = "ID_Curso";
            ddElegirCursoCertificado.DataBind();
            ddElegirCursoCertificado.Items.Insert(0, new ListItem("Seleccione un curso", "0"));
        }
    }//fin class AgregarNuevoProfesor : System.Web.UI.Page
}//fin namespace PaginaWeb