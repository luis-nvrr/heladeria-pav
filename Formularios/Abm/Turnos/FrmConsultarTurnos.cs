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

namespace Practico.Formularios.Abm.Turnos
{
    public partial class FrmConsultarTurnos : Form
    {
        public string idTurno { get; set; }
        public string nombre { get; set; }
        public string horaInicio { get; set; }
        public string horaFin { get; set; }
        public string nroDoc { get; set; }

        public string tipoDoc { get; set; }

        public FrmConsultarTurnos()
        {
            InitializeComponent();
        }

        private void FrmConsultarTurnos_Load(object sender, EventArgs e)
        {
            lblId.TabStop = false;
            lblNombre.TabStop = false;
            lblHoraInicio.TabStop = false;
            lblHoraFin.TabStop = false;
            lblNumeroD.TabStop = false;
            lblTipo.TabStop = false;
            cmbTipo.Cargar();

            CargarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarCampos()
        {
            Negocios.Turnos turnos = new Negocios.Turnos();
            DataTable tabla = turnos.RecuperarTurno(Int32.Parse(idTurno));

            idTurno = tabla.Rows[0]["idTurno"].ToString();
            nombre = tabla.Rows[0]["nombre"].ToString();
            horaInicio = tabla.Rows[0]["horaInicio"].ToString();
            horaFin = tabla.Rows[0]["horaFin"].ToString();
            nroDoc = tabla.Rows[0]["nroDocSupervisor"].ToString();
            tipoDoc = tabla.Rows[0]["tipoDocSupervisor"].ToString();

            txtId.Text = idTurno;
            txtNombre.Text = nombre;
            pckHoraInicio.Value = DateTime.Parse(horaInicio);
            pckHoraFin.Value = DateTime.Parse(horaFin);
            cmbTipo.SelectedIndex = cmbTipo.FindStringExact(tipoDoc);
            txtNumeroD.Text = nroDoc;

        }
    }
}
