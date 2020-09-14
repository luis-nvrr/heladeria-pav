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
    public partial class FrmAltaProveedoresHelados : Form
    {
        Negocios.TiposDocumento tipoDoc = new Negocios.TiposDocumento();
        Negocios.ProveedoresHelados proveedoresHelados = new Negocios.ProveedoresHelados();
        public FrmAltaProveedoresHelados()
        {
            InitializeComponent();
        }

        private void FrmAltaProveedoresHelados_Load(object sender, EventArgs e)
        {
            cmbTipoDoc.cargar(tipoDoc.EstrCombo());
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();

            if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                
                if (proveedoresHelados.Insertar(this.Controls) == Negocios.ProveedoresHelados.Respuesta.validacionCorrecta)
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
            cmbTipoDoc.SelectedIndex = -1;
            txtNroDoc.Text = "";
            txtIdHelado.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
