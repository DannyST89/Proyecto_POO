
namespace CapaInterfaz
{
    partial class FrmEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstudiante));
            this.txtAdministrarEstudiantes = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grdListaMuestraEstudiantes = new System.Windows.Forms.DataGridView();
            this.ID_Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Est = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Primer_Apellido_Est = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Segundo_Apellido_Est = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Telefonico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo_Electronico_Est = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion_Exacta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_Est = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelAdministrarProfesor = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.btnBuscarProfesor = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.lblIdEstudiante = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombreEstudiante = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.lblNombreEstudiante = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaMuestraEstudiantes)).BeginInit();
            this.panelAdministrarProfesor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdministrarEstudiantes
            // 
            this.txtAdministrarEstudiantes.AutoSize = true;
            this.txtAdministrarEstudiantes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAdministrarEstudiantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(209)))));
            this.txtAdministrarEstudiantes.Location = new System.Drawing.Point(310, 9);
            this.txtAdministrarEstudiantes.Name = "txtAdministrarEstudiantes";
            this.txtAdministrarEstudiantes.Size = new System.Drawing.Size(415, 32);
            this.txtAdministrarEstudiantes.TabIndex = 82;
            this.txtAdministrarEstudiantes.Text = "Administración de Estudiantes";
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
            this.btnEliminar.Location = new System.Drawing.Point(789, 519);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(129, 39);
            this.btnEliminar.TabIndex = 80;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnActualizar.Location = new System.Drawing.Point(642, 519);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(129, 39);
            this.btnActualizar.TabIndex = 79;
            this.btnActualizar.Text = "&       Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
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
            this.btnGuardar.Location = new System.Drawing.Point(496, 519);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(129, 39);
            this.btnGuardar.TabIndex = 78;
            this.btnGuardar.Text = "&       Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // grdListaMuestraEstudiantes
            // 
            this.grdListaMuestraEstudiantes.AllowUserToAddRows = false;
            this.grdListaMuestraEstudiantes.AllowUserToDeleteRows = false;
            this.grdListaMuestraEstudiantes.AllowUserToResizeColumns = false;
            this.grdListaMuestraEstudiantes.AllowUserToResizeRows = false;
            this.grdListaMuestraEstudiantes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdListaMuestraEstudiantes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdListaMuestraEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaMuestraEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Estudiante,
            this.Nombre_Est,
            this.Primer_Apellido_Est,
            this.Segundo_Apellido_Est,
            this.Fecha_Nacimiento,
            this.Numero_Telefonico,
            this.Correo_Electronico_Est,
            this.Direccion_Exacta,
            this.Estado_Est});
            this.grdListaMuestraEstudiantes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdListaMuestraEstudiantes.Location = new System.Drawing.Point(11, 277);
            this.grdListaMuestraEstudiantes.Name = "grdListaMuestraEstudiantes";
            this.grdListaMuestraEstudiantes.RowTemplate.Height = 25;
            this.grdListaMuestraEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListaMuestraEstudiantes.Size = new System.Drawing.Size(907, 225);
            this.grdListaMuestraEstudiantes.TabIndex = 77;
            this.grdListaMuestraEstudiantes.Click += new System.EventHandler(this.grdListaMuestraEstudiantes_Click);
            // 
            // ID_Estudiante
            // 
            this.ID_Estudiante.DataPropertyName = "ID_Estudiante";
            this.ID_Estudiante.HeaderText = "Código";
            this.ID_Estudiante.Name = "ID_Estudiante";
            // 
            // Nombre_Est
            // 
            this.Nombre_Est.DataPropertyName = "Nombre_Est";
            this.Nombre_Est.HeaderText = "Nombre";
            this.Nombre_Est.Name = "Nombre_Est";
            this.Nombre_Est.ReadOnly = true;
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
            // Fecha_Nacimiento
            // 
            this.Fecha_Nacimiento.DataPropertyName = "Fecha_Nacimiento";
            this.Fecha_Nacimiento.HeaderText = "Fecha de Nacimiento";
            this.Fecha_Nacimiento.Name = "Fecha_Nacimiento";
            // 
            // Numero_Telefonico
            // 
            this.Numero_Telefonico.DataPropertyName = "Numero_Telefonico";
            this.Numero_Telefonico.HeaderText = "Teléfono";
            this.Numero_Telefonico.Name = "Numero_Telefonico";
            // 
            // Correo_Electronico_Est
            // 
            this.Correo_Electronico_Est.DataPropertyName = "Correo_Electronico_Est";
            this.Correo_Electronico_Est.HeaderText = "Correo Electrónico";
            this.Correo_Electronico_Est.Name = "Correo_Electronico_Est";
            // 
            // Direccion_Exacta
            // 
            this.Direccion_Exacta.DataPropertyName = "Direccion_Exacta";
            this.Direccion_Exacta.HeaderText = "Direccion";
            this.Direccion_Exacta.Name = "Direccion_Exacta";
            // 
            // Estado_Est
            // 
            this.Estado_Est.DataPropertyName = "Estado_Est";
            this.Estado_Est.HeaderText = "Estado";
            this.Estado_Est.Name = "Estado_Est";
            // 
            // panelAdministrarProfesor
            // 
            this.panelAdministrarProfesor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelAdministrarProfesor.Controls.Add(this.button1);
            this.panelAdministrarProfesor.Controls.Add(this.textBox1);
            this.panelAdministrarProfesor.Controls.Add(this.pictureBox1);
            this.panelAdministrarProfesor.Controls.Add(this.lblDireccion);
            this.panelAdministrarProfesor.Controls.Add(this.btnBuscarProfesor);
            this.panelAdministrarProfesor.Controls.Add(this.txtDireccion);
            this.panelAdministrarProfesor.Controls.Add(this.txtBuscarCliente);
            this.panelAdministrarProfesor.Controls.Add(this.lblIdEstudiante);
            this.panelAdministrarProfesor.Controls.Add(this.txtCodigo);
            this.panelAdministrarProfesor.Controls.Add(this.txtNombreEstudiante);
            this.panelAdministrarProfesor.Controls.Add(this.txtPrimerApellido);
            this.panelAdministrarProfesor.Controls.Add(this.lblCorreoElectronico);
            this.panelAdministrarProfesor.Controls.Add(this.txtTelefono);
            this.panelAdministrarProfesor.Controls.Add(this.lblTelefono);
            this.panelAdministrarProfesor.Controls.Add(this.txtSegundoApellido);
            this.panelAdministrarProfesor.Controls.Add(this.lblSegundoApellido);
            this.panelAdministrarProfesor.Controls.Add(this.txtCorreo);
            this.panelAdministrarProfesor.Controls.Add(this.lblPrimerApellido);
            this.panelAdministrarProfesor.Controls.Add(this.lblNombreEstudiante);
            this.panelAdministrarProfesor.Controls.Add(this.dtpFechaNacimiento);
            this.panelAdministrarProfesor.Controls.Add(this.lblFechaNacimiento);
            this.panelAdministrarProfesor.Location = new System.Drawing.Point(12, 56);
            this.panelAdministrarProfesor.Name = "panelAdministrarProfesor";
            this.panelAdministrarProfesor.Size = new System.Drawing.Size(906, 215);
            this.panelAdministrarProfesor.TabIndex = 81;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(764, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 38);
            this.button1.TabIndex = 52;
            this.button1.Text = "&";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Location = new System.Drawing.Point(610, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Buscar...";
            this.textBox1.Size = new System.Drawing.Size(148, 23);
            this.textBox1.TabIndex = 51;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(630, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 109);
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDireccion.ForeColor = System.Drawing.Color.Black;
            this.lblDireccion.Location = new System.Drawing.Point(312, 40);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(71, 15);
            this.lblDireccion.TabIndex = 45;
            this.lblDireccion.Text = "Dirección";
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
            this.btnBuscarProfesor.Location = new System.Drawing.Point(1069, 62);
            this.btnBuscarProfesor.Name = "btnBuscarProfesor";
            this.btnBuscarProfesor.Size = new System.Drawing.Size(39, 38);
            this.btnBuscarProfesor.TabIndex = 49;
            this.btnBuscarProfesor.Text = "&";
            this.btnBuscarProfesor.UseVisualStyleBackColor = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDireccion.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtDireccion.Location = new System.Drawing.Point(312, 58);
            this.txtDireccion.MaxLength = 100;
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PlaceholderText = "Dirección";
            this.txtDireccion.Size = new System.Drawing.Size(131, 74);
            this.txtDireccion.TabIndex = 24;
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscarCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBuscarCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBuscarCliente.Location = new System.Drawing.Point(915, 71);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.PlaceholderText = "Buscar...";
            this.txtBuscarCliente.Size = new System.Drawing.Size(148, 23);
            this.txtBuscarCliente.TabIndex = 5;
            // 
            // lblIdEstudiante
            // 
            this.lblIdEstudiante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdEstudiante.AutoSize = true;
            this.lblIdEstudiante.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdEstudiante.ForeColor = System.Drawing.Color.Black;
            this.lblIdEstudiante.Location = new System.Drawing.Point(9, 14);
            this.lblIdEstudiante.Name = "lblIdEstudiante";
            this.lblIdEstudiante.Size = new System.Drawing.Size(53, 15);
            this.lblIdEstudiante.TabIndex = 1;
            this.lblIdEstudiante.Text = "Código";
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
            this.txtCodigo.Size = new System.Drawing.Size(120, 19);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtNombreEstudiante
            // 
            this.txtNombreEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.txtNombreEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreEstudiante.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombreEstudiante.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtNombreEstudiante.Location = new System.Drawing.Point(9, 58);
            this.txtNombreEstudiante.Multiline = true;
            this.txtNombreEstudiante.Name = "txtNombreEstudiante";
            this.txtNombreEstudiante.PlaceholderText = "Nombre";
            this.txtNombreEstudiante.Size = new System.Drawing.Size(118, 22);
            this.txtNombreEstudiante.TabIndex = 14;
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
            // lblNombreEstudiante
            // 
            this.lblNombreEstudiante.AutoSize = true;
            this.lblNombreEstudiante.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreEstudiante.ForeColor = System.Drawing.Color.Black;
            this.lblNombreEstudiante.Location = new System.Drawing.Point(9, 40);
            this.lblNombreEstudiante.Name = "lblNombreEstudiante";
            this.lblNombreEstudiante.Size = new System.Drawing.Size(59, 15);
            this.lblNombreEstudiante.TabIndex = 34;
            this.lblNombreEstudiante.Text = "Nombre";
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
            // FrmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 595);
            this.Controls.Add(this.txtAdministrarEstudiantes);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grdListaMuestraEstudiantes);
            this.Controls.Add(this.panelAdministrarProfesor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEstudiante";
            this.Text = "FrmEstudiante";
            this.Load += new System.EventHandler(this.FrmEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdListaMuestraEstudiantes)).EndInit();
            this.panelAdministrarProfesor.ResumeLayout(false);
            this.panelAdministrarProfesor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtAdministrarEstudiantes;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView grdListaMuestraEstudiantes;
        private System.Windows.Forms.Panel panelAdministrarProfesor;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Button btnBuscarProfesor;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Label lblIdEstudiante;
        internal System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombreEstudiante;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.Label lblNombreEstudiante;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Est;
        private System.Windows.Forms.DataGridViewTextBoxColumn Primer_Apellido_Est;
        private System.Windows.Forms.DataGridViewTextBoxColumn Segundo_Apellido_Est;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Telefonico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo_Electronico_Est;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion_Exacta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_Est;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}