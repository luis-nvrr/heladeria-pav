using Practico.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practico.Formularios.Abm.Usuarios;

namespace Practico.Negocios
{
    class Localidades
    {
        private BaseDatos baseDatos = new BaseDatos();
        public enum Respuesta
        {
            validacionCorrecta,
            validacionIncorrecta
        };

		public Respuesta ValidarLocalidad(string nombreLocalidad)
		{
			string sql = "SELECT * FROM Localidades WHERE nombre ='" + nombreLocalidad + "'";
			DataTable tabla = new DataTable();
			tabla = baseDatos.Consulta(sql);

			if (tabla.Rows.Count == 1)
			{
				return Respuesta.validacionCorrecta;
			}
			else
			{
				return Respuesta.validacionIncorrecta;
			}
		}

		public DataTable TodasLasLocalidades()
		{
			string sql = "SELECT * FROM Localidades";
			DataTable tabla = new DataTable();
			tabla = baseDatos.Consulta(sql);
			return tabla;
		}

		public DataTable BuscarLocalidad(string nombreLocalidad)
		{
			string sql = "SELECT * FROM Localidades WHERE nombre LIKE '%" + nombreLocalidad.Trim() + "%'";
			DataTable tabla = baseDatos.Consulta(sql);
			return tabla;
		}

		public Respuesta IngresarLocalidad(string nombre)
		{
			string sql = "INSERT INTO Localidades VALUES " + "('" + nombre + "')";


			if (ValidarLocalidad(nombre) == Respuesta.validacionIncorrecta)
			{
				baseDatos.Insertar(sql);
				return Respuesta.validacionCorrecta;
			}

			return Respuesta.validacionIncorrecta;
		}

		public void EliminarLocalidad(int id)
		{
			string sql = "DELETE FROM Localidades WHERE idLocalidad =" + id;
			baseDatos.Eliminar(sql);

		}

		public Respuesta ModificarLocalidad(int id, string nombre)
		{
			string sql = "UPDATE Localidades" + " SET nombre = '" + nombre + "' " +
						 "WHERE idLocalidad = " + id;
			if (baseDatos.Consulta(sql).HasErrors)
			{
				return Respuesta.validacionIncorrecta;
			}
			else
			{
				return Respuesta.validacionCorrecta;
			}
		}

		public DataTable RecuperarLocalidad(int id)
		{
			string sql = "SELECT * FROM Localidades WHERE idLocalidad = " + id;
			DataTable tabla = new DataTable();
			tabla = baseDatos.Consulta(sql);
			return tabla;
		}
	}
}
