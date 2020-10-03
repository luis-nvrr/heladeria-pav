using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Practico.Formularios.Listados.Helados
{
    public partial class FrmListadoHelados : Form
    {
        public FrmListadoHelados()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            Negocios.Helados helados = new Negocios.Helados();
            tabla = helados.TodosLosHelados();

            ReportDataSource data = new ReportDataSource("DatosHelados", tabla);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(data);
            reportViewer1.LocalReport.Refresh();
        }

        private void FrmListadoHelados_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
