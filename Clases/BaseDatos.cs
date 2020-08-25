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
        private SqlConnection conexion = new SqlConnection();   // armar conexion
        private SqlCommand comando = new SqlCommand();    // transporte de la consulta


        private void Conectar()  // metodo para conectar
        {
            conexion.ConnectionString = "Data Source=DESKTOP-6V98254\\SQLEXPRESS;Initial Catalog=HeladeriaPAV;Integrated Security=True";   // cadena para usar la variable del archivo .config 
            conexion.Open();                                                                                 // se puede reemplazar con la cadena directamente
                                                                                                            // NO hacerlo
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
            return tabla;
        }
    }
}
