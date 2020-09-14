using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Practico.Clases;
using System.Data;
using System.Net.Http.Headers;

namespace Practico.Negocios
{
    class Turnos
    {
        private BaseDatos baseDatos = new BaseDatos();

        public enum Respuesta
        {
            validacionCorrecta,
            validacionIncorrecta
        }

        public DataTable TodosLosTurnos()
        {
            string sql = "SELECT * FROM Turnos";
            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public DataTable BuscarTurno(string nombre)
        {
            string sql = "Select * FROM Turnos WHERE nombre = '" + nombre + "'";
            DataTable tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public DataTable RecuperarTurno(int id)
        {
            string sql = "SELECT * FROM Turnos WHERE idTurno = " + id;
            DataTable tabla = new DataTable();
            tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public Respuesta EliminarTurno(int id)
        {
            string sql = "DELETE FROM Turnos WHERE idTurno = " + id;
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

        public Respuesta InsertarTurno( string nombre, DateTime horaInicio, DateTime horaFin
                                       ,string nroDocSupervisor, int tipoDocSupervisor)
        {
            string sql = "INSERT INTO Turnos(nombre,horaInicio,horaFin,nroDocSupervisor" +
                         ",tipoDocSupervisor) VALUES " + ",'" + nombre + "','" +
                         "," + "convert(date," + horaInicio + "',103)" + "convert(date," + horaInicio + "',103)" +
                         "," + nroDocSupervisor + "," + tipoDocSupervisor + ")";
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

        public Respuesta ModificarTurno(int idTurno, string nombre, DateTime horaInicio, DateTime horaFin
                                       , string nroDocSupervisor, int tipoDocSupervisor)
        {
            string sql = "INSERT INTO Turnos(idTurno,nombre,horaInicio,horaFin,nroDocSupervisor" +
                        ",tipoDocSupervisor) VALUES " + "(" + idTurno + ",'" + nombre + "','" +
                        "," + "convert(date," + horaInicio + "',103)" + "convert(date," + horaInicio + "',103)" +
                        "," + nroDocSupervisor + "," + tipoDocSupervisor + ")";
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
