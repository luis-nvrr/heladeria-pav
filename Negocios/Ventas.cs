    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Practico.Clases;

    namespace Practico.Negocios
    {
        class Ventas
        {
            BaseDatos baseDatos = new BaseDatos();

            public void InsertarVenta(string tipoDoc, string nroDoc, Grid01 detalles)
            {
                baseDatos.IniciarTransaccion();
                int nroTicket = baseDatos.nextAutoincrement("Ventas");
                string fecha = baseDatos.Fecha();

                string insertVenta = "INSERT INTO Ventas (fecha, tipoDocEmpleado, nroDocEmpleado) VALUES";
                insertVenta += "(" + baseDatos.FormatearDato(fecha, "Date") + "," + tipoDoc + ",'" + nroDoc + "')";

                baseDatos.Insertar(insertVenta);


                string insertDetalle =
                    @"INSERT INTO DetalleVentas (nroTicket, idHeladoSimple, cantKilos, idHeladoEspecial, cantItems) VALUES (";

                for (int i = 0; i < detalles.Rows.Count; i++)
                {
                    string datosDetalle = nroTicket.ToString();
                    if (detalles.Rows[i].Cells[6].Value.ToString() == "false")
                    {
                        datosDetalle += "," + detalles.Rows[i].Cells[1].Value.ToString();
                        datosDetalle += "," + detalles.Rows[i].Cells[4].Value.ToString();
                    }
                    else
                    {
                        datosDetalle += "," + "NULL";
                        datosDetalle += "," + "NULL";
                    }

                    if (detalles.Rows[i].Cells[6].Value.ToString() == "true")
                    {
                        datosDetalle += "," + detalles.Rows[i].Cells[1].Value.ToString();
                        datosDetalle += "," + detalles.Rows[i].Cells[4].Value.ToString();
                    }
                    else
                    {
                        datosDetalle += "," + "NULL";
                        datosDetalle += "," + "NULL";
                    }

                    datosDetalle += ")";

                    string insertFinal = insertDetalle + datosDetalle;
                    baseDatos.Insertar(insertFinal);
                }

                if (baseDatos.CerrarTransaccion() == BaseDatos.EstadoTransaccion.correcta)
                {
                    MessageBox.Show("exito");
                }

            }

            public DataTable RecuperarVenta(string tipoDoc, string nroDoc, string nombre)
            {
                DataTable tabla = new DataTable();
                string sql = @"	SELECT nroTicket, 
			                    nroDocEmpleado,
			                    tipoDocEmpleado,
			                    CONVERT(varchar, fecha, 101) as fecha,
			                    nombre,
			                    SUM(Total) as SumTotal
	                            FROM (
		                                SELECT	V.nroTicket,
				                                V.nroDocEmpleado,
				                                V.tipoDocEmpleado,
				                                V.fecha,
				                                E.nombre, 
				                                SUM( D.cantKilos * H.precio) as Total
		                                FROM Ventas V
			                                INNER JOIN Empleados E ON (V.tipoDocEmpleado = E.tipoDoc) AND (V.nroDocEmpleado = E.nroDoc)
			                                INNER JOIN DetalleVentas D ON (V.nroTicket = D.nroTicket)
			                                INNER JOIN Helados H ON (D.idHeladoSimple = H.idHelado)
		                                GROUP BY V.nroTicket, V.nroDocEmpleado, V.tipoDocEmpleado, V.fecha, E.nombre
		                                UNION
		                                SELECT	V.nroTicket, 
				                                V.nroDocEmpleado,
				                                V.tipoDocEmpleado,
				                                V.fecha,
				                                E.nombre, 
				                                SUM(D.cantItems * HE.precio) as Total
		                                FROM Ventas V
			                                INNER JOIN Empleados E ON (V.tipoDocEmpleado = E.tipoDoc) AND (V.nroDocEmpleado = E.nroDoc)
			                                INNER JOIN DetalleVentas D ON (V.nroTicket = D.nroTicket)
			                                INNER JOIN HeladosEspeciales HE ON (D.idHeladoEspecial = HE.idHeladoEspecial)
		                                GROUP BY V.nroTicket, V.nroDocEmpleado, V.tipoDocEmpleado, V.fecha, E.nombre
		                                ) AS Resultado
	                                WHERE ";
                sql += "tipoDocEmpleado =" + tipoDoc + " AND nroDocEmpleado LIKE '" + nroDoc + "'" +
                       " AND nombre LIKE '" + nombre + "'";
                sql += " GROUP BY nroTicket, nroDocEmpleado, tipoDocEmpleado, fecha, nombre";

                tabla = baseDatos.Consulta(sql);
                return tabla;
            }


            public DataTable RecuperarVenta(string fechaDesde, string fechaHasta)
            {
                DataTable tabla = new DataTable();
                string sql = @"	SELECT nroTicket, 
			                    nroDocEmpleado,
			                    tipoDocEmpleado,
			                    CONVERT(varchar, fecha, 101) as fecha,
			                    nombre,
			                    SUM(Total) as SumTotal
	                            FROM (
		                                SELECT	V.nroTicket,
				                                V.nroDocEmpleado,
				                                V.tipoDocEmpleado,
				                                V.fecha,
				                                E.nombre, 
				                                SUM( D.cantKilos * H.precio) as Total
		                                FROM Ventas V
			                                INNER JOIN Empleados E ON (V.tipoDocEmpleado = E.tipoDoc) AND (V.nroDocEmpleado = E.nroDoc)
			                                INNER JOIN DetalleVentas D ON (V.nroTicket = D.nroTicket)
			                                INNER JOIN Helados H ON (D.idHeladoSimple = H.idHelado)
		                                GROUP BY V.nroTicket, V.nroDocEmpleado, V.tipoDocEmpleado, V.fecha, E.nombre
		                                UNION
		                                SELECT	V.nroTicket, 
				                                V.nroDocEmpleado,
				                                V.tipoDocEmpleado,
				                                V.fecha,
				                                E.nombre, 
				                                SUM(D.cantItems * HE.precio) as Total
		                                FROM Ventas V
			                                INNER JOIN Empleados E ON (V.tipoDocEmpleado = E.tipoDoc) AND (V.nroDocEmpleado = E.nroDoc)
			                                INNER JOIN DetalleVentas D ON (V.nroTicket = D.nroTicket)
			                                INNER JOIN HeladosEspeciales HE ON (D.idHeladoEspecial = HE.idHeladoEspecial)
		                                GROUP BY V.nroTicket, V.nroDocEmpleado, V.tipoDocEmpleado, V.fecha, E.nombre
		                                ) AS Resultado
	                                WHERE ";
                sql += " fecha BETWEEN CONVERT(date,'" + fechaDesde +
                   "',103) AND CONVERT(date,'" + fechaHasta + "',103)";
                sql += " GROUP BY nroTicket, nroDocEmpleado, tipoDocEmpleado, fecha, nombre";

                tabla = baseDatos.Consulta(sql);
                return tabla;
            }

            public DataTable RecuperarVenta(string tipoDoc, string nroDoc, string nombre, string fechaDesde,
                string fechaHasta)
            {
			    DataTable tabla = new DataTable();
			    string sql = @"	SELECT nroTicket, 
			                        nroDocEmpleado,
			                        tipoDocEmpleado,
			                        CONVERT(varchar, fecha, 101) as fecha,
			                        nombre,
			                        SUM(Total) as SumTotal
	                                FROM (
		                                    SELECT	V.nroTicket,
				                                    V.nroDocEmpleado,
				                                    V.tipoDocEmpleado,
				                                    V.fecha,
				                                    E.nombre, 
				                                    SUM( D.cantKilos * H.precio) as Total
		                                    FROM Ventas V
			                                    INNER JOIN Empleados E ON (V.tipoDocEmpleado = E.tipoDoc) AND (V.nroDocEmpleado = E.nroDoc)
			                                    INNER JOIN DetalleVentas D ON (V.nroTicket = D.nroTicket)
			                                    INNER JOIN Helados H ON (D.idHeladoSimple = H.idHelado)
		                                    GROUP BY V.nroTicket, V.nroDocEmpleado, V.tipoDocEmpleado, V.fecha, E.nombre
		                                    UNION
		                                    SELECT	V.nroTicket, 
				                                    V.nroDocEmpleado,
				                                    V.tipoDocEmpleado,
				                                    V.fecha,
				                                    E.nombre, 
				                                    SUM(D.cantItems * HE.precio) as Total
		                                    FROM Ventas V
			                                    INNER JOIN Empleados E ON (V.tipoDocEmpleado = E.tipoDoc) AND (V.nroDocEmpleado = E.nroDoc)
			                                    INNER JOIN DetalleVentas D ON (V.nroTicket = D.nroTicket)
			                                    INNER JOIN HeladosEspeciales HE ON (D.idHeladoEspecial = HE.idHeladoEspecial)
		                                    GROUP BY V.nroTicket, V.nroDocEmpleado, V.tipoDocEmpleado, V.fecha, E.nombre
		                                    ) AS Resultado
	                                    WHERE ";
                sql += "tipoDocEmpleado =" + tipoDoc + " AND nroDocEmpleado LIKE '" + nroDoc + "'" +
                      " AND nombre LIKE '" + nombre + "'";
                sql += " AND fecha BETWEEN CONVERT(date,'" + fechaDesde +
                       "',103) AND CONVERT(date,'" + fechaHasta + "',103)";
			    sql += " GROUP BY nroTicket, nroDocEmpleado, tipoDocEmpleado, fecha, nombre";

                tabla = baseDatos.Consulta(sql);
                return tabla;

		    }

            public DataTable RecuperarTodasLasVentas()
            {
			    DataTable tabla = new DataTable();
			    string sql = @"	SELECT nroTicket, 
			                            nroDocEmpleado,
			                            tipoDocEmpleado,
			                            CONVERT(varchar, fecha, 101) as fecha,
			                            nombre,
			                            SUM(Total) as SumTotal
	                                    FROM (
		                                        SELECT	V.nroTicket,
				                                        V.nroDocEmpleado,
				                                        V.tipoDocEmpleado,
				                                        V.fecha,
				                                        E.nombre, 
				                                        SUM( D.cantKilos * H.precio) as Total
		                                        FROM Ventas V
			                                        INNER JOIN Empleados E ON (V.tipoDocEmpleado = E.tipoDoc) AND (V.nroDocEmpleado = E.nroDoc)
			                                        INNER JOIN DetalleVentas D ON (V.nroTicket = D.nroTicket)
			                                        INNER JOIN Helados H ON (D.idHeladoSimple = H.idHelado)
		                                        GROUP BY V.nroTicket, V.nroDocEmpleado, V.tipoDocEmpleado, V.fecha, E.nombre
		                                        UNION
		                                        SELECT	V.nroTicket, 
				                                        V.nroDocEmpleado,
				                                        V.tipoDocEmpleado,
				                                        V.fecha,
				                                        E.nombre, 
				                                        SUM(D.cantItems * HE.precio) as Total
		                                        FROM Ventas V
			                                        INNER JOIN Empleados E ON (V.tipoDocEmpleado = E.tipoDoc) AND (V.nroDocEmpleado = E.nroDoc)
			                                        INNER JOIN DetalleVentas D ON (V.nroTicket = D.nroTicket)
			                                        INNER JOIN HeladosEspeciales HE ON (D.idHeladoEspecial = HE.idHeladoEspecial)
		                                        GROUP BY V.nroTicket, V.nroDocEmpleado, V.tipoDocEmpleado, V.fecha, E.nombre
		                                        ) AS Resultado ";
                sql += " GROUP BY nroTicket, nroDocEmpleado, tipoDocEmpleado, fecha, nombre";

			    tabla = baseDatos.Consulta(sql);
                return tabla;
            }
        }
    
    }

