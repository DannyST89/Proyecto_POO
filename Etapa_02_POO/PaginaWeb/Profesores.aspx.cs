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
    public partial class Profesores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarListaDataSet();
            }
            
        }
        //traemos los datos de la tabla profesor para cargarlos en el gridview
        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLProfesor logica = new BLProfesor(Configuration.getConnectionString);
            DataSet dsProfesor;

            try
            {
                dsProfesor = logica.ListarProfesores(condicion, orden);// Este listar cliente es de la capa logica
                grdProfesores.DataSource = dsProfesor;
                grdProfesores.DataMember = dsProfesor.Tables["Profesores"].TableName;
                grdProfesores.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }

      //Agregamos un nuevo profesor
      //para eso redireccionamos la pagina profesor hacia agregarnuevoprofesor

        protected void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            Session.Remove("ID_Profesor");
            Response.Redirect("AgregarNuevoProfesor.aspx");
        }
        //Actualizamos los profesores
        protected void btnActualizar_Command(object sender, CommandEventArgs e)
        {
            Session["ID_Profesor"] = e.CommandArgument.ToString();
            Response.Redirect("AgregarNuevoProfesor.aspx");
        }

        protected void grdProfesores_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdProfesores.PageIndex = e.NewPageIndex;
            CargarListaDataSet();
        }
        //Eliminar un profesor
        protected void btnEliminar_Command(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            BLProfesor logica = new BLProfesor(Configuration.getConnectionString);
            EntidadProfesor profesor = new EntidadProfesor();
            try
            {
                profesor = logica.ObtenerProfesor(id);
                if (profesor.Existe)
                {
                    if (logica.EliminarProfesor(profesor) > 0)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "swal('Excelente','Eliminado correctamente','success');", true);

                        CargarListaDataSet();

                    }
                   
                }
            }
            catch (Exception)            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "swal('Error','Se ha producido un error','warning');", true);
            }
        }
    }//fin class Profesores : System.Web.UI.Page
}//fin namespace PaginaWeb