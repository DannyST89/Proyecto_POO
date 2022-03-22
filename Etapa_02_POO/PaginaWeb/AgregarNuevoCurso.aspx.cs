using System;
using System.Web.UI;
using CapaEntidades;
using CapaLogica;

namespace PaginaWeb
{
    public partial class AgregarNuevoCurso : System.Web.UI.Page
    {
       
        //Cuando se carga la página necesitamos verificar si vamos a insertar un datos o a actualizarlo
        protected void Page_Load(object sender, EventArgs e)
        {
            EntidadCurso curso;
            BLCurso logica = new BLCurso(Configuration.getConnectionString);
            int identificacion;
            try
            {
                if (!Page.IsPostBack)
                {
                    if (Session["ID_Curso"] != null)
                    {
                        identificacion = int.Parse(Session["ID_Curso"].ToString());
                        curso = logica.ObtenerCurso(identificacion);
                        
                        if (curso.Existe)
                        {
                            txtId.Text = curso.IdCurso.ToString();
                            txtNombreCurso.Text = curso.NombreCurso;
                            txtCantidadHoras.Text = curso.CantidadHoras.ToString();
                            txtPrecioHora.Text = curso.PrecioHora.ToString();
                            txtId.Visible = true;

                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "swal('Error','No se encontraron registros','warning');", true);
                        }
                    }
                    else
                    {
                        Limpiar();
                        txtId.Text = "-1";
                        txtId.Visible = false; // si actualizamos un dato, mostramos el campo de id, se vamos a crear uno nuevo no mostramos el campo id
                        lblId.Visible = false;
                    }
                }//!Page.IspostBack
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "swal('Error','Lo sentimos, ha ocurrido un problema','warning');", true);
                Response.Redirect("Cursos.aspx");
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            EntidadCurso curso;
            BLCurso logica = new BLCurso(Configuration.getConnectionString);
            int resultado = 0;
            try
            {
                curso = GenerarEntidadCurso();
                //si el cliente ya existe se modifica
                if (curso.Existe)
                {
                    resultado = logica.ActualizarCurso(curso);
                }
                //si no existe
                else
                {
                    if (!string.IsNullOrEmpty(txtNombreCurso.Text))
                    {
                        resultado = logica.InsertarCursos(curso);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "swal('Excelente','Insertado correctamente','success');", true);
                        resultado = -1;
                    }
                }
                if (resultado > 0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "swal('Excelente','Actualizado correctamente','success');", true);
                    Response.Redirect("Cursos.aspx");
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "swal('Error','No se pudo realizar la operación','warning');", true);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
                
        

        //***********************************
        //Generamos una entidad
        private EntidadCurso GenerarEntidadCurso()
        {
            EntidadCurso curso = new EntidadCurso();

            // Si hay algo en la variable de sesión
            if (Session["ID_Curso"] != null)
            {
                curso.IdCurso = int.Parse(Session["ID_Curso"].ToString());
                curso.Existe = true;
            }
            // Si no hay nada en la variable de sesión, es un cliente nuevo
            else
            {
                curso.IdCurso = -1;
                curso.Existe = false;
            }

            // los demás datos siempre se toman de los cuadros de texto:
            curso.NombreCurso = txtNombreCurso.Text;
            curso.CantidadHoras = Convert.ToInt32(txtCantidadHoras.Text);
            curso.PrecioHora = Convert.ToInt32(txtPrecioHora.Text);

            return curso;
        }//GenerarEntidadCliente
        //Limpiar formulario
        public void Limpiar()
        {
            txtNombreCurso.Text = string.Empty;
            txtCantidadHoras.Text = string.Empty;
            txtPrecioHora.Text = string.Empty;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cursos.aspx");
           
        }
    }//fin class AgregarNuevoCurso : System.Web.UI.Page
}//fin namespace PaginaWeb