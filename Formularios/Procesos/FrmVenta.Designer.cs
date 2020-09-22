namespace Practico.Formularios.Procesos
{
    partial class FrmVenta
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
            this.btnEscritorio = new System.Windows.Forms.Button();
            this.lblPersonas = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNumeroD = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new Practico.Clases.TextBox01();
            this.cmbTipo = new Practico.Clases.ComboBox01();
            this.txtNombre = new Practico.Clases.TextBox01();
            this.txtNroDoc = new Practico.Clases.TextBox01();
            this.SuspendLayout();
            // 
            // btnEscritorio
            // 
            this.btnEscritorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnEscritorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEscritorio.FlatAppearance.BorderSize = 0;
            this.btnEscritorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnEscritorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(122)))), ((int)(((byte)(127)))));
            this.btnEscritorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEscritorio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscritorio.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnEscritorio.Location = new System.Drawing.Point(562, 14);
            this.btnEscritorio.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnEscritorio.Name = "btnEscritorio";
            this.btnEscritorio.Size = new System.Drawing.Size(166, 63);
            this.btnEscritorio.TabIndex = 14;
            this.btnEscritorio.Text = "Volver Al Escritorio";
            this.btnEscritorio.UseVisualStyleBackColor = false;
            // 
            // lblPersonas
            // 
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPersonas.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lblPersonas.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPersonas.Location = new System.Drawing.Point(24, 31);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(110, 23);
            this.lblPersonas.TabIndex = 15;
            this.lblPersonas.Text = "Vendedor";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(117, 135);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 19);
            this.lblNombre.TabIndex = 41;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblNumeroD
            // 
            this.lblNumeroD.AutoSize = true;
            this.lblNumeroD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNumeroD.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblNumeroD.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumeroD.Location = new System.Drawing.Point(9, 105);
            this.lblNumeroD.Name = "lblNumeroD";
            this.lblNumeroD.Size = new System.Drawing.Size(176, 19);
            this.lblNumeroD.TabIndex = 40;
            this.lblNumeroD.Text = "Numero de Documento:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTipo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblTipo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTipo.Location = new System.Drawing.Point(36, 75);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(149, 19);
            this.lblTipo.TabIndex = 39;
            this.lblTipo.Text = "Tipo de Documento:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblApellido.ForeColor = System.Drawing.SystemColors.Control;
            this.lblApellido.Location = new System.Drawing.Point(116, 164);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(69, 19);
            this.lblApellido.TabIndex = 43;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.White;
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(192, 159);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PpMensajeError = "No ingresó nombre!";
            this.txtApellido.PpNombreCampo = null;
            this.txtApellido.PpNombreTabla = null;
            this.txtApellido.PpValidable = true;
            this.txtApellido.Size = new System.Drawing.Size(164, 23);
            this.txtApellido.TabIndex = 42;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Enabled = false;
            this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(192, 69);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.PpDisplay = "descripcion";
            this.cmbTipo.PpMensajeError = null;
            this.cmbTipo.PpNombreCampo = null;
            this.cmbTipo.PpNombreTabla = null;
            this.cmbTipo.PpTabla = "TiposDocumento";
            this.cmbTipo.PpValidable = true;
            this.cmbTipo.PpValue = "tipoDocumento";
            this.cmbTipo.Size = new System.Drawing.Size(123, 25);
            this.cmbTipo.TabIndex = 36;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(192, 130);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PpMensajeError = "No se ingresó cantidad en stock!";
            this.txtNombre.PpNombreCampo = null;
            this.txtNombre.PpNombreTabla = null;
            this.txtNombre.PpValidable = true;
            this.txtNombre.Size = new System.Drawing.Size(164, 23);
            this.txtNombre.TabIndex = 38;
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.BackColor = System.Drawing.Color.White;
            this.txtNroDoc.Enabled = false;
            this.txtNroDoc.Location = new System.Drawing.Point(192, 100);
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.PpMensajeError = "No ingresó Precio!";
            this.txtNroDoc.PpNombreCampo = null;
            this.txtNroDoc.PpNombreTabla = null;
            this.txtNroDoc.PpValidable = true;
            this.txtNroDoc.Size = new System.Drawing.Size(124, 23);
            this.txtNroDoc.TabIndex = 37;
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(752, 480);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNroDoc);
            this.Controls.Add(this.lblNumeroD);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblPersonas);
            this.Controls.Add(this.btnEscritorio);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmVenta";
            this.Text = "FrmVenta";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEscritorio;
        private System.Windows.Forms.Label lblPersonas;
        private Clases.ComboBox01 cmbTipo;
        private System.Windows.Forms.Label lblNombre;
        private Clases.TextBox01 txtNombre;
        private Clases.TextBox01 txtNroDoc;
        private System.Windows.Forms.Label lblNumeroD;
        private System.Windows.Forms.Label lblTipo;
        private Clases.TextBox01 txtApellido;
        private System.Windows.Forms.Label lblApellido;
    }
}