﻿namespace Practico.Formularios.Procesos
{
    partial class FrmConsultarVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarVenta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblHelado = new System.Windows.Forms.Label();
            this.pnlHelados = new System.Windows.Forms.Panel();
            this.lblPrecioHelado = new System.Windows.Forms.Label();
            this.txtPrecioHelado = new Practico.Clases.TextBox01();
            this.btnConfirmarHelado = new System.Windows.Forms.Button();
            this.lblKilos = new System.Windows.Forms.Label();
            this.txtHelado = new Practico.Clases.TextBox01();
            this.cmbHelado = new Practico.Clases.ComboBox01();
            this.pnlEspecial = new System.Windows.Forms.Panel();
            this.lblPrecioEspecial = new System.Windows.Forms.Label();
            this.txtPrecioEspecial = new Practico.Clases.TextBox01();
            this.btnConfirmarEspecial = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtEspecial = new Practico.Clases.TextBox01();
            this.lblEspecial = new System.Windows.Forms.Label();
            this.cmbEspecial = new Practico.Clases.ComboBox01();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.lblTxtTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSigno = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEspecial = new System.Windows.Forms.Button();
            this.btnHelado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grdDetalleHelado = new Practico.Clases.Grid01();
            this.pnlHelados.SuspendLayout();
            this.pnlEspecial.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleHelado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(122)))), ((int)(((byte)(127)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnCerrar.Location = new System.Drawing.Point(724, 14);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(71, 41);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDetalle.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.lblDetalle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDetalle.Location = new System.Drawing.Point(19, 59);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(243, 33);
            this.lblDetalle.TabIndex = 46;
            this.lblDetalle.Text = "Detalle de Venta";
            // 
            // lblHelado
            // 
            this.lblHelado.AutoSize = true;
            this.lblHelado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHelado.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblHelado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHelado.Location = new System.Drawing.Point(21, 12);
            this.lblHelado.Name = "lblHelado";
            this.lblHelado.Size = new System.Drawing.Size(64, 19);
            this.lblHelado.TabIndex = 48;
            this.lblHelado.Text = "Helado:";
            // 
            // pnlHelados
            // 
            this.pnlHelados.Controls.Add(this.lblPrecioHelado);
            this.pnlHelados.Controls.Add(this.txtPrecioHelado);
            this.pnlHelados.Controls.Add(this.btnConfirmarHelado);
            this.pnlHelados.Controls.Add(this.lblKilos);
            this.pnlHelados.Controls.Add(this.txtHelado);
            this.pnlHelados.Controls.Add(this.lblHelado);
            this.pnlHelados.Controls.Add(this.cmbHelado);
            this.pnlHelados.Location = new System.Drawing.Point(110, 614);
            this.pnlHelados.Name = "pnlHelados";
            this.pnlHelados.Size = new System.Drawing.Size(492, 118);
            this.pnlHelados.TabIndex = 52;
            this.pnlHelados.Visible = false;
            // 
            // lblPrecioHelado
            // 
            this.lblPrecioHelado.AutoSize = true;
            this.lblPrecioHelado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrecioHelado.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblPrecioHelado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrecioHelado.Location = new System.Drawing.Point(241, 8);
            this.lblPrecioHelado.Name = "lblPrecioHelado";
            this.lblPrecioHelado.Size = new System.Drawing.Size(55, 19);
            this.lblPrecioHelado.TabIndex = 58;
            this.lblPrecioHelado.Text = "Precio:";
            // 
            // txtPrecioHelado
            // 
            this.txtPrecioHelado.BackColor = System.Drawing.Color.White;
            this.txtPrecioHelado.Enabled = false;
            this.txtPrecioHelado.Location = new System.Drawing.Point(302, 5);
            this.txtPrecioHelado.Name = "txtPrecioHelado";
            this.txtPrecioHelado.PpMensajeError = "No ingresó precio!";
            this.txtPrecioHelado.PpNombreCampo = null;
            this.txtPrecioHelado.PpNombreTabla = null;
            this.txtPrecioHelado.PpValidable = true;
            this.txtPrecioHelado.Size = new System.Drawing.Size(68, 24);
            this.txtPrecioHelado.TabIndex = 57;
            // 
            // btnConfirmarHelado
            // 
            this.btnConfirmarHelado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnConfirmarHelado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmarHelado.FlatAppearance.BorderSize = 0;
            this.btnConfirmarHelado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnConfirmarHelado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnConfirmarHelado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarHelado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarHelado.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConfirmarHelado.Image = global::Practico.Properties.Resources.add_to_cart;
            this.btnConfirmarHelado.Location = new System.Drawing.Point(88, 74);
            this.btnConfirmarHelado.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmarHelado.Name = "btnConfirmarHelado";
            this.btnConfirmarHelado.Size = new System.Drawing.Size(123, 40);
            this.btnConfirmarHelado.TabIndex = 54;
            this.btnConfirmarHelado.Text = "Confirmar";
            this.btnConfirmarHelado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmarHelado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmarHelado.UseVisualStyleBackColor = false;
            this.btnConfirmarHelado.Click += new System.EventHandler(this.btnConfirmarHelado_Click);
            // 
            // lblKilos
            // 
            this.lblKilos.AutoSize = true;
            this.lblKilos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblKilos.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblKilos.ForeColor = System.Drawing.SystemColors.Control;
            this.lblKilos.Location = new System.Drawing.Point(44, 42);
            this.lblKilos.Name = "lblKilos";
            this.lblKilos.Size = new System.Drawing.Size(41, 19);
            this.lblKilos.TabIndex = 52;
            this.lblKilos.Text = "Kilos:";
            // 
            // txtHelado
            // 
            this.txtHelado.BackColor = System.Drawing.Color.White;
            this.txtHelado.Location = new System.Drawing.Point(88, 35);
            this.txtHelado.Name = "txtHelado";
            this.txtHelado.PpMensajeError = "No ingresó kilos!";
            this.txtHelado.PpNombreCampo = null;
            this.txtHelado.PpNombreTabla = null;
            this.txtHelado.PpValidable = true;
            this.txtHelado.Size = new System.Drawing.Size(68, 24);
            this.txtHelado.TabIndex = 51;
            this.txtHelado.TextChanged += new System.EventHandler(this.txtHelado_TextChanged);
            // 
            // cmbHelado
            // 
            this.cmbHelado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHelado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHelado.FormattingEnabled = true;
            this.cmbHelado.Location = new System.Drawing.Point(88, 3);
            this.cmbHelado.Name = "cmbHelado";
            this.cmbHelado.PpDisplay = "nombre";
            this.cmbHelado.PpMensajeError = "No seleccionó helado!";
            this.cmbHelado.PpNombreCampo = null;
            this.cmbHelado.PpNombreTabla = null;
            this.cmbHelado.PpTabla = "Helados";
            this.cmbHelado.PpValidable = true;
            this.cmbHelado.PpValue = "idHelado";
            this.cmbHelado.Size = new System.Drawing.Size(123, 25);
            this.cmbHelado.TabIndex = 47;
            this.cmbHelado.SelectionChangeCommitted += new System.EventHandler(this.cmbHelado_SelectionChangeCommitted);
            // 
            // pnlEspecial
            // 
            this.pnlEspecial.Controls.Add(this.lblPrecioEspecial);
            this.pnlEspecial.Controls.Add(this.txtPrecioEspecial);
            this.pnlEspecial.Controls.Add(this.btnConfirmarEspecial);
            this.pnlEspecial.Controls.Add(this.lblCantidad);
            this.pnlEspecial.Controls.Add(this.txtEspecial);
            this.pnlEspecial.Controls.Add(this.lblEspecial);
            this.pnlEspecial.Controls.Add(this.cmbEspecial);
            this.pnlEspecial.Enabled = false;
            this.pnlEspecial.Location = new System.Drawing.Point(107, 614);
            this.pnlEspecial.Name = "pnlEspecial";
            this.pnlEspecial.Size = new System.Drawing.Size(492, 118);
            this.pnlEspecial.TabIndex = 2;
            this.pnlEspecial.Visible = false;
            // 
            // lblPrecioEspecial
            // 
            this.lblPrecioEspecial.AutoSize = true;
            this.lblPrecioEspecial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrecioEspecial.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblPrecioEspecial.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrecioEspecial.Location = new System.Drawing.Point(309, 10);
            this.lblPrecioEspecial.Name = "lblPrecioEspecial";
            this.lblPrecioEspecial.Size = new System.Drawing.Size(55, 19);
            this.lblPrecioEspecial.TabIndex = 56;
            this.lblPrecioEspecial.Text = "Precio:";
            // 
            // txtPrecioEspecial
            // 
            this.txtPrecioEspecial.BackColor = System.Drawing.Color.White;
            this.txtPrecioEspecial.Enabled = false;
            this.txtPrecioEspecial.Location = new System.Drawing.Point(370, 7);
            this.txtPrecioEspecial.Name = "txtPrecioEspecial";
            this.txtPrecioEspecial.PpMensajeError = "No ingresó precio!";
            this.txtPrecioEspecial.PpNombreCampo = null;
            this.txtPrecioEspecial.PpNombreTabla = null;
            this.txtPrecioEspecial.PpValidable = true;
            this.txtPrecioEspecial.Size = new System.Drawing.Size(68, 24);
            this.txtPrecioEspecial.TabIndex = 1;
            // 
            // btnConfirmarEspecial
            // 
            this.btnConfirmarEspecial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnConfirmarEspecial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmarEspecial.FlatAppearance.BorderSize = 0;
            this.btnConfirmarEspecial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnConfirmarEspecial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnConfirmarEspecial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarEspecial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarEspecial.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConfirmarEspecial.Image = global::Practico.Properties.Resources.add_to_cart;
            this.btnConfirmarEspecial.Location = new System.Drawing.Point(161, 74);
            this.btnConfirmarEspecial.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmarEspecial.Name = "btnConfirmarEspecial";
            this.btnConfirmarEspecial.Size = new System.Drawing.Size(123, 40);
            this.btnConfirmarEspecial.TabIndex = 3;
            this.btnConfirmarEspecial.Text = "Confirmar";
            this.btnConfirmarEspecial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmarEspecial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmarEspecial.UseVisualStyleBackColor = false;
            this.btnConfirmarEspecial.Click += new System.EventHandler(this.btnConfirmarEspecial_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCantidad.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCantidad.Location = new System.Drawing.Point(74, 42);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(81, 19);
            this.lblCantidad.TabIndex = 52;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtEspecial
            // 
            this.txtEspecial.BackColor = System.Drawing.Color.White;
            this.txtEspecial.Location = new System.Drawing.Point(161, 38);
            this.txtEspecial.Name = "txtEspecial";
            this.txtEspecial.PpMensajeError = "No ingresó cantidad!";
            this.txtEspecial.PpNombreCampo = null;
            this.txtEspecial.PpNombreTabla = null;
            this.txtEspecial.PpValidable = true;
            this.txtEspecial.Size = new System.Drawing.Size(68, 24);
            this.txtEspecial.TabIndex = 2;
            this.txtEspecial.TextChanged += new System.EventHandler(this.txtEspecial_TextChanged);
            // 
            // lblEspecial
            // 
            this.lblEspecial.AutoSize = true;
            this.lblEspecial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEspecial.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblEspecial.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEspecial.Location = new System.Drawing.Point(30, 10);
            this.lblEspecial.Name = "lblEspecial";
            this.lblEspecial.Size = new System.Drawing.Size(125, 19);
            this.lblEspecial.TabIndex = 48;
            this.lblEspecial.Text = "Helado Especial:";
            // 
            // cmbEspecial
            // 
            this.cmbEspecial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEspecial.FormattingEnabled = true;
            this.cmbEspecial.Location = new System.Drawing.Point(161, 4);
            this.cmbEspecial.Name = "cmbEspecial";
            this.cmbEspecial.PpDisplay = "nombreProducto";
            this.cmbEspecial.PpMensajeError = "No seleccionó helado especial!";
            this.cmbEspecial.PpNombreCampo = null;
            this.cmbEspecial.PpNombreTabla = null;
            this.cmbEspecial.PpTabla = "HeladosEspeciales";
            this.cmbEspecial.PpValidable = true;
            this.cmbEspecial.PpValue = "idHeladoEspecial";
            this.cmbEspecial.Size = new System.Drawing.Size(123, 25);
            this.cmbEspecial.TabIndex = 0;
            this.cmbEspecial.SelectionChangeCommitted += new System.EventHandler(this.cmbEspecial_SelectionChangeCommitted_1);
            // 
            // lblOpcion
            // 
            this.lblOpcion.AutoSize = true;
            this.lblOpcion.Enabled = false;
            this.lblOpcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOpcion.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblOpcion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOpcion.Location = new System.Drawing.Point(110, 372);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(174, 19);
            this.lblOpcion.TabIndex = 58;
            this.lblOpcion.Text = "Seleccione una opcion:";
            this.lblOpcion.Visible = false;
            // 
            // lblTxtTotal
            // 
            this.lblTxtTotal.AutoSize = true;
            this.lblTxtTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTxtTotal.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lblTxtTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTxtTotal.Location = new System.Drawing.Point(34, 19);
            this.lblTxtTotal.Name = "lblTxtTotal";
            this.lblTxtTotal.Size = new System.Drawing.Size(73, 28);
            this.lblTxtTotal.TabIndex = 57;
            this.lblTxtTotal.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotal.Location = new System.Drawing.Point(30, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(30, 32);
            this.lblTotal.TabIndex = 61;
            this.lblTotal.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblTxtTotal);
            this.panel1.Location = new System.Drawing.Point(588, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 121);
            this.panel1.TabIndex = 62;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.lblSigno);
            this.panel2.Location = new System.Drawing.Point(23, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 41);
            this.panel2.TabIndex = 63;
            // 
            // lblSigno
            // 
            this.lblSigno.AutoSize = true;
            this.lblSigno.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSigno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSigno.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.lblSigno.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSigno.Location = new System.Drawing.Point(0, 0);
            this.lblSigno.Name = "lblSigno";
            this.lblSigno.Size = new System.Drawing.Size(30, 32);
            this.lblSigno.TabIndex = 62;
            this.lblSigno.Text = "$";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAceptar);
            this.panel3.Controls.Add(this.btnConsultar);
            this.panel3.Controls.Add(this.btnLimpiar);
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Controls.Add(this.btnRegistrar);
            this.panel3.Location = new System.Drawing.Point(611, 258);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(202, 55);
            this.panel3.TabIndex = 3;
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
            this.btnAceptar.Image = global::Practico.Properties.Resources.floppy_disk;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(4, 4);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(194, 40);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultar.Enabled = false;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(4, 162);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(194, 40);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Habilitar Modificacion";
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Visible = false;
            this.btnConsultar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.Image = global::Practico.Properties.Resources.trash;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(4, 210);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(194, 40);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Visible = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Image = global::Practico.Properties.Resources.remove;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(4, 114);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(194, 40);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar Item";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistrar.Image = global::Practico.Properties.Resources.floppy_disk;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(4, 66);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(194, 40);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar Modificacion";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Visible = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(268, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 48);
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // btnEspecial
            // 
            this.btnEspecial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnEspecial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEspecial.Enabled = false;
            this.btnEspecial.FlatAppearance.BorderSize = 0;
            this.btnEspecial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnEspecial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnEspecial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEspecial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspecial.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEspecial.Image = global::Practico.Properties.Resources.plus;
            this.btnEspecial.Location = new System.Drawing.Point(375, 543);
            this.btnEspecial.Margin = new System.Windows.Forms.Padding(4);
            this.btnEspecial.Name = "btnEspecial";
            this.btnEspecial.Size = new System.Drawing.Size(170, 51);
            this.btnEspecial.TabIndex = 1;
            this.btnEspecial.Text = "Agregar Helado Especial";
            this.btnEspecial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEspecial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEspecial.UseVisualStyleBackColor = false;
            this.btnEspecial.Visible = false;
            this.btnEspecial.Click += new System.EventHandler(this.btnEspecial_Click);
            // 
            // btnHelado
            // 
            this.btnHelado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnHelado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelado.Enabled = false;
            this.btnHelado.FlatAppearance.BorderSize = 0;
            this.btnHelado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnHelado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnHelado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelado.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHelado.Image = global::Practico.Properties.Resources.plus;
            this.btnHelado.Location = new System.Drawing.Point(96, 543);
            this.btnHelado.Margin = new System.Windows.Forms.Padding(4);
            this.btnHelado.Name = "btnHelado";
            this.btnHelado.Size = new System.Drawing.Size(170, 51);
            this.btnHelado.TabIndex = 0;
            this.btnHelado.Text = "Agregar Helado";
            this.btnHelado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelado.UseVisualStyleBackColor = false;
            this.btnHelado.Visible = false;
            this.btnHelado.Click += new System.EventHandler(this.btnHelado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 33);
            this.label1.TabIndex = 63;
            this.label1.Text = "Consultar";
            // 
            // grdDetalleHelado
            // 
            this.grdDetalleHelado.AllowUserToAddRows = false;
            this.grdDetalleHelado.AllowUserToDeleteRows = false;
            this.grdDetalleHelado.AllowUserToResizeColumns = false;
            this.grdDetalleHelado.AllowUserToResizeRows = false;
            this.grdDetalleHelado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.grdDetalleHelado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdDetalleHelado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDetalleHelado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDetalleHelado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDetalleHelado.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdDetalleHelado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.grdDetalleHelado.Location = new System.Drawing.Point(12, 142);
            this.grdDetalleHelado.Name = "grdDetalleHelado";
            this.grdDetalleHelado.ReadOnly = true;
            this.grdDetalleHelado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDetalleHelado.Size = new System.Drawing.Size(570, 294);
            this.grdDetalleHelado.TabIndex = 5;
            this.grdDetalleHelado.tabla = null;
            // 
            // FrmConsultarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(892, 477);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlEspecial);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grdDetalleHelado);
            this.Controls.Add(this.lblOpcion);
            this.Controls.Add(this.btnEspecial);
            this.Controls.Add(this.btnHelado);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlHelados);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Venta";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            this.pnlHelados.ResumeLayout(false);
            this.pnlHelados.PerformLayout();
            this.pnlEspecial.ResumeLayout(false);
            this.pnlEspecial.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleHelado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblDetalle;
        private Clases.ComboBox01 cmbHelado;
        private System.Windows.Forms.Label lblHelado;
        private Clases.TextBox01 txtHelado;
        private System.Windows.Forms.Panel pnlHelados;
        private System.Windows.Forms.Panel pnlEspecial;
        private System.Windows.Forms.Label lblCantidad;
        private Clases.TextBox01 txtEspecial;
        private System.Windows.Forms.Label lblEspecial;
        private Clases.ComboBox01 cmbEspecial;
        private System.Windows.Forms.Label lblKilos;
        private System.Windows.Forms.Button btnHelado;
        private System.Windows.Forms.Button btnEspecial;
        private System.Windows.Forms.Button btnConfirmarHelado;
        private System.Windows.Forms.Button btnConfirmarEspecial;
        private System.Windows.Forms.Label lblOpcion;
        private System.Windows.Forms.Label lblPrecioEspecial;
        private Clases.TextBox01 txtPrecioEspecial;
        private System.Windows.Forms.Label lblPrecioHelado;
        private Clases.TextBox01 txtPrecioHelado;
        private Clases.Grid01 grdDetalleHelado;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblTxtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSigno;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAceptar;
    }
}
