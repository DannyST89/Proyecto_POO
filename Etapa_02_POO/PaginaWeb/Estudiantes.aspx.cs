using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CapaLogica;
using CapaEntidades;

namespace PaginaWeb
{
    public partial class Estudiantes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarListaDataSet();

            }

        }
        //cargamos los datos de la tabla estudiante
        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLEstudiante logica = new BLEstudiante(Configuration.getConnectionString);
            DataSet dsEstudiante;

            try
            {
                dsEstudiante = logica.ListarEstudiantes(condicion, orden);// Este listar cliente es de la capa logica
                grdEstudiantes.DataSource = dsEstudiante;
                grdEstudiantes.DataMember = dsEstudiante.Tables["Estudiantes"].TableName;
                grdEstudiantes.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void grdEstudiantes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdEstudiantes.PageIndex = e.NewPageIndex;
            CargarListaDataSet();

        }
        //Redireccionamos la página a la de administrar los datos del estudiante
        protected void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            Session.Remove("ID_Estudiante");
            Response.Redirect("AgregarNuevoEstudiante.aspx");            

        }
        //********************************************
        //Eliminar los datos de un estudiante
        protected void btnEliminar_Command(object sender, CommandEventArgs e)
        {
            //Leer el id que envía el commandArgument
            int id = int.Parse(e.CommandArgument.ToString());
            BLEstudiante logica = new BLEstudiante(Configuration.getConnectionString);
            EntidadEstudiante estudiante = new EntidadEstudiante();
            try
            {
                estudiante = logica.ObtenerEstudiantes(id);
                if (estudiante.Existe)
                {
                    if (logica.EliminarEstudiante(estudiante) > 0)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "swal('Excelente','Eliminado correctamente','warning');", true);

                        CargarListaDataSet();

                    }
                    else
                    {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "swal('Aviso','Seleccione un estudiante','warning');", true);
                    }

                }
            }
            catch (Exception)
            {
              
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "swal('Error','Se ha producido un error','warning');", true);
            }
        }
        //********************************************
        //Actualizar los datos de un estudiante
        protected void btnActualizar_Command(object sender, CommandEventArgs e)
        {
            Session["ID_Estudiante"] = e.CommandArgument.ToString();
            Response.Redirect("AgregarNuevoEstudiante.aspx");
        }
    }//fin class Estudiantes : System.Web.UI.Page
}//fin namespace PaginaWeb