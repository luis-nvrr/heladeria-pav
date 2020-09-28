using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Practico.Clases;

namespace Practico.Negocios
{
    class Compras
    {
		BaseDatos baseDatos = new BaseDatos();
		
		public DataTable RecuperarCompra(string nroComprobante)
		{
			DataTable tabla = new DataTable();
			string sql = @"	SELECT nroComprobante, 
			                    CONVERT(varchar, fecha, 101) as fecha,
								tipoDocProveedor,
								nroDocProveedor,
								razonSocial,
			                    SUM(Total) as SumTotal
	                            FROM (
		                                SELECT	C.nroComprobante,
				                                C.fecha,
				                                C.tipoDocProveedor,
				                                C.nroDocProveedor,
				                                P.razonSocial, 
				                                SUM( D.cantKilos * PH.precio) as Total
		                                FROM Compras C
			                                INNER JOIN Proveedores P ON (C.tipoDocProveedor = P.tipoDocumento) AND (C.nroDocProveedor = P.nroDocumento)
			                                INNER JOIN DetallesCompras D ON (C.nroComprobante = D.nroComprobante)
			                                INNER JOIN ProveedoresHelados PH ON (D.tipoDocProveedor = PH.tipoDocProveedor)	
																			  AND (D.nroDocProveedor = PH.nroDocProveedor) 
																		      AND (D.idHelado = PH.idHelado)
		                                GROUP BY C.nroComprobante, C.fecha, C.tipoDocProveedor, C.nroDocProveedor, P.razonSocial) AS Resultado
	                                WHERE ";
			sql += "NroComprobante = '" + nroComprobante + "'";
			sql += " GROUP BY nroComprobante, fecha, tipoDocProveedor, nroDocProveedor, razonSocial";

			tabla = baseDatos.Consulta(sql);
			return tabla;
		}

		public DataTable RecuperarCompra(string fechaDesde, string fechaHasta)
		{
			DataTable tabla = new DataTable();
			string sql = @"	SELECT nroComprobante, 
			                    CONVERT(varchar, fecha, 101) as fecha,
								tipoDocProveedor,
								nroDocProveedor,
								razonSocial,
			                    SUM(Total) as SumTotal
	                            FROM (
		                                SELECT	C.nroComprobante,
				                                C.fecha,
				                                C.tipoDocProveedor,
				                                C.nroDocProveedor,
				                                P.razonSocial, 
				                                SUM( D.cantKilos * PH.precio) as Total
		                                FROM Compras C
			                                INNER JOIN Proveedores P ON (C.tipoDocProveedor = P.tipoDocumento) AND (C.nroDocProveedor = P.nroDocumento)
			                                INNER JOIN DetallesCompras D ON (C.nroComprobante = D.nroComprobante)
			                                INNER JOIN ProveedoresHelados PH ON (D.tipoDocProveedor = PH.tipoDocProveedor)	
																			  AND (D.nroDocProveedor = PH.nroDocProveedor) 
																		      AND (D.idHelado = PH.idHelado)
		                                GROUP BY C.nroComprobante, C.fecha, C.tipoDocProveedor, C.nroDocProveedor, P.razonSocial) AS Resultado
	                                WHERE ";
			sql += " fecha BETWEEN CONVERT(date,'" + fechaDesde +
				   "',103) AND CONVERT(date,'" + fechaHasta + "',103)";
			sql += " GROUP BY nroComprobante, fecha, tipoDocProveedor, nroDocProveedor, razonSocial";

			tabla = baseDatos.Consulta(sql);
			return tabla;
		}

		public DataTable RecuperarCompra(string tipoDocProveedor, string nroDocProveedor, string razonSocial)
		{
			DataTable tabla = new DataTable();
			string sql = @"	SELECT nroComprobante, 
			                    CONVERT(varchar, fecha, 101) as fecha,
								tipoDocProveedor,
								nroDocProveedor,
								razonSocial,
			                    SUM(Total) as SumTotal
	                            FROM (
		                                SELECT	C.nroComprobante,
				                                C.fecha,
				                                C.tipoDocProveedor,
				                                C.nroDocProveedor,
				                                P.razonSocial, 
				                                SUM( D.cantKilos * PH.precio) as Total
		                                FROM Compras C
			                                INNER JOIN Proveedores P ON (C.tipoDocProveedor = P.tipoDocumento) AND (C.nroDocProveedor = P.nroDocumento)
			                                INNER JOIN DetallesCompras D ON (C.nroComprobante = D.nroComprobante)
			                                INNER JOIN ProveedoresHelados PH ON (D.tipoDocProveedor = PH.tipoDocProveedor)	
																			  AND (D.nroDocProveedor = PH.nroDocProveedor) 
																		      AND (D.idHelado = PH.idHelado)
		                                GROUP BY C.nroComprobante, C.fecha, C.tipoDocProveedor, C.nroDocProveedor, P.razonSocial) AS Resultado
	                                WHERE ";
			sql += "tipoDocProveedor =" + tipoDocProveedor + " AND nroDocProveedor LIKE '" + nroDocProveedor + "'" +
					   " AND razonSocial LIKE '" + razonSocial + "'";
			sql += " GROUP BY nroComprobante, fecha, tipoDocProveedor, nroDocProveedor, razonSocial";

			tabla = baseDatos.Consulta(sql);
			return tabla;
		}

