namespace Practico.Formularios.Procesos
{
    partial class FrmAltaVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaVenta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEscritorio = new System.Windows.Forms.Button();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblHelado = new System.Windows.Forms.Label();
            this.pnlHelados = new System.Windows.Forms.Panel();
            this.lblPrecioHelado = new System.Windows.Forms.Label();
            this.lblKilos = new System.Windows.Forms.Label();
            this.pnlEspecial = new System.Windows.Forms.Panel();
            this.lblPrecioEspecial = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblEspecial = new System.Windows.Forms.Label();
            this.lblOpcion = new System.Windows.Forms.Label();
            this.lblTxtTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSigno = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnConfirmarEspecial = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEspecial = new System.Windows.Forms.Button();
            this.btnHelado = new System.Windows.Forms.Button();
            this.btnConfirmarHelado = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPrecioEspecial = new Practico.Clases.TextBox01();
            this.txtEspecial = new Practico.Clases.TextBox01();
            this.cmbEspecial = new Practico.Clases.ComboBox01();
            this.grdDetalleHelado = new Practico.Clases.Grid01();
            this.txtPrecioHelado = new Practico.Clases.TextBox01();
            this.txtHelado = new Practico.Clases.TextBox01();
            this.cmbHelado = new Practico.Clases.ComboBox01();
            this.pnlHelados.SuspendLayout();
            this.pnlEspecial.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleHelado)).BeginInit();
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
            this.btnEscritorio.Location = new System.Drawing.Point(591, 29);
            this.btnEscritorio.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnEscritorio.Name = "btnEscritorio";
            this.btnEscritorio.Size = new System.Drawing.Size(166, 63);
            this.btnEscritorio.TabIndex = 14;
            this.btnEscritorio.Text = "Volver Al Escritorio";
            this.btnEscritorio.UseVisualStyleBackColor = false;
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
            this.pnlHelados.Location = new System.Drawing.Point(64, 214);
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
            // pnlEspecial
            // 
            this.pnlEspecial.Controls.Add(this.lblPrecioEspecial);
            this.pnlEspecial.Controls.Add(this.txtPrecioEspecial);
            this.pnlEspecial.Controls.Add(this.btnConfirmarEspecial);
            this.pnlEspecial.Controls.Add(this.lblCantidad);
            this.pnlEspecial.Controls.Add(this.txtEspecial);
            this.pnlEspecial.Controls.Add(this.lblEspecial);
            this.pnlEspecial.Controls.Add(this.cmbEspecial);
            this.pnlEspecial.Location = new System.Drawing.Point(63, 214);
            this.pnlEspecial.Name = "pnlEspecial";
            this.pnlEspecial.Size = new System.Drawing.Size(492, 118);
            this.pnlEspecial.TabIndex = 53;
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
            // lblOpcion
            // 
            this.lblOpcion.AutoSize = true;
            this.lblOpcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOpcion.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblOpcion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOpcion.Location = new System.Drawing.Point(60, 108);
            this.lblOpcion.Name = "lblOpcion";
            this.lblOpcion.Size = new System.Drawing.Size(179, 19);
            this.lblOpcion.TabIndex = 58;
            this.lblOpcion.Text = "Selecciones una opcion:";
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
            this.panel1.Location = new System.Drawing.Point(582, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 121);
            this.panel1.TabIndex = 62;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.lblSigno);
            this.panel2.Location = new System.Drawing.Point(23, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 41);
            this.panel2.TabIndex = 63;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.Image = global::Practico.Properties.Resources.trash;
            this.btnLimpiar.Location = new System.Drawing.Point(4, 108);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(161, 40);
            this.btnLimpiar.TabIndex = 63;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Image = global::Practico.Properties.Resources.remove;
            this.btnEliminar.Location = new System.Drawing.Point(4, 60);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(161, 40);
            this.btnEliminar.TabIndex = 60;
            this.btnEliminar.Text = "Eliminar Item";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnConfirmarEspecial.TabIndex = 54;
            this.btnConfirmarEspecial.Text = "Confirmar";
            this.btnConfirmarEspecial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmarEspecial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmarEspecial.UseVisualStyleBackColor = false;
            this.btnConfirmarEspecial.Click += new System.EventHandler(this.btnConfirmarEspecial_Click);
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
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistrar.Image = global::Practico.Properties.Resources.floppy_disk;
            this.btnRegistrar.Location = new System.Drawing.Point(4, 12);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(161, 40);
            this.btnRegistrar.TabIndex = 57;
            this.btnRegistrar.Text = "Registrar Venta";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // btnEspecial
            // 
            this.btnEspecial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnEspecial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEspecial.FlatAppearance.BorderSize = 0;
            this.btnEspecial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnEspecial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnEspecial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEspecial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspecial.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEspecial.Image = global::Practico.Properties.Resources.plus;
            this.btnEspecial.Location = new System.Drawing.Point(294, 140);
            this.btnEspecial.Margin = new System.Windows.Forms.Padding(4);
            this.btnEspecial.Name = "btnEspecial";
            this.btnEspecial.Size = new System.Drawing.Size(170, 51);
            this.btnEspecial.TabIndex = 54;
            this.btnEspecial.Text = "Agregar Helado Especial";
            this.btnEspecial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEspecial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEspecial.UseVisualStyleBackColor = false;
            this.btnEspecial.Click += new System.EventHandler(this.btnEspecial_Click);
            // 
            // btnHelado
            // 
            this.btnHelado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnHelado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelado.FlatAppearance.BorderSize = 0;
            this.btnHelado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnHelado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnHelado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelado.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHelado.Image = global::Practico.Properties.Resources.plus;
            this.btnHelado.Location = new System.Drawing.Point(80, 140);
            this.btnHelado.Margin = new System.Windows.Forms.Padding(4);
            this.btnHelado.Name = "btnHelado";
            this.btnHelado.Size = new System.Drawing.Size(170, 51);
            this.btnHelado.TabIndex = 53;
            this.btnHelado.Text = "Agregar Helado";
            this.btnHelado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelado.UseVisualStyleBackColor = false;
            this.btnHelado.Click += new System.EventHandler(this.btnHelado_Click);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLimpiar);
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Controls.Add(this.btnRegistrar);
            this.panel3.Location = new System.Drawing.Point(582, 344);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(178, 159);
            this.panel3.TabIndex = 64;
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
            this.txtPrecioEspecial.Size = new System.Drawing.Size(68, 23);
            this.txtPrecioEspecial.TabIndex = 55;
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
            this.txtEspecial.Size = new System.Drawing.Size(68, 23);
            this.txtEspecial.TabIndex = 51;
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
            this.cmbEspecial.TabIndex = 47;
            this.cmbEspecial.SelectionChangeCommitted += new System.EventHandler(this.cmbEspecial_SelectionChangeCommitted_1);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDetalleHelado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdDetalleHelado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDetalleHelado.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdDetalleHelado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.grdDetalleHelado.Location = new System.Drawing.Point(25, 357);
            this.grdDetalleHelado.Name = "grdDetalleHelado";
            this.grdDetalleHelado.ReadOnly = true;
            this.grdDetalleHelado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDetalleHelado.Size = new System.Drawing.Size(550, 160);
            this.grdDetalleHelado.TabIndex = 45;
            this.grdDetalleHelado.tabla = null;
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
            this.txtPrecioHelado.Size = new System.Drawing.Size(68, 23);
            this.txtPrecioHelado.TabIndex = 57;
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
            this.txtHelado.Size = new System.Drawing.Size(68, 23);
            this.txtHelado.TabIndex = 51;
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
            // FrmAltaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(796, 665);
            this.Controls.Add(this.pnlEspecial);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grdDetalleHelado);
            this.Controls.Add(this.lblOpcion);
            this.Controls.Add(this.btnEspecial);
            this.Controls.Add(this.btnHelado);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.btnEscritorio);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlHelados);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAltaVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Venta";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            this.pnlHelados.ResumeLayout(false);
            this.pnlHelados.PerformLayout();
            this.pnlEspecial.ResumeLayout(false);
            this.pnlEspecial.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleHelado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEscritorio;
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
    }
}