﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practico.Formularios.Estadisticas.CantidadVentasEmpleados;
using Practico.Formularios.Estadisticas.VentasPorHeladosPeriodo;

namespace Practico.Formularios.Presentacion
{
    public partial class FrmEstadisticas : Form
    {
        public FrmEstadisticas()
        {
            InitializeComponent();
        }

        private void abrirFormulario(Form formulario) // usar para abrir CUALQUIER FORMULARIO
        {
            Panel esteFormulario = this.Parent as Panel;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.TopLevel = false;
            formulario.AutoScroll = true;
            esteFormulario.Controls.Add(formulario);
            formulario.Show();
            this.Close();

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmEstadisticaVentasPorHeladosPeriodo());
        }

        private void btnVentasPorEmpleados_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmEstadisticaCantidadVentasEmpleados());
        }
    }
}
