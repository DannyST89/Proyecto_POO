
namespace CapaInterfaz
{
    partial class FrmPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPagos));
            this.txtPagoIngresado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbPayment = new System.Windows.Forms.PictureBox();
            this.txtCursoMatriculado = new System.Windows.Forms.TextBox();
            this.txtMontoPagar = new System.Windows.Forms.TextBox();
            this.lblMontoPagar = new System.Windows.Forms.Label();
            this.txtEstadoPago = new System.Windows.Forms.TextBox();
            this.lblEstadoPago = new System.Windows.Forms.Label();
            this.lblCursoMatriculado = new System.Windows.Forms.Label();
            this.txtIdMatricula = new System.Windows.Forms.TextBox();
            this.lblNumeroMatricula = new System.Windows.Forms.Label();
            this.lblPagoMatricula = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoEstudiante = new System.Windows.Forms.TextBox();
            this.dtpFechaPagos = new System.Windows.Forms.DateTimePicker();
            this.lblFechaPago = new System.Windows.Forms.Label();
            this.btnHacerPago = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarMatricula = new System.Windows.Forms.Button();
            this.txtHorasCurso = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPagoIngresado
            // 
            this.txtPagoIngresado.BackColor = System.Drawing.Color.Silver;
            this.txtPagoIngresado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPagoIngresado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPagoIngresado.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtPagoIngresado.Location = new System.Drawing.Point(84, 409);
            this.txtPagoIngresado.Multiline = true;
            this.txtPagoIngresado.Name = "txtPagoIngresado";
            this.txtPagoIngresado.Size = new System.Drawing.Size(126, 22);
            this.txtPagoIngresado.TabIndex = 99;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(54, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 15);
            this.label4.TabIndex = 98;
            this.label4.Text = "Ingrese el Monto a Cancelar";
            // 
            // pbPayment
            // 
            this.pbPayment.Image = ((System.Drawing.Image)(resources.GetObject("pbPayment.Image")));
            this.pbPayment.Location = new System.Drawing.Point(120, 60);
            this.pbPayment.Name = "pbPayment";
            this.pbPayment.Size = new System.Drawing.Size(71, 65);
            this.pbPayment.TabIndex = 97;
            this.pbPayment.TabStop = false;
            // 
            // txtCursoMatriculado
            // 
            this.txtCursoMatriculado.BackColor = System.Drawing.Color.Silver;
            this.txtCursoMatriculado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCursoMatriculado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCursoMatriculado.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtCursoMatriculado.Location = new System.Drawing.Point(184, 213);
            this.txtCursoMatriculado.Multiline = true;
            this.txtCursoMatriculado.Name = "txtCursoMatriculado";
            this.txtCursoMatriculado.ReadOnly = true;
            this.txtCursoMatriculado.Size = new System.Drawing.Size(93, 22);
            this.txtCursoMatriculado.TabIndex = 96;
            // 
            // txtMontoPagar
            // 
            this.txtMontoPagar.BackColor = System.Drawing.Color.Silver;
            this.txtMontoPagar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMontoPagar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMontoPagar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtMontoPagar.Location = new System.Drawing.Point(184, 318);
            this.txtMontoPagar.Multiline = true;
            this.txtMontoPagar.Name = "txtMontoPagar";
            this.txtMontoPagar.ReadOnly = true;
            this.txtMontoPagar.Size = new System.Drawing.Size(93, 22);
            this.txtMontoPagar.TabIndex = 95;
            // 
            // lblMontoPagar
            // 
            this.lblMontoPagar.AutoSize = true;
            this.lblMontoPagar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMontoPagar.ForeColor = System.Drawing.Color.Black;
            this.lblMontoPagar.Location = new System.Drawing.Point(32, 325);
            this.lblMontoPagar.Name = "lblMontoPagar";
            this.lblMontoPagar.Size = new System.Drawing.Size(100, 15);
            this.lblMontoPagar.TabIndex = 94;
            this.lblMontoPagar.Text = "Monto a Pagar";
            // 
            // txtEstadoPago
            // 
            this.txtEstadoPago.BackColor = System.Drawing.Color.Silver;
            this.txtEstadoPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstadoPago.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEstadoPago.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtEstadoPago.Location = new System.Drawing.Point(184, 283);
            this.txtEstadoPago.Multiline = true;
            this.txtEstadoPago.Name = "txtEstadoPago";
            this.txtEstadoPago.ReadOnly = true;
            this.txtEstadoPago.Size = new System.Drawing.Size(93, 22);
            this.txtEstadoPago.TabIndex = 93;
            // 
            // lblEstadoPago
            // 
            this.lblEstadoPago.AutoSize = true;
            this.lblEstadoPago.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstadoPago.ForeColor = System.Drawing.Color.Black;
            this.lblEstadoPago.Location = new System.Drawing.Point(32, 290);
            this.lblEstadoPago.Name = "lblEstadoPago";
            this.lblEstadoPago.Size = new System.Drawing.Size(111, 15);
            this.lblEstadoPago.TabIndex = 92;
            this.lblEstadoPago.Text = "Estado del Pago";
            // 
            // lblCursoMatriculado
            // 
            this.lblCursoMatriculado.AutoSize = true;
            this.lblCursoMatriculado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCursoMatriculado.ForeColor = System.Drawing.Color.Black;
            this.lblCursoMatriculado.Location = new System.Drawing.Point(32, 220);
            this.lblCursoMatriculado.Name = "lblCursoMatriculado";
            this.lblCursoMatriculado.Size = new System.Drawing.Size(127, 15);
            this.lblCursoMatriculado.TabIndex = 91;
            this.lblCursoMatriculado.Text = "Curso Matrículado";
            // 
            // txtIdMatricula
            // 
            this.txtIdMatricula.BackColor = System.Drawing.Color.Silver;
            this.txtIdMatricula.Location = new System.Drawing.Point(184, 145);
            this.txtIdMatricula.Name = "txtIdMatricula";
            this.txtIdMatricula.Size = new System.Drawing.Size(93, 23);
            this.txtIdMatricula.TabIndex = 90;
            // 
            // lblNumeroMatricula
            // 
            this.lblNumeroMatricula.AutoSize = true;
            this.lblNumeroMatricula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroMatricula.ForeColor = System.Drawing.Color.Black;
            this.lblNumeroMatricula.Location = new System.Drawing.Point(32, 153);
            this.lblNumeroMatricula.Name = "lblNumeroMatricula";
            this.lblNumeroMatricula.Size = new System.Drawing.Size(143, 15);
            this.lblNumeroMatricula.TabIndex = 89;
            this.lblNumeroMatricula.Text = "Número de Matrícula";
            // 
            // lblPagoMatricula
            // 
            this.lblPagoMatricula.AutoSize = true;
            this.lblPagoMatricula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPagoMatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(209)))));
            this.lblPagoMatricula.Location = new System.Drawing.Point(51, 19);
            this.lblPagoMatricula.Name = "lblPagoMatricula";
            this.lblPagoMatricula.Size = new System.Drawing.Size(191, 24);
            this.lblPagoMatricula.TabIndex = 88;
            this.lblPagoMatricula.Text = "Pago de Matrícula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 100;
            this.label1.Text = "Código Estudiante";
            // 
            // txtCodigoEstudiante
            // 
            this.txtCodigoEstudiante.BackColor = System.Drawing.Color.Silver;
            this.txtCodigoEstudiante.Location = new System.Drawing.Point(184, 179);
            this.txtCodigoEstudiante.Name = "txtCodigoEstudiante";
            this.txtCodigoEstudiante.ReadOnly = true;
            this.txtCodigoEstudiante.Size = new System.Drawing.Size(93, 23);
            this.txtCodigoEstudiante.TabIndex = 101;
            // 
            // dtpFechaPagos
            // 
            this.dtpFechaPagos.Enabled = false;
            this.dtpFechaPagos.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPagos.Location = new System.Drawing.Point(184, 355);
            this.dtpFechaPagos.Name = "dtpFechaPagos";
            this.dtpFechaPagos.Size = new System.Drawing.Size(101, 23);
            this.dtpFechaPagos.TabIndex = 102;
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFechaPago.ForeColor = System.Drawing.Color.Black;
            this.lblFechaPago.Location = new System.Drawing.Point(32, 361);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(102, 15);
            this.lblFechaPago.TabIndex = 103;
            this.lblFechaPago.Text = "Fecha de Pago";
            // 
            // btnHacerPago
            // 
            this.btnHacerPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(0)))), ((int)(((byte)(209)))));
            this.btnHacerPago.FlatAppearance.BorderSize = 0;
            this.btnHacerPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(196)))), ((int)(((byte)(187)))));
            this.btnHacerPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHacerPago.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHacerPago.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHacerPago.Location = new System.Drawing.Point(81, 437);
            this.btnHacerPago.Name = "btnHacerPago";
            this.btnHacerPago.Size = new System.Drawing.Size(129, 39);
            this.btnHacerPago.TabIndex = 104;
            this.btnHacerPago.Text = "&Pagar";
            this.btnHacerPago.UseVisualStyleBackColor = false;
            this.btnHacerPago.Click += new System.EventHandler(this.btnHacerPago_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(32, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 105;
            this.label2.Text = "Total de Horas";
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
            this.btnBuscarMatricula.Location = new System.Drawing.Point(203, 87);
            this.btnBuscarMatricula.Name = "btnBuscarMatricula";
            this.btnBuscarMatricula.Size = new System.Drawing.Size(39, 38);
            this.btnBuscarMatricula.TabIndex = 106;
            this.btnBuscarMatricula.Text = "&";
            this.btnBuscarMatricula.UseVisualStyleBackColor = false;
            this.btnBuscarMatricula.Click += new System.EventHandler(this.btnBuscarMatricula_Click);
            // 
            // txtHorasCurso
            // 
            this.txtHorasCurso.BackColor = System.Drawing.Color.Silver;
            this.txtHorasCurso.Location = new System.Drawing.Point(184, 245);
            this.txtHorasCurso.Name = "txtHorasCurso";
            this.txtHorasCurso.ReadOnly = true;
            this.txtHorasCurso.Size = new System.Drawing.Size(93, 23);
            this.txtHorasCurso.TabIndex = 107;
            // 
            // FrmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(306, 496);
            this.Controls.Add(this.txtHorasCurso);
            this.Controls.Add(this.btnBuscarMatricula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHacerPago);
            this.Controls.Add(this.lblFechaPago);
            this.Controls.Add(this.dtpFechaPagos);
            this.Controls.Add(this.txtCodigoEstudiante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPagoIngresado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbPayment);
            this.Controls.Add(this.txtCursoMatriculado);
            this.Controls.Add(this.txtMontoPagar);
            this.Controls.Add(this.lblMontoPagar);
            this.Controls.Add(this.txtEstadoPago);
            this.Controls.Add(this.lblEstadoPago);
            this.Controls.Add(this.lblCursoMatriculado);
            this.Controls.Add(this.txtIdMatricula);
            this.Controls.Add(this.lblNumeroMatricula);
            this.Controls.Add(this.lblPagoMatricula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPagos";
            this.Text = "Pagos";
            this.Load += new System.EventHandler(this.FrmPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPagoIngresado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbPayment;
        private System.Windows.Forms.TextBox txtCursoMatriculado;
        private System.Windows.Forms.TextBox txtMontoPagar;
        private System.Windows.Forms.Label lblMontoPagar;
        private System.Windows.Forms.TextBox txtEstadoPago;
        private System.Windows.Forms.Label lblEstadoPago;
        private System.Windows.Forms.Label lblCursoMatriculado;
        private System.Windows.Forms.TextBox txtIdMatricula;
        private System.Windows.Forms.Label lblNumeroMatricula;
        private System.Windows.Forms.Label lblPagoMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoEstudiante;
        private System.Windows.Forms.DateTimePicker dtpFechaPagos;
        private System.Windows.Forms.Label lblFechaPago;
        private System.Windows.Forms.Button btnHacerPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarMatricula;
        private System.Windows.Forms.TextBox txtHorasCurso;
    }
}