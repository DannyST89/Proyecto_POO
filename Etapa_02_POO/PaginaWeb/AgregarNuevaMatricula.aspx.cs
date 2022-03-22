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
    public partial class AgregarNuevaMatricula : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            EntidadMatricula matricula;
            BLMatricula logica = new BLMatricula(Configuration.getConnectionString);
            int id;
            try
            {
                if (!Page.IsPostBack)
                {
                    //Cuando se carga la página, se llena el dropdownlist con los cursos
                    llenarDropDown();//este es el dropdown de cursos por matricular
                    ValidarFechas();
                    CargarCmbCursoHoras();
                    //ValidarIntensidad();
                    txtId.Focus();

                    
                    if (Session["ID_Matricula"] != null)//cuando se da clic en actualizar se redirecciona a esta página 
                                                       //si la session trae el id se lo pasamos a la variable id
                    {
                        id = int.Parse(Session["ID_Matricula"].ToString());//
                        matricula = logica.ObtenerMatricula(id);//con el id de session obtenemos los datos del estudiante
                        //si el id traido es verdadero se cargan los datos en sus respectivos texboxes
                        if (matricula.Existe)
                        {
                            txtId.Text = matricula.IdEstudiante.ToString();
                            txtIdMatricula.Text = matricula.IdMatricula.ToString();
                            txtNombreEstudiante.Text = matricula.Nombre_Estudiantes;
                            txtPrimerApellido.Text = matricula.Primer_Apellido;
                            txtSegundoApellido.Text = matricula.Segundo_Apellido;
                          
                            txtTelefono.Text = matricula.Numero_Telefono;
                            txtCorreo.Text = matricula.Correo_Electronico;                            
                            txtDireccion.Text = matricula.Direccion;
                            ddCursoMatriculado.Text = matricula.Curso_Matriculado;

                            txtFechaInicio.Text = matricula.Fecha_Inicio.ToString("dd:mm:yy");                           
                            txtFechaFinal.Text = matricula.Fecha_Final.ToString("dd:mm:yy");


                            //txtFechaFinal.Text = System.DateTime.Now.ToString("dd:mm:yy");
                            //txtFechaInicio.Text = System.DateTime.Now.ToString("dd:mm:yy");


                            txtHoraSin.Text = matricula.Horas_Clase_Sincronica.ToString();
                            txtHoraAsin.Text = matricula.Horas_Clase_Asincronica.ToString();
                            txtTotalHorasClase.Text = matricula.Total_Horas_Clases.ToString();
                            txtHorasXClase.Text = matricula.Horas_Por_Dia.ToString();

                            //cuando se actualiza un dato los campos del id se muestran
                            txtIdMatricula.Visible = true;
                            lblIdMatricula.Visible = true;
                            txtId.Visible = true;
                            txtId.ReadOnly = true;
                            lblId.Text = "ID Estudiante";
                            lblId.Visible = true;
                            btnBuscarEstudiante.Visible = false;
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "swal('Error','No se han cargado los datos','warning');", true);
                        }
                    }
                    else
                    {
                        
                        //1txtId.Text = "-1";
                        txtId.Visible = true;
                        lblId.Visible = true;
                        txtIdMatricula.Visible = false;
                        lblIdMatricula.Visible = false;
                    }
                }
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "swal('Error','Ha ocurrido un error');", true);

                Response.Redirect("Matriculas.aspx");
            }

        }

        //*******************************************************************************

        //Nos conectamos a la base de datos para obtener la informacion de los cursos
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

        //llenamos el dropdownlist con los cursos existente en el instituto
        private void llenarDropDown()
        {
            ddCursoMatriculado.DataSource = CargarCmbCursoMatriculado("SELECT * FROM Cursos");
            ddCursoMatriculado.DataTextField = "Nombre_Curso";
            ddCursoMatriculado.DataBind();
            ddCursoMatriculado.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }
        //***********************************************************************************
        //*******************************************************************************
        //Cargamos los datos de un estudiante en específico para matricularlo
        //Botón para buscar estudiante con el ID ingresado
        protected void btnBuscarEstudiante_Click(object sender, EventArgs e)
        {
            //Instanciamos un objeto de tipo sqldataadapter 
            if (txtId.Text != string.Empty)
            {
                EntidadEstudiante estudiante = new EntidadEstudiante();
                SqlConnection conexion = new SqlConnection(Configuration.getConnectionString);
                SqlCommand cmd = new SqlCommand();

                SqlDataReader dataReader;
                string sentencia = string.Format("SELECT ID_Estudiante, Nombre_Est, Primer_Apellido_Est, Segundo_Apellido_Est," + // hacemos la consulta y le pasamos el id
                    "Fecha_Nacimiento, Numero_Telefonico, Correo_Electronico_Est, Direccion_Exacta, Estado_Est, Borrado_Est FROM Estudiantes WHERE ID_Estudiante  = {0}", Convert.ToInt32(txtId.Text));
                cmd.Connection = conexion;
                cmd.CommandText = sentencia;

                try
                {
                    conexion.Open();
                    dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        dataReader.Read();
                        estudiante.Id_Estudiante = dataReader.GetInt32(0);
                        estudiante.Nombre_Est = dataReader.GetString(1);
                        estudiante.PrimerApellido = dataReader.GetString(2);
                        estudiante.SegundoApellido = dataReader.GetString(3);
                        estudiante.FechaNacimiento = dataReader.GetDateTime(4);
                        estudiante.NumeroTelefono = dataReader.GetString(5);
                        estudiante.CorreoElectronico = dataReader.GetString(6);
                        estudiante.Direccion = dataReader.GetString(7);
                        estudiante.Estado = dataReader.GetString(8);
                        estudiante.Existe = true;
                    }
                    conexion.Close();
                }
                catch (Exception)
                {

                    throw;
                }
                //***********************************************************
                //Ya hecha la consulta a la base de datos, los datos traídos los mostrámos en los texboxes
                txtNombreEstudiante.Text = estudiante.Nombre_Est;
                txtPrimerApellido.Text = estudiante.PrimerApellido;
                txtSegundoApellido.Text = estudiante.SegundoApellido;
                txtTelefono.Text = estudiante.NumeroTelefono;
                txtCorreo.Text = estudiante.CorreoElectronico;
                txtDireccion.Text = estudiante.Direccion;
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "swal('Aviso','Por favor ingrese un id', 'warning');", true);
            }

        }
        
        //********************************************
        //Creamos un método para calcular la fecha final
        //Este método lo llamamos en el pageload para cargarse desde inicio
        public void ValidarFechas()
        {
                

          //Al cargarse la página se muestran las fechas
            txtFechaInicio.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txtFechaFinal.Text = DateTime.Now.ToString("yyyy-MM-dd");
            DateTime fechaInicio = DateTime.Parse(txtFechaInicio.Text);
            DateTime fechaFinal = DateTime.Parse(txtFechaFinal.Text);
                
            
        }
        //**************************************************
        //**************************************************
         //Cargamos las horas del curso seleccionado
        public void CargarCmbCursoHoras()
        {
            SqlConnection conexion = new SqlConnection(Configuration.getConnectionString);
            SqlCommand cmd = new SqlCommand();

            try
            {
                conexion.Open();
                cmd.Connection = conexion;
                //creamos una sentencia que va a llamar los datos de la tabla cursos 
                //cargamos la cantidad de horas totales dependiendo del curso seleccionado
                cmd.CommandText = "SELECT * FROM Cursos WHERE Nombre_Curso = '" + ddCursoMatriculado.Text + "'";
                SqlDataReader leer = cmd.ExecuteReader(); // leemos los datos
                if (leer.Read() == true)
                {
                    txtTotalHorasClase.Text = leer["Cantidad_Horas"].ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //**************************************
        //calculamos la intensidad con que se va a estudiar


        protected void ddIntensidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarIntensidad();
        }
        //por medio de un autopostback logramos refrescar la intensidad
        //esto si es necesario cambiarla.
        //el autopostback se habilita en el html
        public void ValidarIntensidad()
        {
            if (ddIntensidad.Text == "Bajo")
            {
                txtHorasXClase.Text = "1";
            }
            else if (ddIntensidad.Text == "Medio")
            {
                txtHorasXClase.Text = "2";
            }
            else if (ddIntensidad.Text == "Alto")
            {
                txtHorasXClase.Text = "3";
            }
            else
            {//intensiva
                txtHorasXClase.Text = "4";
            }
            //CalcularHoraASincronica();
            //CalcularHoraSincronica();

        }
        //*******************************************************************
        //Cuando se selecciona un curso, las horas totales de ese curso se cargan en el texbox total de horas del curso
        //*******************************************************************
        //HACEMOS LAS VERIFICACIONES CORRESPONDIENTES PARA SABER SI UN ESTUDIANTE YA HA MATRICULADO UN CURSO ANTERIORMENTE
        //SI ES ASÍ NO SE PERMITE LA MATRÍCULA
        protected void ddCursoMatriculado_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(Configuration.getConnectionString);
            SqlCommand cmd = new SqlCommand();

            try
            {
                conexion.Open();
                cmd.Connection = conexion;
                //con esta sentencia comparamos si los datos insertados ya tienen un registro similar en matriculas
                //si la condición se cumple quiere decir que el estudiante ya matrículo el curso
                cmd.CommandText = "SELECT * FROM Matriculas WHERE Curso_Matriculado = '" + ddCursoMatriculado.Text + "'and ID_Estudiante = '" + txtId.Text + "'";
                SqlDataReader leer = cmd.ExecuteReader(); // leemos los datos
                if (leer.Read() == true)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "swal('Error','Los sentimos, el estudiante matrículo este curso anteriormente, por favor seleccione otro curso', 'warning');", true);
                    //Limpiamos el formulario para que se vuelvan a ingresar los datos
                    LimpiarFormulario();
                }
                else
                {
                    //Si es estudiante no tiene matriculas en el curso insertado procedemos con normalidad
                    CargarCmbCursoHoras();
                    CalcularHoraASincronica();
                    CalcularHoraSincronica();
                }
            }
            catch (Exception)
            {
                throw;
            }

            


        }
        //FeChaInicio le cargamos las validaciones
        protected void txtFechaInicio_TextChanged(object sender, EventArgs e)
        {
            ValidarFechas();//por el momento está vacía
        }
        //********************************************************************
        //Guardamos la matrícula
        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            EntidadMatricula matricula;
            BLMatricula logica = new BLMatricula(Configuration.getConnectionString);
            int resultado = 0;
            try
            {
                matricula = GenerarEntidad();
                //si el cliente ya existe se modifica
                if (matricula.Existe)
                {
                    resultado = logica.ActualizarMatricula(matricula);
                }
                //si no existe
                else
                {
                    //si no existe se inserta
                    if (!string.IsNullOrEmpty(txtNombreEstudiante.Text))
                    {
                        resultado = logica.InsertarMatricula(matricula);
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "swal('Excelente','El estudiante se ha ingresado correctamente','success');", true);
                        Response.Redirect("Matriculas.aspx");
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
                    Response.Redirect("Matriculas.aspx");
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "swal('Error','Los sentimos, al parecer ha ocurrido un error', 'warning');", true);
                }
            }
            catch (Exception)
            {
                throw;
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "swal('Error','Lo sentimos, se ha generado un problema no controlado', 'warning');", true);
            }
        }
        //****************************************************************************
        //Generamos la entidad Matrícula
        //Creamos la entidad profesor
        private EntidadMatricula GenerarEntidad()
        {
            EntidadMatricula matricula = new EntidadMatricula();

            
            matricula.IdEstudiante = Convert.ToInt32(txtId.Text);
         
            matricula.Nombre_Estudiantes = txtNombreEstudiante.Text;
            matricula.Primer_Apellido = txtPrimerApellido.Text;
            matricula.Segundo_Apellido = txtSegundoApellido.Text;
            matricula.Numero_Telefono = txtTelefono.Text;
            matricula.Correo_Electronico = txtCorreo.Text;
            matricula.Direccion = txtDireccion.Text;
            matricula.Curso_Matriculado = ddCursoMatriculado.Text;
            matricula.Intensidad = ddIntensidad.Text;
            matricula.Fecha_Inicio = Convert.ToDateTime(txtFechaInicio.Text);//no las cargar
            matricula.Fecha_Final = Convert.ToDateTime(txtFechaFinal.Text);
            matricula.Horas_Clase_Asincronica = Convert.ToInt32(txtHoraAsin.Text);
            matricula.Horas_Clase_Sincronica = Convert.ToInt32(txtHoraSin.Text);
            matricula.Total_Horas_Clases = Convert.ToInt32(txtTotalHorasClase.Text);
            matricula.Horas_Por_Dia = Convert.ToInt32(txtHorasXClase.Text);
            //si la matrícula existe la actualizamos en el botón guardar
            if (txtIdMatricula.Text != string.Empty)
            {
                matricula.Existe = true;
                matricula.IdMatricula = Convert.ToInt32(txtIdMatricula.Text);
            }

            return matricula;
        }
        //****************************************************
        //Cuando cancelamos la matrícula nos redireccionamos a la página de matriculas
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Matriculas.aspx");
        }
        //******************************************************
        //Cuando se cambia la intensidad se actualiza la cantidad de horas por clase
        protected void txtHorasXClase_TextChanged(object sender, EventArgs e)
        {
            ValidarIntensidad();
        }
        //******************************************************
        //Cuando se cambia el curso se actualiza la cantidad de horas totales del curso
        protected void txtTotalHorasClase_TextChanged(object sender, EventArgs e)
        {
            CargarCmbCursoHoras();
        }
        //*********************************************
        //*********************************************
        //Calculamos los porcentajes de horas Asincrónicas y Sincrónicas
        //Hacemos el cálculo para obtener la cantidad de horas asincrónicas según el 75%
        //LOS SIGUIENTES MÉTODOS SON LLAMADOS EN EL MOMENTO QUE SE ACTIVA EL AUTOPOSTBACK DE CURSO MATRICULADO EN LINEA 261
        public void CalcularHoraASincronica()
        {

            int horas = int.Parse(txtTotalHorasClase.Text);
            int resultado = (horas * 75) / 100;
            txtHoraAsin.Text = resultado.ToString();
        }
        //Hacemos el cálculo para obtener la cantidad de horas sincrónicas según el 25%
        public void CalcularHoraSincronica()
        {
            ValidarIntensidad();
            int horas = int.Parse(  txtTotalHorasClase.Text);
            int resultado = (horas * 25) / 100;
            txtHoraSin.Text = resultado.ToString();
        }

        protected void txtHoraAsin_TextChanged(object sender, EventArgs e)
        {
        }

        protected void txtHoraSin_TextChanged(object sender, EventArgs e)
        {
        }
        //*************************************************
        //*************************************************
        //limpiar formularios
        public void LimpiarFormulario()
        {
            txtId.Text = "";
            txtNombreEstudiante.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtDireccion.Text = "";
           
        }
        

    }//Fin 
}//Fin 