using Practico.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico.Formularios
{
    public partial class FrmLogin : Form
    {
        string usuario = "";
        string contraseña = "";
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }

        // Login
        public FrmLogin()
        {
            InitializeComponent();
        }

        //carga el formulario
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        // boton cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //boton ingresar

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == "")
            {
                MessageBox.Show("Ingrese usuario");
                LimpiarCampos();
                txtUsuario.Focus();
                return;
            }

            if (this.txtContraseña.Text == "")
            {
                MessageBox.Show("Ingrese contraseña");
                LimpiarCampos();
                txtContraseña.Focus();
                return;
            }

            NgUsuarios usr = new NgUsuarios();

            if (usr.ValidarUsuario(txtUsuario.Text,txtContraseña.Text) == NgUsuarios.Respuesta.validacionCorrecta)
            {   this.usuario = txtUsuario.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Datos Incorrectos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                LimpiarCampos();
                return;
            }
        }
        // Limpia todos los campos
        private void LimpiarCampos()
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }
    }
}
