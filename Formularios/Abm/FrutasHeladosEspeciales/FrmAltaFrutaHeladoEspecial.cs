using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practico.Clases;

namespace Practico.Formularios.Abm.FrutasHeladosEspeciales
{
    public partial class FrmAltaFrutaHeladoEspecial : Form
    {

        public FrmAltaFrutaHeladoEspecial()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();

            if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                Negocios.FrutasHeladosEspeciales frutas = new Negocios.FrutasHeladosEspeciales();
                if (frutas.InsertarFruta(Int32.Parse(cmbHeladoEspecial.SelectedValue.ToString()),
                                             Int32.Parse(cmbFruta.SelectedValue.ToString()),
                                             float.Parse(txtCantidad.Text.Replace(',', '.'), CultureInfo.InvariantCulture)) 
                    == Negocios.FrutasHeladosEspeciales.Respuesta.validacionCorrecta)
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

        private void FrmAltaFrutaHeladoEspecial_Load(object sender, EventArgs e)
        {
            cmbFruta.Cargar();
            cmbHeladoEspecial.Cargar();
        }

        private void LimpiarCampos()
        {
            cmbFruta.SelectedIndex = -1;
            cmbHeladoEspecial.SelectedIndex = -1;
            txtCantidad.Text = "";
        }
    }
}
