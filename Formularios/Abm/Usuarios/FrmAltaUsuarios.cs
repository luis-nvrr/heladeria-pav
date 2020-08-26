using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practico.Clases;

namespace Practico.Formularios.Abm.Usuarios
{
    public partial class FrmAltaUsuarios : Form
    {
        public FrmAltaUsuarios()
        {
            InitializeComponent();
        }

        private void FrmAltaUsuarios_Load(object sender, EventArgs e)
        {
            lblNombre.TabStop = false;
            lblContraseña.TabStop = false;
            lblRepetir.TabStop = false;
            lblNuevo.TabStop = false;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();

            if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                
            }
        }
    }
}
