namespace Practico.Formularios.Listados.Ventas
{
    partial class FrmListadoVentasEmpleado
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
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblTurno = new System.Windows.Forms.Label();
            this.cmbEmpleado = new Practico.Clases.ComboBox01();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmpleados.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.lblEmpleados.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmpleados.Location = new System.Drawing.Point(12, 18);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(299, 33);
            this.lblEmpleados.TabIndex = 48;
            this.lblEmpleados.Text = "Ventas Por Empleado";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Image = global::Practico.Properties.Resources.magnifying_glass;
            this.btnBuscar.Location = new System.Drawing.Point(292, 72);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(123, 40);
            this.btnBuscar.TabIndex = 83;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTurno.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblTurno.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTurno.Location = new System.Drawing.Point(54, 84);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(89, 19);
            this.lblTurno.TabIndex = 84;
            this.lblTurno.Text = "Empleado: ";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(149, 82);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.PpDisplay = "nombre";
            this.cmbEmpleado.PpMensajeError = null;
            this.cmbEmpleado.PpNombreCampo = null;
            this.cmbEmpleado.PpNombreTabla = null;
            this.cmbEmpleado.PpTabla = "Empleados";
            this.cmbEmpleado.PpValidable = true;
            this.cmbEmpleado.PpValue = "nombre";
            this.cmbEmpleado.Size = new System.Drawing.Size(123, 21);
            this.cmbEmpleado.TabIndex = 85;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportViewer1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Practico.Formularios.Listados.Ventas.ListadoVentasEmpleado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 119);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(560, 238);
            this.reportViewer1.TabIndex = 86;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // FrmListadoVentasEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblEmpleados);
            this.Name = "FrmListadoVentasEmpleado";
            this.Text = "FrmListadoVentasEmpleado";
            this.Load += new System.EventHandler(this.FrmListadoVentasEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTurno;
        private Clases.ComboBox01 cmbEmpleado;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}