using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practico.Formularios.Abm;
using Practico.Formularios.Abm.Empleados;
using Practico.Formularios.Abm.Helados;
using Practico.Formularios.Abm.Proveedores;
using Practico.Formularios.Abm.TelefonosEmpleados;

namespace Practico.Formularios
{
    public partial class FrmAdministracion : Form
    {
        public FrmAdministracion()
        {
            InitializeComponent();
        }

        private void btnEscritorio_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmUsuarios());
        }

        private void btnHelados_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmHelados());
        }

        private void abrirFormulario(Form formulario) // usar para abrir CUALQUIER FORMULARIO
        {
            Panel esteFormulario = this.Parent as Panel;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.TopLevel = false;
            formulario.AutoScroll = true;
            esteFormulario.Controls.Add(formulario);
            formulario.Show();
            this.Close();

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FrmEmpleados empleados = new FrmEmpleados();
            abrirFormulario(empleados);

        }

        private void btn_Proveedores_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmProveedores());
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmTelefonosEmpleados telefonos = new FrmTelefonosEmpleados();
            abrirFormulario(telefonos);
        }
    }
}
