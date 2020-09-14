namespace Practico.Formularios.Abm.ProveedoresHelados
{
    partial class FrmConsultarProveedoresHelados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarProveedoresHelados));
            this.lblNuevoProveedor = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.cmbTipoDoc = new Practico.Clases.ComboBox01();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.lblIdHelado = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cmbNroDoc = new Practico.Clases.ComboBox01();
            this.cmbIdHelado = new Practico.Clases.ComboBox01();
            this.SuspendLayout();
            // 
            // lblNuevoProveedor
            // 
            this.lblNuevoProveedor.AutoSize = true;
            this.lblNuevoProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNuevoProveedor.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lblNuevoProveedor.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNuevoProveedor.Location = new System.Drawing.Point(35, 40);
            this.lblNuevoProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevoProveedor.Name = "lblNuevoProveedor";
            this.lblNuevoProveedor.Size = new System.Drawing.Size(324, 23);
            this.lblNuevoProveedor.TabIndex = 21;
            this.lblNuevoProveedor.Text = "Consultar Proveedor de Helado";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTipoDoc.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblTipoDoc.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTipoDoc.Location = new System.Drawing.Point(97, 131);
            this.lblTipoDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(149, 19);
            this.lblTipoDoc.TabIndex = 30;
            this.lblTipoDoc.Text = "Tipo de Documento:";
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDoc.Enabled = false;
            this.cmbTipoDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(254, 130);
            this.cmbTipoDoc.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.PpDisplay = "";
            this.cmbTipoDoc.PpMensajeError = "No se ingresó Tipo de Documento !";
            this.cmbTipoDoc.PpNombreCampo = "tipoDocProveedor";
            this.cmbTipoDoc.PpNombreTabla = "ProveedoresHelados";
            this.cmbTipoDoc.PpTabla = null;
            this.cmbTipoDoc.PpValidable = true;
            this.cmbTipoDoc.PpValue = null;
            this.cmbTipoDoc.Size = new System.Drawing.Size(202, 25);
            this.cmbTipoDoc.TabIndex = 31;
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNroDoc.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblNroDoc.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNroDoc.Location = new System.Drawing.Point(70, 169);
            this.lblNroDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(176, 19);
            this.lblNroDoc.TabIndex = 32;
            this.lblNroDoc.Text = "Número de Documento:";
            // 
            // lblIdHelado
            // 
            this.lblIdHelado.AutoSize = true;
            this.lblIdHelado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIdHelado.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblIdHelado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIdHelado.Location = new System.Drawing.Point(165, 198);
            this.lblIdHelado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdHelado.Name = "lblIdHelado";
            this.lblIdHelado.Size = new System.Drawing.Size(81, 19);
            this.lblIdHelado.TabIndex = 34;
            this.lblIdHelado.Text = "Id Helado:";
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
            this.btnCancelar.Location = new System.Drawing.Point(230, 247);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 40);
            this.btnCancelar.TabIndex = 1;
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
            this.btnAceptar.Location = new System.Drawing.Point(343, 247);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(103, 40);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cmbNroDoc
            // 
            this.cmbNroDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNroDoc.Enabled = false;
            this.cmbNroDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNroDoc.FormattingEnabled = true;
            this.cmbNroDoc.Location = new System.Drawing.Point(254, 163);
            this.cmbNroDoc.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNroDoc.Name = "cmbNroDoc";
            this.cmbNroDoc.PpDisplay = "";
            this.cmbNroDoc.PpMensajeError = "No se ingresó Número de Documento !";
            this.cmbNroDoc.PpNombreCampo = "nroDocProveedor";
            this.cmbNroDoc.PpNombreTabla = "ProveedoresHelados";
            this.cmbNroDoc.PpTabla = "";
            this.cmbNroDoc.PpValidable = true;
            this.cmbNroDoc.PpValue = "";
            this.cmbNroDoc.Size = new System.Drawing.Size(202, 25);
            this.cmbNroDoc.TabIndex = 38;
            // 
            // cmbIdHelado
            // 
            this.cmbIdHelado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdHelado.Enabled = false;
            this.cmbIdHelado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbIdHelado.FormattingEnabled = true;
            this.cmbIdHelado.Location = new System.Drawing.Point(254, 196);
            this.cmbIdHelado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbIdHelado.Name = "cmbIdHelado";
            this.cmbIdHelado.PpDisplay = "";
            this.cmbIdHelado.PpMensajeError = "No se ingresó Id Helado !";
            this.cmbIdHelado.PpNombreCampo = "idHelado";
            this.cmbIdHelado.PpNombreTabla = "ProveedoresHelados";
            this.cmbIdHelado.PpTabla = null;
            this.cmbIdHelado.PpValidable = true;
            this.cmbIdHelado.PpValue = null;
            this.cmbIdHelado.Size = new System.Drawing.Size(202, 25);
            this.cmbIdHelado.TabIndex = 39;
            // 
            // FrmConsultarProveedoresHelados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(498, 319);
            this.Controls.Add(this.cmbIdHelado);
            this.Controls.Add(this.cmbNroDoc);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblIdHelado);
            this.Controls.Add(this.lblNroDoc);
            this.Controls.Add(this.cmbTipoDoc);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.lblNuevoProveedor);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultarProveedoresHelados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Proveedor de Helado";
            this.Load += new System.EventHandler(this.FrmAltaProveedoresHelados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevoProveedor;
        private System.Windows.Forms.Label lblTipoDoc;
        private Clases.ComboBox01 cmbTipoDoc;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.Label lblIdHelado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private Clases.ComboBox01 cmbNroDoc;
        private Clases.ComboBox01 cmbIdHelado;
    }
}