using Practico.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practico.Negocios;

namespace Practico
{
    public partial class FrmEscritorio : Form
    {
        private string usuario = "";
        private string password = "";
        private int idUsuario;
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string IdUsuario { get; set; }


        public FrmEscritorio()
        {
            InitializeComponent();
        }

        private void FrmEscritorio_Load(object sender, EventArgs e)
        {
            OcultarSubMenu(); // prepara el menu

            FrmLogin login = new FrmLogin();  // crea login
            login.ShowDialog();

            if(login.Usuario == "" || login.Password == "")   // NO se logueo
            {
                MessageBox.Show("Acceso Bloqueado", "Error", 
                    buttons:MessageBoxButtons.OK, icon:MessageBoxIcon.Stop);

                this.Close();   // cierra la aplicacion 
            }
            else  // SI se logueo
            {
                MessageBox.Show("Bienvenid@: " + login.Usuario, "Bienvenid@", 
                    buttons:MessageBoxButtons.OK, icon:MessageBoxIcon.Information);

                this.usuario = login.Usuario;  // guarda datos 
                this.password = login.Password;

                Usuarios user = new Usuarios();
                this.idUsuario = user.RecuperarIdUsuario(usuario, password);

                lblUsuario.Text = usuario + " id:" + idUsuario;  // configura labels
                login.Dispose();
            }
        }


        private Form formularioActivo = null;     // usar metodo para abrir CUALQUIER FORMULARIO
        private void AbrirFormulario(Form formularioHijo)
        {
            if (formularioActivo != null)
                formularioActivo.Close();
            formularioActivo = formularioHijo;
            formularioActivo.TopLevel = false;
            formularioActivo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            pnlEscritorio.Controls.Add(formularioHijo);
            pnlEscritorio.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        // Control del escritorio
        private void OcultarSubMenu()             // Oculta los paneles del menu
        {
            if (pnlProcesos.Visible)
                pnlProcesos.Visible = false;
            if (pnlEstadisticas.Visible)
                pnlEstadisticas.Visible = false;
            if (pnlListados.Visible)
                pnlListados.Visible = false;
        }


        private void MostrarSubMenu(Panel subMenu)   // Usar para abrir un submenu
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        // Clicks sobre el Menu
        private void btnProcesos_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlProcesos);
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlEstadisticas);
        }

        private void btnListados_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlListados);
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            //..
            AbrirFormulario(new FrmAdministracion());
            OcultarSubMenu();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
