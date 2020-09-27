using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practico.Clases;

namespace Practico.Negocios
{
    class DetalleVentas
    {
        BaseDatos baseDatos = new BaseDatos();

        public DataTable RecuperarDetalle(string nroTicket)
        {
            DataTable tabla = new DataTable();

            string sql = @"SELECT	D.nroItem AS nroItem,
		                            H.idHelado AS idHelado,
		                            H.nombre AS nombre,
		                            D.cantKilos AS cantidad,
		                            H.precio AS precio,
		                            ISNULL(D.idHeladoEspecial,0) AS especial
                            FROM Ventas V 
                            INNER JOIN Empleados E ON (V.nroDocEmpleado = E.nroDoc) AND (V.tipoDocEmpleado = E.tipoDoc)
                            INNER JOIN DetalleVentas D ON (V.nroTicket = D.nroTicket)
                            INNER JOIN Helados H ON (D.idHeladoSimple = H.idHelado)
                            WHERE D.nroTicket =" + nroTicket +
                         @" UNION
                            SELECT	D.nroItem AS nroItem,
		                            HE.idHeladoEspecial AS idHelado,
		                            HE.nombreProducto AS nombre,
		                            D.cantItems AS cantidad,
		                            HE.precio AS precio,
		                            ISNULL(D.idHeladoSimple,1) AS especial
                            FROM Ventas V 
                            INNER JOIN Empleados E ON (V.nroDocEmpleado = E.nroDoc) AND (V.tipoDocEmpleado = E.tipoDoc)
                            INNER JOIN DetalleVentas D ON (V.nroTicket = D.nroTicket)
                            INNER JOIN HeladosEspeciales HE ON (D.idHeladoEspecial = HE.idHeladoEspecial)
                            WHERE D.nroTicket = " + nroTicket;

            tabla = baseDatos.Consulta(sql);
            return tabla;
        }
    }
}
