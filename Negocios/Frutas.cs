using Practico.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Practico.Negocios
{
	class Helados
	{
		private BaseDatos baseDatos = new BaseDatos();

		public enum Respuesta
		{   validacionCorrecta,
			validacionIncorrecta
		};

		public Respuesta ValidarFruta(string nombreFruta)
        {
			string sql = "SELECT * FROM Frutas WHERE nombre ='" + nombreFruta "'";
			DataTable table = new DataTable();
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
		
		public int RecuperarIdFruta(string nombreFruta)
        {
			string sql = "SELECT * FROM Frutas WHERE nombre = '" + nombreFruta "'";
			DataTable tabla = new DataTable();
			tabla = baseDatos.Consulta(sql);

			if (tabla.Rows.Count == 1)
			{
				return int.Parse(tabla.Rows[0]["idFruta "].ToString()); // retorna idUsuario
			}
			else
			{
				return 0;
			}

		}

		public DataTable TodasLasFrutas()
        {
			string sql = "SELECT * FROM Frutas";
			DataTable tabla = new DataTable();
			tabla = baseDatos.Consulta(sql);
			return tabla;
        }

		public DataTable BuscarFruta(string nombreFruta)
        {
			string sql = "SELECT * FROM Frutas WHERE nombre LIKE '%" + nombreFruta.Trim() +"%'"
				DataTable tabla = baseDatos.Consulta(sql);
			return tabla;
        }
	}
}
