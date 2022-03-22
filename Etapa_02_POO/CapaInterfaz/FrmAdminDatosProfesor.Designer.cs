
using System;
using System.Windows.Forms;

namespace CapaInterfaz
{
    partial class FrmAdminProfesor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminProfesor));
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.grdListaMuestraProfesores = new System.Windows.Forms.DataGridView();
            this.ID_Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Primer_Apellido_Prof = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Segundo_Apellido_Prof = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Nacimiento_Prof = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Telefonico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo_Electronico_Prof = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta_Bancaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion_Exacta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso_Certificado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora_Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora_Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtCuentaBancaria = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.lblCuentaBancaria = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHoraSalida = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblBorrado = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.dtpHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.panelAdministrarProfesor = new System.Windows.Forms.Panel();
            this.cmbCursoCertificado = new System.Windows.Forms.ComboBox();
            this.btnBuscarProfesor = new System.Windows.Forms.Button();
            this.cmbBorradoProf = new System.Windows.Forms.ComboBox();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.cmbElegirEstadoProf = new System.Windows.Forms.ComboBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.ErpValida = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtAdministrarProfesores = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaMuestraProfesores)).BeginInit();
            this.panelAdministrarProfesor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErpValida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCodigo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigo.Location = new System.Drawing.Point(68, 10);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(183, 19);
            this.txtCodigo.TabIndex = 3;
            // 
            // grdListaMuestraProfesores
            // 
            this.grdListaMuestraProfesores.AllowUserToAddRows = false;
            this.grdListaMuestraProfesores.AllowUserToDeleteRows = false;
            this.grdListaMuestraProfesores.AllowUserToResizeColumns = false;
            this.grdListaMuestraProfesores.AllowUserToResizeRows = false;
            this.grdListaMuestraProfesores.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdListaMuestraProfesores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdListaMuestraProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaMuestraProfesores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Profesor,
            this.Nombre_Profesor,
            this.Primer_Apellido_Prof,
            this.Segundo_Apellido_Prof,
            this.Fecha_Nacimiento_Prof,
            this.Numero_Telefonico,
            this.Correo_Electronico_Prof,
            this.Cuenta_Bancaria,
            this.Direccion_Exacta,
            this.Curso_Certificado,
            this.Hora_Entrada,
            this.Hora_Salida,
            this.Estado,
            this.Borrado});
            this.grdListaMuestraProfesores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdListaMuestraProfesores.Location = new System.Drawing.Point(12, 271);
            this.grdListaMuestraProfesores.Name = "grdListaMuestraProfesores";
            this.grdListaMuestraProfesores.RowTemplate.Height = 25;
            this.grdListaMuestraProfesores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListaMuestraProfesores.Size = new System.Drawing.Size(906, 246);
            this.grdListaMuestraProfesores.TabIndex = 2;
            this.grdListaMuestraProfesores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListaMuestraProfesores_CellContentClick_1);
            this.grdListaMuestraProfesores.Click += new System.EventHandler(this.grdListaMuestraProfesores_Click);
            // 
            // ID_Profesor
            // 
            this.ID_Profesor.DataPropertyName = "ID_Profesor";
            this.ID_Profesor.HeaderText = "Código";
            this.ID_Profesor.Name = "ID_Profesor";
            // 
            // Nombre_Profesor
            // 
            this.Nombre_Profesor.DataPropertyName = "Nombre_Profesor";
            this.Nombre_Profesor.HeaderText = "Nombre";
            this.Nombre_Profesor.Name = "Nombre_Profesor";
            this.Nombre_Profesor.ReadOnly = true;
            // 
            // Primer_Apellido_Prof
            // 
            this.Primer_Apellido_Prof.DataPropertyName = "Primer_Apellido_Prof";
            this.Primer_Apellido_Prof.HeaderText = "Primer Apellido";
            this.Primer_Apellido_Prof.Name = "Primer_Apellido_Prof";
            // 
            // Segundo_Apellido_Prof
            // 
            this.Segundo_Apellido_Prof.DataPropertyName = "Segundo_Apellido_Prof";
            this.Segundo_Apellido_Prof.HeaderText = "Segundo Apellido";
            this.Segundo_Apellido_Prof.Name = "Segundo_Apellido_Prof";
            // 
            // Fecha_Nacimiento_Prof
            // 
            this.Fecha_Nacimiento_Prof.DataPropertyName = "Fecha_Nacimiento_Prof";
            this.Fecha_Nacimiento_Prof.HeaderText = "Fecha de Nacimiento";
            this.Fecha_Nacimiento_Prof.Name = "Fecha_Nacimiento_Prof";
            // 
            // Numero_Telefonico
            // 
            this.Numero_Telefonico.DataPropertyName = "Numero_Telefonico";
            this.Numero_Telefonico.HeaderText = "Teléfono";
            this.Numero_Telefonico.Name = "Numero_Telefonico";
            // 
            // Correo_Electronico_Prof
            // 
            this.Correo_Electronico_Prof.DataPropertyName = "Correo_Electronico_Prof";
            this.Correo_Electronico_Prof.HeaderText = "Correo Electrónico";
            this.Correo_Electronico_Prof.Name = "Correo_Electronico_Prof";
            // 
            // Cuenta_Bancaria
            // 
            this.Cuenta_Bancaria.DataPropertyName = "Cuenta_Bancaria";
            this.Cuenta_Bancaria.HeaderText = "Número de Cuenta";
            this.Cuenta_Bancaria.Name = "Cuenta_Bancaria";
            // 
            // Direccion_Exacta
            // 
            this.Direccion_Exacta.DataPropertyName = "Direccion_Exacta";
            this.Direccion_Exacta.HeaderText = "Direccion";
            this.Direccion_Exacta.Name = "Direccion_Exacta";
            // 
            // Curso_Certificado
            // 
            this.Curso_Certificado.DataPropertyName = "Curso_Certificado";
            this.Curso_Certificado.HeaderText = "Curso Certificado";
            this.Curso_Certificado.Name = "Curso_Certificado";
            // 
            // Hora_Entrada
            // 
            this.Hora_Entrada.DataPropertyName = "Hora_Entrada";
            this.Hora_Entrada.HeaderText = "Hora de Entrada";
            this.Hora_Entrada.Name = "Hora_Entrada";
            // 
            // Hora_Salida
            // 
            this.Hora_Salida.DataPropertyName = "Hora_Salida";
            this.Hora_Salida.HeaderText = "Hora de Salída";
            this.Hora_Salida.Name = "Hora_Salida";
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Borrado
            // 
            this.Borrado.DataPropertyName = "Borrado";
            this.Borrado.HeaderText = "Borrado";
            this.Borrado.Name = "Borrado";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtNombre.Location = new System.Drawing.Point(9, 58);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Nombre";
            this.txtNombre.Size = new System.Drawing.Size(118, 22);
            this.txtNombre.TabIndex = 14;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.txtPrimerApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrimerApellido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrimerApellido.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtPrimerApellido.Location = new System.Drawing.Point(9, 112);
            this.txtPrimerApellido.Multiline = true;
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.PlaceholderText = "Primer Apellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(118, 22);
            this.txtPrimerApellido.TabIndex = 15;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTelefono.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtTelefono.Location = new System.Drawing.Point(147, 112);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PlaceholderText = "Teléfono";
            this.txtTelefono.Size = new System.Drawing.Size(118, 22);
            this.txtTelefono.TabIndex = 17;
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.txtSegundoApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSegundoApellido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSegundoApellido.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtSegundoApellido.Location = new System.Drawing.Point(9, 164);
            this.txtSegundoApellido.Multiline = true;
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.PlaceholderText = "Segundo Apellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(118, 22);
            this.txtSegundoApellido.TabIndex = 18;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCorreo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtCorreo.Location = new System.Drawing.Point(147, 164);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PlaceholderText = "Correo Electrónico";
            this.txtCorreo.Size = new System.Drawing.Size(118, 22);
            this.txtCorreo.TabIndex = 19;
            // 
            // txtCuentaBancaria
            // 
            this.txtCuentaBancaria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.txtCuentaBancaria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCuentaBancaria.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCuentaBancaria.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtCuentaBancaria.Location = new System.Drawing.Point(311, 58);
            this.txtCuentaBancaria.Multiline = true;
            this.txtCuentaBancaria.Name = "txtCuentaBancaria";
            this.txtCuentaBancaria.PlaceholderText = "Cuenta Bancaria";
            this.txtCuentaBancaria.Size = new System.Drawing.Size(124, 22);
            this.txtCuentaBancaria.TabIndex = 20;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDireccion.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtDireccion.Location = new System.Drawing.Point(618, 65);
            this.txtDireccion.MaxLength = 100;
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PlaceholderText = "Dirección";
            this.txtDireccion.Size = new System.Drawing.Size(102, 88);
            this.txtDireccion.TabIndex = 24;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(209)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(196)))), ((int)(((byte)(187)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(768, 534);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(129, 39);
            this.btnEliminar.TabIndex = 31;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(209)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(196)))), ((int)(((byte)(187)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(475, 534);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(129, 39);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "&       Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(209)))));
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(196)))), ((int)(((byte)(187)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(621, 534);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(129, 39);
            this.btnActualizar.TabIndex = 30;
            this.btnActualizar.Text = "&       Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaNacimiento.CalendarForeColor = System.Drawing.SystemColors.Highlight;
            this.dtpFechaNacimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFechaNacimiento.CustomFormat = "dd-MM-yyyy";
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(147, 58);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(118, 23);
            this.dtpFechaNacimiento.TabIndex = 32;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaNacimiento.ForeColor = System.Drawing.Color.Black;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(147, 40);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(144, 15);
            this.lblFechaNacimiento.TabIndex = 33;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(9, 40);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 15);
            this.lblNombre.TabIndex = 34;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrimerApellido.ForeColor = System.Drawing.Color.Black;
            this.lblPrimerApellido.Location = new System.Drawing.Point(9, 94);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(108, 15);
            this.lblPrimerApellido.TabIndex = 35;
            this.lblPrimerApellido.Text = "Primer Apellido";
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSegundoApellido.ForeColor = System.Drawing.Color.Black;
            this.lblSegundoApellido.Location = new System.Drawing.Point(9, 146);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(120, 15);
            this.lblSegundoApellido.TabIndex = 36;
            this.lblSegundoApellido.Text = "Segundo Apellido";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefono.Location = new System.Drawing.Point(147, 94);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(63, 15);
            this.lblTelefono.TabIndex = 37;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCorreoElectronico.Location = new System.Drawing.Point(147, 146);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(132, 15);
            this.lblCorreoElectronico.TabIndex = 38;
            this.lblCorreoElectronico.Text = "Correo Electrónico";
            // 
            // lblCuentaBancaria
            // 
            this.lblCuentaBancaria.AutoSize = true;
            this.lblCuentaBancaria.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCuentaBancaria.Location = new System.Drawing.Point(311, 40);
            this.lblCuentaBancaria.Name = "lblCuentaBancaria";
            this.lblCuentaBancaria.Size = new System.Drawing.Size(116, 15);
            this.lblCuentaBancaria.TabIndex = 39;
            this.lblCuentaBancaria.Text = "Cuenta Bancaria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(311, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "Curso Certificado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(478, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "Hora de Entrada";
            // 
            // lblHoraSalida
            // 
            this.lblHoraSalida.AutoSize = true;
            this.lblHoraSalida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoraSalida.Location = new System.Drawing.Point(478, 94);
            this.lblHoraSalida.Name = "lblHoraSalida";
            this.lblHoraSalida.Size = new System.Drawing.Size(102, 15);
            this.lblHoraSalida.TabIndex = 42;
            this.lblHoraSalida.Text = "Hora de Salida";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstado.Location = new System.Drawing.Point(478, 146);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(52, 15);
            this.lblEstado.TabIndex = 43;
            this.lblEstado.Text = "Estado";
            // 
            // lblBorrado
            // 
            this.lblBorrado.AutoSize = true;
            this.lblBorrado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBorrado.Location = new System.Drawing.Point(311, 146);
            this.lblBorrado.Name = "lblBorrado";
            this.lblBorrado.Size = new System.Drawing.Size(60, 15);
            this.lblBorrado.TabIndex = 44;
            this.lblBorrado.Text = "Borrado";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDireccion.ForeColor = System.Drawing.Color.Black;
            this.lblDireccion.Location = new System.Drawing.Point(618, 40);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(71, 15);
            this.lblDireccion.TabIndex = 45;
            this.lblDireccion.Text = "Dirección";
            // 
            // dtpHoraEntrada
            // 
            this.dtpHoraEntrada.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpHoraEntrada.CustomFormat = "HH:mm:ss tt";
            this.dtpHoraEntrada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraEntrada.Location = new System.Drawing.Point(476, 58);
            this.dtpHoraEntrada.Name = "dtpHoraEntrada";
            this.dtpHoraEntrada.ShowUpDown = true;
            this.dtpHoraEntrada.Size = new System.Drawing.Size(114, 23);
            this.dtpHoraEntrada.TabIndex = 46;
            this.dtpHoraEntrada.Value = new System.DateTime(2022, 2, 5, 13, 40, 0, 0);
            // 
            // dtpHoraSalida
            // 
            this.dtpHoraSalida.CustomFormat = "HH:mm:ss tt";
            this.dtpHoraSalida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraSalida.Location = new System.Drawing.Point(476, 111);
            this.dtpHoraSalida.Name = "dtpHoraSalida";
            this.dtpHoraSalida.ShowUpDown = true;
            this.dtpHoraSalida.Size = new System.Drawing.Size(114, 23);
            this.dtpHoraSalida.TabIndex = 47;
            // 
            // panelAdministrarProfesor
            // 
            this.panelAdministrarProfesor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelAdministrarProfesor.Controls.Add(this.pictureBox1);
            this.panelAdministrarProfesor.Controls.Add(this.cmbCursoCertificado);
            this.panelAdministrarProfesor.Controls.Add(this.lblDireccion);
            this.panelAdministrarProfesor.Controls.Add(this.dtpHoraSalida);
            this.panelAdministrarProfesor.Controls.Add(this.btnBuscarProfesor);
            this.panelAdministrarProfesor.Controls.Add(this.dtpHoraEntrada);
            this.panelAdministrarProfesor.Controls.Add(this.cmbBorradoProf);
            this.panelAdministrarProfesor.Controls.Add(this.txtDireccion);
            this.panelAdministrarProfesor.Controls.Add(this.txtBuscarCliente);
            this.panelAdministrarProfesor.Controls.Add(this.lblBorrado);
            this.panelAdministrarProfesor.Controls.Add(this.lblEstado);
            this.panelAdministrarProfesor.Controls.Add(this.cmbElegirEstadoProf);
            this.panelAdministrarProfesor.Controls.Add(this.lblHoraSalida);
            this.panelAdministrarProfesor.Controls.Add(this.lblCodigo);
            this.panelAdministrarProfesor.Controls.Add(this.label2);
            this.panelAdministrarProfesor.Controls.Add(this.txtCodigo);
            this.panelAdministrarProfesor.Controls.Add(this.label1);
            this.panelAdministrarProfesor.Controls.Add(this.txtNombre);
            this.panelAdministrarProfesor.Controls.Add(this.lblCuentaBancaria);
            this.panelAdministrarProfesor.Controls.Add(this.txtPrimerApellido);
            this.panelAdministrarProfesor.Controls.Add(this.lblCorreoElectronico);
            this.panelAdministrarProfesor.Controls.Add(this.txtTelefono);
            this.panelAdministrarProfesor.Controls.Add(this.lblTelefono);
            this.panelAdministrarProfesor.Controls.Add(this.txtSegundoApellido);
            this.panelAdministrarProfesor.Controls.Add(this.lblSegundoApellido);
            this.panelAdministrarProfesor.Controls.Add(this.txtCorreo);
            this.panelAdministrarProfesor.Controls.Add(this.lblPrimerApellido);
            this.panelAdministrarProfesor.Controls.Add(this.txtCuentaBancaria);
            this.panelAdministrarProfesor.Controls.Add(this.lblNombre);
            this.panelAdministrarProfesor.Controls.Add(this.dtpFechaNacimiento);
            this.panelAdministrarProfesor.Controls.Add(this.lblFechaNacimiento);
            this.panelAdministrarProfesor.Location = new System.Drawing.Point(13, 50);
            this.panelAdministrarProfesor.Name = "panelAdministrarProfesor";
            this.panelAdministrarProfesor.Size = new System.Drawing.Size(905, 215);
            this.panelAdministrarProfesor.TabIndex = 48;
            // 
            // cmbCursoCertificado
            // 
            this.cmbCursoCertificado.FormattingEnabled = true;
            this.cmbCursoCertificado.Items.AddRange(new object[] {
            "Inglés",
            "Francés",
            "Alemán",
            "Mandarín"});
            this.cmbCursoCertificado.Location = new System.Drawing.Point(311, 115);
            this.cmbCursoCertificado.Name = "cmbCursoCertificado";
            this.cmbCursoCertificado.Size = new System.Drawing.Size(124, 23);
            this.cmbCursoCertificado.TabIndex = 62;
            this.cmbCursoCertificado.Text = "Inglés";
            // 
            // btnBuscarProfesor
            // 
            this.btnBuscarProfesor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarProfesor.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarProfesor.FlatAppearance.BorderSize = 0;
            this.btnBuscarProfesor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBuscarProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProfesor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarProfesor.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscarProfesor.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProfesor.Image")));
            this.btnBuscarProfesor.Location = new System.Drawing.Point(863, 170);
            this.btnBuscarProfesor.Name = "btnBuscarProfesor";
            this.btnBuscarProfesor.Size = new System.Drawing.Size(39, 38);
            this.btnBuscarProfesor.TabIndex = 49;
            this.btnBuscarProfesor.Text = "&";
            this.btnBuscarProfesor.UseVisualStyleBackColor = false;
            this.btnBuscarProfesor.Click += new System.EventHandler(this.btnBuscarProfesor_Click);
            // 
            // cmbBorradoProf
            // 
            this.cmbBorradoProf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbBorradoProf.FormattingEnabled = true;
            this.cmbBorradoProf.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cmbBorradoProf.Location = new System.Drawing.Point(311, 164);
            this.cmbBorradoProf.Name = "cmbBorradoProf";
            this.cmbBorradoProf.Size = new System.Drawing.Size(121, 23);
            this.cmbBorradoProf.TabIndex = 4;
            this.cmbBorradoProf.Text = "0";
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscarCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBuscarCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBuscarCliente.Location = new System.Drawing.Point(744, 179);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.PlaceholderText = "Buscar...";
            this.txtBuscarCliente.Size = new System.Drawing.Size(113, 23);
            this.txtBuscarCliente.TabIndex = 5;
            this.txtBuscarCliente.TextChanged += new System.EventHandler(this.txtBuscarCliente_TextChanged);
            // 
            // cmbElegirEstadoProf
            // 
            this.cmbElegirEstadoProf.FormattingEnabled = true;
            this.cmbElegirEstadoProf.Items.AddRange(new object[] {
            "ACT",
            "INA"});
            this.cmbElegirEstadoProf.Location = new System.Drawing.Point(476, 164);
            this.cmbElegirEstadoProf.Name = "cmbElegirEstadoProf";
            this.cmbElegirEstadoProf.Size = new System.Drawing.Size(121, 23);
            this.cmbElegirEstadoProf.TabIndex = 2;
            this.cmbElegirEstadoProf.Text = "ACT";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Location = new System.Drawing.Point(9, 14);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(53, 15);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código";
            // 
            // ErpValida
            // 
            this.ErpValida.BlinkRate = 0;
            this.ErpValida.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErpValida.ContainerControl = this;
            this.ErpValida.RightToLeft = true;
            // 
            // txtAdministrarProfesores
            // 
            this.txtAdministrarProfesores.AutoSize = true;
            this.txtAdministrarProfesores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAdministrarProfesores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(209)))));
            this.txtAdministrarProfesores.Location = new System.Drawing.Point(173, 9);
            this.txtAdministrarProfesores.Name = "txtAdministrarProfesores";
            this.txtAdministrarProfesores.Size = new System.Drawing.Size(404, 32);
            this.txtAdministrarProfesores.TabIndex = 76;
            this.txtAdministrarProfesores.Text = "Administración de Profesores";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(744, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 113);
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAdminProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(930, 595);
            this.Controls.Add(this.txtAdministrarProfesores);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grdListaMuestraProfesores);
            this.Controls.Add(this.panelAdministrarProfesor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdminProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Profesor";
            this.Load += new System.EventHandler(this.FrmAdminProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdListaMuestraProfesores)).EndInit();
            this.panelAdministrarProfesor.ResumeLayout(false);
            this.panelAdministrarProfesor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErpValida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grdListaMuestraProfesores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Profesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Profesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Primer_Apellido_Prof;
        private System.Windows.Forms.DataGridViewTextBoxColumn Segundo_Apellido_Prof;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Nacimiento_Prof;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Telefonico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo_Electronico_Prof;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta_Bancaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion_Exacta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso_Certificado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora_Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora_Salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Borrado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtCuentaBancaria;
        private System.Windows.Forms.TextBox txtDireccion;
        internal System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.Label lblCuentaBancaria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHoraSalida;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblBorrado;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.DateTimePicker dtpHoraEntrada;
        private System.Windows.Forms.DateTimePicker dtpHoraSalida;
        private System.Windows.Forms.Panel panelAdministrarProfesor;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox cmbElegirEstadoProf;
        private System.Windows.Forms.ComboBox cmbBorradoProf;
        private System.Windows.Forms.ErrorProvider ErpValida;
        private System.Windows.Forms.Button btnBuscarProfesor;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private ComboBox cmbCursoCertificado;
        private Label txtAdministrarProfesores;
        private PictureBox pictureBox1;
    }
}