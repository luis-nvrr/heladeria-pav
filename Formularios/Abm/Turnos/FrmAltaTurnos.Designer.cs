namespace Practico.Formularios.Abm.Turnos
{
    partial class FrmAltaTurnos
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
            this.lblNuevo = new System.Windows.Forms.Label();
            this.cmbTipo = new Practico.Clases.ComboBox01();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtNumeroD = new Practico.Clases.TextBox01();
            this.lblNumeroD = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new Practico.Clases.TextBox01();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pckHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.pckHoraFin = new System.Windows.Forms.DateTimePicker();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNuevo
            // 
            this.lblNuevo.AutoSize = true;
            this.lblNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNuevo.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lblNuevo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNuevo.Location = new System.Drawing.Point(56, 32);
            this.lblNuevo.Name = "lblNuevo";
            this.lblNuevo.Size = new System.Drawing.Size(133, 23);
            this.lblNuevo.TabIndex = 29;
            this.lblNuevo.Text = "Nuevo Turno";
            this.lblNuevo.Click += new System.EventHandler(this.lblNuevo_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(196, 223);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.PpDisplay = "descripcion";
            this.cmbTipo.PpMensajeError = "Elija un Tipo de Documento!";
            this.cmbTipo.PpNombreCampo = null;
            this.cmbTipo.PpNombreTabla = null;
            this.cmbTipo.PpTabla = "TiposDocumento";
            this.cmbTipo.PpValidable = true;
            this.cmbTipo.PpValue = "tipoDocumento";
            this.cmbTipo.Size = new System.Drawing.Size(123, 21);
            this.cmbTipo.TabIndex = 30;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTipo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblTipo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTipo.Location = new System.Drawing.Point(40, 229);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(149, 19);
            this.lblTipo.TabIndex = 31;
            this.lblTipo.Text = "Tipo de Documento:";
            // 
            // txtNumeroD
            // 
            this.txtNumeroD.BackColor = System.Drawing.Color.White;
            this.txtNumeroD.Location = new System.Drawing.Point(196, 261);
            this.txtNumeroD.Name = "txtNumeroD";
            this.txtNumeroD.PpMensajeError = "Ingrese un Numero de Documento!";
            this.txtNumeroD.PpNombreCampo = null;
            this.txtNumeroD.PpNombreTabla = null;
            this.txtNumeroD.PpValidable = true;
            this.txtNumeroD.Size = new System.Drawing.Size(124, 20);
            this.txtNumeroD.TabIndex = 32;
            // 
            // lblNumeroD
            // 
            this.lblNumeroD.AutoSize = true;
            this.lblNumeroD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNumeroD.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblNumeroD.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumeroD.Location = new System.Drawing.Point(13, 266);
            this.lblNumeroD.Name = "lblNumeroD";
            this.lblNumeroD.Size = new System.Drawing.Size(176, 19);
            this.lblNumeroD.TabIndex = 33;
            this.lblNumeroD.Text = "Numero de Documento:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(121, 127);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 19);
            this.lblNombre.TabIndex = 37;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(196, 122);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PpMensajeError = "Ingrese Nombre!";
            this.txtNombre.PpNombreCampo = null;
            this.txtNombre.PpNombreTabla = null;
            this.txtNombre.PpValidable = true;
            this.txtNombre.Size = new System.Drawing.Size(164, 20);
            this.txtNombre.TabIndex = 36;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(196, 372);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 40);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAceptar.Location = new System.Drawing.Point(307, 372);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(103, 40);
            this.btnAceptar.TabIndex = 38;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // pckHoraInicio
            // 
            this.pckHoraInicio.CustomFormat = "\"HH:mm\"";
            this.pckHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pckHoraInicio.Location = new System.Drawing.Point(196, 157);
            this.pckHoraInicio.Name = "pckHoraInicio";
            this.pckHoraInicio.ShowUpDown = true;
            this.pckHoraInicio.Size = new System.Drawing.Size(176, 20);
            this.pckHoraInicio.TabIndex = 40;
            this.pckHoraInicio.ValueChanged += new System.EventHandler(this.pckHoraInicio_ValueChanged);
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHoraInicio.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblHoraInicio.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHoraInicio.Location = new System.Drawing.Point(80, 161);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(109, 19);
            this.lblHoraInicio.TabIndex = 41;
            this.lblHoraInicio.Text = "Hora de Inicio:";
            // 
            // pckHoraFin
            // 
            this.pckHoraFin.CustomFormat = "\"HH:mm\"";
            this.pckHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pckHoraFin.Location = new System.Drawing.Point(196, 190);
            this.pckHoraFin.Name = "pckHoraFin";
            this.pckHoraFin.ShowUpDown = true;
            this.pckHoraFin.Size = new System.Drawing.Size(176, 20);
            this.pckHoraFin.TabIndex = 42;
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHoraFin.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblHoraFin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHoraFin.Location = new System.Drawing.Point(80, 194);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(92, 19);
            this.lblHoraFin.TabIndex = 43;
            this.lblHoraFin.Text = "Hora de Fin:";
            // 
            // FrmAltaTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.pckHoraFin);
            this.Controls.Add(this.lblHoraFin);
            this.Controls.Add(this.pckHoraInicio);
            this.Controls.Add(this.lblHoraInicio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNumeroD);
            this.Controls.Add(this.lblNumeroD);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblNuevo);
            this.Name = "FrmAltaTurnos";
            this.Text = "Registrar Turno";
            this.Load += new System.EventHandler(this.FrmAltaTurnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevo;
        private Clases.ComboBox01 cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private Clases.TextBox01 txtNumeroD;
        private System.Windows.Forms.Label lblNumeroD;
        private System.Windows.Forms.Label lblNombre;
        private Clases.TextBox01 txtNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DateTimePicker pckHoraInicio;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.DateTimePicker pckHoraFin;
        private System.Windows.Forms.Label lblHoraFin;
    }
}