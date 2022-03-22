
using System;

namespace CapaInterfaz
{
    partial class FrmAdminCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminCurso));
            this.gdrAdminCursos = new System.Windows.Forms.DataGridView();
            this.ID_Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblNombreCurso = new System.Windows.Forms.Label();
            this.txtCantidadHoras = new System.Windows.Forms.TextBox();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.lblCodigoCurso = new System.Windows.Forms.Label();
            this.txtCodigoCurso = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminarCurso = new System.Windows.Forms.Button();
            this.lblPrecioHora = new System.Windows.Forms.Label();
            this.txtPrecioHora = new System.Windows.Forms.TextBox();
            this.txtAdministrarCursos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gdrAdminCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // gdrAdminCursos
            // 
            this.gdrAdminCursos.AllowUserToAddRows = false;
            this.gdrAdminCursos.AllowUserToDeleteRows = false;
            this.gdrAdminCursos.AllowUserToResizeColumns = false;
            this.gdrAdminCursos.AllowUserToResizeRows = false;
            this.gdrAdminCursos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gdrAdminCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrAdminCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Curso,
            this.Nombre_Curso,
            this.Cantidad_Horas,
            this.Estado_Curso,
            this.Precio_Hora});
            this.gdrAdminCursos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gdrAdminCursos.Location = new System.Drawing.Point(12, 124);
            this.gdrAdminCursos.Name = "gdrAdminCursos";
            this.gdrAdminCursos.RowTemplate.Height = 25;
            this.gdrAdminCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdrAdminCursos.Size = new System.Drawing.Size(549, 199);
            this.gdrAdminCursos.TabIndex = 0;
            this.gdrAdminCursos.Click += new System.EventHandler(this.gdrAdminCursos_Click);
            // 
            // ID_Curso
            // 
            this.ID_Curso.DataPropertyName = "ID_Curso";
            this.ID_Curso.HeaderText = "Código";
            this.ID_Curso.Name = "ID_Curso";
            // 
            // Nombre_Curso
            // 
            this.Nombre_Curso.DataPropertyName = "Nombre_Curso";
            this.Nombre_Curso.HeaderText = "Nombre del Curso";
            this.Nombre_Curso.Name = "Nombre_Curso";
            // 
            // Cantidad_Horas
            // 
            this.Cantidad_Horas.DataPropertyName = "Cantidad_Horas";
            this.Cantidad_Horas.HeaderText = "Cantidad de Horas";
            this.Cantidad_Horas.Name = "Cantidad_Horas";
            // 
            // Estado_Curso
            // 
            this.Estado_Curso.DataPropertyName = "Estado_Curso";
            this.Estado_Curso.HeaderText = "Estado";
            this.Estado_Curso.Name = "Estado_Curso";
            // 
            // Precio_Hora
            // 
            this.Precio_Hora.DataPropertyName = "Precio_Hora";
            this.Precio_Hora.HeaderText = "Precio por Hora";
            this.Precio_Hora.Name = "Precio_Hora";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoras.ForeColor = System.Drawing.Color.Black;
            this.lblHoras.Location = new System.Drawing.Point(154, 66);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(127, 15);
            this.lblHoras.TabIndex = 41;
            this.lblHoras.Text = "Cantidad de Horas";
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreCurso.ForeColor = System.Drawing.Color.Black;
            this.lblNombreCurso.Location = new System.Drawing.Point(15, 66);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(124, 15);
            this.lblNombreCurso.TabIndex = 40;
            this.lblNombreCurso.Text = "Nombre del Curso";
            // 
            // txtCantidadHoras
            // 
            this.txtCantidadHoras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.txtCantidadHoras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidadHoras.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCantidadHoras.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtCantidadHoras.Location = new System.Drawing.Point(154, 85);
            this.txtCantidadHoras.Multiline = true;
            this.txtCantidadHoras.Name = "txtCantidadHoras";
            this.txtCantidadHoras.PlaceholderText = "Horas";
            this.txtCantidadHoras.Size = new System.Drawing.Size(118, 22);
            this.txtCantidadHoras.TabIndex = 38;
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.txtNombreCurso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreCurso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombreCurso.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtNombreCurso.Location = new System.Drawing.Point(15, 85);
            this.txtNombreCurso.Multiline = true;
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.PlaceholderText = "Nombre";
            this.txtNombreCurso.Size = new System.Drawing.Size(118, 22);
            this.txtNombreCurso.TabIndex = 37;
            // 
            // lblCodigoCurso
            // 
            this.lblCodigoCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigoCurso.AutoSize = true;
            this.lblCodigoCurso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodigoCurso.ForeColor = System.Drawing.Color.Black;
            this.lblCodigoCurso.Location = new System.Drawing.Point(17, 33);
            this.lblCodigoCurso.Name = "lblCodigoCurso";
            this.lblCodigoCurso.Size = new System.Drawing.Size(53, 15);
            this.lblCodigoCurso.TabIndex = 43;
            this.lblCodigoCurso.Text = "Código";
            // 
            // txtCodigoCurso
            // 
            this.txtCodigoCurso.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCodigoCurso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCodigoCurso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigoCurso.Location = new System.Drawing.Point(85, 29);
            this.txtCodigoCurso.Multiline = true;
            this.txtCodigoCurso.Name = "txtCodigoCurso";
            this.txtCodigoCurso.ReadOnly = true;
            this.txtCodigoCurso.Size = new System.Drawing.Size(118, 19);
            this.txtCodigoCurso.TabIndex = 44;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Location = new System.Drawing.Point(-118, 17);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(53, 15);
            this.lblCodigo.TabIndex = 50;
            this.lblCodigo.Text = "Código";
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
            this.btnGuardar.Location = new System.Drawing.Point(134, 341);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(129, 39);
            this.btnGuardar.TabIndex = 59;
            this.btnGuardar.Text = "&  Guardar";
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
            this.btnActualizar.Location = new System.Drawing.Point(284, 341);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(129, 39);
            this.btnActualizar.TabIndex = 60;
            this.btnActualizar.Text = "&   Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminarCurso
            // 
            this.btnEliminarCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(209)))));
            this.btnEliminarCurso.FlatAppearance.BorderSize = 0;
            this.btnEliminarCurso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(196)))), ((int)(((byte)(187)))));
            this.btnEliminarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCurso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarCurso.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminarCurso.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarCurso.Image")));
            this.btnEliminarCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarCurso.Location = new System.Drawing.Point(432, 341);
            this.btnEliminarCurso.Name = "btnEliminarCurso";
            this.btnEliminarCurso.Size = new System.Drawing.Size(129, 39);
            this.btnEliminarCurso.TabIndex = 61;
            this.btnEliminarCurso.Text = "&   Eliminar";
            this.btnEliminarCurso.UseVisualStyleBackColor = false;
            this.btnEliminarCurso.Click += new System.EventHandler(this.btnEliminarCurso_Click);
            // 
            // lblPrecioHora
            // 
            this.lblPrecioHora.AutoSize = true;
            this.lblPrecioHora.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecioHora.Location = new System.Drawing.Point(306, 66);
            this.lblPrecioHora.Name = "lblPrecioHora";
            this.lblPrecioHora.Size = new System.Drawing.Size(85, 15);
            this.lblPrecioHora.TabIndex = 63;
            this.lblPrecioHora.Text = "Precio Hora";
            // 
            // txtPrecioHora
            // 
            this.txtPrecioHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.txtPrecioHora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrecioHora.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecioHora.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtPrecioHora.Location = new System.Drawing.Point(306, 85);
            this.txtPrecioHora.Multiline = true;
            this.txtPrecioHora.Name = "txtPrecioHora";
            this.txtPrecioHora.PlaceholderText = "Precio Hora";
            this.txtPrecioHora.Size = new System.Drawing.Size(118, 22);
            this.txtPrecioHora.TabIndex = 66;
            // 
            // txtAdministrarCursos
            // 
            this.txtAdministrarCursos.AutoSize = true;
            this.txtAdministrarCursos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAdministrarCursos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(209)))));
            this.txtAdministrarCursos.Location = new System.Drawing.Point(262, 18);
            this.txtAdministrarCursos.Name = "txtAdministrarCursos";
            this.txtAdministrarCursos.Size = new System.Drawing.Size(270, 32);
            this.txtAdministrarCursos.TabIndex = 76;
            this.txtAdministrarCursos.Text = "Administrar Cursos";
            // 
            // FrmAdminCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(681, 398);
            this.Controls.Add(this.txtAdministrarCursos);
            this.Controls.Add(this.txtPrecioHora);
            this.Controls.Add(this.lblPrecioHora);
            this.Controls.Add(this.btnEliminarCurso);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblCodigoCurso);
            this.Controls.Add(this.txtCodigoCurso);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.lblNombreCurso);
            this.Controls.Add(this.txtCantidadHoras);
            this.Controls.Add(this.txtNombreCurso);
            this.Controls.Add(this.gdrAdminCursos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdminCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Cursos";
            this.Load += new System.EventHandler(this.FrmAdminCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrAdminCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtPrecioHora_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView gdrAdminCursos;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.TextBox txtCantidadHoras;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.Label lblCodigoCurso;
        internal System.Windows.Forms.TextBox txtCodigoCurso;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminarCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Hora;
        private System.Windows.Forms.Label lblPrecioHora;
        private System.Windows.Forms.TextBox txtPrecioHora;
        private System.Windows.Forms.Label txtAdministrarCursos;
    }
}