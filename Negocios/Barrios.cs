using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practico.Clases;

namespace Practico.Negocios
{
    class Barrios
    {
        BaseDatos _BD = new BaseDatos();

        public EstructuraComboBox EstrCombo()
        {
            EstructuraComboBox ec = new EstructuraComboBox();
            ec.Display = "nombre";
            ec.Value = "idBarrio";
            ec.Sql = "SELECT * FROM Barrios";
            ec.Tabla = _BD.Consulta(ec.Sql);
            return ec;
        }
    }
}
