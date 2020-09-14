namespace Practico.Formularios.Abm.HeladosEspeciales
{
    partial class FrmEliminarHeladosEspeciales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEliminarHeladosEspeciales));
            this.lblEliminarHeladoEspecial = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCantBochas = new Practico.Clases.TextBox01();
            this.txtStock = new Practico.Clases.TextBox01();
            this.txtPrecio = new Practico.Clases.TextBox01();
            this.txtNombre = new Practico.Clases.TextBox01();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblHelado = new System.Windows.Forms.Label();
            this.cmbTipoHelado = new Practico.Clases.ComboBox01();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantBochas = new System.Windows.Forms.Label();
            this.lblNombreHeladoEspecial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEliminarHeladoEspecial
            // 
            this.lblEliminarHeladoEspecial.AutoSize = true;
            this.lblEliminarHeladoEspecial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEliminarHeladoEspecial.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lblEliminarHeladoEspecial.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEliminarHeladoEspecial.Location = new System.Drawing.Point(34, 42);
            this.lblEliminarHeladoEspecial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEliminarHeladoEspecial.Name = "lblEliminarHeladoEspecial";
            this.lblEliminarHeladoEspecial.Size = new System.Drawing.Size(249, 23);
            this.lblEliminarHeladoEspecial.TabIndex = 20;
            this.lblEliminarHeladoEspecial.Text = "Eliminar Helado Especial";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConfirmar.Location = new System.Drawing.Point(285, 273);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(5);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(103, 40);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(174, 273);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 40);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCantBochas
            // 
            this.txtCantBochas.Enabled = false;
            this.txtCantBochas.Location = new System.Drawing.Point(285, 165);
            this.txtCantBochas.Name = "txtCantBochas";
            this.txtCantBochas.PpMensajeError = "Ingrese la cantidad de bochas!";
            this.txtCantBochas.PpNombreCampo = "cantBochas";
            this.txtCantBochas.PpNombreTabla = "HeladosEspeciales";
            this.txtCantBochas.PpValidable = true;
            this.txtCantBochas.Size = new System.Drawing.Size(65, 24);
            this.txtCantBochas.TabIndex = 59;
            // 
            // txtStock
            // 
            this.txtStock.Enabled = false;
            this.txtStock.Location = new System.Drawing.Point(285, 225);
            this.txtStock.Name = "txtStock";
            this.txtStock.PpMensajeError = "Ingrese el stock!";
            this.txtStock.PpNombreCampo = "cantidadStock";
            this.txtStock.PpNombreTabla = "HeladosEspeciales";
            this.txtStock.PpValidable = false;
            this.txtStock.Size = new System.Drawing.Size(65, 24);
            this.txtStock.TabIndex = 58;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(285, 195);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PpMensajeError = "Ingrese el precio!";
            this.txtPrecio.PpNombreCampo = "precio";
            this.txtPrecio.PpNombreTabla = "HeladosEspeciales";
            this.txtPrecio.PpValidable = true;
            this.txtPrecio.Size = new System.Drawing.Size(65, 24);
            this.txtPrecio.TabIndex = 57;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(285, 135);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PpMensajeError = "Ingrese un nombre!";
            this.txtNombre.PpNombreCampo = "nombreProducto";
            this.txtNombre.PpNombreTabla = "HeladosEspeciales";
            this.txtNombre.PpValidable = true;
            this.txtNombre.Size = new System.Drawing.Size(161, 24);
            this.txtNombre.TabIndex = 56;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStock.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblStock.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStock.Location = new System.Drawing.Point(233, 230);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(50, 19);
            this.lblStock.TabIndex = 55;
            this.lblStock.Text = "Stock:";
            // 
            // lblHelado
            // 
            this.lblHelado.AutoSize = true;
            this.lblHelado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHelado.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblHelado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHelado.Location = new System.Drawing.Point(219, 106);
            this.lblHelado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHelado.Name = "lblHelado";
            this.lblHelado.Size = new System.Drawing.Size(64, 19);
            this.lblHelado.TabIndex = 54;
            this.lblHelado.Text = "Helado:";
            // 
            // cmbTipoHelado
            // 
            this.cmbTipoHelado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoHelado.Enabled = false;
            this.cmbTipoHelado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoHelado.FormattingEnabled = true;
            this.cmbTipoHelado.Location = new System.Drawing.Point(285, 103);
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
            this.cmbTipoHelado.TabIndex = 50;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrecio.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrecio.Location = new System.Drawing.Point(228, 200);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(55, 19);
            this.lblPrecio.TabIndex = 53;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblCantBochas
            // 
            this.lblCantBochas.AutoSize = true;
            this.lblCantBochas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCantBochas.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblCantBochas.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCantBochas.Location = new System.Drawing.Point(123, 171);
            this.lblCantBochas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantBochas.Name = "lblCantBochas";
            this.lblCantBochas.Size = new System.Drawing.Size(160, 19);
            this.lblCantBochas.TabIndex = 52;
            this.lblCantBochas.Text = "Cantidad de bochas:";
            // 
            // lblNombreHeladoEspecial
            // 
            this.lblNombreHeladoEspecial.AutoSize = true;
            this.lblNombreHeladoEspecial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombreHeladoEspecial.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblNombreHeladoEspecial.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombreHeladoEspecial.Location = new System.Drawing.Point(215, 141);
            this.lblNombreHeladoEspecial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreHeladoEspecial.Name = "lblNombreHeladoEspecial";
            this.lblNombreHeladoEspecial.Size = new System.Drawing.Size(68, 19);
            this.lblNombreHeladoEspecial.TabIndex = 51;
            this.lblNombreHeladoEspecial.Text = "Nombre:";
            // 
            // FrmEliminarHeladosEspeciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(578, 355);
            this.Controls.Add(this.txtCantBochas);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblHelado);
            this.Controls.Add(this.cmbTipoHelado);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCantBochas);
            this.Controls.Add(this.lblNombreHeladoEspecial);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblEliminarHeladoEspecial);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEliminarHeladosEspeciales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Helado Especial";
            this.Load += new System.EventHandler(this.FrmModificarHeladosEspeciales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEliminarHeladoEspecial;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private Clases.TextBox01 txtCantBochas;
        private Clases.TextBox01 txtStock;
        private Clases.TextBox01 txtPrecio;
        private Clases.TextBox01 txtNombre;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblHelado;
        private Clases.ComboBox01 cmbTipoHelado;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantBochas;
        private System.Windows.Forms.Label lblNombreHeladoEspecial;
    }
}