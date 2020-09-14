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
        Negocios.TipoDocumento tipoDoc = new Negocios.TipoDocumento();
        Negocios.ProveedoresHelados proveedoresHelados = new Negocios.ProveedoresHelados();
        Negocios.Proveedores proveedores = new Negocios.Proveedores();
        Negocios.Helados helados = new Negocios.Helados();

        public string tipoDocumento { get; set; }
        public string nroDocumento { get; set; }
        public string idHelado { get; set; }
        public string razonSocial { get; set; }
       
        public FrmConsultarProveedoresHelados()
        {
            InitializeComponent();
        }

        private void FrmAltaProveedoresHelados_Load(object sender, EventArgs e)
        {
            cmbTipoDoc.cargar(tipoDoc.EstrCombo());
            cmbNroDoc.cargar(proveedores.EstrCombo());
            cmbIdHelado.cargar(helados.EstrCombo());
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
            cmbNroDoc.SelectedIndex = cmbNroDoc.FindStringExact(razonSocial);
            cmbIdHelado.SelectedIndex = cmbIdHelado.FindStringExact(idHelado);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
