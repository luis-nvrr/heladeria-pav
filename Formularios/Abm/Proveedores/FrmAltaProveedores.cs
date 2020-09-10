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

namespace Practico.Formularios.Abm.Proveedores
{
    public partial class FrmAltaProveedores : Form
    {
        Negocios.TiposDocumento tipoDoc = new Negocios.TiposDocumento();
        Negocios.Barrios barrio = new Negocios.Barrios();

        public FrmAltaProveedores()
        {
            InitializeComponent();
        }

        private void FrmAltaProveedores_Load(object sender, EventArgs e)
        {
            cmbTipoDoc.cargar(tipoDoc.EstrCombo());
            cmbBarrio.cargar(barrio.EstrCombo());
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();

            if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                Negocios.Proveedores proveedor = new Negocios.Proveedores();
                if (proveedor.Insertar(this.Controls) == Negocios.Proveedores.Respuesta.validacionCorrecta)
                {
                    MessageBox.Show("Ingresado correctamente!", "Informacion",
                        buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error...", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void LimpiarCampos()
        {
            txtNroDoc.Text = "";
            txtRazónSocial.Text = "";
            txtEmail.Text = "";
            txtCalle.Text = "";
            txtNroCalle.Text = "";
            txtTelCel.Text = "";
            txtTelFijo.Text = "";
            cmbBarrio.SelectedIndex = -1;
            cmbTipoDoc.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
