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
            // cargar combos
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string sql = "";
            BaseDatos baseDatos = new BaseDatos();
            DataTable tabla = new DataTable();
            if (chkTodos.Checked)  // busca todos los usuarios
            {
                sql = "SELECT * FROM Usuarios";
                tabla = baseDatos.Consulta(sql);
                CargarGrilla(tabla);
            }
            else  //buscar por nombre
            { 
                TratamientosEspeciales tratamiento = new TratamientosEspeciales();

                // valida que haya texto en el textbox
                if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
                {
                    sql = "SELECT * FROM Usuarios WHERE";
                }
            }
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
            }
            else
            {
                txtNombre.Enabled = true;
            }
            
        }
    }
}
