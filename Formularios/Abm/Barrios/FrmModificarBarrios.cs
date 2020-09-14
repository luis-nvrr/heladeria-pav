﻿using Practico.Clases;
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

namespace Practico.Formularios.Abm.Barrios
{
    public partial class FrmModificarBarrios : Form
    {

        public string idBarrio { get; set; }
        public string nombre { get; set; }
        public string localidad { get; set; }

        public FrmModificarBarrios()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            if (tratamiento.Validar(this.Controls) == TratamientosEspeciales.Validacion.correcta)
            {
                Negocios.Barrios barrios = new Negocios.Barrios();
                if (barrios.ModificarBarrio(Int32.Parse(idBarrio), txtNombre.Text, Int32.Parse(cmbLocalidad.SelectedValue.ToString())) ==
                    Negocios.Barrios.Respuesta.validacionCorrecta)
                {
                    MessageBox.Show("Modificado correctamente!", "Informacion",
                            buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                    CargarCampos();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error...", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CargarCampos();
                }
            }
        }

        private void CargarCampos()
        {
            Negocios.Barrios barrios = new Negocios.Barrios();
            DataTable tabla = barrios.RecuperarBarrio(Int32.Parse(idBarrio));
            idBarrio = tabla.Rows[0]["idBarrio"].ToString();
            nombre = tabla.Rows[0]["nombre"].ToString();
            localidad = tabla.Rows[0]["idLocalidad"].ToString();

            txtId.Text = idBarrio;
            txtNombre.Text = nombre;
            cmbLocalidad.SelectedValue = localidad;
        }

        private void FrmModificarBarrios_Load(object sender, EventArgs e)
        {
            lblId.TabStop = false;
            lblLocalidad.TabStop = false;
            lblNombre.TabStop = false;
            cmbLocalidad.Cargar();
        }
    }
}
