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
using Practico.Formularios.Abm.Usuarios;
using Practico.Negocios;

namespace Practico.Formularios.Abm
{
    public partial class FrmUsuarios : Form
    {
        Negocios.Usuarios usuarios = new Negocios.Usuarios();

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void btnEscritorio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            lblNombre.TabStop = false;
            lblUsuarios.TabStop = false;
            grdUsuarios.TabStop = false;
            // cargar combos
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {                                                         
            
            if (chkTodos.Checked)  // busca todos los usuarios
            {
                DataTable tabla = usuarios.TodosLosUsuarios();
                CargarGrilla(tabla);
            }
            else  //buscar por nombre
            { 
                TratamientosEspeciales tratamiento = new TratamientosEspeciales();

                // valida que haya texto en el textbox
                if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
                {
                    DataTable tabla = usuarios.BuscarUsuario(txtNombre.Text);
                    CargarGrilla(tabla);
                }
            }

            txtNombre.Focus();
        }


        private void CargarGrilla(DataTable tabla)
        {
            grdUsuarios.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grdUsuarios.Rows.Add();
                grdUsuarios.Rows[i].Cells[0].Value = tabla.Rows[i]["idUsuario"].ToString();
                grdUsuarios.Rows[i].Cells[1].Value = tabla.Rows[i]["nombreUsuario"].ToString();
            }
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)  // bloquea y desbloquea el textbox
        {
            if (chkTodos.Checked)
            {
                txtNombre.Enabled = false;
                txtNombre.BackColor = Color.SlateGray;
                LimpiarCampos();
            }
            else
            {
                txtNombre.Enabled = true;
                txtNombre.BackColor = Color.White;
                txtNombre.Focus();
            }
            
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAltaUsuarios altaUsuarios = new FrmAltaUsuarios();
            altaUsuarios.ShowDialog();
        }
    }
}
