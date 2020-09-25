    using System;
    using System.Collections.Generic;
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
                        datosDetalle += "," + detalles.Rows[i].Cells[3].Value.ToString();
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
        }
    }
