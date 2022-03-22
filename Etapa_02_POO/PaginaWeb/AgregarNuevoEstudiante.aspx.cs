using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidades;
using CapaLogica;

namespace PaginaWeb
{
    public partial class AgregarNuevoEstudiante : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EntidadEstudiante estudiante;
            BLEstudiante logica = new BLEstudiante(Configuration.getConnectionString);
            int identificacion;
            try
            {
                if (!Page.IsPostBack)
                {
                    if (Session["ID_Estudiante"] != null)
                    {
                        identificacion = int.Parse(Session["ID_Estudiante"].ToString());
                        estudiante = logica.ObtenerEstudiantes(identificacion);

                        //si el estudiante existe cargamos los datos en sus respectivos texboxes
                        if (estudiante.Existe)
                        {
                            txtIdEstudiante.Text = estudiante.Id_Estudiante.ToString();
                            txtNombre.Text = estudiante.Nombre_Est;
                            txtPrimerApellido.Text = estudiante.PrimerApellido;
                            txtSegundoApellido.Text = estudiante.SegundoApellido;
                            txtFechaNacimiento.Text = estudiante.FechaNacimiento.ToString();
                            txtTelefono.Text = estudiante.NumeroTelefono;
                            txtCorreo.Text = estudiante.CorreoElectronico;
                            txtDireccion.Text = estudiante.Direccion;

                            //si el estudiante está registrado mostramos en un texbox el id del estudinte
                            txtIdEstudiante.Visible = true;

                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "swal('Error','No se han cargado los datos','warning');", true);
                        }
                    }
                    else
                    {
                        Limpiar();
                        txtIdEstudiante.Text = "-1";
                        txtIdEstudiante.Visible = false; // si actualizamos un dato, mostramos el campo de id, se vamos a crear uno nuevo no mostramos el campo id
                        lblIdEstudiante.Visible = false;
                    }
                }//!Page.IspostBack
            }
            catch (Exception )
            {
                //si por alguna razon aparece un error , se muestra el mensaje de error y se retorno a la página de llamado
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "swal('Error','Ha ocurrido un error');", true);
              
                Response.Redirect("Estudiantes.aspx");
            }
        }
        //*****************************
        //cremos un método para limpiar los formularios
        private void Limpiar()
        {
            txtIdEstudiante.Text = "";
            txtNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";
            txtFechaNacimiento.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Estudiantes.aspx");//cuando se da cliente se redirecciona al la página estudiantes
        }
        //Generramos una entidad
        private EntidadEstudiante GenerarEntidadEstudiante()
        {
            EntidadEstudiante estudiante = new EntidadEstudiante();

            // Si hay algo en la variable de sesión
            if (Session["ID_Estudiante"] != null)
            {
                estudiante.Id_Estudiante = int.Parse(Session["ID_Estudiante"].ToString());
                estudiante.Existe = true;
            }
            // Si no hay nada en la variable de sesión, es un estudiante nuevo
            else
            {
                estudiante.Id_Estudiante = -1;
                estudiante.Existe = false;
            }

            // los demás datos siempre se toman de los cuadros de texto:
            estudiante.Nombre_Est = txtNombre.Text;
            estudiante.PrimerApellido = txtPrimerApellido.Text;
            estudiante.SegundoApellido = txtSegundoApellido.Text;
            estudiante.FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
            estudiante.NumeroTelefono = txtTelefono.Text;
            estudiante.CorreoElectronico = txtCorreo.Text;
            estudiante.Direccion = txtDireccion.Text;

            return estudiante;
        }//GenerarEntidadEstudiante

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            EntidadEstudiante estudiante;
            BLEstudiante logica = new BLEstudiante(Configuration.getConnectionString);
            int resultado = 0;
            try
            {
                estudiante = GenerarEntidadEstudiante();
                //si el cliente ya existe se modifica
                if (estudiante.Existe)
                {
                    resultado = logica.ActualizarEstudiante(estudiante);
                }
                //si no existe
                else
                {
                    //si no existe se inserta
                    if (!string.IsNullOrEmpty(txtNombre.Text))
                    {
                        resultado = logica.InsertarEstudiante(estudiante);
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "swal('Excelente','El estudiante se ha ingresado correctamente','success');", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "swal('Aviso','Debe completar todos los datos','warning');", true);
                        resultado = -1;
                    }
                }
                if (resultado > 0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "swal('Excelente','Actualizado correctamente', 'success');", true);
                    Response.Redirect("Estudiantes.aspx");
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
    }//fin class agregarNuevoEstudiante
}//fin namespace