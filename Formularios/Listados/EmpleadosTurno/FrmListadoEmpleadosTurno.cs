﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Practico.Clases;
using Practico.Negocios;

namespace Practico.Formularios.Listados
{
    public partial class FrmListadoEmpleados : Form
    {
        public FrmListadoEmpleados()
        {
            InitializeComponent();
        }

        private void FrmListadoEmpleados_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            cmbTurno.Cargar();
            cargarListado();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbTurno.SelectedIndex != -1)
            {
               cargarListado();
            }
            else
            {
                MessageBox.Show("Seleccione un item!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarListado()
        {
            DataTable tabla = new DataTable();
            Empleados empleados = new Empleados();
            tabla = empleados.ListadoEmpleadosTurno(cmbTurno.SelectedValue.ToString());

            ReportDataSource data = new ReportDataSource("DatosEmpleados", tabla);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(data);
            reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void cmbTurno_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }
    }
}
