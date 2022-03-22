
namespace CapaInterfaz
{
    partial class FrmCrearMatricula
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrearMatricula));
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNumeroMatricula = new System.Windows.Forms.Label();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.lblNumeroTelefono = new System.Windows.Forms.Label();
            this.txtNumeroTelefono = new System.Windows.Forms.TextBox();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.lblCursoMatriculado = new System.Windows.Forms.Label();
            this.lblIntensidad = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechafinal = new System.Windows.Forms.Label();
            this.lblHorasSincronicas = new System.Windows.Forms.Label();
            this.txtHorasSincronicas = new System.Windows.Forms.TextBox();
            this.lblHorasAsincronicas = new System.Windows.Forms.Label();
            this.txtHoras_Asincronas = new System.Windows.Forms.TextBox();
            this.cmbCursoMatriculado = new System.Windows.Forms.ComboBox();
            this.cmbIntensidad = new System.Windows.Forms.ComboBox();
            this.txtNumeroMatricula = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDirección = new System.Windows.Forms.TextBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.grdListaMatriculas = new System.Windows.Forms.DataGridView();
            this.ID_Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Est = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Primer_Apellido_Est = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Segundo_Apellido_Est = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Telefonico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo_Electronico_Est = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion_Exacta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso_Matriculado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Intensidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horas_Clase_Asin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horas_Clase_Sin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_horas_Clases = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horas_Por_Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardarMatricula = new System.Windows.Forms.Button();
            this.btnActualizarMatricula = new System.Windows.Forms.Button();
            this.btnEliminarMatricula = new System.Windows.Forms.Button();
            this.btnBuscarMatricula = new System.Windows.Forms.Button();
            this.txtBuscarMatricula = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.Label();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.txtHorasXdia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHorasCurso = new System.Windows.Forms.TextBox();
            this.lblCantidadHoras = new System.Windows.Forms.Label();
            this.btnAgregarEstudiante = new System.Windows.Forms.Button();
            this.txtAgregarEstudiante = new System.Windows.Forms.TextBox();
            this.lblCodigoEstudiante = new System.Windows.Forms.Label();
            this.pbMatricula = new System.Windows.Forms.PictureBox();
            this.panelPagos = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaMatriculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMatricula)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(23, 101);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(132, 15);
            this.lblNombre.TabIndex = 36;
            this.lblNombre.Text = "Nombre Estudiante";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtNombre.Location = new System.Drawing.Point(24, 119);
            this.txtNombre.MaxLength = 10;
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Nombre";
            this.txtNombre.Size = new System.Drawing.Size(118, 22);
            this.txtNombre.TabIndex = 35;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblNumeroMatricula
            // 
            this.lblNumeroMatricula.AutoSize = true;
            this.lblNumeroMatricula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroMatricula.ForeColor = System.Drawing.Color.Black;
            this.lblNumeroMatricula.Location = new System.Drawing.Point(24, 43);
            this.lblNumeroMatricula.Name = "lblNumeroMatricula";
            this.lblNumeroMatricula.Size = new System.Drawing.Size(143, 15);
            this.lblNumeroMatricula.TabIndex = 38;
            this.lblNumeroMatricula.Text = "Número de Matrícula";
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.txtPrimerApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrimerApellido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrimerApellido.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtPrimerApellido.Location = new System.Drawing.Point(24, 173);
            this.txtPrimerApellido.MaxLength = 10;
            this.txtPrimerApellido.Multiline = true;
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.PlaceholderText = "Primer Apellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(118, 22);
            this.txtPrimerApellido.TabIndex = 37;
            this.txtPrimerApellido.TextChanged += new System.EventHandler(this.txtPrimerApellido_TextChanged);
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrimerApellido.ForeColor = System.Drawing.Color.Black;
            this.lblPrimerApellido.Location = new System.Drawing.Point(23, 155);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(108, 15);
            this.lblPrimerApellido.TabIndex = 40;
            this.lblPrimerApellido.Text = "Primer Apellido";
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSegundoApellido.ForeColor = System.Drawing.Color.Black;
            this.lblSegundoApellido.Location = new System.Drawing.Point(21, 204);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(120, 15);
            this.lblSegundoApellido.TabIndex = 42;
            this.lblSegundoApellido.Text = "Segundo Apellido";
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.txtSegundoApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSegundoApellido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSegundoApellido.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtSegundoApellido.Location = new System.Drawing.Point(24, 225);
            this.txtSegundoApellido.MaxLength = 10;
            this.txtSegundoApellido.Multiline = true;
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.PlaceholderText = "Segundo Apellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(118, 22);
            this.txtSegundoApellido.TabIndex = 41;
            this.txtSegundoApellido.TextChanged += new System.EventHandler(this.txtSegundoApellido_TextChanged);
            // 
            // lblNumeroTelefono
            // 
            this.lblNumeroTelefono.AutoSize = true;
            this.lblNumeroTelefono.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroTelefono.ForeColor = System.Drawing.Color.Black;
            this.lblNumeroTelefono.Location = new System.Drawing.Point(24, 249);
            this.lblNumeroTelefono.Name = "lblNumeroTelefono";
            this.lblNumeroTelefono.Size = new System.Drawing.Size(118, 15);
            this.lblNumeroTelefono.TabIndex = 46;
            this.lblNumeroTelefono.Text = "Número Teléfono";
            // 
            // txtNumeroTelefono
            // 
            this.txtNumeroTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.txtNumeroTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroTelefono.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumeroTelefono.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtNumeroTelefono.Location = new System.Drawing.Point(24, 267);
            this.txtNumeroTelefono.MaxLength = 15;
            this.txtNumeroTelefono.Multiline = true;
            this.txtNumeroTelefono.Name = "txtNumeroTelefono";
            this.txtNumeroTelefono.PlaceholderText = "Número Teléfono";
            this.txtNumeroTelefono.Size = new System.Drawing.Size(124, 22);
            this.txtNumeroTelefono.TabIndex = 45;
            this.txtNumeroTelefono.TextChanged += new System.EventHandler(this.txtNumeroTelefono_TextChanged);
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCorreoElectronico.ForeColor = System.Drawing.Color.Black;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(165, 206);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(132, 15);
            this.lblCorreoElectronico.TabIndex = 48;
            this.lblCorreoElectronico.Text = "Correo Electrónico";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.txtCorreoElectronico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreoElectronico.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCorreoElectronico.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtCorreoElectronico.Location = new System.Drawing.Point(166, 224);
            this.txtCorreoElectronico.MaxLength = 20;
            this.txtCorreoElectronico.Multiline = true;
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.PlaceholderText = "Correo Electrónico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(126, 22);
            this.txtCorreoElectronico.TabIndex = 47;
            this.txtCorreoElectronico.TextChanged += new System.EventHandler(this.txtCorreoElectronico_TextChanged);
            // 
            // lblCursoMatriculado
            // 
            this.lblCursoMatriculado.AutoSize = true;
            this.lblCursoMatriculado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCursoMatriculado.ForeColor = System.Drawing.Color.Black;
            this.lblCursoMatriculado.Location = new System.Drawing.Point(314, 154);
            this.lblCursoMatriculado.Name = "lblCursoMatriculado";
            this.lblCursoMatriculado.Size = new System.Drawing.Size(127, 15);
            this.lblCursoMatriculado.TabIndex = 50;
            this.lblCursoMatriculado.Text = "Curso Matrículado";
            // 
            // lblIntensidad
            // 
            this.lblIntensidad.AutoSize = true;
            this.lblIntensidad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIntensidad.ForeColor = System.Drawing.Color.Black;
            this.lblIntensidad.Location = new System.Drawing.Point(166, 103);
            this.lblIntensidad.Name = "lblIntensidad";
            this.lblIntensidad.Size = new System.Drawing.Size(75, 15);
            this.lblIntensidad.TabIndex = 52;
            this.lblIntensidad.Text = "Intensidad";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaInicio.ForeColor = System.Drawing.Color.Black;
            this.lblFechaInicio.Location = new System.Drawing.Point(166, 249);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(86, 15);
            this.lblFechaInicio.TabIndex = 54;
            this.lblFechaInicio.Text = "Fecha Inicio";
            // 
            // lblFechafinal
            // 
            this.lblFechafinal.AutoSize = true;
            this.lblFechafinal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechafinal.ForeColor = System.Drawing.Color.Black;
            this.lblFechafinal.Location = new System.Drawing.Point(315, 249);
            this.lblFechafinal.Name = "lblFechafinal";
            this.lblFechafinal.Size = new System.Drawing.Size(82, 15);
            this.lblFechafinal.TabIndex = 56;
            this.lblFechafinal.Text = "Fecha Final";
            // 
            // lblHorasSincronicas
            // 
            this.lblHorasSincronicas.AutoSize = true;
            this.lblHorasSincronicas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHorasSincronicas.ForeColor = System.Drawing.Color.Black;
            this.lblHorasSincronicas.Location = new System.Drawing.Point(314, 101);
            this.lblHorasSincronicas.Name = "lblHorasSincronicas";
            this.lblHorasSincronicas.Size = new System.Drawing.Size(127, 15);
            this.lblHorasSincronicas.TabIndex = 58;
            this.lblHorasSincronicas.Text = "Horas Sincrónicas";
            // 
            // txtHorasSincronicas
            // 
            this.txtHorasSincronicas.BackColor = System.Drawing.Color.Gainsboro;
            this.txtHorasSincronicas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHorasSincronicas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHorasSincronicas.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtHorasSincronicas.HideSelection = false;
            this.txtHorasSincronicas.Location = new System.Drawing.Point(315, 119);
            this.txtHorasSincronicas.Multiline = true;
            this.txtHorasSincronicas.Name = "txtHorasSincronicas";
            this.txtHorasSincronicas.ReadOnly = true;
            this.txtHorasSincronicas.Size = new System.Drawing.Size(126, 22);
            this.txtHorasSincronicas.TabIndex = 57;
            // 
            // lblHorasAsincronicas
            // 
            this.lblHorasAsincronicas.AutoSize = true;
            this.lblHorasAsincronicas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHorasAsincronicas.ForeColor = System.Drawing.Color.Black;
            this.lblHorasAsincronicas.Location = new System.Drawing.Point(473, 101);
            this.lblHorasAsincronicas.Name = "lblHorasAsincronicas";
            this.lblHorasAsincronicas.Size = new System.Drawing.Size(134, 15);
            this.lblHorasAsincronicas.TabIndex = 60;
            this.lblHorasAsincronicas.Text = "Horas Asincrónicas";
            // 
            // txtHoras_Asincronas
            // 
            this.txtHoras_Asincronas.BackColor = System.Drawing.Color.Gainsboro;
            this.txtHoras_Asincronas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoras_Asincronas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHoras_Asincronas.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtHoras_Asincronas.Location = new System.Drawing.Point(474, 119);
            this.txtHoras_Asincronas.Multiline = true;
            this.txtHoras_Asincronas.Name = "txtHoras_Asincronas";
            this.txtHoras_Asincronas.ReadOnly = true;
            this.txtHoras_Asincronas.Size = new System.Drawing.Size(139, 22);
            this.txtHoras_Asincronas.TabIndex = 59;
            // 
            // cmbCursoMatriculado
            // 
            this.cmbCursoMatriculado.FormattingEnabled = true;
            this.cmbCursoMatriculado.Items.AddRange(new object[] {
            "",
            "Inglés",
            "Francés",
            "Alemán",
            "Mandarín"});
            this.cmbCursoMatriculado.Location = new System.Drawing.Point(317, 172);
            this.cmbCursoMatriculado.Name = "cmbCursoMatriculado";
            this.cmbCursoMatriculado.Size = new System.Drawing.Size(124, 23);
            this.cmbCursoMatriculado.TabIndex = 61;
            this.cmbCursoMatriculado.SelectedIndexChanged += new System.EventHandler(this.cmbCursoMatriculado_SelectedIndexChanged);
            // 
            // cmbIntensidad
            // 
            this.cmbIntensidad.FormattingEnabled = true;
            this.cmbIntensidad.Items.AddRange(new object[] {
            "Bajo",
            "Medio",
            "Alto",
            "Intensivo"});
            this.cmbIntensidad.Location = new System.Drawing.Point(164, 123);
            this.cmbIntensidad.Name = "cmbIntensidad";
            this.cmbIntensidad.Size = new System.Drawing.Size(128, 23);
            this.cmbIntensidad.TabIndex = 62;
            this.cmbIntensidad.Text = "Elija una Intensidad";
            this.cmbIntensidad.SelectedIndexChanged += new System.EventHandler(this.cmbIntensidad_SelectedIndexChanged);
            // 
            // txtNumeroMatricula
            // 
            this.txtNumeroMatricula.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNumeroMatricula.Location = new System.Drawing.Point(24, 62);
            this.txtNumeroMatricula.Name = "txtNumeroMatricula";
            this.txtNumeroMatricula.ReadOnly = true;
            this.txtNumeroMatricula.Size = new System.Drawing.Size(143, 23);
            this.txtNumeroMatricula.TabIndex = 63;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDireccion.ForeColor = System.Drawing.Color.Black;
            this.lblDireccion.Location = new System.Drawing.Point(473, 155);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(71, 15);
            this.lblDireccion.TabIndex = 64;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtDirección
            // 
            this.txtDirección.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.txtDirección.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDirección.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDirección.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtDirección.Location = new System.Drawing.Point(473, 173);
            this.txtDirección.MaxLength = 100;
            this.txtDirección.Multiline = true;
            this.txtDirección.Name = "txtDirección";
            this.txtDirección.PlaceholderText = "Dirección";
            this.txtDirección.Size = new System.Drawing.Size(139, 44);
            this.txtDirección.TabIndex = 65;
            this.txtDirección.TextChanged += new System.EventHandler(this.txtDirección_TextChanged);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CustomFormat = "dd-MM-yyyy";
            this.dtpFechaInicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(166, 267);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(126, 23);
            this.dtpFechaInicio.TabIndex = 66;
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            // 
            // grdListaMatriculas
            // 
            this.grdListaMatriculas.AllowUserToAddRows = false;
            this.grdListaMatriculas.AllowUserToDeleteRows = false;
            this.grdListaMatriculas.AllowUserToResizeColumns = false;
            this.grdListaMatriculas.AllowUserToResizeRows = false;
            this.grdListaMatriculas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdListaMatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaMatriculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Estudiante,
            this.ID_Matricula,
            this.Nombre_Est,
            this.Primer_Apellido_Est,
            this.Segundo_Apellido_Est,
            this.Numero_Telefonico,
            this.Correo_Electronico_Est,
            this.Direccion_Exacta,
            this.Curso_Matriculado,
            this.Intensidad,
            this.Fecha_Inicio,
            this.Horas_Clase_Asin,
            this.Horas_Clase_Sin,
            this.Total_horas_Clases,
            this.Horas_Por_Dia});
            this.grdListaMatriculas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdListaMatriculas.Location = new System.Drawing.Point(21, 299);
            this.grdListaMatriculas.Name = "grdListaMatriculas";
            this.grdListaMatriculas.RowTemplate.Height = 25;
            this.grdListaMatriculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListaMatriculas.Size = new System.Drawing.Size(720, 166);
            this.grdListaMatriculas.TabIndex = 68;
            this.grdListaMatriculas.Click += new System.EventHandler(this.grdListaMatriculas_Click);
            // 
            // ID_Estudiante
            // 
            this.ID_Estudiante.DataPropertyName = "ID_Estudiante";
            this.ID_Estudiante.HeaderText = "Código Estudiante";
            this.ID_Estudiante.Name = "ID_Estudiante";
            // 
            // ID_Matricula
            // 
            this.ID_Matricula.DataPropertyName = "ID_Matricula";
            this.ID_Matricula.HeaderText = "Código Matrícula";
            this.ID_Matricula.Name = "ID_Matricula";
            // 
            // Nombre_Est
            // 
            this.Nombre_Est.DataPropertyName = "Nombre_Est";
            this.Nombre_Est.HeaderText = "Nombre";
            this.Nombre_Est.Name = "Nombre_Est";
            // 
            // Primer_Apellido_Est
            // 
            this.Primer_Apellido_Est.DataPropertyName = "Primer_Apellido_Est";
            this.Primer_Apellido_Est.HeaderText = "Primer Apellido";
            this.Primer_Apellido_Est.Name = "Primer_Apellido_Est";
            // 
            // Segundo_Apellido_Est
            // 
            this.Segundo_Apellido_Est.DataPropertyName = "Segundo_Apellido_Est";
            this.Segundo_Apellido_Est.HeaderText = "Segundo Apellido";
            this.Segundo_Apellido_Est.Name = "Segundo_Apellido_Est";
            // 
            // Numero_Telefonico
            // 
            this.Numero_Telefonico.DataPropertyName = "Numero_Telefonico";
            this.Numero_Telefonico.HeaderText = "Número Teléfono";
            this.Numero_Telefonico.Name = "Numero_Telefonico";
            // 
            // Correo_Electronico_Est
            // 
            this.Correo_Electronico_Est.DataPropertyName = "Correo_Electronico_Est";
            this.Correo_Electronico_Est.HeaderText = "Correo";
            this.Correo_Electronico_Est.Name = "Correo_Electronico_Est";
            // 
            // Direccion_Exacta
            // 
            this.Direccion_Exacta.DataPropertyName = "Direccion_Exacta";
            this.Direccion_Exacta.HeaderText = "Dirección";
            this.Direccion_Exacta.Name = "Direccion_Exacta";
            // 
            // Curso_Matriculado
            // 
            this.Curso_Matriculado.DataPropertyName = "Curso_Matriculado";
            this.Curso_Matriculado.HeaderText = "Curso Matriculado";
            this.Curso_Matriculado.Name = "Curso_Matriculado";
            // 
            // Intensidad
            // 
            this.Intensidad.DataPropertyName = "Intensidad";
            this.Intensidad.HeaderText = "Intensidad";
            this.Intensidad.Name = "Intensidad";
            // 
            // Fecha_Inicio
            // 
            this.Fecha_Inicio.DataPropertyName = "Fecha_Inicio";
            this.Fecha_Inicio.HeaderText = "Fecha Inicio";
            this.Fecha_Inicio.Name = "Fecha_Inicio";
            // 
            // Horas_Clase_Asin
            // 
            this.Horas_Clase_Asin.DataPropertyName = "Horas_Clase_Asin";
            this.Horas_Clase_Asin.HeaderText = "Horas Clase Asincrónica";
            this.Horas_Clase_Asin.Name = "Horas_Clase_Asin";
            // 
            // Horas_Clase_Sin
            // 
            this.Horas_Clase_Sin.DataPropertyName = "Horas_Clase_Sin";
            this.Horas_Clase_Sin.HeaderText = "Horas Clase_Sincrónica";
            this.Horas_Clase_Sin.Name = "Horas_Clase_Sin";
            // 
            // Total_horas_Clases
            // 
            this.Total_horas_Clases.DataPropertyName = "Total_horas_Clases";
            this.Total_horas_Clases.HeaderText = "Horas del Curso";
            this.Total_horas_Clases.Name = "Total_horas_Clases";
            // 
            // Horas_Por_Dia
            // 
            this.Horas_Por_Dia.DataPropertyName = "Horas_Por_Dia";
            this.Horas_Por_Dia.HeaderText = "Horas por Día";
            this.Horas_Por_Dia.Name = "Horas_Por_Dia";
            // 
            // btnGuardarMatricula
            // 
            this.btnGuardarMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(209)))));
            this.btnGuardarMatricula.FlatAppearance.BorderSize = 0;
            this.btnGuardarMatricula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(196)))), ((int)(((byte)(187)))));
            this.btnGuardarMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarMatricula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarMatricula.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardarMatricula.Location = new System.Drawing.Point(318, 486);
            this.btnGuardarMatricula.Name = "btnGuardarMatricula";
            this.btnGuardarMatricula.Size = new System.Drawing.Size(129, 39);
            this.btnGuardarMatricula.TabIndex = 69;
            this.btnGuardarMatricula.Text = "&Crear";
            this.btnGuardarMatricula.UseVisualStyleBackColor = false;
            this.btnGuardarMatricula.Click += new System.EventHandler(this.btnGuardarMatricula_Click_1);
            // 
            // btnActualizarMatricula
            // 
            this.btnActualizarMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(209)))));
            this.btnActualizarMatricula.FlatAppearance.BorderSize = 0;
            this.btnActualizarMatricula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(196)))), ((int)(((byte)(187)))));
            this.btnActualizarMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarMatricula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnActualizarMatricula.ForeColor = System.Drawing.SystemColors.Control;
            this.btnActualizarMatricula.Location = new System.Drawing.Point(466, 486);
            this.btnActualizarMatricula.Name = "btnActualizarMatricula";
            this.btnActualizarMatricula.Size = new System.Drawing.Size(129, 39);
            this.btnActualizarMatricula.TabIndex = 70;
            this.btnActualizarMatricula.Text = "&Actualizar";
            this.btnActualizarMatricula.UseVisualStyleBackColor = false;
            this.btnActualizarMatricula.Click += new System.EventHandler(this.btnActualizarMatricula_Click);
            // 
            // btnEliminarMatricula
            // 
            this.btnEliminarMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(209)))));
            this.btnEliminarMatricula.FlatAppearance.BorderSize = 0;
            this.btnEliminarMatricula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(196)))), ((int)(((byte)(187)))));
            this.btnEliminarMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMatricula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarMatricula.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminarMatricula.Location = new System.Drawing.Point(612, 486);
            this.btnEliminarMatricula.Name = "btnEliminarMatricula";
            this.btnEliminarMatricula.Size = new System.Drawing.Size(129, 39);
            this.btnEliminarMatricula.TabIndex = 71;
            this.btnEliminarMatricula.Text = "&Eliminar";
            this.btnEliminarMatricula.UseVisualStyleBackColor = false;
            this.btnEliminarMatricula.Click += new System.EventHandler(this.btnEliminarMatricula_Click);
            // 
            // btnBuscarMatricula
            // 
            this.btnBuscarMatricula.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarMatricula.FlatAppearance.BorderSize = 0;
            this.btnBuscarMatricula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBuscarMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarMatricula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarMatricula.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscarMatricula.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarMatricula.Image")));
            this.btnBuscarMatricula.Location = new System.Drawing.Point(687, 251);
            this.btnBuscarMatricula.Name = "btnBuscarMatricula";
            this.btnBuscarMatricula.Size = new System.Drawing.Size(39, 38);
            this.btnBuscarMatricula.TabIndex = 73;
            this.btnBuscarMatricula.Text = "&";
            this.btnBuscarMatricula.UseVisualStyleBackColor = false;
            this.btnBuscarMatricula.Click += new System.EventHandler(this.btnBuscarMatricula_Click);
            // 
            // txtBuscarMatricula
            // 
            this.txtBuscarMatricula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBuscarMatricula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBuscarMatricula.Location = new System.Drawing.Point(546, 260);
            this.txtBuscarMatricula.Name = "txtBuscarMatricula";
            this.txtBuscarMatricula.PlaceholderText = "Buscar...";
            this.txtBuscarMatricula.Size = new System.Drawing.Size(125, 23);
            this.txtBuscarMatricula.TabIndex = 74;
            // 
            // txtMatricula
            // 
            this.txtMatricula.AutoSize = true;
            this.txtMatricula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(209)))));
            this.txtMatricula.Location = new System.Drawing.Point(375, 0);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(151, 32);
            this.txtMatricula.TabIndex = 75;
            this.txtMatricula.Text = "Matrículas";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.CustomFormat = "dd-MM-yyyy";
            this.dtpFechaFinal.Enabled = false;
            this.dtpFechaFinal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFinal.Location = new System.Drawing.Point(315, 267);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(126, 23);
            this.dtpFechaFinal.TabIndex = 76;
            this.dtpFechaFinal.ValueChanged += new System.EventHandler(this.dtpFechaFinal_ValueChanged);
            // 
            // txtHorasXdia
            // 
            this.txtHorasXdia.BackColor = System.Drawing.Color.Gainsboro;
            this.txtHorasXdia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHorasXdia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHorasXdia.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtHorasXdia.Location = new System.Drawing.Point(166, 173);
            this.txtHorasXdia.Multiline = true;
            this.txtHorasXdia.Name = "txtHorasXdia";
            this.txtHorasXdia.ReadOnly = true;
            this.txtHorasXdia.Size = new System.Drawing.Size(126, 22);
            this.txtHorasXdia.TabIndex = 72;
            this.txtHorasXdia.TextChanged += new System.EventHandler(this.txtHorasXdia_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(165, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 77;
            this.label1.Text = "Horas por día";
            // 
            // txtHorasCurso
            // 
            this.txtHorasCurso.BackColor = System.Drawing.Color.Gainsboro;
            this.txtHorasCurso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHorasCurso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHorasCurso.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtHorasCurso.Location = new System.Drawing.Point(314, 224);
            this.txtHorasCurso.Multiline = true;
            this.txtHorasCurso.Name = "txtHorasCurso";
            this.txtHorasCurso.ReadOnly = true;
            this.txtHorasCurso.Size = new System.Drawing.Size(126, 22);
            this.txtHorasCurso.TabIndex = 78;
            this.txtHorasCurso.TextChanged += new System.EventHandler(this.txtHorasCurso_TextChanged);
            // 
            // lblCantidadHoras
            // 
            this.lblCantidadHoras.AutoSize = true;
            this.lblCantidadHoras.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadHoras.ForeColor = System.Drawing.Color.Black;
            this.lblCantidadHoras.Location = new System.Drawing.Point(313, 208);
            this.lblCantidadHoras.Name = "lblCantidadHoras";
            this.lblCantidadHoras.Size = new System.Drawing.Size(131, 15);
            this.lblCantidadHoras.TabIndex = 79;
            this.lblCantidadHoras.Text = "Cantidad del Curso";
            // 
            // btnAgregarEstudiante
            // 
            this.btnAgregarEstudiante.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarEstudiante.FlatAppearance.BorderSize = 0;
            this.btnAgregarEstudiante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(196)))), ((int)(((byte)(187)))));
            this.btnAgregarEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEstudiante.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarEstudiante.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregarEstudiante.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarEstudiante.Image")));
            this.btnAgregarEstudiante.Location = new System.Drawing.Point(375, 55);
            this.btnAgregarEstudiante.Name = "btnAgregarEstudiante";
            this.btnAgregarEstudiante.Size = new System.Drawing.Size(44, 34);
            this.btnAgregarEstudiante.TabIndex = 81;
            this.btnAgregarEstudiante.Text = "&";
            this.btnAgregarEstudiante.UseVisualStyleBackColor = false;
            this.btnAgregarEstudiante.Click += new System.EventHandler(this.btnAgregarEstudiante_Click);
            // 
            // txtAgregarEstudiante
            // 
            this.txtAgregarEstudiante.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAgregarEstudiante.Location = new System.Drawing.Point(235, 62);
            this.txtAgregarEstudiante.Name = "txtAgregarEstudiante";
            this.txtAgregarEstudiante.PlaceholderText = "Agregar Estudiante ...";
            this.txtAgregarEstudiante.ReadOnly = true;
            this.txtAgregarEstudiante.Size = new System.Drawing.Size(134, 23);
            this.txtAgregarEstudiante.TabIndex = 82;
            this.txtAgregarEstudiante.TextChanged += new System.EventHandler(this.txtAgregarEstudiante_TextChanged);
            // 
            // lblCodigoEstudiante
            // 
            this.lblCodigoEstudiante.AutoSize = true;
            this.lblCodigoEstudiante.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodigoEstudiante.ForeColor = System.Drawing.Color.Black;
            this.lblCodigoEstudiante.Location = new System.Drawing.Point(235, 43);
            this.lblCodigoEstudiante.Name = "lblCodigoEstudiante";
            this.lblCodigoEstudiante.Size = new System.Drawing.Size(126, 15);
            this.lblCodigoEstudiante.TabIndex = 83;
            this.lblCodigoEstudiante.Text = "Código Estudiante";
            // 
            // pbMatricula
            // 
            this.pbMatricula.Image = ((System.Drawing.Image)(resources.GetObject("pbMatricula.Image")));
            this.pbMatricula.Location = new System.Drawing.Point(636, 138);
            this.pbMatricula.Name = "pbMatricula";
            this.pbMatricula.Size = new System.Drawing.Size(73, 67);
            this.pbMatricula.TabIndex = 85;
            this.pbMatricula.TabStop = false;
            // 
            // panelPagos
            // 
            this.panelPagos.Location = new System.Drawing.Point(750, 29);
            this.panelPagos.Name = "panelPagos";
            this.panelPagos.Size = new System.Drawing.Size(346, 496);
            this.panelPagos.TabIndex = 86;
            // 
            // FrmCrearMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1108, 559);
            this.Controls.Add(this.txtHorasCurso);
            this.Controls.Add(this.lblCursoMatriculado);
            this.Controls.Add(this.panelPagos);
            this.Controls.Add(this.cmbCursoMatriculado);
            this.Controls.Add(this.pbMatricula);
            this.Controls.Add(this.lblCantidadHoras);
            this.Controls.Add(this.lblCodigoEstudiante);
            this.Controls.Add(this.txtAgregarEstudiante);
            this.Controls.Add(this.btnAgregarEstudiante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.txtBuscarMatricula);
            this.Controls.Add(this.btnBuscarMatricula);
            this.Controls.Add(this.txtHorasXdia);
            this.Controls.Add(this.btnEliminarMatricula);
            this.Controls.Add(this.btnActualizarMatricula);
            this.Controls.Add(this.btnGuardarMatricula);
            this.Controls.Add(this.grdListaMatriculas);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.txtDirección);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtNumeroMatricula);
            this.Controls.Add(this.cmbIntensidad);
            this.Controls.Add(this.lblHorasAsincronicas);
            this.Controls.Add(this.txtHoras_Asincronas);
            this.Controls.Add(this.lblHorasSincronicas);
            this.Controls.Add(this.txtHorasSincronicas);
            this.Controls.Add(this.lblFechafinal);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.lblIntensidad);
            this.Controls.Add(this.lblCorreoElectronico);
            this.Controls.Add(this.txtCorreoElectronico);
            this.Controls.Add(this.lblNumeroTelefono);
            this.Controls.Add(this.txtNumeroTelefono);
            this.Controls.Add(this.lblSegundoApellido);
            this.Controls.Add(this.txtSegundoApellido);
            this.Controls.Add(this.lblPrimerApellido);
            this.Controls.Add(this.lblNumeroMatricula);
            this.Controls.Add(this.txtPrimerApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCrearMatricula";
            this.Text = "FrmCrearMatricula";
            this.Load += new System.EventHandler(this.FrmCrearMatricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdListaMatriculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMatricula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNumeroMatricula;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.Label lblNumeroTelefono;
        private System.Windows.Forms.TextBox txtNumeroTelefono;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label lblCursoMatriculado;
        private System.Windows.Forms.Label lblIntensidad;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechafinal;
        private System.Windows.Forms.Label lblHorasSincronicas;
        private System.Windows.Forms.TextBox txtHorasSincronicas;
        private System.Windows.Forms.Label lblHorasAsincronicas;
        private System.Windows.Forms.TextBox txtHoras_Asincronas;
        private System.Windows.Forms.ComboBox cmbCursoMatriculado;
        private System.Windows.Forms.ComboBox cmbIntensidad;
        private System.Windows.Forms.TextBox txtNumeroMatricula;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDirección;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DataGridView grdListaMatriculas;
        private System.Windows.Forms.Button btnGuardarMatricula;
        private System.Windows.Forms.Button btnActualizarMatricula;
        private System.Windows.Forms.Button btnEliminarMatricula;
        private System.Windows.Forms.Button btnBuscarMatricula;
        private System.Windows.Forms.TextBox txtBuscarMatricula;
        private System.Windows.Forms.Label txtMatricula;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.TextBox txtHorasXdia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHorasCurso;
        private System.Windows.Forms.Label lblCantidadHoras;
        private System.Windows.Forms.Button btnAgregarEstudiante;
        private System.Windows.Forms.TextBox txtAgregarEstudiante;
        private System.Windows.Forms.Label lblCodigoEstudiante;
        private System.Windows.Forms.PictureBox pbMatricula;
        private System.Windows.Forms.Panel panelPagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Est;
        private System.Windows.Forms.DataGridViewTextBoxColumn Primer_Apellido_Est;
        private System.Windows.Forms.DataGridViewTextBoxColumn Segundo_Apellido_Est;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Telefonico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo_Electronico_Est;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion_Exacta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso_Matriculado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intensidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas_Clase_Asin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas_Clase_Sin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_horas_Clases;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas_Por_Dia;
    }
}