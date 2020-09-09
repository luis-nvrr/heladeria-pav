using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practico.Clases;

namespace Practico.Negocios
{
    class TiposDocumento
    {
        BaseDatos _BD = new BaseDatos();

        public EstructuraComboBox EstrCombo()
        {
            EstructuraComboBox ec = new EstructuraComboBox();
            ec.Display = "descripcion";
            ec.Value = "tipoDocumento";
            ec.Sql = "SELECT * FROM TiposDocumento";
            ec.Tabla = _BD.Consulta(ec.Sql);
            return ec;
        }
    }
}
