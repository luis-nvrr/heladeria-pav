using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;  //Conector estandar cliente de SQL
using System.Data;
using System.Windows.Forms;

namespace Practico.Clases
{
    class BaseDatos
    {
        private SqlConnection conexion = new SqlConnection();   // armar conexion
        private SqlCommand comando = new SqlCommand();    // transporte de la consulta

        public enum Respuesta
        {
            validacionCorrecta,
            validacionIncorrecta
        }

        private void Conectar()  // metodo para conectar
        {
            conexion.ConnectionString = "Data Source=DESKTOP-L73414Q\\SQLEXPRESS;Initial Catalog=HeladeriaPAV;Integrated Security=True";   
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            
        }
       

        private void Desconectar()  // metodo para desconectar
        {
            conexion.Close();
        }

        public DataTable Consulta (string sql)  // devuelve tabla
        {
            Conectar();
            comando.CommandText = sql;   // comando a ejecutar
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());   // carga la tabla y ejecuta la consulta en el motor
            Desconectar();
            return tabla;
        }


        public void Insertar(string sql)
        {
            Conectar();
            comando.CommandText = sql;
            try
            {
                comando.ExecuteNonQuery();
            }
            catch(SqlException exception)
            {
                throw exception;
            }
            Desconectar();
        }

        public void InsertarAutomatizado(string NombreTabla, Control.ControlCollection controles)
        {
            string sqlInsertar = "INSERT INTO " + NombreTabla.Trim() + " (";
            string sqlDatos = " VALUES (";
            DataTable Estructura = new DataTable();
            Estructura = EstructuraTabla(NombreTabla);
            for (int i = 0; i < Estructura.Columns.Count; i++)
            {
                string ValorCampo = BuscarValorCampo(Estructura.Columns[i].Caption, NombreTabla, controles);
                if (ValorCampo != "")
                {
                    sqlInsertar += ", " + Estructura.Columns[i].Caption;
                    sqlDatos += ", " + FormatearDato(ValorCampo, Estructura.Columns[i].DataType.Name);
                }
            }
            sqlInsertar = sqlInsertar + ")" + sqlDatos + ")";
            sqlInsertar = sqlInsertar.Replace("(,", "(");
            Insertar(sqlInsertar);
        }

        public void Eliminar(string sql)
        {
            Conectar();
            comando.CommandText = sql;
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (SqlException exception)
            {
                throw exception;
            }
            Desconectar();
        }

        public void Actualizar(string sql)
        {
            Conectar();
            comando.CommandText = sql;
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (SqlException exception)
            {
                throw exception;
            }
            Desconectar();
        } 

        public string FormatearDato(string dato,string formato)
        {
            switch (formato)
            {
                case "String":
                    return "'" + dato + "'";
                case "Date":
                case "DateTime":
                    return "convert(date,'" + dato + "', 103)";
                default:
                    return dato;
            }
        }


        private DataTable EstructuraTabla (string NombreTabla)
        {
            string sql = "SELECT TOP 1 * FROM " + NombreTabla.Trim();
            DataTable tabla = new DataTable();
            tabla = this.Consulta(sql);
            return tabla;
        }

        private string BuscarValorCampo(string campo, string NombreTabla, Control.ControlCollection controles)
        {
            foreach (var item in controles)
            {
                if (item.GetType().Name == "TextBox01")
                {
                    if (((TextBox01)item).PpNombreCampo is null) 
                        continue;

                    if (((TextBox01)item).PpNombreTabla.IndexOf(NombreTabla) != -1
                        && ((TextBox01)item).PpNombreCampo == campo) 
                        return ((TextBox01)item).Text;
                }

                if(item.GetType().Name == "ComboBox01")
                {
                    if (((ComboBox01)item).PpNombreCampo is null)
                        continue;

                    if (((ComboBox01)item).PpNombreTabla.IndexOf(NombreTabla) != -1
                        && ((ComboBox01)item).PpNombreCampo == campo)
                        return ((ComboBox01)item).SelectedValue.ToString();
                }
                
            }
            return "";
        }
    }
}
