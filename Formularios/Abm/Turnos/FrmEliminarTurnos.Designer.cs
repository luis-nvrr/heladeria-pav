namespace Practico.Formularios.Abm.Turnos
{
    partial class FrmEliminarTurnos
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
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new Practico.Clases.TextBox01();
            this.pckHoraFin = new System.Windows.Forms.DateTimePicker();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.pckHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new Practico.Clases.TextBox01();
            this.txtNumeroD = new Practico.Clases.TextBox01();
            this.lblNumeroD = new System.Windows.Forms.Label();
            this.cmbTipo = new Practico.Clases.ComboBox01();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNuevo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblId.ForeColor = System.Drawing.SystemColors.Control;
            this.lblId.Location = new System.Drawing.Point(161, 102);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(26, 19);
            this.lblId.TabIndex = 73;
            this.lblId.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.Location = new System.Drawing.Point(201, 101);
            this.txtId.Name = "txtId";
            this.txtId.PpMensajeError = "Ingrese Nombre!";
            this.txtId.PpNombreCampo = null;
            this.txtId.PpNombreTabla = null;
            this.txtId.PpValidable = true;
            this.txtId.Size = new System.Drawing.Size(164, 20);
            this.txtId.TabIndex = 72;
            // 
            // pckHoraFin
            // 
            this.pckHoraFin.CustomFormat = "\"HH:mm\"";
            this.pckHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pckHoraFin.Location = new System.Drawing.Point(201, 207);
            this.pckHoraFin.Name = "pckHoraFin";
            this.pckHoraFin.ShowUpDown = true;
            this.pckHoraFin.Size = new System.Drawing.Size(176, 20);
            this.pckHoraFin.TabIndex = 70;
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHoraFin.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblHoraFin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHoraFin.Location = new System.Drawing.Point(85, 211);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(92, 19);
            this.lblHoraFin.TabIndex = 71;
            this.lblHoraFin.Text = "Hora de Fin:";
            // 
            // pckHoraInicio
            // 
            this.pckHoraInicio.CustomFormat = "\"HH:mm\"";
            this.pckHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pckHoraInicio.Location = new System.Drawing.Point(201, 174);
            this.pckHoraInicio.Name = "pckHoraInicio";
            this.pckHoraInicio.ShowUpDown = true;
            this.pckHoraInicio.Size = new System.Drawing.Size(176, 20);
            this.pckHoraInicio.TabIndex = 68;
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHoraInicio.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblHoraInicio.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHoraInicio.Location = new System.Drawing.Point(85, 178);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(109, 19);
            this.lblHoraInicio.TabIndex = 69;
            this.lblHoraInicio.Text = "Hora de Inicio:";
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
            this.btnCancelar.Location = new System.Drawing.Point(194, 365);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 40);
            this.btnCancelar.TabIndex = 67;
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
            this.btnAceptar.Location = new System.Drawing.Point(305, 365);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(103, 40);
            this.btnAceptar.TabIndex = 66;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(126, 144);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 19);
            this.lblNombre.TabIndex = 65;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(201, 139);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PpMensajeError = "Ingrese Nombre!";
            this.txtNombre.PpNombreCampo = null;
            this.txtNombre.PpNombreTabla = null;
            this.txtNombre.PpValidable = true;
            this.txtNombre.Size = new System.Drawing.Size(164, 20);
            this.txtNombre.TabIndex = 64;
            // 
            // txtNumeroD
            // 
            this.txtNumeroD.BackColor = System.Drawing.Color.White;
            this.txtNumeroD.Location = new System.Drawing.Point(201, 278);
            this.txtNumeroD.Name = "txtNumeroD";
            this.txtNumeroD.PpMensajeError = "Ingrese un Numero de Documento!";
            this.txtNumeroD.PpNombreCampo = null;
            this.txtNumeroD.PpNombreTabla = null;
            this.txtNumeroD.PpValidable = true;
            this.txtNumeroD.Size = new System.Drawing.Size(124, 20);
            this.txtNumeroD.TabIndex = 62;
            // 
            // lblNumeroD
            // 
            this.lblNumeroD.AutoSize = true;
            this.lblNumeroD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNumeroD.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblNumeroD.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumeroD.Location = new System.Drawing.Point(18, 283);
            this.lblNumeroD.Name = "lblNumeroD";
            this.lblNumeroD.Size = new System.Drawing.Size(176, 19);
            this.lblNumeroD.TabIndex = 63;
            this.lblNumeroD.Text = "Numero de Documento:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(201, 240);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.PpDisplay = "descripcion";
            this.cmbTipo.PpMensajeError = "Elija un Tipo de Documento!";
            this.cmbTipo.PpNombreCampo = null;
            this.cmbTipo.PpNombreTabla = null;
            this.cmbTipo.PpTabla = "TiposDocumento";
            this.cmbTipo.PpValidable = true;
            this.cmbTipo.PpValue = "tipoDocumento";
            this.cmbTipo.Size = new System.Drawing.Size(123, 21);
            this.cmbTipo.TabIndex = 60;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTipo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblTipo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTipo.Location = new System.Drawing.Point(45, 246);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(149, 19);
            this.lblTipo.TabIndex = 61;
            this.lblTipo.Text = "Tipo de Documento:";
            // 
            // lblNuevo
            // 
            this.lblNuevo.AutoSize = true;
            this.lblNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNuevo.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lblNuevo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNuevo.Location = new System.Drawing.Point(54, 25);
            this.lblNuevo.Name = "lblNuevo";
            this.lblNuevo.Size = new System.Drawing.Size(140, 23);
            this.lblNuevo.TabIndex = 59;
            this.lblNuevo.Text = "Eliminar Turno";
            // 
            // FrmEliminarTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
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
            this.Name = "FrmEliminarTurnos";
            this.Text = "Eliminar Turnos";
            this.Load += new System.EventHandler(this.FrmEliminarTurnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private Clases.TextBox01 txtId;
        private System.Windows.Forms.DateTimePicker pckHoraFin;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.DateTimePicker pckHoraInicio;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblNombre;
        private Clases.TextBox01 txtNombre;
        private Clases.TextBox01 txtNumeroD;
        private System.Windows.Forms.Label lblNumeroD;
        private Clases.ComboBox01 cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNuevo;
    }
}