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
using Practico.Clases;

namespace Practico.Formularios.Abm.ProveedoresHelados
{
    public partial class FrmConsultarProveedoresHelados : Form
    {
        Negocios.TiposDocumento tipoDoc = new Negocios.TiposDocumento();
        Negocios.ProveedoresHelados proveedoresHelados = new Negocios.ProveedoresHelados();

        public string tipoDocumento { get; set; }
        public string nroDocumento { get; set; }
        public string idHelado { get; set; }
        public FrmConsultarProveedoresHelados()
        {
            InitializeComponent();
        }

        private void FrmAltaProveedoresHelados_Load(object sender, EventArgs e)
        {
            cmbTipoDoc.cargar(tipoDoc.EstrCombo());
            CargarCampos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarCampos()
        {
            DataTable tabla = new DataTable();
            tabla = proveedoresHelados.RecuperarProoveedorHelado(tipoDocumento, nroDocumento,idHelado);
            cmbTipoDoc.SelectedIndex = cmbTipoDoc.FindStringExact(tipoDocumento);
            txtNroDoc.Text = tabla.Rows[0]["nroDocProveedor"].ToString();
            txtIdHelado.Text = tabla.Rows[0]["idHelado"].ToString();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
