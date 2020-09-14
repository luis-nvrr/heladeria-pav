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

namespace Practico.Formularios.Abm.HeladosEspeciales
{
    public partial class FrmAltaHeladosEspeciales : Form
    {

        Negocios.Helados helados = new Negocios.Helados();

        public FrmAltaHeladosEspeciales()
        {
            InitializeComponent();
        }

        private void FrmAltaHeladosEspeciales_Load(object sender, EventArgs e)
        {
            cmbHelado.cargar(helados.EstrCombo());
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();

            if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                Negocios.HeladosEspeciales heladoEspecial = new Negocios.HeladosEspeciales();
                if (heladoEspecial.Insertar(this.Controls) == Negocios.HeladosEspeciales.Respuesta.validacionCorrecta)
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
            txtNombre.Text = "";
            txtCantBochas.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            cmbHelado.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
