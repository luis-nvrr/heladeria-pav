using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practico.Negocios;

namespace Practico.Formularios.Abm.Proveedores
{
    public partial class FrmAltaProveedores : Form
    {
        Negocios.TiposDocumento tipoDoc = new Negocios.TiposDocumento();
        Negocios.Barrios barrios = new Negocios.Barrios();
        public FrmAltaProveedores()
        {
            InitializeComponent();
        }

        private void FrmAltaProveedores_Load(object sender, EventArgs e)
        {
            cmbTipoDoc.cargar(tipoDoc.EstrCombo());
            cmbBarrios.cargar(barrios.EstrCombo());
        }
    }
}
