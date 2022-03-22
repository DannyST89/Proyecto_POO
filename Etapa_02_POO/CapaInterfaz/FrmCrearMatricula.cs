using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using CapaEntidades;
using CapaLogica;
using System.Globalization;
using System.Drawing;


namespace CapaInterfaz
{
    public partial class FrmCrearMatricula : Form
    {
        EntidadMatricula matriculaRegistrada;
        FrmSeleccionaEstudianteMatricula formularioBuscar;
        //EntidadMatricula estudianteBD;
        public FrmCrearMatricula()
        {
            InitializeComponent();
            AutoCompletado();
            CargarCmbCursoMatriculado();//me trae de la tabla cursos los cursos disponibles
            CargarCmbCursoHoras();// de la tabla cursos metra las horas totales de cada respectivo curso

        }
        //***********************************************************
        //PRIMERA PARTE
        //Método para obtener los datos del formulario

        private EntidadMatricula GenerarEntidad()
        {
            EntidadMatricula matricula = new EntidadMatricula();
            if (!string.IsNullOrEmpty(txtNumeroMatricula.Text))
            {
                matricula = matriculaRegistrada;
            }
            else
            {
                matricula = new EntidadMatricula();
            }
            matricula.IdEstudiante = Convert.ToInt32(txtAgregarEstudiante.Text);
            matricula.Nombre_Estudiantes = txtNombre.Text;
            matricula.Primer_Apellido = txtPrimerApellido.Text;
            matricula.Segundo_Apellido = txtSegundoApellido.Text;
            matricula.Numero_Telefono = txtNumeroTelefono.Text;
            matricula.Correo_Electronico = txtCorreoElectronico.Text;
            matricula.Direccion = txtDirección.Text;
            matricula.Curso_Matriculado = cmbCursoMatriculado.Text;
            matricula.Intensidad = cmbIntensidad.Text;
            matricula.Fecha_Inicio = (Convert.ToDateTime(dtpFechaInicio.Value.Date.ToString("dd-MM-yyyy")));
            matricula.Fecha_Final = (Convert.ToDateTime(dtpFechaFinal.Value.Date.ToString("dd-MM-yyyy")));
            matricula.Horas_Clase_Asincronica = Convert.ToInt32(txtHoras_Asincronas.Text);
            matricula.Horas_Clase_Sincronica = Convert.ToInt32(txtHorasSincronicas.Text);
            matricula.Total_Horas_Clases = Convert.ToInt32(txtHorasCurso.Text);
            matricula.Horas_Por_Dia = Convert.ToInt32(txtHorasXdia.Text);

            return matricula;
        }
    
        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            
            dtpFechaFinal.Value = dtpFechaInicio.Value.AddDays(1);
            ValidarFechas();
            //FechaFinal();
         
           
        }//Fin dtpFechaInicio_ValueChanged
         //****************************************
        //Calculamos la cantidad de horas Asincrónicas y Sincrónicas
        private void cmbCursoMatriculado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCmbCursoHoras();           
        }//
        //Cargar los datos del combobox curso matriculado llamando los datos de la tabla Cursos
        public void CargarCmbCursoMatriculado()
        {
            SqlConnection conexion = new SqlConnection(Configuracion.getConnectionString);
            SqlCommand cmd = new SqlCommand();
            DataTable table = new DataTable();
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Cursos"; // pasamos el resultado de la consulta a cmd

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);// hacemos una instancia con el valor cmd
            adapter.Fill(table);//llenamos el objeto table
            conexion.Close();
            //llamamos al combo box
            cmbCursoMatriculado.DataSource = table; // pasamos el valor de table a cmbcursoMatriculado
            cmbCursoMatriculado.DisplayMember = "Cursos";
            cmbCursoMatriculado.ValueMember = "Nombre_Curso";
        }
        //Cargar horas de los cursos
        public void CargarCmbCursoHoras()
        {
            SqlConnection conexion = new SqlConnection(Configuracion.getConnectionString);
            SqlCommand cmd = new SqlCommand();
           
            try
            {
                conexion.Open();
                cmd.Connection = conexion;
                //creamos una sentencia que va a llamar los datos de la tabla cursos
                cmd.CommandText = "SELECT * FROM Cursos WHERE Nombre_Curso = '" + cmbCursoMatriculado.Text + "'";
                SqlDataReader leer = cmd.ExecuteReader(); // leemos los datos
                if (leer.Read() == true)
                {
                    txtHorasCurso.Text = leer["Cantidad_Horas"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCrearMatricula_Load(object sender, EventArgs e)
        {
            //llamamos al formulario pagos para mostrarlo en el panel pago de matriculas en matriculas
            Form abrirAdminPagos = new FrmPagos();
            agregarFormulario(abrirAdminPagos);// 
            abrirAdminPagos.Dock = DockStyle.Fill;
            abrirAdminPagos.Show();
        
            CargarListaDataSet();
            //desabilitamos el boton crear matrícula, para que sea obligatorio ingresar un estudiante primero para crear una matrícula
            btnGuardarMatricula.Enabled = false;
            //con el using System.Drawing le cambiamos el color miestras esté desabilitado
            btnGuardarMatricula.BackColor = Color.FromArgb(182,182,182);
        }

        //***************************************************************
        //Cargar Lista DataSet
        public void CargarListaDataSet(string condicion = "", string orden = "")
        {
            BLMatricula logica = new BLMatricula(Configuracion.getConnectionString);
            DataSet datosMatricula;

            try
            {
                datosMatricula = logica.ListarMatriculas(condicion, orden);
                grdListaMatriculas.DataSource = datosMatricula;
                grdListaMatriculas.DataMember = datosMatricula.Tables["Matriculas"].TableName;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//Fin CargarListaDataSet
        //***********************************************
        //**  TENGO ERRORES EN ESTE MÉTODO NO SIRVE EN ACTUALIZAR*///
        //El problema son los dos ultimos texbox agregados a la tabla
        //TODO:
        public void LimpiarFormulario()
        {
            txtNumeroMatricula.Text = string.Empty;
            txtAgregarEstudiante.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtPrimerApellido.Text = string.Empty;
            txtSegundoApellido.Text = string.Empty;
            txtNumeroTelefono.Text = string.Empty;
            txtCorreoElectronico.Text = string.Empty;
            txtDirección.Text = string.Empty;
            //cmbCursoMatriculado.Text = string.Empty;
            //cmbIntensidad.Text = string.Empty;
            dtpFechaInicio.Text = string.Empty;
            dtpFechaFinal.Text = string.Empty;
            txtHorasSincronicas.Text = string.Empty;
            txtHoras_Asincronas.Text = string.Empty;
            txtHorasXdia.Text = string.Empty;
            txtHorasCurso.Text = string.Empty;
            txtNombre.Focus();
        }

        private void btnGuardarMatricula_Click_1(object sender, EventArgs e)
        {
            BLMatricula logica = new BLMatricula(Configuracion.getConnectionString);
            EntidadMatricula matricula;
            int resultado;

            try
            {
                if (!string.IsNullOrEmpty(txtNombre.Text) &&
                    !string.IsNullOrEmpty(txtAgregarEstudiante.Text) &&
                    !string.IsNullOrEmpty(txtPrimerApellido.Text) &&
                    !string.IsNullOrEmpty(txtSegundoApellido.Text) &&
                    !string.IsNullOrEmpty(txtNumeroTelefono.Text) &&
                    !string.IsNullOrEmpty(txtCorreoElectronico.Text) &&
                    !string.IsNullOrEmpty(txtDirección.Text) &&
                    !string.IsNullOrEmpty(cmbCursoMatriculado.Text) &&
                    !string.IsNullOrEmpty(cmbIntensidad.Text) &&
                    !string.IsNullOrEmpty(dtpFechaInicio.Text) &&
                    !string.IsNullOrEmpty(dtpFechaFinal.Text) &&
                    !string.IsNullOrEmpty(txtHoras_Asincronas.Text) &&
                    !string.IsNullOrEmpty(txtHorasSincronicas.Text) &&
                    !string.IsNullOrEmpty(txtHorasXdia.Text) &&
                    !string.IsNullOrEmpty(txtHorasCurso.Text))
                {
                    matricula = GenerarEntidad();
                    resultado = logica.InsertarMatricula(matricula);
                    LimpiarFormulario();
                    CargarListaDataSet();
                    MessageBox.Show("El dato se ha registrado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Debe completar todos los datos del registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//Fin btnGuardarMatricula_Click_1
         //************************************************
         //TERCERA PARTE

        private void btnBuscarMatricula_Click(object sender, EventArgs e)
        {
            string condicion = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(txtBuscarMatricula.Text))
                {
                    condicion = string.Format("Nombre_Est like '%{0}%'", txtBuscarMatricula.Text);
                }
                else
                {
                    MessageBox.Show("Ingrese un nombre para buscar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBuscarMatricula.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CargarListaDataSet(condicion);
            txtBuscarMatricula.Focus();
        }//Fin btnBuscarMatricula_Click
        //Se seleciona matriculas en el dataGridView
        private void grdListaMatriculas_Click(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                id = (int)grdListaMatriculas.SelectedRows[0].Cells[0].Value;
                CargarMatricula(id);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//Fin  grdListaMatriculas_Click
        //*************************************
         //Recibimos el método ObtenerMatricula
         private void CargarMatricula(int id)
        {
            EntidadMatricula matricula = new EntidadMatricula();
            BLMatricula traerMatricula = new BLMatricula(Configuracion.getConnectionString);
            try
            {
                matricula = traerMatricula.ObtenerMatricula(id);
                if (matricula != null)
                {
                    txtNumeroMatricula.Text = matricula.IdMatricula.ToString();
                    txtAgregarEstudiante.Text = matricula.IdEstudiante.ToString();
                    txtNombre.Text = matricula.Nombre_Estudiantes;
                    txtPrimerApellido.Text = matricula.Primer_Apellido;
                    txtSegundoApellido.Text = matricula.Segundo_Apellido;
                    txtNumeroTelefono.Text = matricula.Numero_Telefono;
                    txtCorreoElectronico.Text = matricula.Correo_Electronico;
                    txtDirección.Text = matricula.Direccion;
                    cmbCursoMatriculado.Text = matricula.Curso_Matriculado;
                    cmbIntensidad.Text = matricula.Intensidad;
                    dtpFechaInicio.Text = matricula.Fecha_Inicio.ToString();
                    dtpFechaFinal.Text = matricula.Fecha_Final.ToString();
                    txtHoras_Asincronas.Text = matricula.Horas_Clase_Asincronica.ToString();
                    txtHorasSincronicas.Text = matricula.Horas_Clase_Sincronica.ToString();
                    txtHorasCurso.Text = matricula.Total_Horas_Clases.ToString();
                    txtHorasXdia.Text = matricula.Horas_Por_Dia.ToString();
                    //variable global
                    matriculaRegistrada = matricula;
                }
                else
                {
                    MessageBox.Show("La matrícula no está registrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//Fin CargarMatricula
        //Con este método hacemos un auto completado cuando buscamos un profesor
        private void AutoCompletado()
        {
            SqlConnection conexion = new SqlConnection(Configuracion.getConnectionString);
            DataTable datos = new DataTable();
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Nombre_Est FROM Matriculas", conexion);
            adapter.Fill(datos);

            for (int i = 0; i < datos.Rows.Count; i++)
            {
                lista.Add(datos.Rows[i]["Nombre_Est"].ToString());
            }
            txtBuscarMatricula.AutoCompleteCustomSource = lista;
        }
        //***********************************************
        //CUARTA PARTE
        //Eliminar una matrícula
        private void btnEliminarMatricula_Click(object sender, EventArgs e)
        {
            EntidadMatricula matricula;
            int resultado;
            BLMatricula logica = new BLMatricula(Configuracion.getConnectionString);
            try
            {
                if (!string.IsNullOrEmpty(txtNumeroMatricula.Text))
                {
                    matricula = logica.ObtenerMatricula(int.Parse(txtNumeroMatricula.Text));
                    if (matricula != null)
                    {
                        resultado = logica.EliminarMatricula(matricula);
                        MessageBox.Show("Matricula eliminada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarFormulario();
                        CargarListaDataSet();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error al eliminar matricula", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LimpiarFormulario();
                        CargarListaDataSet();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//Fin btnEliminarMatricula_Click
        //***********************************************
        //QUINTA PARTE
        //Actualizar una matrícula
        private void btnActualizarMatricula_Click(object sender, EventArgs e)
        {
            BLMatricula logica = new BLMatricula(Configuracion.getConnectionString);
            EntidadMatricula matricula;
            int resultado;
            try
            {
                if (!string.IsNullOrEmpty(txtNombre.Text) &&
                    !string.IsNullOrEmpty(txtPrimerApellido.Text) &&
                    !string.IsNullOrEmpty(txtSegundoApellido.Text) &&
                    !string.IsNullOrEmpty(txtNumeroTelefono.Text) &&
                    !string.IsNullOrEmpty(txtCorreoElectronico.Text) &&
                    !string.IsNullOrEmpty(txtDirección.Text) &&
                    !string.IsNullOrEmpty(cmbCursoMatriculado.Text) &&
                    !string.IsNullOrEmpty(cmbIntensidad.Text) &&
                    !string.IsNullOrEmpty(dtpFechaInicio.Text) &&
                    !string.IsNullOrEmpty(dtpFechaFinal.Text) &&
                    !string.IsNullOrEmpty(txtHoras_Asincronas.Text) &&
                    !string.IsNullOrEmpty(txtHorasSincronicas.Text) &&
                    !string.IsNullOrEmpty(txtHorasCurso.Text) &&
                    !string.IsNullOrEmpty(txtHorasXdia.Text))
                {
                    matricula = GenerarEntidad();

                    resultado = logica.ActualizarMatricula(matricula);
                    LimpiarFormulario();
                    CargarListaDataSet();
                    MessageBox.Show("El dato se ha actualizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Debe completar todos los datos del registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//btnActualizarMatricula_Click
        //********************************************
        //Creamos un método para calcular la fecha final
        public void ValidarFechas()
        {           
            //la fecha a un dia laboral
            if (dtpFechaInicio.Value.Date < DateTime.Now.Date || dtpFechaFinal.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("La fecha seleccionada no puede ser menor a la fecha actual", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaInicio.Value = DateTime.Now;
                dtpFechaFinal.Value = dtpFechaInicio.Value.Date.AddDays(1);
               
            }
            else if (dtpFechaInicio.Value.Date > dtpFechaFinal.Value.Date)
            {
                MessageBox.Show("La fecha de inicio no pueden ser mayor a la fecha final", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFechaFinal.Value = dtpFechaInicio.Value.AddDays(1);
            }
        }
        //**************************************************
        //datetimepicker que muestra la fecha de finalizacion
        private void dtpFechaFinal_ValueChanged(object sender, EventArgs e)
        {         
            //llamado al método calcular fecha final
            //FechaFinal();
        }
        //Agregamos la cantidad de horas dependiendo de la intensidad elegida
        private void cmbIntensidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIntensidad.SelectedItem.ToString() == "Bajo")
            {
                txtHorasXdia.Text = "1"; 
            }
            else if (cmbIntensidad.SelectedItem.ToString() == "Medio")
            {
                txtHorasXdia.Text = "2";
            }
            else if (cmbIntensidad.SelectedItem.ToString() == "Alto")
            {
                txtHorasXdia.Text = "3";
            }
            else
            {
                txtHorasXdia.Text = "4";
            }
            //Actualiza la fecha final , cada vez que se cambia la intensidad
            FechaFinal();
        }
        //Hacemos el cálculo para obtener la cantidad de horas sincrónicas según el 25%
        public void CalcularHoraASincronica()
        {
            int horas = int.Parse(txtHorasCurso.Text);
            int resultado = (horas * 75) / 100;
            txtHoras_Asincronas.Text = resultado.ToString();
        }
        //Hacemos el cálculo para obtener la cantidad de horas sincrónicas según el 25%
        public void CalcularHoraSincronica()
        {
            int horas = int.Parse(txtHorasCurso.Text);
            int resultado = (horas * 25) / 100;
            txtHorasSincronicas.Text = resultado.ToString();
        }
        private void txtHorasCurso_TextChanged(object sender, EventArgs e)
        {
            CalcularHoraASincronica();
            CalcularHoraSincronica();           
           
        }

        //***********************************************
        //Calcular Fecha final del curso
        public void FechaFinal()
        {
            //Con esta variable obtenemos los dias totales de clases segun el curso elegido y la intensidad
            int diasTotalClases = 0;

            DateTime fechaInicio = DateTime.Parse(dtpFechaInicio.Text);
            DateTime fechaFinal = DateTime.Parse(dtpFechaFinal.Text);
            //***************************
            //Posible solución
            string hCurso = txtHorasCurso.Text.ToString();
            //El valor está vacío porque no se ha seleccionado la intensidad, para ellos es necesario que no se tome en cuenta 
            //la intensidad para sacar la fecha inicial, pero que no se pueda realizar la matricula sin haberla seleccionado
            string hDia = txtHorasXdia.Text.ToString(); //Está vacío *****************************

            //***************************
            
            int diasNoLaborales = 0;
            try
            {
                if (dtpFechaInicio.Text != string.Empty || dtpFechaFinal.Text != string.Empty)
                {
                    diasTotalClases = Convert.ToInt32(hCurso) / Convert.ToInt32(hDia); //AQUÍ MUESTRA EL ERROR
                    diasTotalClases *= 7;// ya divididas las horas del curso y la intensidad, las multiplico por siete dias a la semana
                    //**************************************************************
                    // dias festivos y fines de semana
                    for (int i = 1; i <= diasTotalClases; i++)
                    { //verifico si el dia es domingo o sábado

                        if (fechaInicio.ToString() == $"01/01/2022")
                        {
                            diasNoLaborales++;
                        }
                        else if (fechaInicio.ToString() == $"11/04/2022")
                        {
                            diasNoLaborales++;
                        }
                        else if (fechaInicio.ToString() == $"15/04/2022")
                        {
                            diasNoLaborales++;
                        }
                        else if (fechaInicio.ToString() == $"01/05/2022")
                        {
                            diasNoLaborales++;
                        }
                        else if (fechaInicio.ToString() == $"17/06/2022")
                        {
                            diasNoLaborales++;
                        }
                        else if (fechaInicio.ToString() == $"02/08/2022")
                        {
                            diasNoLaborales++;
                        }
                        else if (fechaInicio.ToString() == $"15/08/2022")
                        {
                            diasNoLaborales++;
                        }
                        else if (fechaInicio.ToString() == $"17/09/2022")
                        {
                            diasNoLaborales++;
                        }
                        else if (fechaInicio.ToString() == $"01/12/2022")
                        {
                            diasNoLaborales++;
                        }
                        else if (fechaInicio.ToString() == $"25/12/2022")
                        {
                            diasNoLaborales++;
                        }
                        else
                        {
                            diasNoLaborales = 0;
                        }

                        fechaInicio = DateTime.Now.AddDays(i);//Agrego un día en  a la fecha inicial hasta que se cumpla el ciclo
                        //cada vez que encuentre un sabado o un domingo se agrega a dias no laborales y esto aumenta la fecha final
                    }
                    dtpFechaFinal.Value = dtpFechaInicio.Value.Date.AddDays(diasTotalClases + diasNoLaborales);
                }
                else
                {
                    MessageBox.Show("Debe de seleccionar una fecha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }//Fin FechaFinal

        private void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {
           
            formularioBuscar = new FrmSeleccionaEstudianteMatricula();
            formularioBuscar.Aceptar += new EventHandler(Aceptar);
            formularioBuscar.ShowDialog();
        }
        ////***********************************************
        private void Aceptar(object id, EventArgs e)
        {
            try
            {
                int id_Estudiante = (int)id;
                if (id_Estudiante != -1)
                {
                    ObtenerEstudiante(id_Estudiante);
                }
                else
                {
                    LimpiarFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }
        //***************************************************
        //SEXTA PARTE
        //Se carba el estudiante en matricula
        private void ObtenerEstudiante(int id)
        {
            EntidadEstudiante estudiante = new EntidadEstudiante();
            BLEstudiante traerEstudiante = new BLEstudiante(Configuracion.getConnectionString);
            try
            {
                estudiante = traerEstudiante.ObtenerEstudiantes(id);
                if (estudiante != null)
                {
                    txtAgregarEstudiante.Text = estudiante.Id_Estudiante.ToString();
                    txtNombre.Text = estudiante.Nombre_Est;
                    txtPrimerApellido.Text = estudiante.PrimerApellido;
                    txtSegundoApellido.Text = estudiante.SegundoApellido;
                    txtNumeroTelefono.Text = estudiante.NumeroTelefono;
                    txtCorreoElectronico.Text = estudiante.CorreoElectronico;
                    txtDirección.Text = estudiante.Direccion;
                }
                else
                {
                    MessageBox.Show("El estudiante no está registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Desabilitamos el botón guardar matricula hasta que se cargue un estudiante
        private void txtAgregarEstudiante_TextChanged(object sender, EventArgs e)
        {
            if (txtAgregarEstudiante.Text != string.Empty &&
                txtNombre.Text != string.Empty &&
                txtPrimerApellido.Text != string.Empty &&
                txtSegundoApellido.Text != string.Empty &&
                txtNumeroTelefono.Text != string.Empty &&
                txtCorreoElectronico.Text != string.Empty &&
                txtDirección.Text != string.Empty)
            {
                btnGuardarMatricula.Enabled = true;
                btnGuardarMatricula.BackColor = Color.FromArgb(28, 0, 209);
            }
            else
            {
                btnGuardarMatricula.Enabled = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtAgregarEstudiante.Text != string.Empty &&
               txtNombre.Text != string.Empty &&
               txtPrimerApellido.Text != string.Empty &&
               txtSegundoApellido.Text != string.Empty &&
               txtNumeroTelefono.Text != string.Empty &&
               txtCorreoElectronico.Text != string.Empty &&
               txtDirección.Text != string.Empty)
            {
                btnGuardarMatricula.Enabled = true;
                btnGuardarMatricula.BackColor = Color.FromArgb(28, 0, 209);
            }
            else
            {
                btnGuardarMatricula.Enabled = false;
            }
        }

        private void txtPrimerApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtAgregarEstudiante.Text != string.Empty &&
               txtNombre.Text != string.Empty &&
               txtPrimerApellido.Text != string.Empty &&
               txtSegundoApellido.Text != string.Empty &&
               txtNumeroTelefono.Text != string.Empty &&
               txtCorreoElectronico.Text != string.Empty &&
               txtDirección.Text != string.Empty)

            {
                btnGuardarMatricula.Enabled = true;
                btnGuardarMatricula.BackColor = Color.FromArgb(28, 0, 209);
            }
            else
            {
                btnGuardarMatricula.Enabled = false;
            }
        }

        private void txtSegundoApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtAgregarEstudiante.Text != string.Empty &&
               txtNombre.Text != string.Empty &&
               txtPrimerApellido.Text != string.Empty &&
               txtSegundoApellido.Text != string.Empty &&
               txtNumeroTelefono.Text != string.Empty &&
               txtCorreoElectronico.Text != string.Empty &&
               txtDirección.Text != string.Empty)
            {
                btnGuardarMatricula.Enabled = true;
                btnGuardarMatricula.BackColor = Color.FromArgb(28, 0, 209);
            }
            else
            {
                btnGuardarMatricula.Enabled = false;
            }
        }

        private void txtNumeroTelefono_TextChanged(object sender, EventArgs e)
        {
            if (txtAgregarEstudiante.Text != string.Empty &&
               txtNombre.Text != string.Empty &&
               txtPrimerApellido.Text != string.Empty &&
               txtSegundoApellido.Text != string.Empty &&
               txtNumeroTelefono.Text != string.Empty &&
               txtCorreoElectronico.Text != string.Empty &&
               txtDirección.Text != string.Empty)
            {
                btnGuardarMatricula.Enabled = true;
                btnGuardarMatricula.BackColor = Color.FromArgb(28, 0, 209);
            }
            else
            {
                btnGuardarMatricula.Enabled = false;
            }
        }

        private void txtCorreoElectronico_TextChanged(object sender, EventArgs e)
        {
            if (txtAgregarEstudiante.Text != string.Empty &&
               txtNombre.Text != string.Empty &&
               txtPrimerApellido.Text != string.Empty &&
               txtSegundoApellido.Text != string.Empty &&
               txtNumeroTelefono.Text != string.Empty &&
               txtCorreoElectronico.Text != string.Empty &&
               txtDirección.Text != string.Empty)
            {
                btnGuardarMatricula.Enabled = true;
                btnGuardarMatricula.BackColor = Color.FromArgb(28, 0, 209);
            }
            else
            {
                btnGuardarMatricula.Enabled = false;
            }
        }

        private void txtDirección_TextChanged(object sender, EventArgs e)
        {
            if (txtAgregarEstudiante.Text != string.Empty &&
               txtNombre.Text != string.Empty &&
               txtPrimerApellido.Text != string.Empty &&
               txtSegundoApellido.Text != string.Empty &&
               txtNumeroTelefono.Text != string.Empty &&
               txtCorreoElectronico.Text != string.Empty &&
               txtDirección.Text != string.Empty)
            {
                btnGuardarMatricula.Enabled = true;
                btnGuardarMatricula.BackColor = Color.FromArgb(28, 0, 209);
            }
            else
            {
                btnGuardarMatricula.Enabled = false;
            }
        }
        //Abrir Formulario en panel
        public void agregarFormulario(Form formulario)
        {
            formulario.TopLevel = false; // esto hace que el formulario no se salga del formulario menú
            this.panelPagos.Controls.Add(formulario); // lo agrega como un control en el panel
            formulario.Show();
        }

        private void txtHorasXdia_TextChanged(object sender, EventArgs e)
        {

        }
    }//partial class FrmCrearMatricula
}//namespace CapaInterfaz
