namespace Practico.Formularios.Abm.HeladosEspeciales
{
    partial class FrmAltaHeladosEspeciales
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
            this.lblNuevoHeladoEspecial = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblHelado = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNombreHeladoEspecial = new System.Windows.Forms.Label();
            this.lblCantBochas = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCantBochas = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.cmbHelado = new Practico.Clases.ComboBox01();
            this.SuspendLayout();
            // 
            // lblNuevoHeladoEspecial
            // 
            this.lblNuevoHeladoEspecial.AutoSize = true;
            this.lblNuevoHeladoEspecial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNuevoHeladoEspecial.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lblNuevoHeladoEspecial.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNuevoHeladoEspecial.Location = new System.Drawing.Point(35, 40);
            this.lblNuevoHeladoEspecial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevoHeladoEspecial.Name = "lblNuevoHeladoEspecial";
            this.lblNuevoHeladoEspecial.Size = new System.Drawing.Size(242, 23);
            this.lblNuevoHeladoEspecial.TabIndex = 20;
            this.lblNuevoHeladoEspecial.Text = "Nuevo Helado Especial";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrecio.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrecio.Location = new System.Drawing.Point(197, 212);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(55, 19);
            this.lblPrecio.TabIndex = 23;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblHelado
            // 
            this.lblHelado.AutoSize = true;
            this.lblHelado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHelado.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblHelado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHelado.Location = new System.Drawing.Point(182, 106);
            this.lblHelado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHelado.Name = "lblHelado";
            this.lblHelado.Size = new System.Drawing.Size(64, 19);
            this.lblHelado.TabIndex = 29;
            this.lblHelado.Text = "Helado:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStock.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblStock.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStock.Location = new System.Drawing.Point(196, 246);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(50, 19);
            this.lblStock.TabIndex = 37;
            this.lblStock.Text = "Stock:";
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
            this.btnAceptar.Location = new System.Drawing.Point(343, 303);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(103, 40);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(230, 303);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 40);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNombreHeladoEspecial
            // 
            this.lblNombreHeladoEspecial.AutoSize = true;
            this.lblNombreHeladoEspecial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNombreHeladoEspecial.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblNombreHeladoEspecial.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombreHeladoEspecial.Location = new System.Drawing.Point(178, 144);
            this.lblNombreHeladoEspecial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreHeladoEspecial.Name = "lblNombreHeladoEspecial";
            this.lblNombreHeladoEspecial.Size = new System.Drawing.Size(68, 19);
            this.lblNombreHeladoEspecial.TabIndex = 21;
            this.lblNombreHeladoEspecial.Text = "Nombre:";
            // 
            // lblCantBochas
            // 
            this.lblCantBochas.AutoSize = true;
            this.lblCantBochas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCantBochas.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblCantBochas.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCantBochas.Location = new System.Drawing.Point(86, 178);
            this.lblCantBochas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantBochas.Name = "lblCantBochas";
            this.lblCantBochas.Size = new System.Drawing.Size(160, 19);
            this.lblCantBochas.TabIndex = 22;
            this.lblCantBochas.Text = "Cantidad de bochas:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(254, 142);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(164, 24);
            this.txtNombre.TabIndex = 38;
            // 
            // txtCantBochas
            // 
            this.txtCantBochas.Location = new System.Drawing.Point(254, 176);
            this.txtCantBochas.Name = "txtCantBochas";
            this.txtCantBochas.Size = new System.Drawing.Size(52, 24);
            this.txtCantBochas.TabIndex = 39;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(254, 210);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(52, 24);
            this.txtPrecio.TabIndex = 40;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(254, 244);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(52, 24);
            this.txtStock.TabIndex = 41;
            // 
            // cmbHelado
            // 
            this.cmbHelado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHelado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHelado.FormattingEnabled = true;
            this.cmbHelado.Location = new System.Drawing.Point(254, 103);
            this.cmbHelado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHelado.Name = "cmbHelado";
            this.cmbHelado.PpDisplay = "nombre";
            this.cmbHelado.PpMensajeError = "No se ingresó Helado";
            this.cmbHelado.PpNombreCampo = "";
            this.cmbHelado.PpNombreTabla = "Helados";
            this.cmbHelado.PpTabla = "Helados";
            this.cmbHelado.PpValidable = true;
            this.cmbHelado.PpValue = "idHelado";
            this.cmbHelado.Size = new System.Drawing.Size(164, 25);
            this.cmbHelado.TabIndex = 0;
            // 
            // FrmAltaHeladosEspeciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(634, 378);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantBochas);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblHelado);
            this.Controls.Add(this.cmbHelado);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCantBochas);
            this.Controls.Add(this.lblNombreHeladoEspecial);
            this.Controls.Add(this.lblNuevoHeladoEspecial);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAltaHeladosEspeciales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Helado Especial";
            this.Load += new System.EventHandler(this.FrmAltaHeladosEspeciales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevoHeladoEspecial;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblHelado;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNombreHeladoEspecial;
        private System.Windows.Forms.Label lblCantBochas;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCantBochas;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private Clases.ComboBox01 cmbHelado;
    }
}