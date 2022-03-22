using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CapaEntidades;
using CapaLogica;

namespace PaginaWeb
{
    public partial class Matriculas : System.Web.UI.Page
    {
        string mensajeScript;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    CargarListaDataSet();
                }
            }
            catch (Exception ex)
            {
                mensajeScript = string.Format("javaScript:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
            }
        }
        //********************************************
        //Primera Parte
        //Creamos el dataset para cargar los datos de la base de datos
        private void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLMatricula logica = new BLMatricula(Configuration.getConnectionString);
            DataSet dsMatriculas;

            try
            {
                dsMatriculas = logica.ListarMatriculas(condicion, orden);// Este listar cliente es de la capa logica
                grdMatriculas.DataSource = dsMatriculas;
                grdMatriculas.DataMember = dsMatriculas.Tables["Matriculas"].TableName;
                grdMatriculas.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }
        //con este botón llamamos a otro formulario donde creamos una nueva matrícula
        protected void btnAgregarNueva_Click(object sender, EventArgs e)
        {
            Session.Remove("ID_Matricula");
            Response.Redirect("AgregarNuevaMatricula.aspx");
        }
        //Eliminamos una matrícula
        protected void btnEliminar_Command(object sender, CommandEventArgs e)
        {
            //El commandArgument que agregamos en el botón eliminar , aquí lo leemos 
            int id = int.Parse(e.CommandArgument.ToString());
            BLMatricula logica = new BLMatricula(Configuration.getConnectionString);
            EntidadMatricula matricula = new EntidadMatricula();
            try
            {
                matricula = logica.ObtenerMatricula(id);
                if (matricula.Existe)
                {
                    if (logica.EliminarMatricula(matricula) > 0)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "swal('Aviso','Matrícula eliminada correctamente', 'success');", true);
                        CargarListaDataSet();
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "swal('Error','No fue posible eliminar la matrícula', 'warning');", true);

                    }
                }
            }
            catch (Exception)
            {
                mensajeScript = "No se puede eliminar la matrícula";
                mensajeScript = string.Format("javascript:mostrarMensaje('{0}')", mensajeScript);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
            }
        }

        protected void grdMatriculas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdMatriculas.PageIndex = e.NewPageIndex;
            CargarListaDataSet();
        }
        //llamamos al formulario para actualizar las matricualas
        protected void btnActualizar_Command(object sender, CommandEventArgs e)
        {
            Session["ID_Matricula"] = e.CommandArgument.ToString();
            Response.Redirect("AgregarNuevaMatricula.aspx");
        }
    }//fin class Matriculas : System.Web.UI.Page
}//namespace PaginaWeb