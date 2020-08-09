using Practico.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico.Negocios
{
    class NgUsuarios
    {
        BeBaseDatos _baseDatos = new BeBaseDatos();  // creacion de la base de datos


        public enum Respuesta {validacionCorrecta, validacionIncorrecta};

        // para el login
        public Respuesta ValidarUsuario(string usuario, string password)
        {
            string sql = "SELECT * FROM usuarios WHERE nombreUsuario = '"+usuario+"' AND contrasenia= '"+password+"'";
            DataTable tabla = new DataTable();
            tabla = _baseDatos.Consulta(sql);

            if (tabla.Rows.Count == 0)
            {
                return Respuesta.validacionCorrecta;
            }
            else
            {
                return Respuesta.validacionIncorrecta;
            }
        }
    }
}
