
namespace CapaInterfaz
{
    partial class FrmBuscarMatricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarMatricula));
            this.grdListarMatriculas = new System.Windows.Forms.DataGridView();
            this.ID_Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso_Matriculado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_horas_Clases = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarMatricula = new System.Windows.Forms.TextBox();
            this.btnBuscarMatricula = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdListarMatriculas)).BeginInit();
            this.SuspendLayout();
            // 
            // grdListarMatriculas
            // 
            this.grdListarMatriculas.AllowUserToAddRows = false;
            this.grdListarMatriculas.AllowUserToDeleteRows = false;
            this.grdListarMatriculas.AllowUserToResizeColumns = false;
            this.grdListarMatriculas.AllowUserToResizeRows = false;
            this.grdListarMatriculas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grdListarMatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListarMatriculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Matricula,
            this.ID_Estudiante,
            this.Curso_Matriculado,
            this.Total_horas_Clases});
            this.grdListarMatriculas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdListarMatriculas.Location = new System.Drawing.Point(12, 83);
            this.grdListarMatriculas.Name = "grdListarMatriculas";
            this.grdListarMatriculas.RowTemplate.Height = 25;
            this.grdListarMatriculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListarMatriculas.Size = new System.Drawing.Size(448, 150);
            this.grdListarMatriculas.TabIndex = 0;
            this.grdListarMatriculas.Click += new System.EventHandler(this.grdListarMatriculas_Click);
            // 
            // ID_Matricula
            // 
            this.ID_Matricula.DataPropertyName = "ID_Matricula";
            this.ID_Matricula.HeaderText = "Código Matricula";
            this.ID_Matricula.Name = "ID_Matricula";
            // 
            // ID_Estudiante
            // 
            this.ID_Estudiante.DataPropertyName = "ID_Estudiante";
            this.ID_Estudiante.HeaderText = "Código Estudiante";
            this.ID_Estudiante.Name = "ID_Estudiante";
            // 
            // Curso_Matriculado
            // 
            this.Curso_Matriculado.DataPropertyName = "Curso_Matriculado";
            this.Curso_Matriculado.HeaderText = "Curso Matriculado";
            this.Curso_Matriculado.Name = "Curso_Matriculado";
            // 
            // Total_horas_Clases
            // 
            this.Total_horas_Clases.DataPropertyName = "Total_horas_Clases";
            this.Total_horas_Clases.HeaderText = "Horas del Curso";
            this.Total_horas_Clases.Name = "Total_horas_Clases";
            // 
            // txtBuscarMatricula
            // 
            this.txtBuscarMatricula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBuscarMatricula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBuscarMatricula.Location = new System.Drawing.Point(12, 48);
            this.txtBuscarMatricula.Name = "txtBuscarMatricula";
            this.txtBuscarMatricula.PlaceholderText = "Buscar...";
            this.txtBuscarMatricula.Size = new System.Drawing.Size(125, 23);
            this.txtBuscarMatricula.TabIndex = 76;
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
            this.btnBuscarMatricula.Location = new System.Drawing.Point(143, 39);
            this.btnBuscarMatricula.Name = "btnBuscarMatricula";
            this.btnBuscarMatricula.Size = new System.Drawing.Size(39, 38);
            this.btnBuscarMatricula.TabIndex = 75;
            this.btnBuscarMatricula.Text = "&";
            this.btnBuscarMatricula.UseVisualStyleBackColor = false;
            this.btnBuscarMatricula.Click += new System.EventHandler(this.btnBuscarMatricula_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(209)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(196)))), ((int)(((byte)(187)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(317, 248);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 39);
            this.btnCancelar.TabIndex = 105;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(209)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(196)))), ((int)(((byte)(187)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAceptar.Location = new System.Drawing.Point(170, 248);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(129, 39);
            this.btnAceptar.TabIndex = 106;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FrmBuscarMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 299);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtBuscarMatricula);
            this.Controls.Add(this.btnBuscarMatricula);
            this.Controls.Add(this.grdListarMatriculas);
            this.Name = "FrmBuscarMatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Matricula";
            this.Load += new System.EventHandler(this.FrmBuscarMatricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdListarMatriculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdListarMatriculas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso_Matriculado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_horas_Clases;
        private System.Windows.Forms.TextBox txtBuscarMatricula;
        private System.Windows.Forms.Button btnBuscarMatricula;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}