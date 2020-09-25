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

namespace Practico.Formularios.Procesos
{
    public partial class FrmAltaVenta : Form
    {
        private float total = 0;
        private int nroItem = 0;

        Helados helados = new Helados();
        HeladosEspeciales heladosEspeciales = new HeladosEspeciales();
        Ventas ventas = new Ventas();
        

        public string idUsuario { get; set; }
        Empleados empleados = new Empleados();

        public FrmAltaVenta()
        {
            InitializeComponent();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            cmbHelado.Cargar();
            cmbEspecial.Cargar();
            RecuperarEmpleado();
            grdDetalleHelado.Formatear("Item,40;Id,40;Helado,170;Precio,80;Cantidad,80;Unidad,60;Especial,0");
            grdDetalleHelado.Columns[6].Visible = false;
            actualizarPrecio();
        }

        private void RecuperarEmpleado()
        {
            DataTable tabla = empleados.RecuperarEmpleadoPorUsuario(idUsuario);

            empleados.tipoDoc = tabla.Rows[0]["tipoDoc"].ToString();
            empleados.nroDoc = tabla.Rows[0]["nroDoc"].ToString();
            empleados.nombre = tabla.Rows[0]["nombre"].ToString();
            empleados.apellido = tabla.Rows[0]["apellido"].ToString();
            empleados.calle = tabla.Rows[0]["calle"].ToString();
            empleados.nroCalle = tabla.Rows[0]["nroCalle"].ToString();
            empleados.barrio = tabla.Rows[0]["idBarrio"].ToString();
            empleados.fechaNacimiento = tabla.Rows[0]["fechaNacimiento"].ToString();
            empleados.fechaIngreso = tabla.Rows[0]["fechaIngreso"].ToString();
            empleados.usuario = tabla.Rows[0]["idUsuario"].ToString();
            empleados.turno = tabla.Rows[0]["idTurno"].ToString();

        }

        private void btnHelado_Click(object sender, EventArgs e)
        {
            pnlHelados.BringToFront();
            pnlEspecial.Visible = false;
            pnlHelados.Visible = true;
            limpiarEspecial();
        }

        private void limpiarHelados()
        {
            cmbHelado.SelectedIndex = -1;
            txtHelado.Text = "";
        }

        private void limpiarEspecial()
        {
            cmbEspecial.SelectedIndex = -1;
            txtEspecial.Text = "";
        }

        private void btnEspecial_Click(object sender, EventArgs e)
        {
            pnlEspecial.BringToFront();
            pnlHelados.Visible = false;
            pnlEspecial.Visible = true;
            limpiarHelados();
        }

        private void actualizarPrecio()
        {
            lblTotal.Text = total.ToString();
        }

        private void btnConfirmarEspecial_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamientos = new TratamientosEspeciales();

            if (tratamientos.Validar(pnlEspecial.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                int nroItem = grdDetalleHelado.Rows.Count;
                nroItem += 1;

                grdDetalleHelado.Rows.Add();
                int ind = grdDetalleHelado.Rows.Count - 1;

                if (ind > 4)
                {
                    grdDetalleHelado.Height = grdDetalleHelado.Height + 20;
                }

                grdDetalleHelado.Rows[ind].Cells[0].Value = nroItem;
                grdDetalleHelado.Rows[ind].Cells[1].Value = cmbEspecial.SelectedValue;
                grdDetalleHelado.Rows[ind].Cells[2].Value = cmbEspecial.Text;
                grdDetalleHelado.Rows[ind].Cells[3].Value = txtPrecioEspecial.Text;
                grdDetalleHelado.Rows[ind].Cells[4].Value = txtEspecial.Text;
                grdDetalleHelado.Rows[ind].Cells[5].Value = "uni.";
                grdDetalleHelado.Rows[ind].Cells[6].Value = "true";

                total += float.Parse(txtPrecioEspecial.Text) * float.Parse(txtEspecial.Text);
                actualizarPrecio();
            }
            
        }


        private void btnConfirmarHelado_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamientos = new TratamientosEspeciales();
            if (tratamientos.Validar(pnlHelados.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                nroItem += 1;

                grdDetalleHelado.Rows.Add();
                int ind = grdDetalleHelado.Rows.Count - 1;

                if (ind > 4)
                {
                    grdDetalleHelado.Height = grdDetalleHelado.Height + 20;
                }

                grdDetalleHelado.Rows[ind].Cells[0].Value = nroItem;
                grdDetalleHelado.Rows[ind].Cells[1].Value = cmbHelado.SelectedValue;
                grdDetalleHelado.Rows[ind].Cells[2].Value = cmbHelado.Text;
                grdDetalleHelado.Rows[ind].Cells[3].Value = txtPrecioHelado.Text;
                grdDetalleHelado.Rows[ind].Cells[4].Value = txtHelado.Text;
                grdDetalleHelado.Rows[ind].Cells[5].Value = "kg";
                grdDetalleHelado.Rows[ind].Cells[6].Value = "false";

                total += float.Parse(txtPrecioHelado.Text) * float.Parse(txtHelado.Text);
                actualizarPrecio();
            }
            
        }

        private void cmbHelado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = helados.RecuperarHelado(Int32.Parse(cmbHelado.SelectedValue.ToString()));
            txtPrecioHelado.Text = tabla.Rows[0]["precio"].ToString();
        }

        private void cmbEspecial_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = heladosEspeciales.RecuperarHeladosEspeciales(cmbEspecial.SelectedValue.ToString());
            txtPrecioEspecial.Text = tabla.Rows[0]["precio"].ToString();
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            MessageBox.Show(empleados.tipoDoc + "- " + empleados.nroDoc);
            ventas.InsertarVenta(empleados.tipoDoc, empleados.nroDoc, grdDetalleHelado);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdDetalleHelado.SelectedRows.Count != 1)
            {
                MessageBox.Show("Seleccione UNA fila!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea continuar?", "Importante", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    total += float.Parse(grdDetalleHelado.CurrentRow.Cells[3].Value.ToString()) * float.Parse(grdDetalleHelado.CurrentRow.Cells[4].Value.ToString());
                    actualizarPrecio();
                    grdDetalleHelado.Rows.Remove(grdDetalleHelado.CurrentRow);
                }
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarEspecial();
            limpiarHelados();
            total = 0;
            actualizarPrecio();
            grdDetalleHelado.Rows.Clear();
            txtPrecioHelado.Text = "";
            txtEspecial.Text = "";
        }
    }
}
