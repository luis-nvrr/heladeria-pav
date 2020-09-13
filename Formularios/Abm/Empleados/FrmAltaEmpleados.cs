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

namespace Practico.Formularios.Abm.Empleados
{
    public partial class FrmAltaEmpleados : Form
    {
        public FrmAltaEmpleados()
        {
            InitializeComponent();
        }

        private void FrmAltaEmpleados_Load(object sender, EventArgs e)
        {
            lblTipo.TabStop = false;
            lblNumeroD.TabStop = false;
            lblNombre.TabStop = false;
            lblApellido.TabStop = false;
            lblCalle.TabStop = false;
            lblNumero.TabStop = false;
            lblBarrio.TabStop = false;
            lblFechaNa.TabStop = false;
            lblFechaIn.TabStop = false;
            lblUsuario.TabStop = false;
            lblTurno.TabStop = false;
            cmbTipo.Cargar();
            cmbBarrio.Cargar();
            cmbTurno.Cargar();
            cmbUsuario.Cargar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();

            if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                Negocios.Empleados empleados = new Negocios.Empleados();
                if (empleados.InsertarEmpleado(Int32.Parse(cmbTipo.SelectedValue.ToString()), 
                        txtNumeroD.Text, 
                        txtNombre.Text,
                        txtApellido.Text,
                        txtCalle.Text, 
                        Int32.Parse(txtNumero.Text),
                        Int32.Parse(cmbBarrio.SelectedValue.ToString()),
                        pckNacimiento.Value, 
                        pckIngreso.Value,
                        Int32.Parse(cmbUsuario.SelectedValue.ToString()),
                        Int32.Parse(cmbTurno.SelectedValue.ToString())) 
                    == Negocios.Empleados.Respuesta.validacionCorrecta)
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
            txtNumeroD.Text = "";
            txtApellido.Text = "";
            txtCalle.Text = "";
            txtNumero.Text = "";
            cmbBarrio.SelectedIndex = -1;
            cmbTipo.SelectedIndex = -1;
            cmbUsuario.SelectedIndex = -1;
            cmbTurno.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
