namespace Practico.Formularios.Abm.HeladosEspeciales
{
    partial class FrmConsultarHeladosEspeciales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarHeladosEspeciales));
            this.lblConsultarHeladoEspecial = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbTipoHelado = new Practico.Clases.ComboBox01();
            this.txtCantBochas = new Practico.Clases.TextBox01();
            this.txtStock = new Practico.Clases.TextBox01();
            this.txtPrecio = new Practico.Clases.TextBox01();
            this.txtNombre = new Practico.Clases.TextBox01();
            this.lblCantStock = new System.Windows.Forms.Label();
            this.lblHelado = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantBochas = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblConsultarHeladoEspecial
            // 
            this.lblConsultarHeladoEspecial.AutoSize = true;
            this.lblConsultarHeladoEspecial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblConsultarHeladoEspecial.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lblConsultarHeladoEspecial.ForeColor = System.Drawing.SystemColors.Control;
            this.lblConsultarHeladoEspecial.Location = new System.Drawing.Point(32, 40);
            this.lblConsultarHeladoEspecial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConsultarHeladoEspecial.Name = "lblConsultarHeladoEspecial";
            this.lblConsultarHeladoEspecial.Size = new System.Drawing.Size(298, 23);
            this.lblConsultarHeladoEspecial.TabIndex = 20;
            this.lblConsultarHeladoEspecial.Text = "Consultar Helados Especiales";
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
            this.btnAceptar.Location = new System.Drawing.Point(303, 285);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(103, 40);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
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
            this.btnCancelar.Location = new System.Drawing.Point(190, 285);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 40);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbTipoHelado
            // 
            this.cmbTipoHelado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoHelado.Enabled = false;
            this.cmbTipoHelado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoHelado.FormattingEnabled = true;
            this.cmbTipoHelado.Location = new System.Drawing.Point(304, 108);
            this.cmbTipoHelado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoHelado.Name = "cmbTipoHelado";
            this.cmbTipoHelado.PpDisplay = "nombre";
            this.cmbTipoHelado.PpMensajeError = "No se ingresó Helado";
            this.cmbTipoHelado.PpNombreCampo = "idHelado";
            this.cmbTipoHelado.PpNombreTabla = "HeladosEspeciales";
            this.cmbTipoHelado.PpTabla = "Helados";
            this.cmbTipoHelado.PpValidable = true;
            this.cmbTipoHelado.PpValue = "idHelado";
            this.cmbTipoHelado.Size = new System.Drawing.Size(164, 25);
            this.cmbTipoHelado.TabIndex = 64;
            // 
            // txtCantBochas
            // 
            this.txtCantBochas.Enabled = false;
            this.txtCantBochas.Location = new System.Drawing.Point(303, 170);
            this.txtCantBochas.Name = "txtCantBochas";
            this.txtCantBochas.PpMensajeError = "Ingrese la cantidad de bochas!";
            this.txtCantBochas.PpNombreCampo = "cantBochas";
            this.txtCantBochas.PpNombreTabla = "HeladosEspeciales";
            this.txtCantBochas.PpValidable = true;
            this.txtCantBochas.Size = new System.Drawing.Size(65, 24);
            this.txtCantBochas.TabIndex = 63;
            // 
            // txtStock
            // 
            this.txtStock.Enabled = false;
            this.txtStock.Location = new System.Drawing.Point(303, 230);
            this.txtStock.Name = "txtStock";
            this.txtStock.PpMensajeError = "Ingrese el stock!";
            this.txtStock.PpNombreCampo = "cantidadStock";
            this.txtStock.PpNombreTabla = "HeladosEspeciales";
            this.txtStock.PpValidable = false;
            this.txtStock.Size = new System.Drawing.Size(65, 24);
            this.txtStock.TabIndex = 62;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(303, 200);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PpMensajeError = "Ingrese el precio!";
            this.txtPrecio.PpNombreCampo = "precio";
            this.txtPrecio.PpNombreTabla = "HeladosEspeciales";
            this.txtPrecio.PpValidable = true;
            this.txtPrecio.Size = new System.Drawing.Size(65, 24);
            this.txtPrecio.TabIndex = 61;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(303, 140);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PpMensajeError = "Ingrese un nombre!";
            this.txtNombre.PpNombreCampo = "nombreProducto";
            this.txtNombre.PpNombreTabla = "HeladosEspeciales";
            this.txtNombre.PpValidable = true;
            this.txtNombre.Size = new System.Drawing.Size(161, 24);
            this.txtNombre.TabIndex = 60;
            // 
            // lblCantStock
            // 
            this.lblCantStock.AutoSize = true;
            this.lblCantStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCantStock.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblCantStock.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCantStock.Location = new System.Drawing.Point(246, 235);
            this.lblCantStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantStock.Name = "lblCantStock";
            this.lblCantStock.Size = new System.Drawing.Size(50, 19);
            this.lblCantStock.TabIndex = 59;
            this.lblCantStock.Text = "Stock:";
            // 
            // lblHelado
            // 
            this.lblHelado.AutoSize = true;
            this.lblHelado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHelado.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblHelado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHelado.Location = new System.Drawing.Point(232, 111);
            this.lblHelado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHelado.Name = "lblHelado";
            this.lblHelado.Size = new System.Drawing.Size(64, 19);
            this.lblHelado.TabIndex = 58;
            this.lblHelado.Text = "Helado:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrecio.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrecio.Location = new System.Drawing.Point(241, 205);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(55, 19);
            this.lblPrecio.TabIndex = 57;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblCantBochas
            // 
            this.lblCantBochas.AutoSize = true;
            this.lblCantBochas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCantBochas.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblCantBochas.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCantBochas.Location = new System.Drawing.Point(138, 175);
            this.lblCantBochas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantBochas.Name = "lblCantBochas";
            this.lblCantBochas.Size = new System.Drawing.Size(158, 19);
            this.lblCantBochas.TabIndex = 56;
            this.lblCantBochas.Text = "Cantidad de Bochas:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(228, 145);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 19);
            this.lblNombre.TabIndex = 55;
            this.lblNombre.Text = "Nombre:";
            // 
            // FrmConsultarHeladosEspeciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(601, 371);
            this.Controls.Add(this.cmbTipoHelado);
            this.Controls.Add(this.txtCantBochas);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCantStock);
            this.Controls.Add(this.lblHelado);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCantBochas);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblConsultarHeladoEspecial);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultarHeladosEspeciales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Helados Especiales";
            this.Load += new System.EventHandler(this.FrmModificarHeladosEspeciales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultarHeladoEspecial;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private Clases.ComboBox01 cmbTipoHelado;
        private Clases.TextBox01 txtCantBochas;
        private Clases.TextBox01 txtStock;
        private Clases.TextBox01 txtPrecio;
        private Clases.TextBox01 txtNombre;
        private System.Windows.Forms.Label lblCantStock;
        private System.Windows.Forms.Label lblHelado;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantBochas;
        private System.Windows.Forms.Label lblNombre;
    }
}