using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practico.Negocios;

namespace Practico.Formularios.Procesos
{
    public partial class FrmVenta : Form
    {
        public string idUsuario { get; set; }
        Empleados empleados = new Empleados();

        public FrmVenta()
        {
            InitializeComponent();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            cmbTipo.Cargar();
            CargarCampos();

        }

        private void CargarCampos()
        {
            Negocios.Empleados empleados = new Negocios.Empleados();
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


            cmbTipo.SelectedValue = empleados.tipoDoc; // para seleccionar el item del combo que coincide con la cadena tipoDoc
            txtNroDoc.Text = empleados.nroDoc;

            txtNombre.Text = empleados.nombre;
            txtApellido.Text = empleados.apellido;

        }
    }
}
