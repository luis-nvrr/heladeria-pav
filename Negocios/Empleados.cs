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
        private BaseDatos baseDatos = new BaseDatos(); // creacion de la base de datos
        public enum Respuesta
        {
            validacionCorrecta,
            validacionIncorrecta
        }

        public DataTable TodosLosEmpleados()
        {
            string sql = "SELECT * FROM Empleados";
            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }
        public DataTable BuscarEmpleado(string nombre, string apellido, string turno, string barrio)
        {
            string sql = "SELECT * FROM Empleados WHERE nombre LIKE '%" + nombre.Trim() + "%'" + 
                                                "AND apellido LIKE '%" + apellido.Trim() + "%'" +
                                                "AND idTurno IN " + turno +
                                                "AND idBarrio IN " + barrio;
            DataTable tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public Respuesta InsertarEmpleado(int tipoDoc, int nroDoc, string nombre, string apellido, string calle,
                                            int nroCalle, int idBarrio, DateTime fechaNacimiento, DateTime fechaIngreso,
                                            int idUsuario, int idTurno)
        {
            string sql = "INSERT INTO Empleados (tipoDoc, nroDoc, nombre, apellido, calle, nroCalle, idBarrio, fechaNacimiento," +
                         "fechaIngreso, idUsuario, idTurno) VALUES " + 
                         "(" + tipoDoc + "," + nroDoc + ",'" + nombre + "','" + apellido + "','" + calle + "'," +
                         nroCalle + "," + idBarrio + "," + "convert(date,'" + fechaNacimiento + "', 103)" + "," +
                         "convert(date,'" + fechaIngreso + "', 103)" + "," + idUsuario + ","+ idTurno +")";

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

        public DataTable RecuperarEmpleado(int tipoDoc, int nroDoc)
        {
            string sql = "SELECT * FROM Empleados WHERE tipoDoc = " + tipoDoc + "AND nroDoc = " + nroDoc;
            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public Respuesta ModificarEmpleado(int tipoDoc, int nroDoc, string nombre, string apellido, string calle,
            int nroCalle, int idBarrio, DateTime fechaNacimiento, DateTime fechaIngreso,
            int idUsuario, int idTurno)
        {
            string sql = "UPDATE Empleados" + " SET nombre = '" + nombre +
                         "',apellido = '" + apellido + "', calle = '" + calle +"', nroCalle = " +nroCalle +
                         ", idBarrio = " + idBarrio + ", fechaNacimiento = " + "convert(date,'" + fechaNacimiento + "', 103)" +
                         ", fechaIngreso = " + "convert(date,'" + fechaIngreso + "', 103)" +
                         ", idUsuario = " + idUsuario + ", idTurno = " + idTurno +
                         "WHERE tipoDoc = " + tipoDoc + "AND nroDoc = " + nroDoc;

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


    }
}
