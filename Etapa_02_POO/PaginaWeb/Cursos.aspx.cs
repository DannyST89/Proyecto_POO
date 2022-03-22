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
    public partial class Cursos : System.Web.UI.Page
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
            BLCurso logica = new BLCurso(Configuration.getConnectionString);
            DataSet dsCursos;

            try
            {
                dsCursos = logica.ListarCursos(condicion, orden);// Este listar cliente es de la capa logica
                grdCursos.DataSource = dsCursos;
                grdCursos.DataMember = dsCursos.Tables["Cursos"].TableName;
                grdCursos.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }
        //Llamamos el nuevo formulario para agregar o modificar un curso


        protected void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            Session.Remove("ID_Curso");
            Response.Redirect("AgregarNuevoCurso.aspx");
        }

        protected void btnEliminar_Command(object sender, CommandEventArgs e)
        {
            //Leer el id que envía el commandArgument
            int id = int.Parse(e.CommandArgument.ToString());
            BLCurso logica = new BLCurso(Configuration.getConnectionString);
            EntidadCurso curso = new EntidadCurso();
            try
            {
                curso = logica.ObtenerCurso(id);
                if (curso.Existe)
                {
                    if (logica.EliminarCurso(curso) > 0)
                    {
                        mensajeScript = string.Format("javascript:mostrarMensaje('Curso eliminado correctamente')");
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                        CargarListaDataSet();
                        
                    }
                    else
                    {
                        //El cliente existe pero no se puede eliminar proque tiene reservaciones
                        mensajeScript = string.Format("javascript:mostrarMensaje('{0}')",logica.Mensaje);
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                    }

                }
            }
            catch (Exception)
            {
                //mensajeScript = string.Format("javascript:mostrarMensaje('{0}')",ex.Message);
                mensajeScript = "No se puede eliminar";
                mensajeScript = string.Format("javascript:mostrarMensaje('{0}')", mensajeScript);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
            }
        }
        //
        protected void btnActualizar_Command(object sender, CommandEventArgs e)
        {
            Session["ID_Curso"] = e.CommandArgument.ToString();
            Response.Redirect("AgregarNuevoCurso.aspx"); //llamamos al formulario para modificar que es otra página
        }
        //Seleccionar varias página en el gridView
       

        protected void grdCursos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdCursos.PageIndex = e.NewPageIndex;
            CargarListaDataSet();
        }
    }//fin class Cursos : System.Web.UI.Page
}//fin namespace PaginaWeb