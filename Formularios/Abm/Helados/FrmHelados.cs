using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico.Formularios.Abm.Helados
{
    public partial class FrmHelados : Form
    {
        public FrmHelados()
        {
            InitializeComponent();
        }

        private void lblUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btnEscritorio_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void abrirFormulario(Form formulario)  // usar para abrir CUALQUIER FORMULARIO
        {
            Panel esteFormulario = this.Parent as Panel;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.TopLevel = false;
            formulario.AutoScroll = true;
            esteFormulario.Controls.Add(formulario);
            formulario.Show();
            this.Close();

        }
    }
}
