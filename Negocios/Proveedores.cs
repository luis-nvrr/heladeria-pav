﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Practico.Clases;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Practico.Negocios
{
    class Proveedores
    {

        BaseDatos baseDatos = new BaseDatos();

        public enum Respuesta
        {
            validacionCorrecta,
            validacionIncorrecta
        }

        public DataTable TodosLosProveedores()
        {
            string sql = "SELECT * FROM Proveedores P JOIN TiposDocumento TD ON P.tipoDocumento=TD.tipoDocumento";
            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public DataTable RecuperarProoveedor(string tipoDocumento, int nroDocumento)
        {
            string sql = "SELECT P.* FROM Proveedores P INNER JOIN TiposDocumento TD ON (P.tipoDocumento = TD.tipoDocumento)" +
                         " WHERE descripcion LIKE '" + tipoDocumento + "' AND nroDocumento = " + nroDocumento;
            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public DataTable BuscarProveedor(string razonSocial)
        {
            string sql = "SELECT * FROM Proveedores P JOIN TiposDocumento TD ON P.tipoDocumento=TD.tipoDocumento WHERE razonSocial LIKE '%" + razonSocial.Trim() + "%'";
            DataTable tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public Respuesta Insertar(Control.ControlCollection controles)
        {
            try
            {
                baseDatos.InsertarAutomatizado("Proveedores", controles);
                return Respuesta.validacionCorrecta;

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return Respuesta.validacionIncorrecta;
            }

        }

        public Respuesta Modificar(int tipoDocumento, string nroDocumento, Control.ControlCollection controles)
        {
            try
            {
                baseDatos.ModificarAutomatizado("Proveedores", " tipoDocumento  =" + tipoDocumento + " AND nroDocumento = '" + nroDocumento + "'", controles);
                return Respuesta.validacionCorrecta;

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return Respuesta.validacionIncorrecta;
            }

        }

        public Respuesta Eliminar(int tipoDocumento, int nroDocumento)
        {
            string sql = "DELETE FROM Proveedores WHERE tipoDocumento LIKE '" + tipoDocumento + "' AND nroDocumento = " + nroDocumento;

            try
            {
                baseDatos.Eliminar(sql);
                return Respuesta.validacionCorrecta;

            }
            catch (SqlException exception)
            {
                return Respuesta.validacionIncorrecta;
            }

        }



    }
}
