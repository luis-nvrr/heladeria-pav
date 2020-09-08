using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Practico.Clases;

namespace Practico.Negocios
{
    class Helados
    {
        private BaseDatos baseDatos = new BaseDatos(); // creacion de la base de datos

        public enum Respuesta
        {
            validacionCorrecta,
            validacionIncorrecta
        }

        public DataTable TodosLosHelados()
        {
            string sql = "SELECT * FROM Helados";
            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public DataTable BuscarHelado(string nombre)
        {
            string sql = "SELECT * FROM Helados WHERE nombre LIKE '%" + nombre.Trim() + "%'";
            DataTable tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public Respuesta InsertarHelado(string nombre, int precio, int cantidad)
        {
            string sql = "INSERT INTO Helados VALUES " + "('" + nombre + "'," + precio + "," + cantidad +")";
            try
            {
                baseDatos.Insertar(sql);
                return Respuesta.validacionCorrecta;

            }
            catch (SqlException)
            {
                return Respuesta.validacionIncorrecta;
            }

        }
        public Respuesta EliminarHelado(int id)
        {
            string sql = "DELETE FROM Helados WHERE idHelado =" + id;

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
