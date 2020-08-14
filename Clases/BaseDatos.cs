using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;  //Conector estandar cliente de SQL
using System.Data;

namespace Practico.Clases
{
    class BaseDatos
    {
        // armar conexion 
        SqlConnection conexion = new SqlConnection();

        // transporte de la consulta
        SqlCommand cmd = new SqlCommand();

        // metodo para conectar
        private void Conectar()
        {
            conexion.ConnectionString = "Data Source=DESKTOP-U030ECN\\SQLEXPRESS;Initial Catalog=HeladeriaPAV;Integrated Security=True";
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = System.Data.CommandType.Text;
        }

        private void Desconectar()
        {
            conexion.Close();
        }

        public DataTable Consulta (string sql)  //devuelve tabla
        {
            Conectar();
            cmd.CommandText = sql;   //comando a ejecutar
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());   //carga la tabla y ejecuta la consulta en el motor
            return tabla;
        }
    }
}
