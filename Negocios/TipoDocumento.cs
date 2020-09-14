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
	class TipoDocumento
	{
		private BaseDatos baseDatos = new BaseDatos();
		
		public EstructuraComboBox EstrCombo()
		{
			EstructuraComboBox ec = new EstructuraComboBox();
			ec.Display = "descripcion";
			ec.Value = "tipoDocumento";
			ec.Sql = "SELECT * FROM TiposDocumento";
			ec.Tabla = baseDatos.Consulta(ec.Sql);
			return ec;
		}

		public enum Respuesta
		{
			validacionCorrecta,
			validacionIncorrecta
		};

		public Respuesta ValidarTipoDocumento(string nombreTipoDoc)
		{
			string sql = "SELECT * FROM TiposDocumento WHERE descripcion ='" + nombreTipoDoc + "'";
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

		public DataTable TodosLosTipoDocumento()
		{
			string sql = "SELECT * FROM TiposDocumento";
			DataTable tabla = new DataTable();
			tabla = baseDatos.Consulta(sql);
			return tabla;
		}

		public DataTable BuscarTipoDocumento(string nombreTipoDocumento)
		{
			string sql = "SELECT * FROM TiposDocumento WHERE descripcion LIKE '%" + nombreTipoDocumento.Trim() + "%'";
			DataTable tabla = baseDatos.Consulta(sql);
			return tabla;
		}

		public Respuesta IngresarTipoDocumento(string nombreTipoDocumento)
		{
			string sql = "INSERT INTO TiposDocumento VALUES " + "('" + nombreTipoDocumento + "')";


			if (ValidarTipoDocumento(nombreTipoDocumento) == Respuesta.validacionIncorrecta)
			{
				baseDatos.Insertar(sql);
				return Respuesta.validacionCorrecta;
			}

			return Respuesta.validacionIncorrecta;
		}

		public void EliminarTipoDocumento(int id)
		{
			string sql = "DELETE FROM TiposDocumento WHERE tipoDocumento =" + id;
			baseDatos.Eliminar(sql);

		}

		public Respuesta ModificarTipoDocumento(int id, string descripcionTipoDocumento)
		{
			string sql = "UPDATE TiposDocumento" + " SET descripcion = '" + descripcionTipoDocumento + "' " +
						 "WHERE tipoDocumento = " + id;
			if (baseDatos.Consulta(sql).HasErrors)
			{
				return Respuesta.validacionIncorrecta;
			}
			else
			{
				return Respuesta.validacionCorrecta;
			}
		}

		public DataTable RecuperarTipoDocumento(int id)
		{
			string sql = "SELECT * FROM TiposDocumento WHERE tipoDocumento = " + id;
			DataTable tabla = new DataTable();
			tabla = baseDatos.Consulta(sql);
			return tabla;
		}
	}
}
