﻿namespace Practico.Formularios.Abm.Turnos
{
    partial class FrmModificarTurnos
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
            this.lblNuevo = new System.Windows.Forms.Label();
            this.cmbNombre = new Practico.Clases.ComboBox01();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDocumento = new Practico.Clases.ComboBox01();
            this.cmbTipo = new Practico.Clases.ComboBox01();
            this.pckHoraFin = new System.Windows.Forms.DateTimePicker();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.pckHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new Practico.Clases.TextBox01();
            this.lblNumeroD = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnAgregarJefe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblId.ForeColor = System.Drawing.SystemColors.Control;
            this.lblId.Location = new System.Drawing.Point(193, 98);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(26, 19);
            this.lblId.TabIndex = 88;
            this.lblId.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(229, 95);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.PpMensajeError = "Ingrese Nombre!";
            this.txtId.PpNombreCampo = null;
            this.txtId.PpNombreTabla = null;
            this.txtId.PpValidable = true;
            this.txtId.Size = new System.Drawing.Size(90, 24);
            this.txtId.TabIndex = 87;
            // 
            // lblNuevo
            // 
            this.lblNuevo.AutoSize = true;
            this.lblNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNuevo.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lblNuevo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNuevo.Location = new System.Drawing.Point(61, 37);
            this.lblNuevo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevo.Name = "lblNuevo";
            this.lblNuevo.Size = new System.Drawing.Size(156, 23);
            this.lblNuevo.TabIndex = 74;
            this.lblNuevo.Text = "Modificar Turno";
            // 
            // cmbNombre
            // 
            this.cmbNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNombre.FormattingEnabled = true;
            this.cmbNombre.Location = new System.Drawing.Point(228, 219);
            this.cmbNombre.Name = "cmbNombre";
            this.cmbNombre.PpDisplay = "tipoDoc";
            this.cmbNombre.PpMensajeError = "Seleccione un tipo de documento!";
            this.cmbNombre.PpNombreCampo = null;
            this.cmbNombre.PpNombreTabla = null;
            this.cmbNombre.PpTabla = "Empleados";
            this.cmbNombre.PpValidable = true;
            this.cmbNombre.PpValue = "tipoDoc";
            this.cmbNombre.Size = new System.Drawing.Size(164, 25);
            this.cmbNombre.TabIndex = 102;
            this.cmbNombre.SelectedValueChanged += new System.EventHandler(this.cmbNombre_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(97, 225);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 101;
            this.label1.Text = "Nombre de Jefe:";
            // 
            // cmbDocumento
            // 
            this.cmbDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDocumento.FormattingEnabled = true;
            this.cmbDocumento.Location = new System.Drawing.Point(228, 281);
            this.cmbDocumento.Name = "cmbDocumento";
            this.cmbDocumento.PpDisplay = "nroDoc";
            this.cmbDocumento.PpMensajeError = "Seleccione un numero de documento!";
            this.cmbDocumento.PpNombreCampo = null;
            this.cmbDocumento.PpNombreTabla = null;
            this.cmbDocumento.PpTabla = "Empleados";
            this.cmbDocumento.PpValidable = true;
            this.cmbDocumento.PpValue = "nroDoc";
            this.cmbDocumento.Size = new System.Drawing.Size(164, 25);
            this.cmbDocumento.TabIndex = 100;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(228, 250);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.PpDisplay = "tipoDoc";
            this.cmbTipo.PpMensajeError = "Seleccione un tipo de documento!";
            this.cmbTipo.PpNombreCampo = null;
            this.cmbTipo.PpNombreTabla = null;
            this.cmbTipo.PpTabla = "Empleados";
            this.cmbTipo.PpValidable = true;
            this.cmbTipo.PpValue = "tipoDoc";
            this.cmbTipo.Size = new System.Drawing.Size(123, 25);
            this.cmbTipo.TabIndex = 99;
            this.cmbTipo.SelectedValueChanged += new System.EventHandler(this.cmbTipo_SelectedValueChanged);
            // 
            // pckHoraFin
            // 
            this.pckHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pckHoraFin.Location = new System.Drawing.Point(228, 188);
            this.pckHoraFin.Margin = new System.Windows.Forms.Padding(4);
            this.pckHoraFin.Name = "pckHoraFin";
            this.pckHoraFin.ShowUpDown = true;
            this.pckHoraFin.Size = new System.Drawing.Size(91, 24);
            this.pckHoraFin.TabIndex = 97;
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHoraFin.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblHoraFin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHoraFin.Location = new System.Drawing.Point(129, 194);
            this.lblHoraFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(92, 19);
            this.lblHoraFin.TabIndex = 98;
            this.lblHoraFin.Text = "Hora de Fin:";
            // 
            // pckHoraInicio
            // 
            this.pckHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pckHoraInicio.Location = new System.Drawing.Point(228, 156);
            this.pckHoraInicio.Margin = new System.Windows.Forms.Padding(4);
            this.pckHoraInicio.Name = "pckHoraInicio";
            this.pckHoraInicio.ShowUpDown = true;
            this.pckHoraInicio.Size = new System.Drawing.Size(91, 24);
            this.pckHoraInicio.TabIndex = 95;
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHoraInicio.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblHoraInicio.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHoraInicio.Location = new System.Drawing.Point(112, 162);
            this.lblHoraInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(109, 19);
            this.lblHoraInicio.TabIndex = 96;
            this.lblHoraInicio.Text = "Hora de Inicio:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(153, 130);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 19);
            this.lblNombre.TabIndex = 92;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(228, 125);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PpMensajeError = "Ingrese Nombre!";
            this.txtNombre.PpNombreCampo = null;
            this.txtNombre.PpNombreTabla = null;
            this.txtNombre.PpValidable = true;
            this.txtNombre.Size = new System.Drawing.Size(217, 24);
            this.txtNombre.TabIndex = 91;
            // 
            // lblNumeroD
            // 
            this.lblNumeroD.AutoSize = true;
            this.lblNumeroD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNumeroD.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblNumeroD.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumeroD.Location = new System.Drawing.Point(45, 287);
            this.lblNumeroD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroD.Name = "lblNumeroD";
            this.lblNumeroD.Size = new System.Drawing.Size(176, 19);
            this.lblNumeroD.TabIndex = 90;
            this.lblNumeroD.Text = "Numero de Documento:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTipo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblTipo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTipo.Location = new System.Drawing.Point(72, 256);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(149, 19);
            this.lblTipo.TabIndex = 89;
            this.lblTipo.Text = "Tipo de Documento:";
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
            this.btnCancelar.Image = global::Practico.Properties.Resources.remove;
            this.btnCancelar.Location = new System.Drawing.Point(194, 324);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 40);
            this.btnCancelar.TabIndex = 126;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.btnAceptar.Image = global::Practico.Properties.Resources.floppy_disk1;
            this.btnAceptar.Location = new System.Drawing.Point(317, 324);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(103, 40);
            this.btnAceptar.TabIndex = 125;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnAgregarJefe
            // 
            this.btnAgregarJefe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAgregarJefe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarJefe.FlatAppearance.BorderSize = 0;
            this.btnAgregarJefe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnAgregarJefe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnAgregarJefe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarJefe.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarJefe.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregarJefe.Image = global::Practico.Properties.Resources.add;
            this.btnAgregarJefe.Location = new System.Drawing.Point(400, 211);
            this.btnAgregarJefe.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregarJefe.Name = "btnAgregarJefe";
            this.btnAgregarJefe.Size = new System.Drawing.Size(60, 39);
            this.btnAgregarJefe.TabIndex = 127;
            this.btnAgregarJefe.Text = "...";
            this.btnAgregarJefe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarJefe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarJefe.UseVisualStyleBackColor = false;
            this.btnAgregarJefe.Click += new System.EventHandler(this.btnAgregarJefe_Click);
            // 
            // FrmModificarTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(594, 406);
            this.Controls.Add(this.btnAgregarJefe);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDocumento);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.pckHoraFin);
            this.Controls.Add(this.lblHoraFin);
            this.Controls.Add(this.pckHoraInicio);
            this.Controls.Add(this.lblHoraInicio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNumeroD);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblNuevo);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmModificarTurnos";
            this.Text = "Modificar Turnos";
            this.Load += new System.EventHandler(this.FrmModificarTurnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private Clases.TextBox01 txtId;
        private System.Windows.Forms.Label lblNuevo;
        private Clases.ComboBox01 cmbNombre;
        private System.Windows.Forms.Label label1;
        private Clases.ComboBox01 cmbDocumento;
        private Clases.ComboBox01 cmbTipo;
        private System.Windows.Forms.DateTimePicker pckHoraFin;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.DateTimePicker pckHoraInicio;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.Label lblNombre;
        private Clases.TextBox01 txtNombre;
        private System.Windows.Forms.Label lblNumeroD;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnAgregarJefe;
    }
}