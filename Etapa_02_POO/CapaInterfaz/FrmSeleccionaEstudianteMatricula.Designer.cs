
namespace CapaInterfaz
{
    partial class FrmSeleccionaEstudianteMatricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeleccionaEstudianteMatricula));
            this.grdMuestraEstudiantes = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtIdEstudiante = new System.Windows.Forms.TextBox();
            this.btnBuscarEstudiante = new System.Windows.Forms.Button();
            this.txtMatricula = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdMuestraEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // grdMuestraEstudiantes
            // 
            this.grdMuestraEstudiantes.AllowUserToAddRows = false;
            this.grdMuestraEstudiantes.AllowUserToDeleteRows = false;
            this.grdMuestraEstudiantes.AllowUserToResizeColumns = false;
            this.grdMuestraEstudiantes.AllowUserToResizeRows = false;
            this.grdMuestraEstudiantes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grdMuestraEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMuestraEstudiantes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdMuestraEstudiantes.Location = new System.Drawing.Point(12, 76);
            this.grdMuestraEstudiantes.Name = "grdMuestraEstudiantes";
            this.grdMuestraEstudiantes.RowTemplate.Height = 25;
            this.grdMuestraEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMuestraEstudiantes.Size = new System.Drawing.Size(499, 187);
            this.grdMuestraEstudiantes.TabIndex = 0;
            this.grdMuestraEstudiantes.Click += new System.EventHandler(this.grdMuestraEstudiantes_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(209)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(196)))), ((int)(((byte)(187)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAceptar.Location = new System.Drawing.Point(235, 281);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(129, 39);
            this.btnAceptar.TabIndex = 70;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(209)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(196)))), ((int)(((byte)(187)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(382, 281);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 39);
            this.btnCancelar.TabIndex = 71;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtIdEstudiante
            // 
            this.txtIdEstudiante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtIdEstudiante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtIdEstudiante.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtIdEstudiante.Location = new System.Drawing.Point(12, 41);
            this.txtIdEstudiante.Name = "txtIdEstudiante";
            this.txtIdEstudiante.Size = new System.Drawing.Size(125, 23);
            this.txtIdEstudiante.TabIndex = 76;
            // 
            // btnBuscarEstudiante
            // 
            this.btnBuscarEstudiante.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarEstudiante.FlatAppearance.BorderSize = 0;
            this.btnBuscarEstudiante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBuscarEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEstudiante.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarEstudiante.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscarEstudiante.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarEstudiante.Image")));
            this.btnBuscarEstudiante.Location = new System.Drawing.Point(143, 32);
            this.btnBuscarEstudiante.Name = "btnBuscarEstudiante";
            this.btnBuscarEstudiante.Size = new System.Drawing.Size(39, 38);
            this.btnBuscarEstudiante.TabIndex = 75;
            this.btnBuscarEstudiante.Text = "&";
            this.btnBuscarEstudiante.UseVisualStyleBackColor = false;
            this.btnBuscarEstudiante.Click += new System.EventHandler(this.btnBuscarEstudiante_Click);
            // 
            // txtMatricula
            // 
            this.txtMatricula.AutoSize = true;
            this.txtMatricula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(209)))));
            this.txtMatricula.Location = new System.Drawing.Point(219, 30);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(271, 32);
            this.txtMatricula.TabIndex = 77;
            this.txtMatricula.Text = "Agregar Estudiante";
            // 
            // FrmSeleccionaEstudianteMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 334);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.txtIdEstudiante);
            this.Controls.Add(this.btnBuscarEstudiante);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grdMuestraEstudiantes);
            this.Name = "FrmSeleccionaEstudianteMatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Estudiante";
            this.Load += new System.EventHandler(this.FrmSeleccionaEstudianteMatricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMuestraEstudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdMuestraEstudiantes;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtIdEstudiante;
        private System.Windows.Forms.Button btnBuscarEstudiante;
        private System.Windows.Forms.Label txtMatricula;
    }
}