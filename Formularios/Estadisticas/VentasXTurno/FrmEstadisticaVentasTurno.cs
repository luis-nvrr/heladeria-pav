using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico.Formularios.Estadisticas.VentasXTurno
{
    public partial class FrmEstadisticaVentasTurno : Form
    {
        public FrmEstadisticaVentasTurno()
        {
            InitializeComponent();
        }

        private void FrmEstadisticaVentasTurno_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
