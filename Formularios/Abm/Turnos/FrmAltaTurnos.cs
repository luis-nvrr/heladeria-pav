using Practico.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico.Formularios.Abm.Turnos
{
    public partial class FrmAltaTurnos : Form
    {
        public FrmAltaTurnos()
        {
            InitializeComponent();
        }

        private void FrmAltaTurnos_Load(object sender, EventArgs e)
        {
            lblHoraFin.TabStop = false;
            lblHoraInicio.TabStop = false;
            lblNombre.TabStop = false;
            lblNuevo.TabStop = false;
            lblNumeroD.TabStop = false;
            lblTipo.TabStop = false;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtNumeroD.Text = "";
            cmbTipo.SelectedIndex = -1;
        }


        private void lblNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pckHoraInicio_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();

            if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                Negocios.Turnos turnos = new Negocios.Turnos();
                if (turnos.InsertarTurno(txtNombre.Text,
                                         pckHoraInicio.Value,
                                         pckHoraFin.Value,
                                         txtNumeroD.Text,
                                         Int32.Parse(cmbTipo.SelectedValue.ToString())) ==
                                         Negocios.Turnos.Respuesta.validacionCorrecta)
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
    }
}
