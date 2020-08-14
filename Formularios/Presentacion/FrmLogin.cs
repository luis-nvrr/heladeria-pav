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
        private string usuario = "";
        string password = ""; 

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }

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
            if (this.txtUsuario.Text == "")   // nombre de usuario vacio
            {
                MessageBox.Show("Ingrese usuario");
                txtUsuario.Focus();
                return;
            }

            if (this.txtContraseña.Text == "")
            {
                MessageBox.Show("Ingrese contraseña");  // contraseña vacia
                txtContraseña.Focus();
                return;
            }

            Usuarios user = new Usuarios();  // crea objeto usuario del negocio para validar

            if (user.ValidarUsuario(txtUsuario.Text,txtContraseña.Text) == Usuarios.Respuesta.validacionCorrecta)
            {   this.usuario = txtUsuario.Text;  // usuario validado, guada el nombre en la propiedad del formulario
                this.Close();
            }
            else   // datos incorrectos
            {
                MessageBox.Show("Datos Incorrectos", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtUsuario.Focus();
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

        //
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