        public DataTable RecuperarCompra1(string nroComprobante, string fechaDesde, string fechaHasta)
        {
            DataTable tabla = new DataTable();
            string sql = @"	SELECT nroComprobante, 
			                    CONVERT(varchar, fecha, 101) as fecha,
								tipoDocProveedor,
								nroDocProveedor,
								razonSocial,
			                    SUM(Total) as SumTotal
	                            FROM (
		                                SELECT	C.nroComprobante,
				                                C.fecha,
				                                C.tipoDocProveedor,
				                                C.nroDocProveedor,
				                                P.razonSocial, 
				                                SUM( D.cantKilos * PH.precio) as Total
		                                FROM Compras C
			                                INNER JOIN Proveedores P ON (C.tipoDocProveedor = P.tipoDocumento) AND (C.nroDocProveedor = P.nroDocumento)
			                                INNER JOIN DetallesCompras D ON (C.nroComprobante = D.nroComprobante)
			                                INNER JOIN ProveedoresHelados PH ON (D.tipoDocProveedor = PH.tipoDocProveedor)	
																			  AND (D.nroDocProveedor = PH.nroDocProveedor) 
																		      AND (D.idHelado = PH.idHelado)
		                                GROUP BY C.nroComprobante, C.fecha, C.tipoDocProveedor, C.nroDocProveedor, P.razonSocial) AS Resultado
	                                WHERE ";
            sql += "NroComprobante = '" + nroComprobante + "'";
            sql += " AND fecha BETWEEN CONVERT(date,'" + fechaDesde +
                       "',103) AND CONVERT(date,'" + fechaHasta + "',103)";
            sql += " GROUP BY nroComprobante, fecha, tipoDocProveedor, nroDocProveedor, razonSocial";

            tabla = baseDatos.Consulta(sql);
            return tabla;
        }

        public DataTable RecuperarCompra2(string tipoDocProveedor, string nroDocProveedor, string razonSocial, string fechaDesde, string fechaHasta)
        {
            DataTable tabla = new DataTable();
            string sql = @"	SELECT nroComprobante, 
        	                    CONVERT(varchar, fecha, 101) as fecha,
        						tipoDocProveedor,
        						nroDocProveedor,
        						razonSocial,
        	                    SUM(Total) as SumTotal
                                   FROM (
                                        SELECT	C.nroComprobante,
        		                                C.fecha,
        		                                C.tipoDocProveedor,
        		                                C.nroDocProveedor,
        		                                P.razonSocial, 
        		                                SUM( D.cantKilos * PH.precio) as Total
                                        FROM Compras C
        	                                INNER JOIN Proveedores P ON (C.tipoDocProveedor = P.tipoDocumento) AND (C.nroDocProveedor = P.nroDocumento)
        	                                INNER JOIN DetallesCompras D ON (C.nroComprobante = D.nroComprobante)
        	                                INNER JOIN ProveedoresHelados PH ON (D.tipoDocProveedor = PH.tipoDocProveedor)	
        																	  AND (D.nroDocProveedor = PH.nroDocProveedor) 
        																      AND (D.idHelado = PH.idHelado)
                                        GROUP BY C.nroComprobante, C.fecha, C.tipoDocProveedor, C.nroDocProveedor, P.razonSocial) AS Resultado
                                       WHERE ";
            sql += "tipoDocProveedor =" + tipoDocProveedor + " AND nroDocProveedor LIKE '" + nroDocProveedor + "'" +
                       " AND razonSocial LIKE '" + razonSocial + "'";
            sql += " AND fecha BETWEEN CONVERT(date,'" + fechaDesde +
                       "',103) AND CONVERT(date,'" + fechaHasta + "',103)";
            sql += " GROUP BY nroComprobante, fecha, tipoDocProveedor, nroDocProveedor, razonSocial";

            tabla = baseDatos.Consulta(sql);
            return tabla;
        }

