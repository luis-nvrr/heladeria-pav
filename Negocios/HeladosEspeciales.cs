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
    class HeladosEspeciales
    {

        BaseDatos baseDatos = new BaseDatos();

        public enum Respuesta
        {
            validacionCorrecta,
            validacionIncorrecta
        }

        public DataTable TodosLosHeladosEspeciales()
        {
            string sql = "SELECT * FROM HeladosEspeciales P JOIN Helados TD ON P.idHelado=TD.idHelado";
            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }


        public DataTable RecuperarHeladosEspeciales(string idHeladoEspecial, string idHelado)
        {
            string sql = "SELECT P.* FROM HeladosEspeciales P INNER JOIN Helados TD ON (P.idhelado = TD.idHelado)" +
                         " WHERE idHeladoEspecial LIKE '" + idHeladoEspecial + "' AND P.idHelado LIKE '" + idHelado + "'";
            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public DataTable BuscarHeladosEspeciales(string nombreProducto)
        {
            string sql = "SELECT * FROM HeladosEspeciales P JOIN Helados TD ON P.idhelado=TD.idHelado WHERE nombreProducto LIKE '%" + nombreProducto.Trim() + "%'";
            DataTable tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public Respuesta Insertar(Control.ControlCollection controles)
        {
            try
            {
                baseDatos.InsertarAutomatizado("HeladosEspeciales", controles);
                return Respuesta.validacionCorrecta;

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return Respuesta.validacionIncorrecta;
            }

        }


        //public Respuesta Modificar(int idHeladoEspecial, string idHelado, Control.ControlCollection controles)
        public Respuesta Modificar(int idHelado, string idHeladoEspecial, Control.ControlCollection controles)
        {
            try
            {
                baseDatos.ModificarAutomatizado("HeladosEspeciales", " idHeladoEspecial  =" + idHeladoEspecial + " AND idHelado LIKE '" + idHelado + "'", controles);
                //baseDatos.ModificarAutomatizado("HeladosEspeciales", " idHelado  =" + idHelado + " AND idHeladoEspecial LIKE '" + idHeladoEspecial + "'", controles);
                return Respuesta.validacionCorrecta;

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return Respuesta.validacionIncorrecta;
            }

        }


        public Respuesta Eliminar(int idHeladoEspecial, string idHelado)
        {
            string sql = "DELETE FROM HeladosEspeciales WHERE idHeladoEspecial LIKE '" + idHeladoEspecial + "' AND idHelado LIKE '" + idHelado + "'";

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
