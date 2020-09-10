using System;
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

    }
}