		public DataTable RecuperarCompra3(string nroComprobante, string tipoDocProveedor, string nroDocProveedor, string razonSocial)
		{
			DataTable tabla = new DataTable();
			string sql = @"	SELECT nroComprobante, 
        	                    CONVERT(varchar, fecha, 101) as fecha,
        						tipoDocProveedor,
        						nroDocProveedor,
        						razonSocial,
        	                    SUM(Total) as SumTotal
                                   FROM (
                                        SELECT	C.nroComprobante,
        		                                C.fecha,
        		                                C.tipoDocProveedor,
        		                                C.nroDocProveedor,
        		                                P.razonSocial, 
        		                                SUM( D.cantKilos * PH.precio) as Total
                                        FROM Compras C
        	                                INNER JOIN Proveedores P ON (C.tipoDocProveedor = P.tipoDocumento) AND (C.nroDocProveedor = P.nroDocumento)
        	                                INNER JOIN DetallesCompras D ON (C.nroComprobante = D.nroComprobante)
        	                                INNER JOIN ProveedoresHelados PH ON (D.tipoDocProveedor = PH.tipoDocProveedor)	
        																	  AND (D.nroDocProveedor = PH.nroDocProveedor) 
        																      AND (D.idHelado = PH.idHelado)
                                        GROUP BY C.nroComprobante, C.fecha, C.tipoDocProveedor, C.nroDocProveedor, P.razonSocial) AS Resultado
                                       WHERE ";
			sql += "NroComprobante = '" + nroComprobante + "'";
			sql += " AND tipoDocProveedor =" + tipoDocProveedor + " AND nroDocProveedor LIKE '" + nroDocProveedor + "'" +
					   " AND razonSocial LIKE '" + razonSocial + "'";
			sql += " GROUP BY nroComprobante, fecha, tipoDocProveedor, nroDocProveedor, razonSocial";

			tabla = baseDatos.Consulta(sql);
			return tabla;
		}

		public DataTable RecuperarCompra4(string nroComprobante, string fechaDesde, string fechaHasta, string tipoDocProveedor, string nroDocProveedor, string razonSocial)
		{
			DataTable tabla = new DataTable();
			string sql = @"	SELECT nroComprobante, 
        	                    CONVERT(varchar, fecha, 101) as fecha,
        						tipoDocProveedor,
        						nroDocProveedor,
        						razonSocial,
        	                    SUM(Total) as SumTotal
                                   FROM (
                                        SELECT	C.nroComprobante,
        		                                C.fecha,
        		                                C.tipoDocProveedor,
        		                                C.nroDocProveedor,
        		                                P.razonSocial, 
        		                                SUM( D.cantKilos * PH.precio) as Total
                                        FROM Compras C
        	                                INNER JOIN Proveedores P ON (C.tipoDocProveedor = P.tipoDocumento) AND (C.nroDocProveedor = P.nroDocumento)
        	                                INNER JOIN DetallesCompras D ON (C.nroComprobante = D.nroComprobante)
        	                                INNER JOIN ProveedoresHelados PH ON (D.tipoDocProveedor = PH.tipoDocProveedor)	
        																	  AND (D.nroDocProveedor = PH.nroDocProveedor) 
        																      AND (D.idHelado = PH.idHelado)
                                        GROUP BY C.nroComprobante, C.fecha, C.tipoDocProveedor, C.nroDocProveedor, P.razonSocial) AS Resultado
                                       WHERE ";
			sql += "NroComprobante = '" + nroComprobante + "'";
			sql += " AND fecha BETWEEN CONVERT(date,'" + fechaDesde +
					   "',103) AND CONVERT(date,'" + fechaHasta + "',103)";
			sql += " AND tipoDocProveedor =" + tipoDocProveedor + " AND nroDocProveedor LIKE '" + nroDocProveedor + "'" +
					   " AND razonSocial LIKE '" + razonSocial + "'";
			sql += " GROUP BY nroComprobante, fecha, tipoDocProveedor, nroDocProveedor, razonSocial";

			tabla = baseDatos.Consulta(sql);
			return tabla;
		}

		public DataTable RecuperarTodasLasCompras()
		{
			DataTable tabla = new DataTable();
			string sql = @"	SELECT nroComprobante, 
        	                    CONVERT(varchar, fecha, 101) as fecha,
        						tipoDocProveedor,
        						nroDocProveedor,
        						razonSocial,
        	                    SUM(Total) as SumTotal
                                   FROM (
                                        SELECT	C.nroComprobante,
        		                                C.fecha,
        		                                C.tipoDocProveedor,
        		                                C.nroDocProveedor,
        		                                P.razonSocial, 
        		                                SUM( D.cantKilos * PH.precio) as Total
                                        FROM Compras C
        	                                INNER JOIN Proveedores P ON (C.tipoDocProveedor = P.tipoDocumento) AND (C.nroDocProveedor = P.nroDocumento)
        	                                INNER JOIN DetallesCompras D ON (C.nroComprobante = D.nroComprobante)
        	                                INNER JOIN ProveedoresHelados PH ON (D.tipoDocProveedor = PH.tipoDocProveedor)	
        																	  AND (D.nroDocProveedor = PH.nroDocProveedor) 
        																      AND (D.idHelado = PH.idHelado)
                                        GROUP BY C.nroComprobante, C.fecha, C.tipoDocProveedor, C.nroDocProveedor, P.razonSocial) AS Resultado";
			sql += " GROUP BY nroComprobante, fecha, tipoDocProveedor, nroDocProveedor, razonSocial";

			tabla = baseDatos.Consulta(sql);
			return tabla;
		}
	}
}