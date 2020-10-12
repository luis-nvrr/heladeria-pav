using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico.Formularios.Listados.Ventas
{
    public partial class FrmListadoVentasEmpleado : Form
    {
        public FrmListadoVentasEmpleado()
        {
            InitializeComponent();
        }

        private void FrmListadoVentasEmpleado_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            cmbEmpleado.Cargar();
            CargarListado();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbEmpleado.SelectedIndex != -1)
            {
                CargarListado();
            }
            else
            {
                MessageBox.Show("Seleccione un item!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarListado()
        {
            DataTable tabla = new DataTable();
            Negocios.Ventas ventas = new Negocios.Ventas();
            tabla = ventas.listadoVentasEmpleado(cmbEmpleado.SelectedValue.ToString());

            ReportDataSource data = new ReportDataSource("DatosVentas", tabla);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(data);
            reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
            reportViewer1.Show();
        }
    }
}
