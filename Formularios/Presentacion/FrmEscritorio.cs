using Practico.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico
{
    public partial class FrmEscritorio : Form
    {
        private string usuario = "";
        private string contraseña = "";

        public FrmEscritorio()
        {
            InitializeComponent();
        }

        private void FrmEscritorio_Load(object sender, EventArgs e)
        {            
            // Prepara el menu
            PersonalizarDiseño();

            // Verifica que se logeo
            FrmLogin login = new FrmLogin();
            login.ShowDialog();
            if(login.Usuario == "")   // no se logeo
            {
                MessageBox.Show("No se validó ningun usuario");
                login.Dispose();
                Application.Exit();   // cierra la aplicacion 
            }
            this.usuario = login.Usuario;     // si se logeo
            this.contraseña = login.Contraseña;
            login.Dispose();

            // Configura labels
            lblUsuario.Text = usuario;

        }

        // usar metodo para abrir CUALQUIER FORMULARIO
        private Form formularioActivo = null;
        private void abrirFormulario(Form formularioHijo)
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

        // Control de Menu
        // Presentacion de Menu
        private void PersonalizarDiseño()
        {
            pnlProcesos.Visible = false;
            pnlEstadisticas.Visible = false;
            pnlListados.Visible = false;
        }

        //Oculta los paneles del Menu
        private void OcultarSubMenu()
        {
            if (pnlProcesos.Visible == true)
                pnlProcesos.Visible = false;
            if (pnlEstadisticas.Visible == true)
                pnlEstadisticas.Visible = false;
            if (pnlListados.Visible == true)
                pnlListados.Visible = false;
        }

        //Muestra el panel del Menu pasado como parametro
        private void MostrarSubMenu(Panel subMenu)
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
            abrirFormulario(new FrmAdministracion());
            OcultarSubMenu();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
