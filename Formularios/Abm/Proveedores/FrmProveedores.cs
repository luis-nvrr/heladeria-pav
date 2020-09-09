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
using Practico.Formularios.Abm.Proveedores;
using Practico.Negocios;

namespace Practico.Formularios.Abm.Proveedores
{
    public partial class FrmProveedores : Form
    {
        Negocios.Proveedores proveedores = new Negocios.Proveedores();
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            lblRazónSocial.TabStop = false;
            lblProveedores.TabStop = false;
            grdProveedores.TabStop = false;
        }

        private void btnEscritorio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (chkTodos.Checked)  // busca todos los proveedores
            {
                DataTable tabla = proveedores.TodosLosProveedores();
                CargarGrilla(tabla);
            }
            else  //buscar por razón social
            {
                TratamientosEspeciales tratamiento = new TratamientosEspeciales();

                // valida que haya texto en el textbox
                if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
                {
                    DataTable tabla = proveedores.BuscarProveedor(txtRazónSocial.Text);
                    CargarGrilla(tabla);
                }
            }

            txtRazónSocial.Focus();
        }

        private void CargarGrilla(DataTable tabla)
        {
            grdProveedores.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grdProveedores.Rows.Add();
                grdProveedores.Rows[i].Cells[0].Value = tabla.Rows[i]["descripcion"].ToString();
                grdProveedores.Rows[i].Cells[1].Value = tabla.Rows[i]["nroDocumento"].ToString();
                grdProveedores.Rows[i].Cells[2].Value = tabla.Rows[i]["razonSocial"].ToString();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAltaProveedores altaProveedores = new FrmAltaProveedores();
            altaProveedores.ShowDialog();

            DataTable tabla = proveedores.TodosLosProveedores();
            CargarGrilla(tabla);
            altaProveedores.Close();
        }
    }
}
