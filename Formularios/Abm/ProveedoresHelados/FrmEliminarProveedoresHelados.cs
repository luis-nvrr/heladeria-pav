﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practico.Negocios;
using Practico.Clases;

namespace Practico.Formularios.Abm.ProveedoresHelados
{
    public partial class FrmEliminarProveedoresHelados : Form
    {
        Negocios.TipoDocumento tipoDoc = new Negocios.TipoDocumento();
        Negocios.ProveedoresHelados proveedoresHelados = new Negocios.ProveedoresHelados();
        Negocios.Proveedores proveedores = new Negocios.Proveedores();
        Negocios.Helados helados = new Negocios.Helados();

        public string tipoDocumento { get; set; }
        public string nroDocumento { get; set; }
        public string idHelado { get; set; }
        public string razonSocial { get; set; }

        public FrmEliminarProveedoresHelados()
        {
            InitializeComponent();
        }

        private void FrmEliminarProveedoresHelados_Load(object sender, EventArgs e)
        {
            cmbTipoDoc.cargar(tipoDoc.EstrCombo());
            cmbNroDoc.cargar(proveedores.EstrCombo());
            cmbIdHelado.cargar(helados.EstrCombo());
            CargarCampos();
        }


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
           if (proveedoresHelados.Eliminar(Int32.Parse(cmbTipoDoc.SelectedValue.ToString()), nroDocumento,proveedoresHelados.RecuperarIdHelado(idHelado)) == Negocios.ProveedoresHelados.Respuesta.validacionCorrecta)
           {
                MessageBox.Show("Eliminado correctamente!", "Informacion",
                                buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                this.Close();
           }
           else
           {
               MessageBox.Show("No se ha podido eliminar!", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }

        private void CargarCampos()
        {
            DataTable tabla = new DataTable();
            tabla = proveedoresHelados.RecuperarProoveedorHelado(tipoDocumento, nroDocumento, idHelado);

            cmbTipoDoc.SelectedIndex = cmbTipoDoc.FindStringExact(tipoDocumento);
            cmbNroDoc.SelectedValue = nroDocumento;
            cmbIdHelado.SelectedIndex = cmbIdHelado.FindStringExact(idHelado);
            CargarComboNombre();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarComboNombre()
        {
            BaseDatos baseDatos = new BaseDatos();
            string sql = "SELECT P.razonSocial FROM Proveedores P WHERE P.tipoDocumento = " + cmbTipoDoc.SelectedValue +
                         " AND P.nroDocumento LIKE '" + cmbNroDoc.SelectedValue + "'";
            cmbNombre.ValueMember = "razonSocial";
            cmbNombre.DisplayMember = "razonSocial";
            cmbNombre.DataSource = baseDatos.Consulta(sql);
        }
    }
}

