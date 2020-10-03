using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practico.Clases;

namespace Practico.Negocios
{
    class Empleados
    {
        public string tipoDoc { get; set; }
        public string nroDoc { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string calle { get; set; }
        public string nroCalle { get; set; }
        public string barrio { get; set; }
        public string fechaNacimiento { get; set; }
        public string fechaIngreso { get; set; }
        public string usuario { get; set; }
        public string turno { get; set; }


        private BaseDatos baseDatos = new BaseDatos(); // creacion de la base de datos
        public enum Respuesta
        {
            validacionCorrecta,
            validacionIncorrecta
        }

        public DataTable TodosLosEmpleados()
        {
            string sql = "SELECT E.*," +
                         "U.nombreUsuario," +
                         "TD.descripcion," +
                         "B.nombre AS nombreBarrio," +
                         "T.nombre AS nombreTurno" +
                         " FROM Empleados E " +
                         "  INNER JOIN TiposDocumento TD ON (E.tipoDoc = TD.tipoDocumento)" +
                         "  INNER JOIN Barrios B ON (E.idBarrio = B.idBarrio) " +
                         "  INNER JOIN Turnos T ON (E.idTurno = T.idTurno)  " +
                         "  INNER JOIN Usuarios U ON (u.idUsuario = E.idUsuario)";

            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public DataTable BuscarEmpleado(string nombre, string apellido, string turno, string barrio)
        {
            string sql = "SELECT E.*," +
                         "U.nombreUsuario," +
                         "TD.descripcion," +
                         "B.nombre AS nombreBarrio," +
                         "T.nombre AS nombreTurno" +
                         " FROM Empleados E " +
                         "  INNER JOIN TiposDocumento TD ON (E.tipoDoc = TD.tipoDocumento)" +
                         "  INNER JOIN Barrios B ON (E.idBarrio = B.idBarrio) " +
                         "  INNER JOIN Turnos T ON (E.idTurno = T.idTurno)  " +
                         "  INNER JOIN Usuarios U ON (u.idUsuario = E.idUsuario)" +
                         " WHERE E.nombre LIKE '%" + nombre.Trim() + "%'" + 
                         "  AND E.apellido LIKE '%" + apellido.Trim() + "%'" +
                         "  AND E.idTurno IN " + turno +
                         "  AND E.idBarrio IN " + barrio;

            DataTable tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public Respuesta InsertarEmpleado(int tipoDoc, string nroDoc, string nombre, string apellido, string calle,
                                            int nroCalle, int idBarrio, DateTime fechaNacimiento, DateTime fechaIngreso,
                                            int idUsuario, int idTurno)
        {
            string sql = "INSERT INTO Empleados (tipoDoc, nroDoc, nombre, apellido, calle, nroCalle, idBarrio, fechaNacimiento," +
                         "fechaIngreso, idUsuario, idTurno) VALUES " +
                         "(" + tipoDoc + ",'" + nroDoc + "','" + nombre + "','" + apellido + "','" + calle + "'," +
                         nroCalle + "," + idBarrio + "," + "convert(date,'" + fechaNacimiento + "', 103)" + "," +
                         "convert(date,'" + fechaIngreso + "', 103)" + "," + idUsuario + "," + idTurno + ")";

            try
            {
                baseDatos.Insertar(sql);
                return Respuesta.validacionCorrecta;

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return Respuesta.validacionIncorrecta;
            }

        }

        public DataTable RecuperarEmpleado(string descripcion, string nroDoc) // notar que para buscar usa descripcion y no tipoDocumento, pero recupera solo las columnas de E, para procesar en el form
        {
            string sql = "SELECT E.* FROM Empleados E INNER JOIN TiposDocumento TD ON (E.tipoDoc = TD.tipoDocumento)" +
                         " WHERE descripcion LIKE '" + descripcion + "' AND nroDoc LIKE '" + nroDoc + "'";

            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public Respuesta ModificarEmpleado(int tipoDoc, string nroDoc, string nombre, string apellido, string calle,
            int nroCalle, int idBarrio, DateTime fechaNacimiento, DateTime fechaIngreso,
            int idUsuario, int idTurno)
        {
            string sql = "UPDATE Empleados" + " SET nombre = '" + nombre +
                         "',apellido = '" + apellido + "', calle = '" + calle + "', nroCalle = " + nroCalle +
                         ", idBarrio = " + idBarrio + ", fechaNacimiento = " + "convert(date,'" + fechaNacimiento + "', 103)" +
                         ", fechaIngreso = " + "convert(date,'" + fechaIngreso + "', 103)" +
                         ", idUsuario = " + idUsuario + ", idTurno = " + idTurno +
                         "WHERE tipoDoc = " + tipoDoc + "AND nroDoc LIKE '" + nroDoc+ "'";

            try
            {
                baseDatos.Actualizar(sql);
                return Respuesta.validacionCorrecta;

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return Respuesta.validacionIncorrecta;
            }
        }


        public Respuesta EliminarEmpleado(int tipoDoc, string nroDoc)
        {
            string sql = "DELETE FROM Empleados WHERE tipoDoc =" + tipoDoc + "AND nroDoc LIKE '" + nroDoc + "'";

            try
            {
                baseDatos.Eliminar(sql);
                return Respuesta.validacionCorrecta;

            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
                return Respuesta.validacionIncorrecta;
            }

        }

        public DataTable RecuperarEmpleadoPorUsuario(string idUsuario)
        {
            string sql = "SELECT E.* FROM Empleados E INNER JOIN TiposDocumento TD ON (E.tipoDoc = TD.tipoDocumento)" +
                         " WHERE idUsuario LIKE '" + idUsuario.Trim() + "'";

            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public DataTable RecuperarEmpleadoPorVenta(string nroTicket)
        {
            string sql = "SELECT E.* FROM Empleados E INNER JOIN Ventas V ON (E.tipoDoc = V.tipoDocEmpleado) AND (E.nroDoc = V.nroDocEmpleado)" +
                         " WHERE nroTicket LIKE '" + nroTicket.Trim() + "'";

            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }


        public DataTable ListadoEmpleados()
        {
            string sql = @"SELECT	TD.descripcion AS tipoDoc,
		                            nroDoc,
		                            E.nombre AS nombre,
		                            apellido,
		                            calle,
		                            nroCalle,
		                            B.nombre AS idBarrio,
		                            CONVERT(VARCHAR, E.fechaNacimiento, 103) AS fechaNacimiento,
		                            CONVERT(VARCHAR, E.fechaIngreso, 103) AS fechaIngreso,
		                            U.nombreUsuario AS idUsuario,
		                            T.nombre AS idTurno
                            FROM Empleados E
                             INNER JOIN TiposDocumento TD ON (E.tipodOC = TD.tipoDocumento)
                             INNER JOIN Barrios B ON (E.idBarrio = B.idBarrio)
                             INNER JOIN Usuarios U ON(E.idUsuario = U.idUsuario)
                             INNER JOIN Turnos T ON (E.idTurno = T.idTurno)";

                         DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }
    }
}
